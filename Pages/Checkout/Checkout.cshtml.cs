using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaShop.Data;
using PizzaShop.Models;

namespace PizzaShop.Pages.Checkout
{
    [BindProperties(SupportsGet = true)]
    public class CheckoutModel : PageModel
    {
        
        public string? PizzaName { get; set; }
        public float PizzaPrice { get; set; }
        public string? ImageTitle { get; set; }

        private readonly ApplicationDbContext _context;

        public CheckoutModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(PizzaName))
            {
                PizzaName = "Custom Pizza";
            }
            if (string.IsNullOrWhiteSpace(ImageTitle))
            {
                ImageTitle = "Create";
            }
            else
            {
                PizzaName = ImageTitle;
            }
           
            PizzaOrder pizzaOrder = new PizzaOrder();
            pizzaOrder.PizzaName = PizzaName;
            pizzaOrder.BasePrice = PizzaPrice;


            if (pizzaOrder.BasePrice != 0)
            {

                _context.PizzaOrders.Add(pizzaOrder); // SaveChanges();
                _context.SaveChanges();
            }
            else
            {

            }
            

        }
    }
}
