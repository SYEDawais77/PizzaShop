using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaShop.Models;

namespace PizzaShop.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> PizzaDB = new()
        {
            new PizzasModel()
            {
                ImageTitle ="Bolognese",
                PizzaName = "Bolognese",
                BasePrice=2,
                TomatoSauce=true,
                Beef= true ,
                FinalPrice= 4 * 180
            },

            new PizzasModel()
            {
                ImageTitle ="Carbonara",
                PizzaName="Carbonara",
                BasePrice =2,
                Cheese=true,
                TomatoSauce=true ,
                FinalPrice= 6 * 180
            },

            new PizzasModel()
            {
                ImageTitle ="Hawaiian",
                PizzaName="Hawaiian",
                BasePrice = 2,
                Pineapple=true,
                Cheese=true ,
                FinalPrice= 9 * 180
            },

            new PizzasModel()
            {
                ImageTitle ="Margerita",
                PizzaName="Margerita",
                BasePrice = 2,
                Beef=true,
                Mushroom=true ,
                FinalPrice= 3 * 180
            },

            new PizzasModel()
            {
                ImageTitle ="MeatFeast",
                PizzaName="MeatFeast",
                BasePrice = 2,
                Mutton=true,
                Beef=true ,
                FinalPrice= 7 * 180
            },
            
            new PizzasModel()
            {
                ImageTitle ="Mushroom",
                PizzaName="Mushroom",
                BasePrice = 2,
                Mushroom=true,
                TomatoSauce= true ,
                FinalPrice= 5 * 180
            },
            
            new PizzasModel()
            {
                ImageTitle ="Pepperoni",
                PizzaName="Pepperoni",
                BasePrice = 2,
                Peperoni=true,
                Mutton=true ,
                FinalPrice= 8 * 180
            },
            
            new PizzasModel()
            {
                ImageTitle ="Seafood",
                PizzaName="Seafood",
                BasePrice = 2,
                Pineapple=true,
                TomatoSauce=true ,
                FinalPrice= 6 * 180
            },

            new PizzasModel()
            {
                ImageTitle ="Vegetarian",
                PizzaName="Vegetarian",
                BasePrice = 2,
                Veg=true,
                TomatoSauce=true ,
                FinalPrice= 3 * 180
            }

        };
        public void OnGet()
        {

        }



    }
}
