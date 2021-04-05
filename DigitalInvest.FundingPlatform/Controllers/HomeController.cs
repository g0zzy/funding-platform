using DigitalInvest.FundingPlatform;
using DigitalInvest.FundingPlatform.Models;
using DigitalInvest.FundingPlatform.Services;
using Ev.DigitalInvest.FundingPlatform.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Ev.DigitalInvest.FundingPlatform.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IService<FundingViewModel> _fundingService;


        public HomeController(ILogger<HomeController> logger, IService<FundingViewModel> fundingService)
        {
            _logger = logger.ThrowIfNull(nameof(logger));
            _fundingService = fundingService.ThrowIfNull(nameof(fundingService));
        }

        public async Task<IActionResult> IndexAsync()
        {
            var fundings = await _fundingService.GetAllAsync();

            return View(fundings);
        }


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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
