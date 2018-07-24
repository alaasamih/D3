using Sitecore.Data.Items;
using Sitecore.Feature.Partners.Models;
using Sitecore.Mvc.Presentation;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Sitecore.Feature.Partners.Controllers
{
  public class PartnersController : Controller
  {
   
    [HttpGet]
    public ActionResult GetPartnersList(string letter)
    {
      var datasource = Sitecore.Context.Database.GetItem("{8B5D765F-A21D-413F-B202-B31D34FC8976}");
      IEnumerable<PartnersList> list = null;

            if(letter =="All")
      {
        list = datasource.GetChildren().Select(o => new PartnersList { item = o, Partners = GetChildren(o), Value = o.Database.GetItem(((Sitecore.Data.Fields.LinkField)o.Fields[Templates.Partners.Fields.Value]).Value).Name });
      }
      else {  
        list = datasource.GetChildren().Where(o => FiletrItem(o, letter)).Select(o => new PartnersList { item = o, Partners = GetChildren(o), Value = o.Database.GetItem(((Sitecore.Data.Fields.LinkField)o.Fields[Templates.Partners.Fields.Value]).Value).Name });
       }
      return View("/Views/Partners/PartnersList.cshtml", list);
    }

    public ActionResult GetPartners()
    {
      //var datasource = RenderingContext.CurrentOrNull.Rendering.DataSource;
      var datasource = RenderingContext.Current.Rendering.Item;
      IEnumerable<PartnersList> list = null;
      
        list = datasource.GetChildren().Select(o => new PartnersList { item = o, Partners = GetChildren(o), Value = o.Database.GetItem(((Sitecore.Data.Fields.LinkField)o.Fields[Templates.Partners.Fields.Value]).Value).Name });
     
      return View("/Views/Partners/PartnersList.cshtml", list);
    }

    public bool FiletrItem(Item currentitem, string letter)
    {
      var value = currentitem.Database.GetItem(((Sitecore.Data.Fields.LinkField)currentitem.Fields[Templates.Partners.Fields.Value]).Value).Name;
      if (value.ToString() == letter)
      {
        return true;
      }
      return false;
    }

    public List<PartnersList> GetChildren(Item currentchildren)
    {
      List<PartnersList> Chill = new List<PartnersList>();

      foreach (Item itemChill in currentchildren.Children)
      {
        string title = itemChill.Fields[Templates.Partners.Fields.Title].Value;
        string address = itemChill.Fields[Templates.Partners.Fields.Address].Value;
        string telephone = itemChill.Fields[Templates.Partners.Fields.Telephone].Value;
        string link = itemChill.Fields[Templates.Partners.Fields.Link].Value;

        Chill.Add(new PartnersList { Title = title, Address = address, Telephone = telephone, Link = link });
      }

      return Chill;
    }
  }
}
