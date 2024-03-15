using Contacter.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

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

            return View(model);
        }
    }
}
