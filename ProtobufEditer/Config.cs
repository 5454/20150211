using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProtobufEditer {
    class Config {

        private static Config _instance = null;

        [XmlAttribute]
        public static string compilerLocal="";

        public static Config Instance {
            get {
                if (_instance == null) {
                    _instance = new Config();
                }
                return _instance;
            }
        }



    }
}
