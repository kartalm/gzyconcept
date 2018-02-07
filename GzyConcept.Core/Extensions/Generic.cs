using GzyConcept.Core.Base;
using GzyConcept.Core.Common;
using System;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace GzyConcept.Core.Extensions
{
    public static class Generic
    {
        public static bool IsNull(this object value)
        {
            return value == null;
        }

        public static bool IsNotNull(this object value)
        {
            return value != null;
        }

        public static bool IsNotNullOrEmpty(this string value)
        {
            return !string.IsNullOrEmpty(value);
        }

        public static bool IsNullOrEmpty(this string value)
        {
            return string.IsNullOrEmpty(value);
        }
         
        public static string ToEncryptedString(this string clearText)
        {
            clearText = clearText.Trim();
            const string encryptionKey = "MAKV2SPBNI99212";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);

            using (Aes encryptor = Aes.Create())
            {
                var pdb = new Rfc2898DeriveBytes(encryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });

                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }

                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }

            return clearText;

        }

        public static string ToDecryptedString(this string cipherText)
        {
            try
            {
                cipherText = cipherText.Trim();
                const string EncryptionKey = "MAKV2SPBNI99212";
                byte[] cipherBytes = Convert.FromBase64String(cipherText);

                using (Aes encryptor = Aes.Create())
                {
                    var pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                    encryptor.Key = pdb.GetBytes(32);
                    encryptor.IV = pdb.GetBytes(16);

                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                        {
                            cs.Write(cipherBytes, 0, cipherBytes.Length);
                            cs.Close();
                        }

                        cipherText = Encoding.Unicode.GetString(ms.ToArray());
                    }
                }
            }
            catch (Exception ex)
            {
                new AppException("Unable to decrypt string. Date : " + DateTime.Now.ToString("dd.MM.yyyy HH:mm") + " String : " + cipherText, ex);
            }

            return cipherText;

        }

        public static bool ContainsOrNull(this string value, string searchKey)
        {
            return value.IsNullOrEmpty() || value.IndexOf(searchKey, StringComparison.Ordinal) >= 0;
        }

        public static string ToFormat(this string value, params object[] parameters)
        {
            if (value.IsNullOrEmpty() || parameters == null || parameters.Length == 0)
            {
                return value;
            }

            return string.Format(value, parameters);
        }

        public static IQueryable<T> IncludeRelations<T>(this IQueryable<T> source, params Expression<Func<T, object>>[] includes) where T : BaseEntity
        {
            if (includes != null)
            {
                foreach (var inc in includes)
                {
                    source = source.Include(inc);
                }
            }

            return source;

        }

        public static string ToClientIp(this HttpRequest request)
        {
            if (request != null)
            {
                string ip = request.ServerVariables["HTTP_CLIENT_IP"];

                if (string.IsNullOrEmpty(ip))
                {
                    ip = request.ServerVariables["REMOTE_ADDR"];
                }

                if (string.IsNullOrEmpty(ip))
                {
                    ip = request.UserHostAddress;
                }

                if (ip == "::1")
                {
                    IPHostEntry host;
                    host = Dns.GetHostEntry(Dns.GetHostName());

                    foreach (IPAddress ipAddress in host.AddressList)
                    {
                        if (ipAddress.AddressFamily == AddressFamily.InterNetwork)
                        {
                            ip = ipAddress.ToString();
                            break;
                        }
                    }

                    if (ip == "::1")
                    {
                        ip = "127.0.0.1";
                    }
                }

                return ip;

            }

            return null;

        }

    }
}
