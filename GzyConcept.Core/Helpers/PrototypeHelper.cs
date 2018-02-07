using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace GzyConcept.Core.Helpers
{
    [Serializable]
    public abstract class PrototypeHelper<T>
    {
        public T Clone()
        {
            return (T)this.MemberwiseClone();
        }

        public T DeepCopy()
        {
            var memoryStream = new MemoryStream();
            var bf = new BinaryFormatter();

            bf.Serialize(memoryStream, this);
            memoryStream.Seek(0, SeekOrigin.Begin);

            T tmp = (T)bf.Deserialize(memoryStream);
            memoryStream.Close();

            return tmp;

        }

    }
}
