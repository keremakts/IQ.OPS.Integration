using IQ.OPS.Integration.Gsm.SmartMessage.Abstractions.Sms.Senders;
using IQ.OPS.Integration.Gsm.Sms.Senders;

namespace IQ.OPS.Integration.Gsm.SmartMessage.Sms.Senders;

public class SmartMessageSmsSender : SmsSender, ISmartMessageSmsSender
{
    public override string Send(string number, string message) => nameof(SmartMessage);
}