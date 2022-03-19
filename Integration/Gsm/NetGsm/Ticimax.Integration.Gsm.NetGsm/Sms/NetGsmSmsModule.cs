using IQ.OPS.Core.Data.DependencyInjection.Annotations;
using IQ.OPS.Core.Modules;
using Ticimax.Integration.Gsm.Abstractions.Sms.Contexts;
using Ticimax.Integration.Gsm.Data.Sms.Enums;
using Ticimax.Integration.Gsm.NetGsm.Abstractions.Sms.Senders;

namespace Ticimax.Integration.Gsm.NetGsm.Sms;

[DependsOn(typeof(IntegrationGsmModule))]
public class NetGsmSmsModule : Module
{
    public void Configure(ISmsSenderContext smsSenderContext) => smsSenderContext?.Add<INetGsmSmsSender>(EnumSmsServiceProvider.NetGsm);
}