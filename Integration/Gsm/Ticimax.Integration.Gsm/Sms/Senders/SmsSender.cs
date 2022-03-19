using Ticimax.Integration.Gsm.Abstractions.Sms.Senders;

namespace Ticimax.Integration.Gsm.Sms.Senders;

public abstract class SmsSender : ISmsSender
{
    public abstract string Send(string number, string message);
}