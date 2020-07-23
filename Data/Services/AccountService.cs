using System;
using System.Collections.Generic;
using System.Linq;
using Data.Interfaces;

namespace Data.Services
{
    public class AccountService : IAccountService
    {
        private IDbContext _dbContext;

        public AccountService(IDbContext dbContext)
        {
            // dbContext is dependency injected
            _dbContext = dbContext;
        }

        public List<Entities.Account> GetAccounts()
        {
            // using linq query
            return (
                from a in _dbContext.Set<Entities.Account>()
                select a
            ).ToList();
        }
    }
}
