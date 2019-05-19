using System;
using System.IO;
using System.Windows.Forms;

namespace H4ProvinceEditor.Logging {
    class ErrorHandler {
        public void ErrorMessage(string message) {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Log(message, "Error");
        }

        public void CustomErrorMessage(string message, string type, MessageBoxButtons button, MessageBoxIcon icon) {
            MessageBox.Show(message, type, button, icon);
            Log(message, type);
        }

        public void Log(string message, string type) {
            File.AppendAllText("resources/errorlog.txt", $"[{DateTime.Now.ToString()}][{type}] {message}{Environment.NewLine}");
        }
    }
}
