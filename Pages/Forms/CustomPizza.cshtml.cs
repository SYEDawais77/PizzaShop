using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaShop.Models;

namespace PizzaShop.Pages.Forms
{
    
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzasModel Pizza  { get; set; }

        public float PizzaPrice { get; set; }
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            PizzaPrice = Pizza.BasePrice;
            if (Pizza.TomatoSauce) PizzaPrice += 1;
            if (Pizza.Cheese) PizzaPrice += 2;
            if (Pizza.Peperoni) PizzaPrice += 2;
            if (Pizza.Pineapple) PizzaPrice += 5;
            if (Pizza.Beef) PizzaPrice += 3;
            if (Pizza.Mutton) PizzaPrice += 6;
            if (Pizza.Veg)  PizzaPrice += 1;

            PizzaPrice *=  180;

            return RedirectToPage("/Checkout/Checkout", new {Pizza.PizzaName, PizzaPrice });
        }
    }
}
