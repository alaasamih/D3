namespace Sitecore.Feature.Media
{
  using Sitecore.Data;

  public struct Templates
  {

    public struct HasMedia
    {
      public static readonly ID ID = new ID("{3C45AF40-8AC0-4124-A665-DE37306F74EE}");

      public struct Fields
      {
        public static readonly ID Title = new ID("{4B55B6BE-F78C-475E-A276-3C8B214D034E}");
        public static readonly ID Description = new ID("{598BD8FE-22C8-4ADC-8D48-B93560CB5942}");
        public static readonly ID Link = new ID("{18976E30-5E8E-4C13-885B-27EA274DA9A7}");
      }
    }

    public struct HasMediaSelector
    {
      public static readonly ID ID = new ID("{EF556019-1706-4D3C-93D7-A56B903C5130}");

      public struct Fields
      {
        public static readonly ID MediaSelector = new ID("{9131C283-7143-42D6-8CE5-3DC6BD219C01}");
      }
    }

    public struct HasMediaImage
    {
      public static readonly ID ID = new ID("{B807828B-670B-4B3A-83F0-04DF159791B4}");

      public struct Fields
      {
        public static readonly ID Image = new ID("{47C5FE69-E903-488C-AEA9-84AB644BEF72}");
      }
    }
    public struct HasMediaVideo
    {
      public static readonly ID ID = new ID("{D2098210-2C02-43B5-A3B2-8083756BD02C}");

      public struct Fields
      {
        public static readonly ID VideoLink = new ID("{2CD487B9-1902-4A8B-B6F2-88E5082153A2}");
      }
    }
  }
}