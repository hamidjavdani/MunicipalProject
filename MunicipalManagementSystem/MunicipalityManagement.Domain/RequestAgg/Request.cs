using _0_Framework.Domain;
using MunicipalityManagement.Domain.Title_RequestAgg;

namespace MunicipalityManagement.Domain.RequestAgg;

public class Request : EntityBase
{
    public long AccountId { get; private set; }
    public TitleRequest TitleRequests { get; private set; }
    public long RequestType { get; private set; }
    public string Codemelk { get; private set; }
    public string IssueTrackingNo { get; private set; }//شماره پیگیری

    public string Cnmantagheh { get; private set; }
    public string Cnhozeh { get; private set; }
    public string Cnblock { get; private set; }
    public string Cnmelk { get; private set; }


    public Request(long accountId, long requestType, string codemelk,
        string issueTrackingNo,
        string cnmantagheh, string cnhozeh, string cnblock, string cnmelk)
    {
        AccountId = accountId;
        RequestType = requestType;
        Codemelk = codemelk;
        IssueTrackingNo = issueTrackingNo;
        Cnmantagheh = cnmantagheh;
        Cnhozeh = cnhozeh;
        Cnblock = cnblock;
        Cnmelk = cnmelk;
    }

    public void Edit(long accountId, long requestType, string codemelk,
        string issueTrackingNo,
        string cnmantagheh, string cnhozeh, string cnblock, string cnmelk)
    {
        AccountId = accountId;
        RequestType = requestType;
        Codemelk = codemelk;
        IssueTrackingNo = issueTrackingNo;
        Cnmantagheh = cnmantagheh;
        Cnhozeh = cnhozeh;
        Cnblock = cnblock;
        Cnmelk = cnmelk;
    }

}
