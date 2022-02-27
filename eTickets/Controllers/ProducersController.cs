using Microsoft.AspNetCore.Mvc;
using eTickets.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
    
    public class ProducersController : Controller
    {
        private readonly ProducersServices _producersServices;

        public ProducersController(ProducersServices producersServices)
        {
            _producersServices = producersServices;
        }

        public async Task<IActionResult> Index()
        {
            var allProducers = await _producersServices.FindAllAsync();
            return View(allProducers);
        }
    }
}
