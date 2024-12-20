using _0_Framework.Domain;
namespace MunicipalityManagement.Domain.OrderAgg;

public class Order : EntityBase
{
    public long AccountId { get; private set; }
    public int RequestType { get; private set; }
    public string Cnmantagheh { get; private set; }
    public string Cnhozeh { get; private set; }
    public string Cnblock { get; private set; }
    public string Cnmelk { get; private set; }
    public bool IsCanceled { get; private set; }
    public string IssueTrackingNo { get; private set; }//شماره پیگیری

    public Order(
        long accountId,
        int requestType,
        string cnmantagheh,
        string cnhozeh,
        string cnblock,
        string cnmelk,
        string issueTrackingNo)
    {
        AccountId = accountId;
        RequestType = requestType;
        this.Cnmantagheh = cnmantagheh;
        this.Cnhozeh = cnhozeh;
        this.Cnblock = cnblock;
        this.Cnmelk = cnmelk;
        IsCanceled = false;
        IssueTrackingNo = issueTrackingNo;
    }


    public void Edit(long accountId,
        int requestType,
        string cnmantagheh,
        string cnhozeh,
        string cnblock,
        string cnmelk,
        string issueTrackingNo)
    {
        AccountId = accountId;
        RequestType = requestType;
        this.Cnmantagheh = cnmantagheh;
        this.Cnhozeh = cnhozeh;
        this.Cnblock = cnblock;
        this.Cnmelk = cnmelk;
        IsCanceled = false;
        IssueTrackingNo = issueTrackingNo;
    }
    public void SetIssueTrackingNo(string number)
    {
        IssueTrackingNo = number;
    }

    public void Cancel()
    {
        IsCanceled = true;
    }
}
