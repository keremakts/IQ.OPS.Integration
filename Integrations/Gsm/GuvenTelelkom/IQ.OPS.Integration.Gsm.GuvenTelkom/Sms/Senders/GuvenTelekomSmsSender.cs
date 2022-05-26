using IQ.OPS.Integration.Gsm.GuvenTelekom.Abstractions.Sms.Senders;
using IQ.OPS.Integration.Gsm.Sms.Senders;

namespace IQ.OPS.Integration.Gsm.GuvenTelekom.Sms.Senders;

public class GuvenTelekomSmsSender : SmsSender, IGuvenTelekomSmsSender
{
    public override string Send(string number, string message) => nameof(GuvenTelekom);
}