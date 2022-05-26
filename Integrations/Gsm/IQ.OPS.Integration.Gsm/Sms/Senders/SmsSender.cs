using IQ.OPS.Integration.Gsm.Abstractions.Sms.Senders;

namespace IQ.OPS.Integration.Gsm.Sms.Senders;

public abstract class SmsSender : ISmsSender
{
    public abstract string Send(string number, string message);
}