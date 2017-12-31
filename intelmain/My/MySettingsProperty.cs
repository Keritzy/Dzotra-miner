// Decompiled with JetBrains decompiler
// Type: intelmain.My.MySettingsProperty
// Assembly: intelmain, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3933E1F4-7FB5-440C-9014-0BDF170FA1C9
// Assembly location: C:\Users\gorno\Desktop\vm\Intel(R) Management\intelmain.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace intelmain.My
{
  [DebuggerNonUserCode]
  [StandardModule]
  [CompilerGenerated]
  [HideModuleName]
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
