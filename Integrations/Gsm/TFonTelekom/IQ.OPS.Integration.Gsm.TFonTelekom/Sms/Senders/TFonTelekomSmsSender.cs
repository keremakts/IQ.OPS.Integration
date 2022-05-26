using IQ.OPS.Integration.Gsm.Sms.Senders;
using IQ.OPS.Integration.Gsm.TFonTelekom.Abstractions.Sms.Senders;

namespace IQ.OPS.Integration.Gsm.TFonTelekom.Sms.Senders;

public class TFonTelekomSmsSender : SmsSender, ITFonTelekomSmsSender
{
    public override string Send(string number, string message) => nameof(TFonTelekom);
}