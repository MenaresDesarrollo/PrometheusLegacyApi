using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.SanRosa;

public partial class ImedSoapMessage
{
    public string MsgId { get; set; } = null!;

    public string? MsgReference { get; set; }

    public string? MsgType { get; set; }

    public string? MsgXml { get; set; }

    public DateTime? MsgDate { get; set; }

    public string? WsMethod { get; set; }

    public int? MsgStatus { get; set; }

    public string? UserRef { get; set; }

    public string? RecepcionId { get; set; }
}
