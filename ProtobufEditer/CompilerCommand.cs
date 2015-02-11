using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ProtobufEditer {
    class CompilerCommand {
        private static CompilerCommand _instance = null;

        private static Process diagProcess = new Process();

        public static CompilerCommand Instance {
            get {
                if (_instance == null) {
                    _instance = new CompilerCommand();
                    InitShell();
                }
                return _instance;
            }
        }


        private static void InitShell() {
            diagProcess.StartInfo.FileName = "cmd.exe";
            diagProcess.StartInfo.UseShellExecute = false;
            diagProcess.StartInfo.RedirectStandardInput = true;
            diagProcess.StartInfo.RedirectStandardError = true;
            diagProcess.StartInfo.RedirectStandardOutput = true;
            diagProcess.StartInfo.CreateNoWindow = true;
        }

        public static void ExcuteCommand() {

        }




    }
}
