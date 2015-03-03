using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProtobufEditer {
    public enum OperationType { New, Open, Close, Add, Delete }
    public enum TargetType { File, Message, Enum, Field }

    class Log {
        private const string Protobuf = "Protobuf";
        private static Log instance;

        public static Log Instance {
            get {
                if (instance == null) {
                    instance = new Log();
                }
                return instance;
            }
        }

        public string output(OperationType ot, TargetType tt, params string[] other) {
            string otherOutput = "";
            for (int i = 0; i < other.Length; i++) {
                otherOutput += other[i] + " ";
            }
            return DateTime.Now.ToString() + " " + ot + " " + Protobuf + " " + tt + " >>> " + otherOutput + "\n";
        }

    }
}






