// Decompiled with JetBrains decompiler
// Type: Program.My.Resources.Resources
// Assembly: Program, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AE112E4D-F167-49FF-A3FB-40F1535BBBA8
// Assembly location: C:\Users\gorno\Desktop\malware\dzorta\Build.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Program.My.Resources
{
  [StandardModule]
  [CompilerGenerated]
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
  [HideModuleName]
  [DebuggerNonUserCode]
  internal sealed class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (object.ReferenceEquals((object) Program.My.Resources.Resources.resourceMan, (object) null))
          Program.My.Resources.Resources.resourceMan = new ResourceManager("Program.Resources", typeof (Program.My.Resources.Resources).Assembly);
        return Program.My.Resources.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get
      {
        return Program.My.Resources.Resources.resourceCulture;
      }
      set
      {
        Program.My.Resources.Resources.resourceCulture = value;
      }
    }

    internal static byte[] Build
    {
      get
      {
        return (byte[]) RuntimeHelpers.GetObjectValue(Program.My.Resources.Resources.ResourceManager.GetObject("Build", Program.My.Resources.Resources.resourceCulture));
      }
    }
  }
}
