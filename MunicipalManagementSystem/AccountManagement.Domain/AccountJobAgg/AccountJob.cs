using _0_Framework.Domain;
using AccountManagement.Domain.AccountAgg;
using AccountManagement.Domain.JobsChartAgg;
using System;
namespace AccountManagement.Domain.AccountJobAgg;

public class AccountJob : EntityBase
{
    public long AccountId { get; private set; }
    public Account Account { get; private set; }
    public long JobId { get; private set; }
    public JobsChart Job { get; private set; }
    public DateTime StartJobName { get; private set; }
    public DateTime EndJobName { get; private set; }
    public bool IsHaveJob { get; private set; }

    public AccountJob(
        long accountId,
        long jobId,
        DateTime startJobName,
        DateTime endJobName,
        bool isHaveJob)
    {
        AccountId = accountId;
        JobId = jobId;
        StartJobName = startJobName;
        EndJobName = endJobName;
        IsHaveJob = isHaveJob;
    }
    public void Edit(
      long accountId,
      long jobId,
      DateTime startJobName,
      DateTime endJobName,
      bool isHaveJob)
    {
        AccountId = accountId;
        JobId = jobId;
        StartJobName = startJobName;
        EndJobName = endJobName;
        IsHaveJob = isHaveJob;
    }
}
