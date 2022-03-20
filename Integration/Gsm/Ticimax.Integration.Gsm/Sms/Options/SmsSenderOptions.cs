using IQ.OPS.Core.Abstractions.Options;
using Ticimax.Integration.Gsm.Data.Sms.Enums;

namespace Ticimax.Integration.Gsm.Sms.Options;

public class SmsSenderOptions : IOptions
{
    public EnumSmsServiceProvider? SmsServiceProvider { get; set; }

    public string? SendSmsEndpoint { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? Originator { get; set; }
}