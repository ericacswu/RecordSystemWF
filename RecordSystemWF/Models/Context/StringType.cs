using System;
using System.Collections.Generic;

namespace RecordSystemWF.Models.Context;

/// <summary>
/// 線種
/// </summary>
public partial class StringType
{
    public int TypeId { get; set; }

    /// <summary>
    /// 線種
    /// </summary>
    public string? StringName { get; set; }

    /// <summary>
    /// 成本
    /// </summary>
    public int? Cost { get; set; }

    /// <summary>
    /// 備註
    /// </summary>
    public string? Remark { get; set; }

    /// <summary>
    /// 是否可用 (1:可用 0:不可用)
    /// </summary>
    public bool Enabled { get; set; }

    /// <summary>
    /// 建立時間
    /// </summary>
    public DateTime CreateDate { get; set; }

    /// <summary>
    /// 建立人員
    /// </summary>
    public DateTime CreateUser { get; set; }

    /// <summary>
    /// 更新時間
    /// </summary>
    public DateTime UpdateDate { get; set; }

    /// <summary>
    /// 操作人員(登入 ID)
    /// </summary>
    public string UpdateUser { get; set; } = null!;
}
