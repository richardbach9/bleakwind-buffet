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

        public void OnGet(string SearchTerms, string[] itemType, uint? caloriesMin, uint? caloriesMax, double? priceMin, double? priceMax)
        {
            Items = Menu.FullMenu();
            if(SearchTerms != null)
            {
                string[] splitTerms = SearchTerms.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                foreach(string str in splitTerms)
                {
                    Items = Items.Where(item => item.ToString().Contains(str, StringComparison.InvariantCultureIgnoreCase));
                    Items = Items.Where(item => item.Description.Contains(str, StringComparison.InvariantCultureIgnoreCase));
                }
            }
            if (itemType != null && itemType.Length != 0)
            {
                foreach (string type in itemType)
                {
                    switch(type)
                    {
                        case "Drink":
                            Items = Items.Where(item => item is BleakwindBuffet.Data.Drinks.Drink);
                            break;
                        case "Entree":
                            Items = Items.Where(item => item is BleakwindBuffet.Data.Entrees.Entree);
                            break;
                        case "Side":
                            Items = Items.Where(item => item is BleakwindBuffet.Data.Sides.Side);
                            break;
                    }
                }
            }
            if (caloriesMin != null || caloriesMax != null)
            {
                if ((caloriesMin == 0 || caloriesMin == null) && caloriesMax != 0)
                {
                    Items = Items.Where(item => item.Calories <= caloriesMax);
                }
                else if ((caloriesMax == 0 || caloriesMax == null) && caloriesMin != 0)
                {
                    Items = Items.Where(item => item.Calories >= caloriesMin);
                }
                else
                {
                    Items = Items.Where(item => item.Calories >= caloriesMin && item.Calories <= caloriesMax);
                }
            }
            if (priceMin != null || priceMax != null)
            {
                if ((priceMin == 0 || priceMin == null) && priceMax != 0)
                {
                    Items = Items.Where(item => item.Price <= priceMax);
                }
                else if ((priceMax == 0 || priceMax == null) && priceMin != 0)
                {
                    Items = Items.Where(item => item.Price >= priceMin);
                }
                else
                {
                    Items = Items.Where(item => item.Price >= priceMin && item.Price <= priceMax);
                }
            }
        }
    }
}
