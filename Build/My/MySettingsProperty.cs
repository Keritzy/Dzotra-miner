// Decompiled with JetBrains decompiler
// Type: Program.My.MySettingsProperty
// Assembly: Program, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AE112E4D-F167-49FF-A3FB-40F1535BBBA8
// Assembly location: C:\Users\gorno\Desktop\malware\dzorta\Build.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Program.My
{
  [HideModuleName]
  [DebuggerNonUserCode]
  [StandardModule]
  [CompilerGenerated]
  internal sealed class MySettingsProperty
  {
    [HelpKeyword("My.Settings")]
    internal static MySettings Settings
    {
      get
      {
        return MySettings.Default;
      }
    }
  }
}
