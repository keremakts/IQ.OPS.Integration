using Ticimax.Integration.Gsm.Sms.Senders;
using Ticimax.Integration.Gsm.Verimor.Abstractions.Sms.Senders;

namespace Ticimax.Integration.Gsm.Verimor.Sms.Senders;

public class VerimorSmsSender : SmsSender, IVerimorSmsSender
{
    public override string Send(string number, string message) => nameof(Verimor);
}