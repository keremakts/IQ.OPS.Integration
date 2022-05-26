using IQ.OPS.Core.Abstractions.DependencyInjection;

namespace IQ.OPS.Integration.Gsm.Abstractions.Sms.Senders;

public interface ISmsSender : ISingleton
{
    string Send(string number, string message);
}
