using CleanArchTDC.Application.Contracts;
using CleanArchTDC.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace CleanArchTDC.Web.MVC.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ICustomerService _customerService;
        
        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var customerViewModel = await _customerService.GetCustomers();
            return View(customerViewModel);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,Name,BirthDate,Gender")] CustomerViewModel customerViewModel)
        {
            if (ModelState.IsValid)
            {
                _customerService.Add(customerViewModel);
                return RedirectToAction(nameof(Index));
            }

            return View(customerViewModel);
        }

        [HttpGet()]
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
                return NotFound();

            var customerViewModel = await _customerService.GetById(id);

            if (customerViewModel == null)
                return NotFound();

            return View(customerViewModel);
        }

        [HttpPost()]
        public IActionResult Edit([Bind] CustomerViewModel customerViewModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _customerService.Update(customerViewModel);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                
                return RedirectToAction(nameof(Index));
            }

            return View(customerViewModel);
        }

        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerViewModel = await _customerService.GetById(id);

            if (customerViewModel == null)
            {
                return NotFound();
            }

            return View(customerViewModel);
        }

        [HttpGet()]
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
                return NotFound();

            var customerViewModel = await _customerService.GetById(id);

            if (customerViewModel == null)
                return NotFound();

            return View(customerViewModel);
        }

        [HttpPost(), ActionName("Delete")]
        public IActionResult DeleteConfirmed(Guid? id)
        {
            _customerService.Remove(id);
            return RedirectToAction("Index");
        }
    }
}
