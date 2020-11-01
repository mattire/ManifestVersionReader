using System;
using System.Xml;

namespace ManifestVersionReader
{
    class Program
    {
        public static string ReadVersion(string path)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            var node = doc.SelectSingleNode("/manifest");
            return node.Attributes.GetNamedItem("android:versionName").Value;
        }

        static void Main(string[] args)
        {
            string path = args[0];
            var versin = ReadVersion(path);
            Console.WriteLine(versin);
        }
    }
}
