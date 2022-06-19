using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaShop.Data;
using PizzaShop.Models;

namespace PizzaShop.Pages
{
    public class OrdersModel : PageModel
    {
        public List<PizzaOrder> PizzaOrders = new List<PizzaOrder>();

        private readonly ApplicationDbContext _context;

        public OrdersModel(ApplicationDbContext Context)
        {
            _context = Context;
        }


        public void OnGet()
        {
            PizzaOrders = _context.PizzaOrders.ToList();

        }
    }
}
