using Ticimax.Integration.Gsm.Abstractions.Sms.Contexts;
using Ticimax.Integration.Gsm.Abstractions.Sms.Factories;
using Ticimax.Integration.Gsm.Abstractions.Sms.Senders;
using Ticimax.Integration.Gsm.Data.Sms.Enums;

namespace Ticimax.Integration.Gsm.Sms.Factories;

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