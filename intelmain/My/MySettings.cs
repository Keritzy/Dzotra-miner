// Decompiled with JetBrains decompiler
// Type: intelmain.My.MySettings
// Assembly: intelmain, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3933E1F4-7FB5-440C-9014-0BDF170FA1C9
// Assembly location: C:\Users\gorno\Desktop\vm\Intel(R) Management\intelmain.exe

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace intelmain.My
{
  [EditorBrowsable(EditorBrowsableState.Advanced)]
  [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
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
