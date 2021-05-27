using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SoftifyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftifyApp.Controllers
{
    public class CompanyController : Controller
    {
        private readonly CompanyContext _context;
        public CompanyController(CompanyContext context)
        {
            _context = context;
        }
           
        public async Task<IActionResult> Listing()
        {
            return View(await _context.Companies.ToListAsync());
        }
        public ActionResult Create()
        {
            return View();
        }
        public async Task<IActionResult> Create(Company company)
        {
            if (company.Id > 0)
            {
                _context.Companies.Add(company);
                await _context.SaveChangesAsync();
                return RedirectToAction("Listing");
            }
            else
            {
                _context.Companies.Update(company);
            }
            return View(company);
         
        }
    }
}
