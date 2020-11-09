using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public IEnumerable<IOrderItem> Items { get; set; }
        public string SearchTerms { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet(string SearchTerms, string[] itemType, uint caloriesMin, uint caloriesMax, double priceMin, double priceMax)
        {
            Items = Menu.Search(SearchTerms);
            Items = Menu.FilterByItemType(Items, itemType);
            Items = Menu.FilterByCalories(Items, caloriesMin, caloriesMax);
            Items = Menu.FilterByPrice(Items, priceMin, priceMax);
        }
    }
}
