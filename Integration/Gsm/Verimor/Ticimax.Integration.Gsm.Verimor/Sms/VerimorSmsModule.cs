using IQ.OPS.Core.Data.DependencyInjection.Annotations;
using IQ.OPS.Core.Modules;
using Ticimax.Integration.Gsm.Abstractions.Sms.Contexts;
using Ticimax.Integration.Gsm.Data.Sms.Enums;
using Ticimax.Integration.Gsm.Verimor.Abstractions.Sms.Senders;

namespace Ticimax.Integration.Gsm.Verimor.Sms;

[DependsOn(typeof(IntegrationGsmModule))]
public class VerimorSmsModule : Module
{
    public void Configure(ISmsSenderContext smsSenderContext) => smsSenderContext?.Add<IVerimorSmsSender>(EnumSmsServiceProvider.Verimor);
}