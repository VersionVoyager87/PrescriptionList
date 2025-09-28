using Microsoft.AspNetCore.Mvc;
using PrescriptionList.Models;
using System.Collections.Generic;

namespace PrescriptionList.Controllers
{
    public class HomeController : Controller
    {
        private readonly PrescriptionContext _context;

        public HomeController(PrescriptionContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // Get all prescriptions
            List<Prescription> prescriptions = _context.Prescriptions.ToList();
            return View(prescriptions);
        }
    }
}
