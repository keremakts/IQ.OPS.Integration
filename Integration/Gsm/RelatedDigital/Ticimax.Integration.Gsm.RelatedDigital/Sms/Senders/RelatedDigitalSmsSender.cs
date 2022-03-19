using Ticimax.Integration.Gsm.RelatedDigital.Abstractions.Sms.Senders;
using Ticimax.Integration.Gsm.Sms.Senders;

namespace Ticimax.Integration.Gsm.RelatedDigital.Sms.Senders;

public class RelatedDigitalSmsSender : SmsSender, IRelatedDigitalSmsSender
{
    public override string Send(string number, string message) => nameof(RelatedDigital);
}
