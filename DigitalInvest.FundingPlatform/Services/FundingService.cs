using AutoMapper;
using DigitalInvest.FundingPlatform.DataAccess.Entitities;
using DigitalInvest.FundingPlatform.Models;
using DigitalInvest.FundingPlatform.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalInvest.FundingPlatform.Services
{
    public class FundingService : IService<FundingViewModel>
    {
        private readonly IRepository<Funding> _repository;
        private readonly IMapper _mapper;

        public FundingService(IRepository<Funding> repository, IMapper mapper)
        {
            _repository = repository.ThrowIfNull(nameof(repository));
            _mapper = mapper.ThrowIfNull(nameof(mapper));
        }

        public async Task<IEnumerable<FundingViewModel>> GetAllAsync()
        {
            try
            {
                var queryable = await _repository.GetAllAsync();

                var fundings = queryable.OrderByDescending(f => f.ExpirationDate)
                            .ThenBy(f => f.CreatedOn)
                          .ToList();

                return _mapper.Map<ICollection<FundingViewModel>>(fundings);
            }
            catch
            {
                throw;
            }
        }

        public async Task UpdateAsync(string id, FundingViewModel changedFunding)
        {
            try
            {
                var entity = await _repository.GetAsync(id);
                entity = _mapper.Map<FundingViewModel,Funding>(changedFunding);
                await _repository.UpdateAsync(entity);
            }
            //catch(NotFoundException e)
            //{

            //}
            catch(Exception e)
            {
                throw e;
            }
        }

        public async Task<FundingViewModel> GetAsync(string id)
        {
            try
            {
                var entity = await _repository.GetAsync(id);
                return _mapper.Map<FundingViewModel>(entity);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
