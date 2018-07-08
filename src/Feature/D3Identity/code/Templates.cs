using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.Feature.D3Identity
{
  using Sitecore.Data;
  public class Templates
  {
    public struct Identity
    {
      public static readonly ID ID = new ID("{EB36F4AD-3657-475F-94C8-3B9E0CC216EF}");

      public struct Fields
      {
        public static readonly ID Logo = new ID("{973679A7-F52E-44A5-80FF-6FD15C93CE96}");
        public static readonly ID LogoTagLine = new ID("{AAEA8144-DDDB-4619-BB73-343FECDDF699}");
        public static readonly ID Copyright = new ID("{BD84030B-407C-4C0B-9609-DA7FA6AB12F8}");
        public static readonly ID OrganisationPhone = new ID("{10FA770F-F040-48EF-814C-56D55CF9BC21}");
      }
    }
  }
}