// Decompiled with JetBrains decompiler
// Type: intelmain.My.Resources.Resources
// Assembly: intelmain, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 3933E1F4-7FB5-440C-9014-0BDF170FA1C9
// Assembly location: C:\Users\gorno\Desktop\vm\Intel(R) Management\intelmain.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace intelmain.My.Resources
{
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
  [DebuggerNonUserCode]
  [HideModuleName]
  [CompilerGenerated]
  [StandardModule]
  internal sealed class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (object.ReferenceEquals((object) intelmain.My.Resources.Resources.resourceMan, (object) null))
          intelmain.My.Resources.Resources.resourceMan = new ResourceManager("intelmain.Resources", typeof (intelmain.My.Resources.Resources).Assembly);
        return intelmain.My.Resources.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get
      {
        return intelmain.My.Resources.Resources.resourceCulture;
      }
      set
      {
        intelmain.My.Resources.Resources.resourceCulture = value;
      }
    }
  }
}
