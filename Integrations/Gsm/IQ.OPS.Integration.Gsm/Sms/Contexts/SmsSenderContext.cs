using IQ.OPS.Integration.Gsm.Abstractions.Sms.Contexts;
using IQ.OPS.Integration.Gsm.Abstractions.Sms.Senders;
using IQ.OPS.Integration.Gsm.Data.Sms.Enums;

namespace IQ.OPS.Integration.Gsm.Sms.Contexts;

internal class SmsSenderContext : Dictionary<EnumSmsServiceProvider, Type>, ISmsSenderContext
{
    public ISmsSenderContext Add<TSmsSender>(EnumSmsServiceProvider serviceProvider) where TSmsSender : ISmsSender
    {
        TryAdd(serviceProvider, typeof(TSmsSender));
        return this;
    }
}