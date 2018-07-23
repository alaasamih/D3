//using Sitecore.ContentSearch;
//using Sitecore.ContentSearch.SearchTypes;
//using Sitecore.Data.Items;
//using System.Collections.Generic;
//using System.Linq;

//namespace Sitecore.Demo.D3.Controllers
//{
//    public class Search
//    {
//    public List<Item> getResult()
//    {
//      var index = ContentSearchManager.GetIndex("sitecore_master_index");

//      using (var context = index.CreateSearchContext())
//      {
//        var searchQuery = context.GetQueryable<SearchResultItem>();
//        var resultItems = searchQuery.Select(o => o.GetItem()).ToList();
//        var totalCount = searchQuery.Count();
//        return resultItems;
//      }
//    }
//  }
//}