using Ticimax.Integration.Gsm.NetGsm.Abstractions.Sms.Senders;
using Ticimax.Integration.Gsm.Sms.Senders;

namespace Ticimax.Integration.Gsm.NetGsm.Sms.Senders;

public class NetGsmSmsSender : SmsSender, INetGsmSmsSender
{
    public override string Send(string number, string message) => nameof(NetGsm);
}