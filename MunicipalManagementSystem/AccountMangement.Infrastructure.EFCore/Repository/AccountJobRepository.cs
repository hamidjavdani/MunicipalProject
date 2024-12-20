using _0_Framework.Infrastructure;
using AccountManagement.Application.Contracts.AccountJob;
using AccountManagement.Domain.AccountJobAgg;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AccountMangement.Infrastructure.EFCore.Repository
{
    public class AccountJobRepository : RepositoryBase<long, AccountJob>, IAccountJobRepository
    {
        private readonly AccountContext _context;

        public AccountJobRepository(AccountContext context) : base(context)
        {
            _context = context;
        }
        public EditAccountJob GetDetails(long id)
        {
            throw new NotImplementedException();
        }




        public List<AccountJobViewModel> Search(AccountJobSearchModel searchModel)
        {
            var query = _context.tblaccountjob.Select(x => new AccountJobViewModel
            {
                JobId = x.JobId,
                AccountId = x.AccountId,
                AccountName = x.Account.Fullname,
                JobName = x.Job.JobsChartName,
                //CreationDate = x.CreationDate.ToFarsi(),


            });
            if (!string.IsNullOrWhiteSpace(searchModel.AccountName))
            {
                query = query.Where(x => x.AccountName.Contains(searchModel.AccountName));
            }

            return query.OrderByDescending(x => x.AccountId).ToList();
        }


    }
}
