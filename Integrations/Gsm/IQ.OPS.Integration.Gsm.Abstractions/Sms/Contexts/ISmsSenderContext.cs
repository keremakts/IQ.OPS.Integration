using IQ.OPS.Core.Abstractions.DependencyInjection;
using IQ.OPS.Integration.Gsm.Abstractions.Sms.Senders;
using IQ.OPS.Integration.Gsm.Data.Sms.Enums;

namespace IQ.OPS.Integration.Gsm.Abstractions.Sms.Contexts;

public interface ISmsSenderContext : IReadOnlyDictionary<EnumSmsServiceProvider, Type>, ISingleton
{
    ISmsSenderContext Add<TSmsSender>(EnumSmsServiceProvider serviceProvider) where TSmsSender : ISmsSender;
}