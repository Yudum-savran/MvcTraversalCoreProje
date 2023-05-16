using BusinessLayer.AbstractUow;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalCoreProje.Areas.Admin.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(AccountViewModel accountViewModel)
        {
            var valueSender = _accountService.TGetById(accountViewModel.SenderId);
            var valueReceiver = _accountService.TGetById(accountViewModel.ReceiverId);

            valueSender.Balance -= accountViewModel.Amount;
            valueReceiver.Balance += accountViewModel.Amount;

            List<Account> modifedAccounts = new List<Account>()
            {
                valueReceiver,
                valueSender
            };
            _accountService.TMultiUpdate(modifedAccounts);
            return View();
        }
    }
}
