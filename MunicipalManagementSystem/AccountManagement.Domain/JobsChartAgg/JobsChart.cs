using _0_Framework.Domain;
using AccountManagement.Domain.AccountJobAgg;
using System.Collections.Generic;

namespace AccountManagement.Domain.JobsChartAgg;

public class JobsChart : EntityBase
{
    public string JobsChartName { get; private set; }
    public string JobsChartDescription { get; private set; }
    public int JobsChartLevel { get; private set; }
    public bool IsRemoved { get; private set; }
    public List<AccountJob> AccountJob { get; private set; }
    public JobsChart(
        string jobsChartName,
        string jobsChartDescription,
        int jobsChartLevel)
    {

        JobsChartName = jobsChartName;
        JobsChartDescription = jobsChartDescription;
        JobsChartLevel = jobsChartLevel;
    }

    public void Edit(
     string jobsChartName,
     string jobsChartDescription,
     int jobsChartLevel)
    {

        JobsChartName = jobsChartName;
        JobsChartDescription = jobsChartDescription;
        JobsChartLevel = jobsChartLevel;
    }

    public void Remove()
    {
        IsRemoved = true;
    }

    public void Restore()
    {
        IsRemoved = false;
    }

}
