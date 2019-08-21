using System;
using System.Threading;
using System.Windows.Forms;

namespace Sythen
{
  internal class Functions
  {
    public static string exploitdllname = "SprxLOL.dll";

    public static void Inject()
    {
      if (NamedPipes.NamedPipeExist(NamedPipes.luapipename))
      {
        int num1 = (int) MessageBox.Show("Already injected Dumbass", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      else
      {
        if (NamedPipes.NamedPipeExist(NamedPipes.luapipename))
          return;
        switch (Injector.DllInjector.GetInstance.Inject("RobloxPlayerBeta", AppDomain.CurrentDomain.BaseDirectory + Functions.exploitdllname))
        {
          case Injector.DllInjectionResult.DllNotFound:
            int num2 = (int) MessageBox.Show("Couldn't find " + Functions.exploitdllname, "Sprx Dll was not found!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            break;
          case Injector.DllInjectionResult.GameProcessNotFound:
            int num3 = (int) MessageBox.Show("Couldn't find RobloxPlayerBeta.exe!", "Target process was not found!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            break;
          case Injector.DllInjectionResult.InjectionFailed:
            int num4 = (int) MessageBox.Show("Injection Failed!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            break;
          default:
            Thread.Sleep(3000);
            if (!NamedPipes.NamedPipeExist(NamedPipes.luapipename))
            {
              int num5 = (int) MessageBox.Show("Injection Failed!\nMaybe you are Missing something\nor took more time to check if was ready\nor other stuff XD", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            break;
        }
      }
    }
  }
}
