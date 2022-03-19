using Ticimax.Integration.Gsm.Sms.Senders;
using Ticimax.Integration.Gsm.Telsam.Abstractions.Sms.Senders;

namespace Ticimax.Integration.Gsm.Telsam.Sms.Senders;

public class TelsamSmsSender : SmsSender, ITelsamSmsSender
{
    public override string Send(string number, string message) => nameof(Telsam);
}