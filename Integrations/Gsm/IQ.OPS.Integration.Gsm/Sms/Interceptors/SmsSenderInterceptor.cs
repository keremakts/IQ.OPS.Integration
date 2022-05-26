using IQ.OPS.Core.Abstractions.DynamicProxy;
using IQ.OPS.DynamicProxy.Castle.Interception;
using IQ.OPS.Integration.Gsm.Abstractions.Sms.Contexts;
using IQ.OPS.Integration.Gsm.Abstractions.Sms.Senders;
using IQ.OPS.Integration.Gsm.Sms.Options;
using Microsoft.Extensions.Options;

namespace IQ.OPS.Integration.Gsm.Sms.Interceptors;

public class SmsSenderInterceptor : Interceptor, IInterceptor<ISmsSender>
{
    private readonly IServiceProvider _serviceProvider;
    private readonly ISmsSenderContext _smsSenderContext;
    private readonly SmsSenderOptions _smsSenderOptions;

    public SmsSenderInterceptor(IServiceProvider serviceProvider, ISmsSenderContext smsSenderContext, IOptions<SmsSenderOptions> smsSenderOptions)
    {
        _serviceProvider = serviceProvider;
        _smsSenderContext = smsSenderContext;
        _smsSenderOptions = smsSenderOptions.Value;
    }

    public override Task Intercept(IInvocation invocation)
    {
        if (_smsSenderOptions.SmsServiceProvider is null) return Task.CompletedTask;

        _smsSenderContext.TryGetValue(_smsSenderOptions.SmsServiceProvider.Value, out var type);

        var smsSender = _serviceProvider.GetService(type!) as ISmsSender;

        invocation.Method.Invoke(smsSender, invocation.Arguments);

        return Task.CompletedTask;
    }
}