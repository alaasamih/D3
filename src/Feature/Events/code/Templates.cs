using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data;

namespace Sitecore.Feature.Events
{
  public struct Templates
  {
    public struct Event
    {
      public static readonly ID ID = new ID("{0DECCCC0-B11A-4C93-A145-A4E6B9C459D2}");
      public struct Fields
      {
        public static readonly ID Title = new ID("{E972A2AD-4BFE-45C6-ABF7-113D9CDFC1FA}");
        public static readonly ID Description = new ID("{EE7C47E0-4D28-4CDB-B731-6B5D3C2803D0}");
        public static readonly ID Date = new ID("{7823252A-5D9B-4408-A090-B2595C92E69D}");
        public static readonly ID Venue = new ID("{E178B978-716C-4037-9005-157171BEBBF3}");
        public static readonly ID VenueAddress = new ID("{33779ADA-FCD3-46D6-BD5A-3BF858560160}");
      }
    }
  }
}