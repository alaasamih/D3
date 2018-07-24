namespace Sitecore.Feature.Urban
{
  using Sitecore.Data;

  public struct Templates
  {
    public struct Content
    {
      public static readonly ID ID = new ID("{DF750ABD-5DA3-430D-BFDC-462AB7785F93}");

      public struct Fields
      {
        public static readonly ID Discription = new ID("{9C841B2E-E143-4E6D-87DB-0DFA670E5213}");

      }
    }

    public struct Image
    {
      public static readonly ID ID = new ID("{90B2BBB7-1436-4435-9B25-AC4B3E4BD500}");

      public struct Fields
      {
        public static readonly ID Image = new ID("{7E484CA4-B7FF-4B3A-AF89-354D73F4F4D0}");
        public static readonly ID Summary = new ID("{E9B356A6-622B-431B-B747-B55DA812DF3F}");
      }
    }
  }
}
