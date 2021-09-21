using Application.Common.Interfaces;
using Application.Repository.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repository.Implementation.Base
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly IApplicationDbContext _context;

        public Repository(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<T> AddAsync(T entity)
        {
            throw new System.NotImplementedException();
        }

        public async Task DeleteAsync(T entity)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
