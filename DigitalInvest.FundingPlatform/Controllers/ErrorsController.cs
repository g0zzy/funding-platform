using DigitalInvest.FundingPlatform.Models;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalInvest.FundingPlatform.Controllers
{
    public class ErrorsController : Controller
    {
        [Route("Error/{statusCode}")]
        public IActionResult HandleErrorCode(int statusCode)
        {
            var errorViewModel = new ErrorViewModel { 
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier,
                StatusCode = statusCode
            };

            var statusCodeData = HttpContext.Features.Get<IStatusCodeReExecuteFeature>();

            switch (statusCode)
            {
                case 404:
                    errorViewModel.ErrorMessage = "Oh no! The page you are looking for cannot be found!";
                    errorViewModel.RouteOfException = statusCodeData.OriginalPath;
                    break;
                case 500:
                    errorViewModel.ErrorMessage = "Oops! Something went wrong on our server side :(";
                    errorViewModel.RouteOfException = statusCodeData.OriginalPath;
                    break;
            }

            return View("Error", errorViewModel);
        }
    }
}
