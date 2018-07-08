using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.Demo.D3
{
  using Sitecore.Data;
  public class Templates
  {
    public struct TeaserContent
    {
      public static ID ID = new ID("{4D77450E-E9DC-4CB7-AA9E-8CB0801757AF}");

      public struct Fields
      {
        public static readonly ID Label = new ID("{E47FA351-485D-4F58-812D-E3BD3A3C412D}");
        public static readonly ID Summary = new ID("{C80E901B-6639-4FA0-970D-E17F712892C5}");
        public static readonly ID Image = new ID("{B70DA270-57B9-42CB-9091-AAD9664CE5C2}");
        public static readonly ID Link = new ID("{419C9E41-B1CF-4A8C-8F8B-1C04252F8299}");
      }
    }
  }
}