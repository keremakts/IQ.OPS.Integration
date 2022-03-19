using IQ.OPS.Core.Abstractions.Modules;
using IQ.OPS.Core.App;
using IQ.OPS.Core.Data.DependencyInjection.Annotations;
using IQ.OPS.Core.Modules;
using Microsoft.Extensions.DependencyInjection;
using Ticimax.Integration.Gsm.Abstractions.Sms.Senders;
using Ticimax.Integration.Gsm.Data.Sms.Enums;
using Ticimax.Integration.Gsm.GuvenTelekom.Sms;
using Ticimax.Integration.Gsm.NetGsm.Sms;
using Ticimax.Integration.Gsm.RelatedDigital.Sms;
using Ticimax.Integration.Gsm.SmartMessage.Sms;
using Ticimax.Integration.Gsm.Sms.Options;
using Ticimax.Integration.Gsm.Telsam.Sms;
using Ticimax.Integration.Gsm.Verimor.Sms;

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
    typeof(VerimorSmsModule))]
public class MainModule : Module
{
    public override async Task PreConfigureServicesAsync(IConfigureServicesOptions options)
    {
        options.Services.Configure<SmsSenderOptions>(opt =>
        {
            opt.SmsServiceProvider = EnumSmsServiceProvider.RelatedDigital;
            opt.Originator = nameof(Ticimax);
            opt.SendSmsEndpoint = "http://api2.ekomesaj.com/json/syncreply/SendInstantSms";
            opt.Username = nameof(opt.Username);
            opt.Password = nameof(opt.Password);
        });

        await base.PreConfigureServicesAsync(options);
    }
}