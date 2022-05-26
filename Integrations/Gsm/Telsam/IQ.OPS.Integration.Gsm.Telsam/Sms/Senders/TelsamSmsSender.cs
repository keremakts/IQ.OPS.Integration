using IQ.OPS.Integration.Gsm.Sms.Senders;
using IQ.OPS.Integration.Gsm.Telsam.Abstractions.Sms.Senders;

namespace IQ.OPS.Integration.Gsm.Telsam.Sms.Senders;

public class TelsamSmsSender : SmsSender, ITelsamSmsSender
{
    public override string Send(string number, string message) => nameof(Telsam);
}