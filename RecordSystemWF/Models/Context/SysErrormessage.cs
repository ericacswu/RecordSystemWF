using System;
using System.Collections.Generic;

namespace RecordSystemWF.Models.Context;

/// <summary>
/// 程式碼例外錯誤紀錄
/// </summary>
public partial class SysErrormessage
{
    public int Id { get; set; }

    public string? Tag { get; set; }

    public string? FileName { get; set; }

    public string? FunctionName { get; set; }

    public int? LineNumber { get; set; }

    public string? Message { get; set; }

    public DateTime Time { get; set; }
}
