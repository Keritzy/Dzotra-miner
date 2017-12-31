// Decompiled with JetBrains decompiler
// Type: Cleaner.My.MySettingsProperty
// Assembly: WindowsApplication1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DD0F7914-DDF1-44F8-B72B-F2E7307DD8C7
// Assembly location: C:\Users\gorno\Desktop\malware\dzorta\Miner Cleaner.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Cleaner.My
{
  [DebuggerNonUserCode]
  [HideModuleName]
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
