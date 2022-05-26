using IQ.OPS.Core.Data.DependencyInjection.Annotations;
using IQ.OPS.Core.Modules;
using IQ.OPS.Integration.Gsm.Abstractions.Sms.Contexts;
using IQ.OPS.Integration.Gsm.Data.Sms.Enums;
using IQ.OPS.Integration.Gsm.RelatedDigital.Abstractions.Sms.Senders;

namespace IQ.OPS.Integration.Gsm.RelatedDigital.Sms;

[DependsOn(typeof(IntegrationGsmModule))]
public class RelatedDigitalSmsModule : Module
{
    public void Configure(ISmsSenderContext smsSenderContext) => smsSenderContext.Add<IRelatedDigitalSmsSender>(EnumSmsServiceProvider.RelatedDigital);
}