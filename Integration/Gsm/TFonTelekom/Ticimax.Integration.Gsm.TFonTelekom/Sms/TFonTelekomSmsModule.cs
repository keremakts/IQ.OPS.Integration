using IQ.OPS.Core.Data.DependencyInjection.Annotations;
using IQ.OPS.Core.Modules;
using Ticimax.Integration.Gsm.Abstractions.Sms.Contexts;
using Ticimax.Integration.Gsm.Data.Sms.Enums;
using Ticimax.Integration.Gsm.TFonTelekom.Abstractions.Sms.Senders;

namespace Ticimax.Integration.Gsm.TFonTelekom.Sms;

[DependsOn(typeof(IntegrationGsmModule))]
public class TFonTelekomSmsModule : Module
{
    public void Configure(ISmsSenderContext smsSenderContext) => smsSenderContext?.Add<ITFonTelekomSmsSender>(EnumSmsServiceProvider.TFonTelekom);
}