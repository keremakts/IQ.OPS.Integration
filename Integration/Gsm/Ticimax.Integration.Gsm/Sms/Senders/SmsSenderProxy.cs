using IQ.OPS.Core.Data.DependencyInjection.Annotations;
using Microsoft.Extensions.Options;
using Ticimax.Integration.Gsm.Abstractions.Sms.Factories;
using Ticimax.Integration.Gsm.Abstractions.Sms.Senders;
using Ticimax.Integration.Gsm.Sms.Options;

namespace Ticimax.Integration.Gsm.Sms.Senders;

[ResolverTypes(typeof(ISmsSender))]
internal class SmsSenderProxy : SmsSender, ISmsSender
{
    private readonly SmsSenderOptions _smsSenderOptions;
    private readonly ISmsSenderFactory _smsSenderFactory;

    public SmsSenderProxy(IOptions<SmsSenderOptions> smsSenderOptions, ISmsSenderFactory smsSenderFactory)
    {
        _smsSenderOptions = smsSenderOptions.Value;
        _smsSenderFactory = smsSenderFactory;
    }

    public override string Send(string number, string message)
    {
        ArgumentNullException.ThrowIfNull(_smsSenderOptions?.SmsServiceProvider, nameof(_smsSenderOptions.SmsServiceProvider));

        return _smsSenderFactory.GetSender(_smsSenderOptions.SmsServiceProvider.Value).Send(number, message);
    }
}