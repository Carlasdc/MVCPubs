using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCPubs.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVCPubs.Controllers
{
    public class HomeController : Controller
        
    {
        //private PubsContext _context { get; }

        public IActionResult Index()
        {
            /*List<Customer> customers = (from customer in this._context.Customers.Take(10)
                                        select customer).ToList(); */
            return View();
        }

    }
}
