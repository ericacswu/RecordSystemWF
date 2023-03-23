using System;
using System.Collections.Generic;

namespace RecordSystemWF.Models.Context;

public partial class SysPaymentMethod
{
    public int Id { get; set; }

    public string PaymentMethod { get; set; } = null!;

    /// <summary>
    /// 是否可用 (Y:可用 N:不可用)
    /// </summary>
    public string Enabled { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public int CreateUser { get; set; }

    /// <summary>
    /// 系統日期時間
    /// </summary>
    public DateTime UpdateDate { get; set; }

    /// <summary>
    /// 操作人員(登入 ID)
    /// </summary>
    public int UpdateUser { get; set; }
}
