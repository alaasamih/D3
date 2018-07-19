namespace Sitecore.Feature.PageContent
{
  using Sitecore.Data;

  public struct Templates
  {
    public struct HasPageContent
    {
      public static readonly ID ID = new ID("{AF74A00B-8CA7-4C9A-A5C1-156A68590EE2}");

      public struct Fields
      {
        public static readonly ID Title = new ID("{C30A013F-3CC8-4961-9837-1C483277084A}");

        public static readonly ID Summary = new ID("{AC3FD4DB-8266-476D-9635-67814D91E901}");

        public static readonly ID Link = new ID("{5B3EDB8A-66AC-4605-A02C-283E26B95696}");
      }
    }
    public struct HasDescription
    {
      public static readonly ID ID = new ID("{726A3143-2E3F-4B57-9FC5-FD43F204E5FD}");

      public struct Fields
      {

        public static readonly ID Body = new ID("{D74F396D-5C5E-4916-BD0A-BFD58B6B1967}");
      }
    }
    public struct HasImage
    {
      public static readonly ID ID = new ID("{EFDB20C3-0DF4-4CF9-B183-CD14FAEE2A0C}");

      public struct Fields
      {
        
        public static readonly ID Image = new ID("{9492E0BB-9DF9-46E7-8188-EC795C4ADE44}");
      }
    }
  }
}
