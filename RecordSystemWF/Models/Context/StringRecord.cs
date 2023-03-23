using System;
using System.Collections.Generic;

namespace RecordSystemWF.Models.Context;

/// <summary>
/// 穿線記錄
/// </summary>
public partial class StringRecord
{
    public int Id { get; set; }

    /// <summary>
    /// 狀態
    /// </summary>
    public int? Status { get; set; }

    /// <summary>
    /// 姓名
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// 球拍
    /// </summary>
    public string? Racket { get; set; }

    /// <summary>
    /// 線種
    /// </summary>
    public int? StringType { get; set; }

    /// <summary>
    /// 顏色
    /// </summary>
    public string? StringColor { get; set; }

    /// <summary>
    /// 磅數
    /// </summary>
    public string? Lbs { get; set; }

    /// <summary>
    /// 費用
    /// </summary>
    public int? TotalPrice { get; set; }

    public int PayStatus { get; set; }

    public int? PaymentMethod { get; set; }

    /// <summary>
    /// 收拍日期
    /// </summary>
    public DateTime? ReceivedDate { get; set; }

    /// <summary>
    /// 完成日期
    /// </summary>
    public DateTime? FinishedDate { get; set; }

    /// <summary>
    /// 備註
    /// </summary>
    public string? Remark { get; set; }

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
