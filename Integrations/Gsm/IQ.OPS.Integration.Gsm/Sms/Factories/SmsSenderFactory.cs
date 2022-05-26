using IQ.OPS.Integration.Gsm.Abstractions.Sms.Contexts;
using IQ.OPS.Integration.Gsm.Abstractions.Sms.Factories;
using IQ.OPS.Integration.Gsm.Abstractions.Sms.Senders;
using IQ.OPS.Integration.Gsm.Data.Sms.Enums;

namespace IQ.OPS.Integration.Gsm.Sms.Factories;

internal class SmsSenderFactory : ISmsSenderFactory
{
    private readonly ISmsSenderContext _smsSenderContext;
    private readonly IServiceProvider _serviceProvider;

    public SmsSenderFactory(ISmsSenderContext smsSenderContext, IServiceProvider serviceProvider)
    {
        _smsSenderContext = smsSenderContext;
        _serviceProvider = serviceProvider;
    }

    public ISmsSender GetSender(EnumSmsServiceProvider provider) => _smsSenderContext
        .Where(s => provider == s.Key)
        .Select(s => _serviceProvider.GetService(s.Value))
        .OfType<ISmsSender>()
        .FirstOrDefault() ?? throw new ApplicationException($"{provider} SMS sender service not registered.");
}