// Decompiled with JetBrains decompiler
// Type: Program.My.MySettings
// Assembly: Program, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AE112E4D-F167-49FF-A3FB-40F1535BBBA8
// Assembly location: C:\Users\gorno\Desktop\malware\dzorta\Build.exe

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace Program.My
{
  [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Advanced)]
  [CompilerGenerated]
  internal sealed class MySettings : ApplicationSettingsBase
  {
    private static MySettings defaultInstance = (MySettings) SettingsBase.Synchronized((SettingsBase) new MySettings());

    public static MySettings Default
    {
      get
      {
        return MySettings.defaultInstance;
      }
    }
  }
}
