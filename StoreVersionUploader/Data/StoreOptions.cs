using System.IO;

namespace StoreVersionUploader
{
    internal class StoreOptions
    {
        public string ApiKey { get; set; }
        public string Changelog { get; set; }
        public int ProductId { get; set; }
        public string VersionType { get; set; }
        public string Version { get; set; }
        public string Path { get; set; }

        public byte[] Data => File.ReadAllBytes(Path);
    }
}
