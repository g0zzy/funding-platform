using DigitalInvest.FundingPlatform.Exceptions;
using DigitalInvest.FundingPlatform.Extensions;
using DigitalInvest.FundingPlatform.Models;
using DigitalInvest.FundingPlatform.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Net;
using System.Threading.Tasks;

namespace DigitalInvest.FundingPlatform.Controllers
{
    public class HomeController : Controller
    {
        private readonly IService<FundingViewModel> _fundingService;

        public HomeController(IService<FundingViewModel> fundingService)
        {
            _fundingService = fundingService.ThrowIfNull(nameof(fundingService));
        }

        [HttpGet]
        public async Task<IActionResult> IndexAsync()
        {
            var fundings = await _fundingService.GetAllAsync();

            return View(fundings);
        }

        [HttpGet]
        public async Task<ActionResult> LoadEditFundingPopupAsync(string id)
        {
            if (ModelState.IsValid)
            {
                var model = await _fundingService.GetAsync(id);
                return PartialView("_EditFunding", model);
            }

            return BadRequest(ModelState);
        }

        [HttpPost]
        public async Task<ActionResult> EditFundingAsync(string id, [Bind("Id,Investment")]FundingViewModel model)
        {
            if(ModelState.IsValid)
            {
                await _fundingService.UpdateAsync(id, model);
                return RedirectToAction(nameof(Index));
            }

            return BadRequest(ModelState);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier, StatusCode = HttpContext.Response.StatusCode });
        }
    }
}
