namespace Sitecore.Feature.Navigation.Controllers
{
  using System.Web.Mvc;
  using Sitecore.Feature.Navigation.Repositories;
  using Sitecore.Foundation.Alerts.Extensions;
  using Sitecore.Foundation.Alerts.Models;
  using Sitecore.Foundation.Dictionary.Repositories;
  using Sitecore.Mvc.Presentation;

  public class NavigationController : Controller
  {
    private readonly INavigationRepository _navigationRepository;

    public NavigationController() : this(new NavigationRepository(RenderingContext.Current.ContextItem))
    {
    }

    public NavigationController(INavigationRepository navigationRepository)
    {
      this._navigationRepository = navigationRepository;
    }

    public ActionResult MainMenu()
    {
      var items = this._navigationRepository.GetPrimaryMenu();
      return this.View("MainMenu", items);
    }
    //    public ActionResult TopMenu()
    //    {
    //      if (string.IsNullOrEmpty(RenderingContext.Current.Rendering.DataSource))
    //      {
    //        return Context.PageMode.IsExperienceEditor ? this.InfoMessage(new InfoMessage(DictionaryPhraseRepository.Current.Get("/Navigation/Link Menu/No Items", "This menu has no items."), InfoMessage.MessageType.Warning)) : null;
    //      }
    //      var item = RenderingContext.Current.Rendering.Item;
    //      var items = this._navigationRepository.GetTopMenu();
    //      return this.View("TopMenu", items);
    //    }
    //public ActionResult SocialLinks()
    //{
    //  if (string.IsNullOrEmpty(RenderingContext.Current.Rendering.DataSource))
    //  {
    //    return Context.PageMode.IsExperienceEditor ? this.InfoMessage(new InfoMessage(DictionaryPhraseRepository.Current.Get("/Navigation/Link Menu/No Items", "This menu has no items."), InfoMessage.MessageType.Warning)) : null;
    //  }
    //  var item = RenderingContext.Current.Rendering.Item;
    //  var items = this._navigationRepository.GetLinkList(item);
    //  return this.View("SocialLinks", items);
    //}
    public ActionResult LinkList()
    {
      if (string.IsNullOrEmpty(RenderingContext.Current.Rendering.DataSource))
      {
        return Context.PageMode.IsExperienceEditor ? this.InfoMessage(new InfoMessage(DictionaryPhraseRepository.Current.Get("/Navigation/Link Menu/No Items", "This menu has no items."), InfoMessage.MessageType.Warning)) : null;
      }
      var item = RenderingContext.Current.Rendering.Item;
      var items = this._navigationRepository.GetLinkMenuItems(item);
      return this.View("LinkList", items);
    }
  }
}
