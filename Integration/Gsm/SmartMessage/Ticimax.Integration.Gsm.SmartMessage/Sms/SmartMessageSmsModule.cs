using IQ.OPS.Core.Data.DependencyInjection.Annotations;
using IQ.OPS.Core.Modules;
using Ticimax.Integration.Gsm.Abstractions.Sms.Contexts;
using Ticimax.Integration.Gsm.Data.Sms.Enums;
using Ticimax.Integration.Gsm.SmartMessage.Abstractions.Sms.Senders;

namespace Ticimax.Integration.Gsm.SmartMessage.Sms;

[DependsOn(typeof(IntegrationGsmModule))]
public class SmartMessageSmsModule : Module
{
    public void Configure(ISmsSenderContext smsSenderContext) => smsSenderContext?.Add<ISmartMessageSmsSender>(EnumSmsServiceProvider.SmartMessage);
}