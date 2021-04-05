using DigitalInvest.FundingPlatform.DataAccess.Entitities;
using DigitalInvest.FundingPlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalInvest.FundingPlatform.Services
{
    public interface IService<T> where T : BaseViewModel
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetAsync(string id);
        Task UpdateAsync(string id, T viewModel);
    }
}
