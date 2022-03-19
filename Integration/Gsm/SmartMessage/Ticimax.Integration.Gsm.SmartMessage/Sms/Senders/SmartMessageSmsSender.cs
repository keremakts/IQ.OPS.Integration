using Ticimax.Integration.Gsm.SmartMessage.Abstractions.Sms.Senders;
using Ticimax.Integration.Gsm.Sms.Senders;

namespace Ticimax.Integration.Gsm.SmartMessage.Sms.Senders;

public class SmartMessageSmsSender : SmsSender, ISmartMessageSmsSender
{
    public override string Send(string number, string message) => nameof(SmartMessage);
}