using Contacter.Application.Interfaces;
using Contacter.Application.ViewModels.Company;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace Contacter.Web.Controllers
{
    public class CompanyController : Controller 
    {
        private readonly ICompanyService _companyService;

        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        public IActionResult Index()
        {
            var model = _companyService.GetAllCompaniesForList();

            return View(model);
        }

        public IActionResult Details(int id)
        {
            var model = _companyService.GetCompanyDetails(id);

            if(model is null)
            {
                return NotFound();
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult AddCompany()
        {
            var model = new NewCompanyVM();

            return View(model);
        }

        [HttpPost]
        public IActionResult AddCompany(NewCompanyVM model)
        {
            _companyService.AddCompany(model);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult EditCompany(int id)
        {
            var model = _companyService.GetCompanyForEdit(id);

            return View(model);
        }

        [HttpPost]
        public IActionResult EditCompant(EditCompanyVM model)
        {
            var result = _companyService.UpdateCompany(model);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult DeleteCompany(int id)
        {
            _companyService.DeleteCompany(id);

            return RedirectToAction(nameof(Index));
        }
    }
}
