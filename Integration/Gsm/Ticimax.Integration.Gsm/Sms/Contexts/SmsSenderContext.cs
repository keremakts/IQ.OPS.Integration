using Ticimax.Integration.Gsm.Abstractions.Sms.Contexts;
using Ticimax.Integration.Gsm.Abstractions.Sms.Senders;
using Ticimax.Integration.Gsm.Data.Sms.Enums;

namespace Ticimax.Integration.Gsm.Sms.Contexts;

internal class SmsSenderContext : Dictionary<EnumSmsServiceProvider, Type>, ISmsSenderContext
{
    public ISmsSenderContext Add<TSmsSender>(EnumSmsServiceProvider serviceProvider) where TSmsSender : ISmsSender
    {
        TryAdd(serviceProvider, typeof(TSmsSender));
        return this;
    }
}