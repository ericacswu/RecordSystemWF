using System;
using System.Collections.Generic;

namespace RecordSystemWF.Models.Context;

public partial class SysUser
{
    /// <summary>
    /// 使用者ID (系統產出唯一值)
    /// </summary>
    public int UserId { get; set; }

    /// <summary>
    /// 姓名
    /// </summary>
    public string UserName { get; set; } = null!;

    /// <summary>
    /// 密碼
    /// </summary>
    public string Password { get; set; } = null!;

    /// <summary>
    /// 電話號碼
    /// </summary>
    public string? Phone { get; set; }

    /// <summary>
    /// 電子信箱
    /// </summary>
    public string? Email { get; set; }

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
