using IQ.OPS.Core.Abstractions.DependencyInjection;
using Ticimax.Integration.Gsm.Abstractions.Sms.Senders;
using Ticimax.Integration.Gsm.Data.Sms.Enums;

namespace Ticimax.Integration.Gsm.Abstractions.Sms.Contexts;

public interface ISmsSenderContext : IReadOnlyDictionary<EnumSmsServiceProvider, Type>, ISingleton
{
    ISmsSenderContext Add<TSmsSender>(EnumSmsServiceProvider serviceProvider) where TSmsSender : ISmsSender;
}