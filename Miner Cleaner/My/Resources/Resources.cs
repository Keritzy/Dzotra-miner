// Decompiled with JetBrains decompiler
// Type: Cleaner.My.Resources.Resources
// Assembly: WindowsApplication1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DD0F7914-DDF1-44F8-B72B-F2E7307DD8C7
// Assembly location: C:\Users\gorno\Desktop\malware\dzorta\Miner Cleaner.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Cleaner.My.Resources
{
  [StandardModule]
  [HideModuleName]
  [CompilerGenerated]
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
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
        if (object.ReferenceEquals((object) Cleaner.My.Resources.Resources.resourceMan, (object) null))
          Cleaner.My.Resources.Resources.resourceMan = new ResourceManager("Cleaner.Resources", typeof (Cleaner.My.Resources.Resources).Assembly);
        return Cleaner.My.Resources.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get
      {
        return Cleaner.My.Resources.Resources.resourceCulture;
      }
      set
      {
        Cleaner.My.Resources.Resources.resourceCulture = value;
      }
    }
  }
}
