using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Library;
namespace LibraryDAL
{
    public class XMLCLassDeserializer
    {
        public string path = "D:\\KPI\\.NET\\Lab2\\Library\\XMLDocs\\";
        public IEnumerable<Author> AuthorDeserialize(string FileName)
        {
            List<Author> Authors = new List<Author>();
            XmlRootAttribute xmlRoot = new XmlRootAttribute();
            xmlRoot.ElementName = "Authors";
            XmlSerializer serializer = new XmlSerializer(typeof(Author),xmlRoot);
            using (FileStream fs = new FileStream(path + FileName, FileMode.Open))
            {
                Authors = serializer.Deserialize(fs) as List<Author>;
            }
            return Authors;
        }
    }
}
