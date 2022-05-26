using IQ.OPS.Core.Abstractions.Modules;
using IQ.OPS.Core.App;
using IQ.OPS.Core.Data.DependencyInjection.Annotations;
using IQ.OPS.Core.Modules;
using IQ.OPS.DynamicProxy.Castle.Modules;
using IQ.OPS.Integration.Gsm.Abstractions.Sms.Senders;
using IQ.OPS.Integration.Gsm.Data.Sms.Enums;
using IQ.OPS.Integration.Gsm.GuvenTelekom.Sms;
using IQ.OPS.Integration.Gsm.NetGsm.Sms;
using IQ.OPS.Integration.Gsm.RelatedDigital.Sms;
using IQ.OPS.Integration.Gsm.SmartMessage.Sms;
using IQ.OPS.Integration.Gsm.Sms.Options;
using IQ.OPS.Integration.Gsm.Telsam.Sms;
using IQ.OPS.Integration.Gsm.TFonTelekom.Sms;
using IQ.OPS.Integration.Gsm.Verimor.Sms;
using Microsoft.Extensions.DependencyInjection;

var application = Application.Create<MainModule>();

await application.RunAsync();

var sender = application.ServiceProvider.GetService<ISmsSender>();

Console.WriteLine(sender?.Send("num", "msg"));

Console.ReadKey();



[DependsOn(
    typeof(GuvenTelekomSmsModule),
    typeof(NetGsmSmsModule),
    typeof(RelatedDigitalSmsModule),
    typeof(SmartMessageSmsModule),
    typeof(TelsamSmsModule),
    typeof(TFonTelekomSmsModule),
    typeof(VerimorSmsModule),
    typeof(DynamicProxyCastleModule))]
public class MainModule : Module
{
    public override async Task PreConfigureServicesAsync(IConfigureServicesOptions options)
    {
        options.Services.Configure<SmsSenderOptions>(opt =>
        {
            opt.SmsServiceProvider = EnumSmsServiceProvider.TFonTelekom;
            opt.Originator = nameof(IQ.OPS);
            opt.SendSmsEndpoint = "http://api2.ekomesaj.com/json/syncreply/SendInstantSms";
            opt.Username = nameof(opt.Username);
            opt.Password = nameof(opt.Password);
        });

        await base.PreConfigureServicesAsync(options);
    }
}