using IQ.OPS.Core.Data.DependencyInjection.Annotations;
using IQ.OPS.Core.Modules;
using Ticimax.Integration.Gsm.Abstractions.Sms.Contexts;
using Ticimax.Integration.Gsm.Data.Sms.Enums;
using Ticimax.Integration.Gsm.GuvenTelekom.Abstractions.Sms.Senders;

namespace Ticimax.Integration.Gsm.GuvenTelekom.Sms;

[DependsOn(typeof(IntegrationGsmModule))]
public class GuvenTelekomSmsModule : Module
{
    public void Configure(ISmsSenderContext smsSenderContext) => smsSenderContext?.Add<IGuvenTelekomSmsSender>(EnumSmsServiceProvider.GuvenTelekom);
}