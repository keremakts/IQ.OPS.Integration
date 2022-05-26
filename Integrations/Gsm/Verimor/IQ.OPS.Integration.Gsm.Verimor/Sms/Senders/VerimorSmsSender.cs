using IQ.OPS.Integration.Gsm.Sms.Senders;
using IQ.OPS.Integration.Gsm.Verimor.Abstractions.Sms.Senders;

namespace IQ.OPS.Integration.Gsm.Verimor.Sms.Senders;

public class VerimorSmsSender : SmsSender, IVerimorSmsSender
{
    public override string Send(string number, string message) => nameof(Verimor);
}