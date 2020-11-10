using OhGamza.UI;
using System;
using System.Windows.Forms;

namespace OhGamza
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new 로그인());
    }
  }
}
