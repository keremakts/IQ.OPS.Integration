using IQ.OPS.Core.Data.DependencyInjection.Annotations;
using IQ.OPS.Core.Modules;
using Ticimax.Integration.Gsm.Abstractions.Sms.Contexts;
using Ticimax.Integration.Gsm.Data.Sms.Enums;
using Ticimax.Integration.Gsm.RelatedDigital.Abstractions.Sms.Senders;

namespace Ticimax.Integration.Gsm.RelatedDigital.Sms;

[DependsOn(typeof(IntegrationGsmModule))]
public class RelatedDigitalSmsModule : Module
{
    public void Configure(ISmsSenderContext smsSenderContext) => smsSenderContext.Add<IRelatedDigitalSmsSender>(EnumSmsServiceProvider.RelatedDigital);
}