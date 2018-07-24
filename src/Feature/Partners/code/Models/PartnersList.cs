using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.Feature.Partners.Models
{
  public class PartnersList
  {
    public IEnumerable<PartnersList> Partners { get; set; }
    public Item item { get; set; }
    public string Title { get; set; }
    public string Address { get; set; }
    public string Telephone { get; set; }
    public string Link { get; set; }
    public string Value { get; set; }
  
  }
}