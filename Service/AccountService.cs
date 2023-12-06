using System;
using Repositories.Models;
using Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class AccountService
    {
        public Account? CheckLogin(string email, string password)
        {
            AccountRepository repo = new AccountRepository();

            Account account = repo.Get(email);

            return account != null && account.MemberAccountPassword == password ? account : null;
        }
    }
}
