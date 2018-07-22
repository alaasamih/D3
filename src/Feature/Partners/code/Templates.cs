namespace Sitecore.Feature.Partners
{
  using Sitecore.Data;

  public struct Templates
  {
    public struct Partners
    {
      public static readonly ID ID = new ID("{C4397EAF-8B80-470D-A860-4DE622CEFB3C}");

      public struct Fields
      {
        public static readonly ID Title = new ID("{AD9D591A-C38B-4FD2-A9A3-B0E93A5025DF}");

        public static readonly ID Address = new ID("{7A266CEC-DDEE-4463-A5CC-EEB2784AF824}");

        public static readonly ID Telephone = new ID("{1AF1EEC3-32CE-4F9F-8B11-70FF4D8B9920}");

        public static readonly ID Value = new ID("{9654E046-0987-4DBF-A511-97C956C456AE}");

        public static readonly ID Link = new ID("{DE15EE4F-21A5-4481-B38C-8EFEDA9D3ADF}");

      }
    }

    public struct FilterPartners
    {
      public static readonly ID ID = new ID("{584CBCFF-0429-4D2E-A6EA-6C5459306BB2}");

      public struct Fields
      {
         public static readonly ID FilterValue = new ID("{1478866A-DDF7-4C70-A419-AD3FD503B487}");
        public static readonly ID FilterLink = new ID("{4D6063A4-F9CD-4D80-AF67-DCDDFB62CBD4}");
      }
    }
  }
}
