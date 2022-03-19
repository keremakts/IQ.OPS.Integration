using Ticimax.Integration.Gsm.GuvenTelekom.Abstractions.Sms.Senders;
using Ticimax.Integration.Gsm.Sms.Senders;

namespace Ticimax.Integration.Gsm.GuvenTelekom.Sms.Senders;

public class GuvenTelekomSmsSender : SmsSender, IGuvenTelekomSmsSender
{
    public override string Send(string number, string message) => nameof(GuvenTelekom);
}