using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Sythen.Properties
{
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
  [DebuggerNonUserCode]
  [CompilerGenerated]
  internal class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    internal Resources()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (Sythen.Properties.Resources.resourceMan == null)
          Sythen.Properties.Resources.resourceMan = new ResourceManager("Sythen.Properties.Resources", typeof (Sythen.Properties.Resources).Assembly);
        return Sythen.Properties.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get
      {
        return Sythen.Properties.Resources.resourceCulture;
      }
      set
      {
        Sythen.Properties.Resources.resourceCulture = value;
      }
    }
  }
}
