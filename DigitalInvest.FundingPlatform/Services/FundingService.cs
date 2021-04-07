using AutoMapper;
using DigitalInvest.FundingPlatform.DataAccess.Entitities;
using DigitalInvest.FundingPlatform.Exceptions;
using DigitalInvest.FundingPlatform.Extensions;
using DigitalInvest.FundingPlatform.Models;
using DigitalInvest.FundingPlatform.Repository;
using Microsoft.EntityFrameworkCore;
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
            var queryable = await _repository.GetAllAsync();

            var fundings = queryable.OrderByDescending(f => f.ExpirationDate)
                        .ThenBy(f => f.CreatedOn)
                        .ToList();

            return _mapper.Map<ICollection<FundingViewModel>>(fundings);
        }

        public async Task UpdateAsync(string id, FundingViewModel changedModel)
        {
            try
            {
                var entity = await _repository.GetAsync(id);
                _mapper.Map(changedModel, entity);
                await _repository.UpdateAsync(entity);
            }

            catch (FormatException formatEx)
            {
                throw new EntityNotFoundException($"Entity not found in database. {formatEx.Message}", formatEx);
            }
            catch (Exception e) // Can add more custom exceptions for other types of errors: mapping, db update etc.
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
            catch (FormatException ex)
            {
                throw new EntityNotFoundException(ex.Message);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
