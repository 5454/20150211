using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace ProtobufEditer {
    class Kit {
        private static Kit _instance=null;
        public static Kit Instance{
            get {
                if (_instance == null) {
                    _instance = new Kit();
                }
                return _instance;
            }
        }

        public void SerializeToXML(Type type, object data, string fileName) {
            XmlSerializer serializer = new XmlSerializer(type);
            StreamWriter stream = new StreamWriter(fileName, false, Encoding.UTF8);
            serializer.Serialize(stream, data);
            stream.Close();
        }

        public object DeserializeToObject(string fileName, Type type) {
            XmlSerializer serializer = new XmlSerializer(type);
            StreamReader stream = new StreamReader(fileName, Encoding.UTF8);
            object obj = serializer.Deserialize(stream);
            stream.Close();
            return obj;
        }



    }
}
