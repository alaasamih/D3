namespace Sitecore.Feature.Navigation
{
  using Sitecore.Data;

  public struct Templates
  {

    public struct Link
    {
      public static readonly ID ID = new ID("{491FBF0A-47ED-4BAC-9458-ED067BEF734F}");
      public struct Fields
      {
        public static readonly ID NavigationTitle = new ID("{6C3781D9-1A94-4BFD-8C27-ED53A2FD420D}");
        public static readonly ID Link = new ID("{FDE27C9D-306C-4984-BC35-E4FBBD5868A7}");
        public static readonly ID Image = new ID("{B95B1656-41F1-445E-9A3D-931C7E324F36}");
      }
    }

    public struct LinkIcon
    {
      public static readonly ID ID = new ID("{80D06AEF-447D-4D16-866D-6D87B468107A}");

      public struct Fields
      {
        public static readonly ID Icon = new ID("{E1CB078E-9917-4186-8FAB-F73C7AFF1389}");

      }
    }

    public struct LinkImage
    {
      public static readonly ID ID = new ID("{007CAFCF-C0A6-4EB1-87B2-B35130256500}");

      public struct Fields
      {
        public static readonly ID Image = new ID("{19C8DA4D-B22F-4C87-9332-D5609C863489}");

      }
    }
  }
}