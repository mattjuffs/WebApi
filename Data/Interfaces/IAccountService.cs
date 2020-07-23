using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Interfaces
{
    interface IAccountService
    {
        List<Entities.Account> GetAccounts();
    }
}
