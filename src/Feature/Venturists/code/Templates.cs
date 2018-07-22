namespace Sitecore.Feature.Venturists
{
  using Sitecore.Data;

  public struct Templates
  {
    public struct PageHeader
    {
      public static readonly ID ID = new ID("{AB1F4AF4-2503-49C6-994E-A4B093381166}");

      public struct Fields
      {
        public static readonly ID Title = new ID("{A668F2E1-7FA4-471A-94B3-746582BEF5CC}");

        public static readonly ID Summary = new ID("{B1481491-BEC4-4FC5-8246-2B7B9852E503}");
       
      }
    }

    public struct Video
    {
      public static readonly ID ID = new ID("{9A191F46-3F55-47AC-9730-0445B0698567}");

      public struct Fields
      {
        public static readonly ID Title = new ID("{1DC6C8FA-A3C7-46B0-A225-4EA865C926DD}");
        public static readonly ID Summary = new ID("{D44E7B80-2247-429B-BB05-68E96DEAFD08}");
        public static readonly ID VideoLink = new ID("{33C48159-B5F8-4EFF-96D5-4435F202F806}");
      }
    }
  }
}
