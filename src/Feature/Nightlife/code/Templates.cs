namespace Sitecore.Feature.Nightlife
{
  using Sitecore.Data;

  public struct Templates
  {
    public struct HasContent
    {
      public static readonly ID ID = new ID("{E41E8F64-E6C3-4427-A4D7-ECACCF027F70}");

      public struct Fields
      {
        public static readonly ID Title = new ID("{3FA90163-6161-4F45-8FBB-86DCCC901AD3}");
        public static readonly ID Summary = new ID("{198738F7-2B00-4935-A196-161C90BD7501}");
        public static readonly ID RestTitle = new ID("{8A99A4F7-13D8-4B4B-9C04-824AFE7763B1}");

      }
    }

    public struct HasRestaurant
    {
      public static readonly ID ID = new ID("{B38FD9B5-7E21-4DBD-976F-9FAFEB6E4EA3}");

      public struct Fields
      {
        public static readonly ID Name = new ID("{BA85E4EF-DAB2-449A-B1AF-AA888F54B3B7}");
        public static readonly ID Phone = new ID("{F4CE868E-EB6E-422B-AD39-91E40799B59C}");
        public static readonly ID Image = new ID("{9C0067DB-86A1-4049-A5D8-E1F9FF1BA3B9}");
        public static readonly ID Link = new ID("{F991E296-1CD9-433C-8884-D18CBA117188}");

      }
    }

  }
}
