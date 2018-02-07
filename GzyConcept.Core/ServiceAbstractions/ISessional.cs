namespace GzyConcept.Core.Services
{
    public interface ISessional
    {
        string ClientIp { get; }

        void Clear();

    }
}
