using IQ.OPS.Integration.Gsm.RelatedDigital.Abstractions.Sms.Senders;
using IQ.OPS.Integration.Gsm.Sms.Senders;

namespace IQ.OPS.Integration.Gsm.RelatedDigital.Sms.Senders;

public class RelatedDigitalSmsSender : SmsSender, IRelatedDigitalSmsSender
{
    public override string Send(string number, string message) => nameof(RelatedDigital);
}