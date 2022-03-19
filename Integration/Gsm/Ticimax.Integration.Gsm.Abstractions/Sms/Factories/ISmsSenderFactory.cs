using IQ.OPS.Core.Abstractions.DependencyInjection;
using Ticimax.Integration.Gsm.Abstractions.Sms.Senders;
using Ticimax.Integration.Gsm.Data.Sms.Enums;

namespace Ticimax.Integration.Gsm.Abstractions.Sms.Factories;

public interface ISmsSenderFactory : ISingleton
{
    ISmsSender GetSender(EnumSmsServiceProvider provider);
}