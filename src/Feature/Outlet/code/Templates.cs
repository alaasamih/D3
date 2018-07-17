namespace Sitecore.Feature.Events
{
  using Sitecore.Data;

  public struct Templates
  {
    public struct Event
    {
      public static readonly ID ID = new ID("{C6DB0A78-309E-4834-8CBD-A725F75BE5EA}");

      public struct Fields
      {
        public static readonly ID StartDate = new ID("{30E3E99D-EDFC-4AFF-AB3E-67881A2F14A9}");
        
        public static readonly ID EndDate = new ID("{F486F493-447D-4517-AF52-855D64BE3F9E}");
       
        public static readonly ID Title = new ID("{66E9D03B-F601-4B95-BC14-260577BA107D}");
        
        public static readonly ID Venue = new ID("{CE755CF6-FB2F-440D-8FE1-89F3C9F23EEC}");
      
        public static readonly ID Description = new ID("{431FC80B-2242-464D-A55F-884863B4B44B}");
       
        public static readonly ID Image = new ID("{CD200A3C-A5EB-40D0-AF7A-6837528CCFDD}");
       
      }
    }

    public struct EventLink
    {
      public static readonly ID ID = new ID("{6BA6260D-1714-4258-8D52-90317B730174}");

      public struct Fields
      {
        public static readonly ID LinkTitle = new ID("{85969632-1470-432F-BFE8-6F00D726A7C9}");
        
        public static readonly ID Link = new ID("{3E946F75-0B1E-406B-B18C-0AFF1EAB8FCC}");
       
    
      }
    }
  }
}
