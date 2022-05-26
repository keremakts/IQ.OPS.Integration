using IQ.OPS.Core.Data.DependencyInjection.Annotations;
using IQ.OPS.Core.Modules;
using IQ.OPS.Integration.Gsm.Abstractions.Sms.Contexts;
using IQ.OPS.Integration.Gsm.Data.Sms.Enums;
using IQ.OPS.Integration.Gsm.GuvenTelekom.Abstractions.Sms.Senders;

namespace IQ.OPS.Integration.Gsm.GuvenTelekom.Sms;

[DependsOn(typeof(IntegrationGsmModule))]
public class GuvenTelekomSmsModule : Module
{
    public void Configure(ISmsSenderContext smsSenderContext) => smsSenderContext?.Add<IGuvenTelekomSmsSender>(EnumSmsServiceProvider.GuvenTelekom);
}