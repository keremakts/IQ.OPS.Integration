using IQ.OPS.Core.Data.DependencyInjection.Annotations;
using IQ.OPS.Core.Modules;
using IQ.OPS.Integration.Gsm.Abstractions.Sms.Contexts;
using IQ.OPS.Integration.Gsm.Data.Sms.Enums;
using IQ.OPS.Integration.Gsm.Verimor.Abstractions.Sms.Senders;

namespace IQ.OPS.Integration.Gsm.Verimor.Sms;

[DependsOn(typeof(IntegrationGsmModule))]
public class VerimorSmsModule : Module
{
    public void Configure(ISmsSenderContext smsSenderContext) => smsSenderContext?.Add<IVerimorSmsSender>(EnumSmsServiceProvider.Verimor);
}