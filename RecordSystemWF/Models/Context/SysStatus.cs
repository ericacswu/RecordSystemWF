using System;
using System.Collections.Generic;

namespace RecordSystemWF.Models.Context;

/// <summary>
/// 狀態設定
/// </summary>
public partial class SysStatus
{
    /// <summary>
    /// 狀態ID (系統產出唯一值)
    /// </summary>
    public int StatusId { get; set; }

    /// <summary>
    /// 狀態
    /// </summary>
    public string StatusGroup { get; set; } = null!;

    /// <summary>
    /// 狀態
    /// </summary>
    public string StatusName { get; set; } = null!;

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
    public int CreateUser { get; set; }

    /// <summary>
    /// 更新時間
    /// </summary>
    public DateTime UpdateDate { get; set; }

    /// <summary>
    /// 操作人員(登入 ID)
    /// </summary>
    public int UpdateUser { get; set; }
}
