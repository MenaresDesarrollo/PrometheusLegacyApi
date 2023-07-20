using System;
using System.Collections.Generic;

namespace PrometheusLegacyApi.Entities.Astorga;

public partial class LaboratorioRestMessage
{
    public string MsgId { get; set; } = null!;

    public string? MsgReference { get; set; }

    public string? MsgType { get; set; }

    public string? MsgJson { get; set; }

    public DateTime? MsgDate { get; set; }

    public string? WsMethod { get; set; }

    public int? MsgStatus { get; set; }

    public string? UserRef { get; set; }

    public string? RecepcionId { get; set; }
}
