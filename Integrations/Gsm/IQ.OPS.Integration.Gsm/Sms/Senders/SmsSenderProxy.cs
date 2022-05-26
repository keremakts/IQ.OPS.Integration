namespace IQ.OPS.Integration.Gsm.Sms.Senders;

//[ServiceTypes(typeof(ISmsSender))]
//internal class SmsSenderProxy : SmsSender, ISmsSender
//{
//    private readonly SmsSenderOptions _smsSenderOptions;
//    private readonly ISmsSenderFactory _smsSenderFactory;

//    public SmsSenderProxy(IOptions<SmsSenderOptions> smsSenderOptions, ISmsSenderFactory smsSenderFactory)
//    {
//        _smsSenderOptions = smsSenderOptions.Value;
//        _smsSenderFactory = smsSenderFactory;
//    }

//    public override string Send(string number, string message)
//    {
//        ArgumentNullException.ThrowIfNull(_smsSenderOptions?.SmsServiceProvider, nameof(_smsSenderOptions.SmsServiceProvider));

//        return _smsSenderFactory.GetSender(_smsSenderOptions.SmsServiceProvider.Value).Send(number, message);
//    }
//}