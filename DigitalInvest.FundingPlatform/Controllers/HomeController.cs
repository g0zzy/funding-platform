using DigitalInvest.FundingPlatform;
using DigitalInvest.FundingPlatform.Models;
using DigitalInvest.FundingPlatform.Services;
using Ev.DigitalInvest.FundingPlatform.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Ev.DigitalInvest.FundingPlatform.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IService<FundingViewModel> _fundingService;
        const string SessionUserId = "_UserId";

        public HomeController(ILogger<HomeController> logger, IService<FundingViewModel> fundingService)
        {
            _logger = logger.ThrowIfNull(nameof(logger));
            _fundingService = fundingService.ThrowIfNull(nameof(fundingService));
        }

        [HttpGet]
        public async Task<IActionResult> IndexAsync()
        {
            HttpContext.Session.SetString(SessionUserId, Guid.NewGuid().ToString());

            ViewData["UserId"] = HttpContext.Session.GetString(SessionUserId);

            var fundings = await _fundingService.GetAllAsync();

            return View(fundings);
        }

        [HttpGet]
        public async Task<ActionResult> LoadEditFundingPopupAsync(string id)
        {
            try
            {
                var model = await _fundingService.GetAsync(id);
                return PartialView("_EditFunding", model);
            }
            catch (Exception)
            {
                return PartialView("_EditFunding");
            }
        }

        [HttpPost]
        public async Task<ActionResult> EditFundingAsync(string id, [Bind("Id,Investment")]FundingViewModel model)
        {
            try
            {
                var userId = HttpContext.Session.GetString(SessionUserId);
                model.UserIds.Add(userId);
                await _fundingService.UpdateAsync(id, model);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {
                return RedirectToAction(nameof(Error));
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
