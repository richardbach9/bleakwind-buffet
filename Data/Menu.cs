using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Represents the menu for the Bleakwind Buffet
    /// </summary>
    public static class Menu
    {
        /// <summary>
        /// represents a menu containing all entrees
        /// </summary>
        /// <returns>returns a list containing all entrees</returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> entrees = new List<IOrderItem>();
            entrees.Add(new BriarheartBurger());
            entrees.Add(new DoubleDraugr());
            entrees.Add(new GardenOrcOmelette());
            entrees.Add(new PhillyPoacher());
            entrees.Add(new SmokehouseSkeleton());
            entrees.Add(new ThalmorTriple());
            entrees.Add(new ThugsTBone());
            return entrees;
        }
        /// <summary>
        /// Represents the menu of all sides containing all sizes
        /// </summary>
        /// <returns>returns a list containing all sides of all sizes</returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> sides = new List<IOrderItem>();
            DragonbornWaffleFries dbwf = new DragonbornWaffleFries();
            sides.Add(dbwf);
            dbwf = new DragonbornWaffleFries();
            dbwf.Size = Enums.Size.Medium;
            sides.Add(dbwf);
            dbwf = new DragonbornWaffleFries();
            dbwf.Size = Enums.Size.Large;
            sides.Add(dbwf);
            FriedMiraak fm = new FriedMiraak();
            sides.Add(fm);
            fm = new FriedMiraak();
            fm.Size = Enums.Size.Medium;
            sides.Add(fm);
            fm = new FriedMiraak();
            fm.Size = Enums.Size.Large;
            sides.Add(fm);
            MadOtarGrits mog = new MadOtarGrits();
            sides.Add(mog);
            mog = new MadOtarGrits();
            mog.Size = Enums.Size.Medium;
            sides.Add(mog);
            mog = new MadOtarGrits();
            mog.Size = Enums.Size.Large;
            sides.Add(mog);
            VokunSalad vs = new VokunSalad();
            sides.Add(vs);
            vs = new VokunSalad();
            vs.Size = Enums.Size.Medium;
            sides.Add(vs);
            vs = new VokunSalad();
            vs.Size = Enums.Size.Large;
            sides.Add(vs);
            return sides;
        }
        /// <summary>
        /// represents a menu containing every drink of all sizes and flavors available
        /// </summary>
        /// <returns>Returns a list containing every drink of all sizes and flavors available</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> drinks = new List<IOrderItem>();
            AretinoAppleJuice aaj = new AretinoAppleJuice();
            drinks.Add(aaj);
            aaj = new AretinoAppleJuice();
            aaj.Size = Enums.Size.Medium;
            drinks.Add(aaj);
            aaj = new AretinoAppleJuice();
            aaj.Size = Enums.Size.Large;
            drinks.Add(aaj);
            CandlehearthCoffee cc = new CandlehearthCoffee();
            drinks.Add(cc);
            cc = new CandlehearthCoffee();
            cc.Size = Enums.Size.Medium;
            drinks.Add(cc);
            cc = new CandlehearthCoffee();
            cc.Size = Enums.Size.Large;
            drinks.Add(cc);
            MarkarthMilk mm = new MarkarthMilk();
            drinks.Add(mm);
            mm = new MarkarthMilk();
            mm.Size = Enums.Size.Medium;
            drinks.Add(mm);
            mm = new MarkarthMilk();
            mm.Size = Enums.Size.Large;
            drinks.Add(mm);
            SailorSoda ss = new SailorSoda();
            drinks.Add(ss);
            ss = new SailorSoda();
            ss.SodaFlavor = Enums.SodaFlavor.Cherry;
            ss.Size = Enums.Size.Medium;
            drinks.Add(ss);
            ss = new SailorSoda();
            ss.Size = Enums.Size.Large;
            ss.SodaFlavor = Enums.SodaFlavor.Cherry;
            drinks.Add(ss);
            ss = new SailorSoda();
            ss.SodaFlavor = Enums.SodaFlavor.Blackberry;
            drinks.Add(ss);
            ss = new SailorSoda();
            ss.Size = Enums.Size.Medium;
            ss.SodaFlavor = Enums.SodaFlavor.Blackberry;
            drinks.Add(ss);
            ss = new SailorSoda();
            ss.Size = Enums.Size.Large;
            ss.SodaFlavor = Enums.SodaFlavor.Blackberry;
            drinks.Add(ss);
            ss = new SailorSoda();
            ss.SodaFlavor = Enums.SodaFlavor.Grapefruit;
            drinks.Add(ss);
            ss = new SailorSoda();
            ss.Size = Enums.Size.Medium;
            ss.SodaFlavor = Enums.SodaFlavor.Grapefruit;
            drinks.Add(ss);
            ss = new SailorSoda();
            ss.Size = Enums.Size.Large;
            ss.SodaFlavor = Enums.SodaFlavor.Grapefruit;
            drinks.Add(ss);
            ss = new SailorSoda();
            ss.SodaFlavor = Enums.SodaFlavor.Lemon;
            drinks.Add(ss);
            ss = new SailorSoda();
            ss.Size = Enums.Size.Medium;
            ss.SodaFlavor = Enums.SodaFlavor.Lemon;
            drinks.Add(ss);
            ss = new SailorSoda();
            ss.Size = Enums.Size.Large;
            ss.SodaFlavor = Enums.SodaFlavor.Lemon;
            drinks.Add(ss);
            ss = new SailorSoda();
            ss.SodaFlavor = Enums.SodaFlavor.Peach;
            drinks.Add(ss);
            ss = new SailorSoda();
            ss.Size = Enums.Size.Medium;
            ss.SodaFlavor = Enums.SodaFlavor.Peach;
            drinks.Add(ss);
            ss = new SailorSoda();
            ss.Size = Enums.Size.Large;
            ss.SodaFlavor = Enums.SodaFlavor.Peach;
            drinks.Add(ss);
            ss = new SailorSoda();
            ss.SodaFlavor = Enums.SodaFlavor.Watermelon;
            drinks.Add(ss);
            ss = new SailorSoda();
            ss.Size = Enums.Size.Medium;
            ss.SodaFlavor = Enums.SodaFlavor.Watermelon;
            drinks.Add(ss);
            ss = new SailorSoda();
            ss.Size = Enums.Size.Large;
            ss.SodaFlavor = Enums.SodaFlavor.Watermelon;
            drinks.Add(ss);
            return drinks;
        }
        /// <summary>
        /// Represents the full menu with every item on it
        /// </summary>
        /// <returns>A list containing every item on the menu</returns>
        public static IEnumerable<IOrderItem> FullMenu()
        {
            List<IOrderItem> fullMenu = new List<IOrderItem>();
            fullMenu.Add(new BriarheartBurger());
            fullMenu.Add(new DoubleDraugr());
            fullMenu.Add(new GardenOrcOmelette());
            fullMenu.Add(new PhillyPoacher());
            fullMenu.Add(new SmokehouseSkeleton());
            fullMenu.Add(new ThalmorTriple());
            fullMenu.Add(new ThugsTBone());
            DragonbornWaffleFries dbwf = new DragonbornWaffleFries();
            fullMenu.Add(dbwf);
            dbwf = new DragonbornWaffleFries();
            dbwf.Size = Enums.Size.Medium;
            fullMenu.Add(dbwf);
            dbwf = new DragonbornWaffleFries();
            dbwf.Size = Enums.Size.Large;
            fullMenu.Add(dbwf);
            FriedMiraak fm = new FriedMiraak();
            fullMenu.Add(fm);
            fm = new FriedMiraak();
            fm.Size = Enums.Size.Medium;
            fullMenu.Add(fm);
            fm = new FriedMiraak();
            fm.Size = Enums.Size.Large;
            fullMenu.Add(fm);
            MadOtarGrits mog = new MadOtarGrits();
            fullMenu.Add(mog);
            mog = new MadOtarGrits();
            mog.Size = Enums.Size.Medium;
            fullMenu.Add(mog);
            mog = new MadOtarGrits();
            mog.Size = Enums.Size.Large;
            fullMenu.Add(mog);
            VokunSalad vs = new VokunSalad();
            fullMenu.Add(vs);
            vs = new VokunSalad();
            vs.Size = Enums.Size.Medium;
            fullMenu.Add(vs);
            vs = new VokunSalad();
            vs.Size = Enums.Size.Large;
            fullMenu.Add(vs);
            AretinoAppleJuice aaj = new AretinoAppleJuice();
            fullMenu.Add(aaj);
            aaj = new AretinoAppleJuice();
            aaj.Size = Enums.Size.Medium;
            fullMenu.Add(aaj);
            aaj = new AretinoAppleJuice();
            aaj.Size = Enums.Size.Large;
            fullMenu.Add(aaj);
            CandlehearthCoffee cc = new CandlehearthCoffee();
            fullMenu.Add(cc);
            cc = new CandlehearthCoffee();
            cc.Size = Enums.Size.Medium;
            fullMenu.Add(cc);
            cc = new CandlehearthCoffee();
            cc.Size = Enums.Size.Large;
            fullMenu.Add(cc);
            MarkarthMilk mm = new MarkarthMilk();
            fullMenu.Add(mm);
            mm = new MarkarthMilk();
            mm.Size = Enums.Size.Medium;
            fullMenu.Add(mm);
            mm = new MarkarthMilk();
            mm.Size = Enums.Size.Large;
            fullMenu.Add(mm);
            SailorSoda ss = new SailorSoda();
            fullMenu.Add(ss);
            ss = new SailorSoda();
            ss.SodaFlavor = Enums.SodaFlavor.Cherry;
            ss.Size = Enums.Size.Medium;
            fullMenu.Add(ss);
            ss = new SailorSoda();
            ss.Size = Enums.Size.Large;
            ss.SodaFlavor = Enums.SodaFlavor.Cherry;
            fullMenu.Add(ss);
            ss = new SailorSoda();
            ss.SodaFlavor = Enums.SodaFlavor.Blackberry;
            fullMenu.Add(ss);
            ss = new SailorSoda();
            ss.Size = Enums.Size.Medium;
            ss.SodaFlavor = Enums.SodaFlavor.Blackberry;
            fullMenu.Add(ss);
            ss = new SailorSoda();
            ss.Size = Enums.Size.Large;
            ss.SodaFlavor = Enums.SodaFlavor.Blackberry;
            fullMenu.Add(ss);
            ss = new SailorSoda();
            ss.SodaFlavor = Enums.SodaFlavor.Grapefruit;
            fullMenu.Add(ss);
            ss = new SailorSoda();
            ss.Size = Enums.Size.Medium;
            ss.SodaFlavor = Enums.SodaFlavor.Grapefruit;
            fullMenu.Add(ss);
            ss = new SailorSoda();
            ss.Size = Enums.Size.Large;
            ss.SodaFlavor = Enums.SodaFlavor.Grapefruit;
            fullMenu.Add(ss);
            ss = new SailorSoda();
            ss.SodaFlavor = Enums.SodaFlavor.Lemon;
            fullMenu.Add(ss);
            ss = new SailorSoda();
            ss.Size = Enums.Size.Medium;
            ss.SodaFlavor = Enums.SodaFlavor.Lemon;
            fullMenu.Add(ss);
            ss = new SailorSoda();
            ss.Size = Enums.Size.Large;
            ss.SodaFlavor = Enums.SodaFlavor.Lemon;
            fullMenu.Add(ss);
            ss = new SailorSoda();
            ss.SodaFlavor = Enums.SodaFlavor.Peach;
            fullMenu.Add(ss);
            ss = new SailorSoda();
            ss.Size = Enums.Size.Medium;
            ss.SodaFlavor = Enums.SodaFlavor.Peach;
            fullMenu.Add(ss);
            ss = new SailorSoda();
            ss.Size = Enums.Size.Large;
            ss.SodaFlavor = Enums.SodaFlavor.Peach;
            fullMenu.Add(ss);
            ss = new SailorSoda();
            ss.SodaFlavor = Enums.SodaFlavor.Watermelon;
            fullMenu.Add(ss);
            ss = new SailorSoda();
            ss.Size = Enums.Size.Medium;
            ss.SodaFlavor = Enums.SodaFlavor.Watermelon;
            fullMenu.Add(ss);
            ss = new SailorSoda();
            ss.Size = Enums.Size.Large;
            ss.SodaFlavor = Enums.SodaFlavor.Watermelon;
            fullMenu.Add(ss);
            return fullMenu;
        }
        public static IEnumerable<IOrderItem> Search(string terms)
        {
            string temp;
            if(terms == null) return FullMenu();
            List<IOrderItem> results = new List<IOrderItem>();
            foreach(IOrderItem item in FullMenu())
            {
                temp = item.ToString().ToLower();
                if(temp.Contains(terms.ToLower()))
                {
                    results.Add(item);
                }
            }
            return results;
        }
        public static IEnumerable<IOrderItem> FilterByItemType(IEnumerable<IOrderItem> items, IEnumerable<string> itemType)
        {
            if (itemType == null || itemType.Count() == 0)
                return items;
            List<IOrderItem> filtered = new List<IOrderItem>();
            foreach(IOrderItem item in items)
            {
                if(itemType.Contains("Drink"))
                {
                    if(item is Drink)
                    {
                        filtered.Add(item);
                    }
                }
                if(itemType.Contains("Entree"))
                {
                    if(item is Entree)
                    {
                        filtered.Add(item);
                    }
                }
                if(itemType.Contains("Side"))
                {
                    if(item is Side)
                    {
                        filtered.Add(item);
                    }
                }
            }
            return filtered; 
        }
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> items, uint? caloriesMin, uint? caloriesMax)
        {
            if(caloriesMin == 0 && caloriesMax == 0)
            {
                return items;
            }
            if (caloriesMin == null && caloriesMax == null)
            {
                return items;
            }
            List<IOrderItem> filtered = new List<IOrderItem>();
            if(caloriesMin == null)
            {
                foreach(IOrderItem item in items)
                {
                    if (item.Calories <= caloriesMax) filtered.Add(item);
                }
                return filtered;
            }
            if ((caloriesMax == 0 || caloriesMax == null) && caloriesMin != 0)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Calories >= caloriesMin) filtered.Add(item);
                }
                return filtered;
            }
            foreach(IOrderItem item in items)
            {
                if (item.Calories >= caloriesMin && item.Calories <= caloriesMax) filtered.Add(item);
            }
            return filtered;
        }
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> items, double? priceMin, double? priceMax)
        {
            if (priceMin == 0 && priceMin == 0)
            {
                return items;
            }
            if (priceMin == null && priceMin == null)
            {
                return items;
            }
            List<IOrderItem> filtered = new List<IOrderItem>();
            if (priceMin == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Price <= priceMax) filtered.Add(item);
                }
                return filtered;
            }
            if ((priceMax == 0 || priceMax == null) && priceMin != 0)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Price >= priceMin) filtered.Add(item);
                }
                return filtered;
            }
            foreach (IOrderItem item in items)
            {
                if (item.Price >= priceMin && item.Price <= priceMax) filtered.Add(item);
            }
            return filtered;
        }
    }
}
