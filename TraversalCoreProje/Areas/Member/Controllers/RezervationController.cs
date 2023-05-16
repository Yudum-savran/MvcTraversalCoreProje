using BusinessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProje.Areas.Member.Controllers
{
    [Area("Member")]
    [AllowAnonymous]
    public class RezervationController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
        RezervationManager rezervationManager = new RezervationManager(new EfRezervationDal());

        private readonly UserManager<AppUser> _userManager;

        public RezervationController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> MyCurrentRezervation()
        {

            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valueList = rezervationManager.GetListWithRezervationByAccepted(values.Id);
            return View(valueList);
        }

        public async Task<IActionResult> MyOddRezervation()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valueList = rezervationManager.GetListWithRezervationByPrevious(values.Id);
            return View(valueList);
        }

        public async Task<IActionResult> MyApprovalRezervation()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valueList = rezervationManager.GetListWithRezervationByWaitApproval(values.Id);
            return View(valueList);
        }


        [HttpGet]
        public IActionResult NewRezervation()
        {
            List<SelectListItem> values = (from x in destinationManager.TGetList()
                                           select new SelectListItem
                                           {
                                               Text = x.City,
                                               Value = x.DestinationId.ToString()
                                           }).ToList();
            ViewBag.v = values;
            return View();
        }

        [HttpPost]
        public IActionResult NewRezervation(Rezervation rezervation)
        {
            rezervation.AppUserId = 2;
            rezervation.Status = "Onay bekliyor";
            rezervationManager.TAdd(rezervation);
            return RedirectToAction("MyCurrentRezervation");
        }
    }
}
