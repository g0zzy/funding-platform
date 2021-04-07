using DigitalInvest.FundingPlatform.DataAccess;
using DigitalInvest.FundingPlatform.DataAccess.Entitities;
using DigitalInvest.FundingPlatform.Extensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalInvest.FundingPlatform.Repository
{
    public class GenericRepository<T> : IRepository<T> where T: BaseEntity
    {
        private readonly ApplicationDbContext _dbContext;
        private DbSet<T> _entities;

        public GenericRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext.ThrowIfNull(nameof(dbContext));
            _entities = dbContext.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _entities.AsNoTracking().ToListAsync();
        }

        public async Task<T> GetAsync(string id)
        {
            id.ThrowIfNull(nameof(id));

            if (Guid.TryParse(id, out var newGuid))
            {
                return await _entities.SingleOrDefaultAsync(e => e.Id.Equals(newGuid));
            }
            else
            {
                throw new FormatException($"Invalid id: {id}.");
            }
        }

        public Task UpdateAsync(T entity)
        {
            entity.ThrowIfNull(nameof(entity));
            // In case AsNoTracking() is used - to make sure we track the entity
            _dbContext.Entry(entity).State = EntityState.Modified;
            return _dbContext.SaveChangesAsync();
        }
    }
}
