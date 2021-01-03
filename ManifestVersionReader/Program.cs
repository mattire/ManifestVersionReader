using System;
using System.Linq;
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
            if (args.Count() < 1) {
                Console.WriteLine("Missing path arg");
            } else {
                string path = args[0];
                var versin = ReadVersion(path);
                Console.WriteLine(versin);                
            }
        }
    }
}
