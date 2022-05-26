using IQ.OPS.Integration.Gsm.NetGsm.Abstractions.Sms.Senders;
using IQ.OPS.Integration.Gsm.Sms.Senders;

namespace IQ.OPS.Integration.Gsm.NetGsm.Sms.Senders;

public class NetGsmSmsSender : SmsSender, INetGsmSmsSender
{
    public override string Send(string number, string message) => nameof(NetGsm);
}