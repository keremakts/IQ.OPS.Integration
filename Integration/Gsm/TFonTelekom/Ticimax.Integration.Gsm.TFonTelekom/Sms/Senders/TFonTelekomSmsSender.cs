using Ticimax.Integration.Gsm.Sms.Senders;
using Ticimax.Integration.Gsm.TFonTelekom.Abstractions.Sms.Senders;

namespace Ticimax.Integration.Gsm.TFonTelekom.Sms.Senders;

public class TFonTelekomSmsSender : SmsSender, ITFonTelekomSmsSender
{
    public override string Send(string number, string message) => nameof(TFonTelekom);
}