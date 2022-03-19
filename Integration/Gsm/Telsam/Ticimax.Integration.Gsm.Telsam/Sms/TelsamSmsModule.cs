using IQ.OPS.Core.Data.DependencyInjection.Annotations;
using IQ.OPS.Core.Modules;
using Ticimax.Integration.Gsm.Abstractions.Sms.Contexts;
using Ticimax.Integration.Gsm.Data.Sms.Enums;
using Ticimax.Integration.Gsm.Telsam.Abstractions.Sms.Senders;

namespace Ticimax.Integration.Gsm.Telsam.Sms;

[DependsOn(typeof(IntegrationGsmModule))]
public class TelsamSmsModule : Module
{
    public void Configure(ISmsSenderContext smsSenderContext) => smsSenderContext?.Add<ITelsamSmsSender>(EnumSmsServiceProvider.Telsam);
}