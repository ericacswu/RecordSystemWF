using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace RecordSystemWF.Models.Context;

public partial class StringingRecordContext : DbContext
{
    public StringingRecordContext()
    {
    }

    public StringingRecordContext(DbContextOptions<StringingRecordContext> options)
        : base(options)
    {
    }

    public virtual DbSet<StringRecord> StringRecords { get; set; }

    public virtual DbSet<StringType> StringTypes { get; set; }

    public virtual DbSet<SysErrormessage> SysErrormessages { get; set; }

    public virtual DbSet<SysPaymentMethod> SysPaymentMethods { get; set; }

    public virtual DbSet<SysStatus> SysStatuses { get; set; }

    public virtual DbSet<SysUser> SysUsers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;port=3306;database=stringing_record;user=stringRecord;password=stringRecord)#!!", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.32-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<StringRecord>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("string_record", tb => tb.HasComment("穿線記錄"));

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreateDate)
                .HasComment("建立時間")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateUser)
                .HasComment("建立人員")
                .HasColumnType("datetime");
            entity.Property(e => e.FinishedDate)
                .HasComment("完成日期")
                .HasColumnType("datetime");
            entity.Property(e => e.Lbs)
                .HasMaxLength(255)
                .HasComment("磅數");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasComment("姓名");
            entity.Property(e => e.PaymentMethod).HasDefaultValueSql("'0'");
            entity.Property(e => e.Racket)
                .HasMaxLength(255)
                .HasComment("球拍");
            entity.Property(e => e.ReceivedDate)
                .HasComment("收拍日期")
                .HasColumnType("datetime");
            entity.Property(e => e.Remark)
                .HasMaxLength(255)
                .HasComment("備註");
            entity.Property(e => e.Status).HasComment("狀態");
            entity.Property(e => e.StringColor)
                .HasMaxLength(255)
                .HasDefaultValueSql("'White'")
                .HasComment("顏色");
            entity.Property(e => e.StringType).HasComment("線種");
            entity.Property(e => e.TotalPrice).HasComment("費用");
            entity.Property(e => e.UpdateDate)
                .HasComment("更新時間")
                .HasColumnType("datetime");
            entity.Property(e => e.UpdateUser)
                .HasMaxLength(25)
                .HasComment("操作人員(登入 ID)");
        });

        modelBuilder.Entity<StringType>(entity =>
        {
            entity.HasKey(e => e.TypeId).HasName("PRIMARY");

            entity.ToTable("string_type", tb => tb.HasComment("線種"));

            entity.Property(e => e.TypeId).HasColumnName("TypeID");
            entity.Property(e => e.Cost).HasComment("成本");
            entity.Property(e => e.CreateDate)
                .HasComment("建立時間")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateUser)
                .HasComment("建立人員")
                .HasColumnType("datetime");
            entity.Property(e => e.Enabled).HasComment("是否可用 (1:可用 0:不可用)");
            entity.Property(e => e.Remark)
                .HasMaxLength(255)
                .HasComment("備註");
            entity.Property(e => e.StringName)
                .HasMaxLength(50)
                .HasComment("線種");
            entity.Property(e => e.UpdateDate)
                .HasComment("更新時間")
                .HasColumnType("datetime");
            entity.Property(e => e.UpdateUser)
                .HasMaxLength(25)
                .HasComment("操作人員(登入 ID)");
        });

        modelBuilder.Entity<SysErrormessage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("sys_errormessage", tb => tb.HasComment("程式碼例外錯誤紀錄"));

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FileName).HasMaxLength(300);
            entity.Property(e => e.FunctionName).HasMaxLength(100);
            entity.Property(e => e.Message).HasColumnType("text");
            entity.Property(e => e.Tag).HasMaxLength(30);
            entity.Property(e => e.Time).HasColumnType("datetime");
        });

        modelBuilder.Entity<SysPaymentMethod>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("sys_payment_method");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Enabled)
                .HasMaxLength(1)
                .HasComment("是否可用 (Y:可用 N:不可用)");
            entity.Property(e => e.PaymentMethod).HasMaxLength(45);
            entity.Property(e => e.UpdateDate)
                .HasComment("系統日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.UpdateUser).HasComment("操作人員(登入 ID)");
        });

        modelBuilder.Entity<SysStatus>(entity =>
        {
            entity.HasKey(e => new { e.StatusId, e.StatusGroup })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("sys_status", tb => tb.HasComment("狀態設定"));

            entity.Property(e => e.StatusId)
                .HasComment("狀態ID (系統產出唯一值)")
                .HasColumnName("StatusID");
            entity.Property(e => e.StatusGroup)
                .HasMaxLength(40)
                .HasComment("狀態");
            entity.Property(e => e.CreateDate)
                .HasComment("建立時間")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateUser).HasComment("建立人員");
            entity.Property(e => e.Enabled).HasComment("是否可用 (1:可用 0:不可用)");
            entity.Property(e => e.StatusName)
                .HasMaxLength(40)
                .HasComment("狀態");
            entity.Property(e => e.UpdateDate)
                .HasComment("更新時間")
                .HasColumnType("datetime");
            entity.Property(e => e.UpdateUser).HasComment("操作人員(登入 ID)");
        });

        modelBuilder.Entity<SysUser>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PRIMARY");

            entity.ToTable("sys_user");

            entity.Property(e => e.UserId)
                .ValueGeneratedNever()
                .HasComment("使用者ID (系統產出唯一值)")
                .HasColumnName("UserID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasComment("電子信箱");
            entity.Property(e => e.Enabled)
                .HasMaxLength(1)
                .HasComment("是否可用 (Y:可用 N:不可用)");
            entity.Property(e => e.Password)
                .HasMaxLength(256)
                .HasComment("密碼");
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .HasComment("電話號碼");
            entity.Property(e => e.UpdateDate)
                .HasComment("系統日期時間")
                .HasColumnType("datetime");
            entity.Property(e => e.UpdateUser).HasComment("操作人員(登入 ID)");
            entity.Property(e => e.UserName)
                .HasMaxLength(20)
                .HasComment("姓名");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
