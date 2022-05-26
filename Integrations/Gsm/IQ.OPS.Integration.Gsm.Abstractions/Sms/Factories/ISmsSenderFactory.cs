using IQ.OPS.Core.Abstractions.DependencyInjection;
using IQ.OPS.Integration.Gsm.Abstractions.Sms.Senders;
using IQ.OPS.Integration.Gsm.Data.Sms.Enums;

namespace IQ.OPS.Integration.Gsm.Abstractions.Sms.Factories;

public interface ISmsSenderFactory : ISingleton
{
    ISmsSender GetSender(EnumSmsServiceProvider provider);
}