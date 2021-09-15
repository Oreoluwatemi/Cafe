using System;
using System.Windows.Forms;

namespace ITE5231_RNA_FinalProject_JoesCafe {
  static class Program {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main() {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Start();
    }

    public static void Start() {
      Global global = new Global();
      Application.Run(global.MainForm);
      // Application.Run(new FrmTest());
    }
  }
}
