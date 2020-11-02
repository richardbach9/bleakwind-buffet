using System;
using System.Collections.Generic;
using System.Text;
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
            dbwf.Size = Enums.Size.Medium;
            fullMenu.Add(dbwf);
            dbwf.Size = Enums.Size.Large;
            fullMenu.Add(dbwf);
            FriedMiraak fm = new FriedMiraak();
            fullMenu.Add(fm);
            fm.Size = Enums.Size.Medium;
            fullMenu.Add(fm);
            fm.Size = Enums.Size.Large;
            fullMenu.Add(fm);
            MadOtarGrits mog = new MadOtarGrits();
            fullMenu.Add(mog);
            mog.Size = Enums.Size.Medium;
            fullMenu.Add(mog);
            mog.Size = Enums.Size.Large;
            fullMenu.Add(mog);
            VokunSalad vs = new VokunSalad();
            fullMenu.Add(vs);
            vs.Size = Enums.Size.Medium;
            fullMenu.Add(vs);
            vs.Size = Enums.Size.Large;
            fullMenu.Add(vs);
            AretinoAppleJuice aaj = new AretinoAppleJuice();
            fullMenu.Add(aaj);
            aaj.Size = Enums.Size.Medium;
            fullMenu.Add(aaj);
            aaj.Size = Enums.Size.Large;
            fullMenu.Add(aaj);
            CandlehearthCoffee cc = new CandlehearthCoffee();
            fullMenu.Add(cc);
            cc.Size = Enums.Size.Medium;
            fullMenu.Add(cc);
            cc.Size = Enums.Size.Large;
            fullMenu.Add(cc);
            MarkarthMilk mm = new MarkarthMilk();
            fullMenu.Add(mm);
            mm.Size = Enums.Size.Medium;
            fullMenu.Add(mm);
            mm.Size = Enums.Size.Large;
            fullMenu.Add(mm);
            SailorSoda ss = new SailorSoda();
            fullMenu.Add(ss);
            ss.SodaFlavor = Enums.SodaFlavor.Blackberry;
            fullMenu.Add(ss);
            ss.SodaFlavor = Enums.SodaFlavor.Grapefruit;
            fullMenu.Add(ss);
            ss.SodaFlavor = Enums.SodaFlavor.Lemon;
            fullMenu.Add(ss);
            ss.SodaFlavor = Enums.SodaFlavor.Peach;
            fullMenu.Add(ss);
            ss.SodaFlavor = Enums.SodaFlavor.Watermelon;
            fullMenu.Add(ss);
            ss.SodaFlavor = Enums.SodaFlavor.Cherry;
            ss.Size = Enums.Size.Medium;
            fullMenu.Add(ss);
            ss.SodaFlavor = Enums.SodaFlavor.Blackberry;
            fullMenu.Add(ss);
            ss.SodaFlavor = Enums.SodaFlavor.Grapefruit;
            fullMenu.Add(ss);
            ss.SodaFlavor = Enums.SodaFlavor.Lemon;
            fullMenu.Add(ss);
            ss.SodaFlavor = Enums.SodaFlavor.Peach;
            fullMenu.Add(ss);
            ss.SodaFlavor = Enums.SodaFlavor.Watermelon;
            fullMenu.Add(ss);
            ss.SodaFlavor = Enums.SodaFlavor.Cherry;
            ss.Size = Enums.Size.Large;
            fullMenu.Add(ss);
            ss.SodaFlavor = Enums.SodaFlavor.Blackberry;
            fullMenu.Add(ss);
            ss.SodaFlavor = Enums.SodaFlavor.Grapefruit;
            fullMenu.Add(ss);
            ss.SodaFlavor = Enums.SodaFlavor.Lemon;
            fullMenu.Add(ss);
            ss.SodaFlavor = Enums.SodaFlavor.Peach;
            fullMenu.Add(ss);
            ss.SodaFlavor = Enums.SodaFlavor.Watermelon;
            fullMenu.Add(ss);
            return fullMenu;
        }
    }
}
