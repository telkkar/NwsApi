using System.IO;

namespace NwsApi
{
    public interface INwsDataLoader
    {
        Stream GetResponseStream(string subDirectoryPath);
    }
}
