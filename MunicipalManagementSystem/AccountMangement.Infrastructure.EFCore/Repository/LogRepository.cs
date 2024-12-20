using _0_Framework.Application;
using _0_Framework.Infrastructure;
using AccountManagement.Application.Contracts.Log;
using AccountManagement.Domain.LogAgg;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AccountMangement.Infrastructure.EFCore.Repository;

public class LogRepository : RepositoryBase<long, Log>, ILogRepository
{
    private readonly AccountContext _context;
    public LogRepository(AccountContext context) : base(context)
    {
        _context = context;
    }

    public Log GetBy(string username)
    {
        throw new NotImplementedException();
    }

    public List<LogViewModel> Getlogs()
    {
        return _context.logs.Select(static x => new LogViewModel
        {
            Id = x.Id,
            Permission = "صدور فیش",
            Fullname = x.Account.Fullname,
            Username = x.Account.Username,
            CreationDate = x.CreationDate.ToFarsi()
        }).ToList();
    }



    public List<LogViewModel> Search(LogSearchModel searchModel)
    {


        var query = _context.logs.Include(x => x.Account
        ).Select(x => new LogViewModel
        {
            Id = x.AccountId,
            Permission = x.TitelPermission.Name,
            Fullname = x.Account.Fullname,
            Username = x.Account.Username,
            CreationDate = x.CreationDate.ToFarsi()

        });
        if (!string.IsNullOrWhiteSpace(searchModel.AccountName))
        {
            query = query.Where(x => x.Fullname.Contains(searchModel.AccountName));
        }

        return query.OrderByDescending(x => x.Id).ToList();




    }


}