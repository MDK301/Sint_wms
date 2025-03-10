using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Sint_wms.Web.Models.Entites;

public partial class DataWmsContext : DbContext
{
    public DataWmsContext()
    {
    }

    public DataWmsContext(DbContextOptions<DataWmsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<EAuditInven> EAuditInvens { get; set; }

    public virtual DbSet<EChargeMi> EChargeMis { get; set; }

    public virtual DbSet<EHangdingCost> EHangdingCosts { get; set; }

    public virtual DbSet<EHistory> EHistories { get; set; }

    public virtual DbSet<EHistoryBot> EHistoryBots { get; set; }

    public virtual DbSet<EInventory> EInventories { get; set; }

    public virtual DbSet<EInventoryCost> EInventoryCosts { get; set; }

    public virtual DbSet<ELot> ELots { get; set; }

    public virtual DbSet<EOrder> EOrders { get; set; }

    public virtual DbSet<EOrderLoca> EOrderLocas { get; set; }

    public virtual DbSet<ERcpt> ERcpts { get; set; }

    public virtual DbSet<ERcptD> ERcptDs { get; set; }

    public virtual DbSet<EShipp> EShipps { get; set; }

    public virtual DbSet<EShippD> EShippDs { get; set; }

    public virtual DbSet<EWeght> EWeghts { get; set; }

    public virtual DbSet<FFile> FFiles { get; set; }

    public virtual DbSet<FImage> FImages { get; set; }

    public virtual DbSet<FParking> FParkings { get; set; }

    public virtual DbSet<HInventoryDaily> HInventoryDailies { get; set; }

    public virtual DbSet<SAccountCostStorage> SAccountCostStorages { get; set; }

    public virtual DbSet<SBot> SBots { get; set; }

    public virtual DbSet<SCategory> SCategories { get; set; }

    public virtual DbSet<SChargeCodeStorage> SChargeCodeStorages { get; set; }

    public virtual DbSet<SChargeCost> SChargeCosts { get; set; }

    public virtual DbSet<SCommand> SCommands { get; set; }

    public virtual DbSet<SCustomer> SCustomers { get; set; }

    public virtual DbSet<SEmail> SEmails { get; set; }

    public virtual DbSet<SEmployee> SEmployees { get; set; }

    public virtual DbSet<SLegalCompany> SLegalCompanies { get; set; }

    public virtual DbSet<SLocation> SLocations { get; set; }

    public virtual DbSet<SPrinter> SPrinters { get; set; }

    public virtual DbSet<SProduct> SProducts { get; set; }

    public virtual DbSet<SStore> SStores { get; set; }

    public virtual DbSet<SSupplier> SSuppliers { get; set; }

    public virtual DbSet<SUserPw> SUserPws { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=VNSGNLOG105;Initial Catalog=DATA_WMS;User ID=sa;Password=Singuyen1;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<EAuditInven>(entity =>
        {
            entity.ToTable("E_AUDIT_INVEN", "DATA");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Account)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CheckDate)
                .HasColumnType("datetime")
                .HasColumnName("Check_date");
            entity.Property(e => e.CheckIn).HasColumnName("Check_in");
            entity.Property(e => e.CreatedTime)
                .HasColumnType("datetime")
                .HasColumnName("Created_time");
            entity.Property(e => e.DateId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DateID");
            entity.Property(e => e.DiffNumber)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("Diff_number");
            entity.Property(e => e.ItemId)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("ItemID");
            entity.Property(e => e.Lot)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Mfg).HasColumnName("MFG");
            entity.Property(e => e.PalletId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PalletID");
            entity.Property(e => e.PosId)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("PosID");
            entity.Property(e => e.ProdId)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ProdID");
            entity.Property(e => e.QtyCheck)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("Qty_check");
            entity.Property(e => e.QtyInven)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("Qty_inven");
            entity.Property(e => e.Remark)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.StoreId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("StoreID");
            entity.Property(e => e.UserId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<EChargeMi>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_E_MIS");

            entity.ToTable("E_CHARGE_MIS", "DATA");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ChargeId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Charge_Id");
            entity.Property(e => e.CreatedTime)
                .HasColumnType("datetime")
                .HasColumnName("Created_time");
            entity.Property(e => e.Cuscode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DateId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DateID");
            entity.Property(e => e.DoRo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DO_RO");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Qty).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Remark).HasMaxLength(255);
            entity.Property(e => e.StoreId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("StoreID");
            entity.Property(e => e.Unit).HasMaxLength(50);
            entity.Property(e => e.Users)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.Charge).WithMany(p => p.EChargeMis)
                .HasForeignKey(d => d.ChargeId)
                .HasConstraintName("FK_E_MIS_CHARGE_S_CHARGE_CODE");
        });

        modelBuilder.Entity<EHangdingCost>(entity =>
        {
            entity.ToTable("E_HANGDING_COST", "DATA");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Account)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ChargeCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Charge_code");
            entity.Property(e => e.Classification)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CompanyID");
            entity.Property(e => e.DateId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DateID");
            entity.Property(e => e.NetWgt)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Net_Wgt");
            entity.Property(e => e.PaymentPeriod)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Payment_period");
            entity.Property(e => e.Remark)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.RoDo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("RO_DO");
            entity.Property(e => e.ToatlAmount)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("Toatl_amount");
            entity.Property(e => e.UnitPrice)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("Unit_price");

            entity.HasOne(d => d.DateNavigation).WithMany(p => p.EHangdingCosts)
                .HasForeignKey(d => d.DateId)
                .HasConstraintName("FK_E_HANGDING_COST_E_RCPT");

            entity.HasOne(d => d.Date1).WithMany(p => p.EHangdingCosts)
                .HasForeignKey(d => d.DateId)
                .HasConstraintName("FK_E_HANGDING_COST_E_SHIPP");
        });

        modelBuilder.Entity<EHistory>(entity =>
        {
            entity.ToTable("E_HISTORY", "DATA");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Action)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Created_time");
            entity.Property(e => e.Cuscode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DateId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DateID");
            entity.Property(e => e.DateInven).HasColumnName("Date_inven");
            entity.Property(e => e.DoComfirmDate)
                .HasColumnType("datetime")
                .HasColumnName("DO_Comfirm_date");
            entity.Property(e => e.DoNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DO_number");
            entity.Property(e => e.Exception)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.GrossWgt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Gross_Wgt");
            entity.Property(e => e.ItemId)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("ItemID");
            entity.Property(e => e.Lot)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.LotComment)
                .HasMaxLength(255)
                .HasColumnName("Lot_comment");
            entity.Property(e => e.LotRemark1)
                .HasMaxLength(50)
                .HasColumnName("LOT_Remark1");
            entity.Property(e => e.LotRemark2)
                .HasMaxLength(50)
                .HasColumnName("LOT_Remark2");
            entity.Property(e => e.LotRemark3)
                .HasMaxLength(50)
                .HasColumnName("LOT_Remark3");
            entity.Property(e => e.Mfg).HasColumnName("MFG");
            entity.Property(e => e.NetWgt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Net_Wgt");
            entity.Property(e => e.OrderQty).HasColumnName("Order_Qty");
            entity.Property(e => e.PalletId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PalletID");
            entity.Property(e => e.PosId)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("PosID");
            entity.Property(e => e.ProdId)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ProdID");
            entity.Property(e => e.QtyInven).HasColumnName("Qty_inven");
            entity.Property(e => e.RoComfirmDate)
                .HasColumnType("datetime")
                .HasColumnName("RO_Comfirm_date");
            entity.Property(e => e.RoNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("RO_number");
            entity.Property(e => e.ShipQty).HasColumnName("Ship_Qty");
            entity.Property(e => e.StoreId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("StoreID");
            entity.Property(e => e.Title)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("User_name");

            entity.HasOne(d => d.Date).WithMany(p => p.EHistories)
                .HasForeignKey(d => d.DateId)
                .HasConstraintName("FK_E_HISTORY_S_COMMAND");
        });

        modelBuilder.Entity<EHistoryBot>(entity =>
        {
            entity.ToTable("E_HISTORY_BOT", "DATA");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Action)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Bot)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("BOT");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.Error).HasMaxLength(500);
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.StoreId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("StoreID");
        });

        modelBuilder.Entity<EInventory>(entity =>
        {
            entity.ToTable("E_INVENTORY", "DATA");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Account)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ChargeCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Charge_Code");
            entity.Property(e => e.Classification)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CompanyID");
            entity.Property(e => e.Lot)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.NetBil)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Net_bil");
            entity.Property(e => e.NetWgtEnd)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("NetWgt_End");
            entity.Property(e => e.NetWgtIn)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("NetWgt_In");
            entity.Property(e => e.NetWgtOut)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("NetWgt_Out");
            entity.Property(e => e.NetWgtStart)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("NetWgt_Start");
            entity.Property(e => e.PaymentPeriod)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Payment_period");
            entity.Property(e => e.PltBil).HasColumnName("Plt_bil");
            entity.Property(e => e.PltEnd).HasColumnName("Plt_End");
            entity.Property(e => e.PltIn).HasColumnName("Plt_In");
            entity.Property(e => e.PltOut).HasColumnName("Plt_Out");
            entity.Property(e => e.PltStart).HasColumnName("Plt_Start");
            entity.Property(e => e.ProdId)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ProdID");
            entity.Property(e => e.QtyBil).HasColumnName("Qty_bil");
            entity.Property(e => e.QtyEnd).HasColumnName("Qty_End");
            entity.Property(e => e.QtyIn).HasColumnName("Qty_In");
            entity.Property(e => e.QtyOut).HasColumnName("Qty_Out");
            entity.Property(e => e.QtyStart).HasColumnName("Qty_Start");
            entity.Property(e => e.StoreId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("StoreID");
            entity.Property(e => e.ToatlAmount)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Toatl_amount");
            entity.Property(e => e.UnitPrice)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("Unit_price");

            entity.HasOne(d => d.Prod).WithMany(p => p.EInventories)
                .HasForeignKey(d => d.ProdId)
                .HasConstraintName("FK_E_INVENTORY_S_PRODUCT");
        });

        modelBuilder.Entity<EInventoryCost>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_S_INVENTORY_COST");

            entity.ToTable("E_INVENTORY_COST", "DATA");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Account)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ChargeCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Charge_code");
            entity.Property(e => e.Classification)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CompanyID");
            entity.Property(e => e.Lot)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.NetWgt)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Net_Wgt");
            entity.Property(e => e.PaymentPeriod)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Payment_period");
            entity.Property(e => e.Remark)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ToatlAmount)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("Toatl_amount");
            entity.Property(e => e.UnitPrice)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("Unit_price");

            entity.HasOne(d => d.Inventory).WithMany(p => p.EInventoryCosts)
                .HasForeignKey(d => d.InventoryId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_S_INVENTORY_COST_E_INVENTORY");
        });

        modelBuilder.Entity<ELot>(entity =>
        {
            entity.HasKey(e => new { e.LotId, e.StoreId });

            entity.ToTable("E_LOT", "DATA");

            entity.Property(e => e.LotId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("LotID");
            entity.Property(e => e.StoreId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("StoreID");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Created_time");
            entity.Property(e => e.DateId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DateID");
            entity.Property(e => e.Exp).HasColumnName("EXP");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Mfg).HasColumnName("MFG");
            entity.Property(e => e.UserId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("UserID");

            entity.HasOne(d => d.Store).WithMany(p => p.ELots)
                .HasForeignKey(d => d.StoreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_E_LOT_S_STORE");
        });

        modelBuilder.Entity<EOrder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_E_ORDER_D");

            entity.ToTable("E_ORDER", "DATA");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Created_time");
            entity.Property(e => e.Cuscode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DateId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DateID");
            entity.Property(e => e.DoConfDate)
                .HasColumnType("datetime")
                .HasColumnName("DO_conf_Date");
            entity.Property(e => e.DoNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DO_number");
            entity.Property(e => e.Lot)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.LotComment)
                .HasMaxLength(255)
                .HasColumnName("Lot_comment");
            entity.Property(e => e.NetWgt)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("Net_Wgt");
            entity.Property(e => e.PalletId)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("PalletID");
            entity.Property(e => e.ProdId)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ProdID");
            entity.Property(e => e.Scanner)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UnitPrice)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("Unit_price");

            entity.HasOne(d => d.Date).WithMany(p => p.EOrders)
                .HasForeignKey(d => d.DateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_E_ORDER_E_SHIPP");
        });

        modelBuilder.Entity<EOrderLoca>(entity =>
        {
            entity.ToTable("E_ORDER_LOCA", "DATA");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CreatedTime)
                .HasColumnType("datetime")
                .HasColumnName("Created_time");
            entity.Property(e => e.Cuscode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DateConfirm).HasColumnName("Date_confirm");
            entity.Property(e => e.DateId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DateID");
            entity.Property(e => e.DoNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DO_number");
            entity.Property(e => e.GrossWgt)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("Gross_Wgt");
            entity.Property(e => e.ItemId)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("ItemID");
            entity.Property(e => e.Lot)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.NetWgt)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("Net_Wgt");
            entity.Property(e => e.PalletId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PalletID");
            entity.Property(e => e.PosId)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("PosID");
            entity.Property(e => e.ProdId)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ProdID");
            entity.Property(e => e.PullId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PullID");
            entity.Property(e => e.Scanner)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.StorId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("StorID");

            entity.HasOne(d => d.Date).WithMany(p => p.EOrderLocas)
                .HasForeignKey(d => d.DateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_E_ORDER_LOCA_E_SHIPP");
        });

        modelBuilder.Entity<ERcpt>(entity =>
        {
            entity.HasKey(e => e.DateId);

            entity.ToTable("E_RCPT", "DATA");

            entity.Property(e => e.DateId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DateID");
            entity.Property(e => e.Account)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Comment).HasMaxLength(255);
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CompanyID");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Created_time");
            entity.Property(e => e.DateConfirm).HasColumnName("Date_confirm");
            entity.Property(e => e.DateOrder).HasColumnName("Date_order");
            entity.Property(e => e.FinishTime)
                .HasColumnType("datetime")
                .HasColumnName("Finish_time");
            entity.Property(e => e.Handling)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.NetOrder)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Net_order");
            entity.Property(e => e.NetWgt)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Net_Wgt");
            entity.Property(e => e.QtyOrder).HasColumnName("Qty_Order");
            entity.Property(e => e.Reference).HasMaxLength(50);
            entity.Property(e => e.Remark1).HasMaxLength(200);
            entity.Property(e => e.Remark2).HasMaxLength(200);
            entity.Property(e => e.Remark3).HasMaxLength(200);
            entity.Property(e => e.RoNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("RO_number");
            entity.Property(e => e.StartTime)
                .HasColumnType("datetime")
                .HasColumnName("Start_time");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.StoreId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("StoreID");
            entity.Property(e => e.SuppId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SuppID");
            entity.Property(e => e.TotalTime)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Total_time");
            entity.Property(e => e.Truck)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.TruckIn)
                .HasColumnType("datetime")
                .HasColumnName("Truck_in");
            entity.Property(e => e.Users)
                .HasMaxLength(7)
                .IsUnicode(false);

            entity.HasOne(d => d.AccountNavigation).WithMany(p => p.ERcpts)
                .HasForeignKey(d => d.Account)
                .HasConstraintName("FK_E_RCPT_S_CUSTOMER");
        });

        modelBuilder.Entity<ERcptD>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_E_RCPT_D_1");

            entity.ToTable("E_RCPT_D", "DATA");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Account)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CheckScan).HasColumnName("Check_Scan");
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CompanyID");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Created_time");
            entity.Property(e => e.DateId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DateID");
            entity.Property(e => e.GrossWgt)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("Gross_Wgt");
            entity.Property(e => e.ItemId)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("ItemID");
            entity.Property(e => e.LastMovement)
                .HasColumnType("datetime")
                .HasColumnName("Last_movement");
            entity.Property(e => e.Lot)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.LotComment)
                .HasMaxLength(255)
                .HasColumnName("Lot_comment");
            entity.Property(e => e.LotRemark1)
                .HasMaxLength(200)
                .HasColumnName("LOT_Remark1");
            entity.Property(e => e.LotRemark2)
                .HasMaxLength(200)
                .HasColumnName("LOT_Remark2");
            entity.Property(e => e.LotRemark3)
                .HasMaxLength(200)
                .HasColumnName("LOT_Remark3");
            entity.Property(e => e.Mfg).HasColumnName("MFG");
            entity.Property(e => e.NetAver)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("Net_Aver");
            entity.Property(e => e.NetInven)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("Net_inven");
            entity.Property(e => e.NetWgt)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("Net_Wgt");
            entity.Property(e => e.PalletId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PalletID");
            entity.Property(e => e.PosId)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("PosID");
            entity.Property(e => e.ProdId)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ProdID");
            entity.Property(e => e.QtyInven).HasColumnName("Qty_inven");
            entity.Property(e => e.QtyOrder).HasColumnName("Qty_Order");
            entity.Property(e => e.RoNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("RO_number");
            entity.Property(e => e.Room)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Scanner)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.StoreId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("StoreID");
            entity.Property(e => e.UserName)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("User_name");
            entity.Property(e => e.WeightId).HasColumnName("WeightID");

            entity.HasOne(d => d.Date).WithMany(p => p.ERcptDs)
                .HasForeignKey(d => d.DateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__E_RCPT_D__DateID__48CFD27E");

            entity.HasOne(d => d.ELot).WithMany(p => p.ERcptDs)
                .HasForeignKey(d => new { d.Lot, d.StoreId })
                .HasConstraintName("FK_E_RCPT_D_E_LOT");
        });

        modelBuilder.Entity<EShipp>(entity =>
        {
            entity.HasKey(e => e.DateId);

            entity.ToTable("E_SHIPP", "DATA");

            entity.Property(e => e.DateId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DateID");
            entity.Property(e => e.Account)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Comment).HasMaxLength(255);
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CompanyID");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Created_time");
            entity.Property(e => e.Cuscode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DateConfirm).HasColumnName("Date_confirm");
            entity.Property(e => e.DateOrder).HasColumnName("Date_order");
            entity.Property(e => e.DoNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DO_number");
            entity.Property(e => e.FinishTime)
                .HasColumnType("datetime")
                .HasColumnName("Finish_time");
            entity.Property(e => e.Handling)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.NetWgt)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Net_Wgt");
            entity.Property(e => e.Reference).HasMaxLength(50);
            entity.Property(e => e.Remark1).HasMaxLength(250);
            entity.Property(e => e.Remark2).HasMaxLength(50);
            entity.Property(e => e.Remark3).HasMaxLength(50);
            entity.Property(e => e.StartTime)
                .HasColumnType("datetime")
                .HasColumnName("Start_time");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.StoreId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("StoreID");
            entity.Property(e => e.TotalTime)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Total_time");
            entity.Property(e => e.Truck)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.TruckIn)
                .HasColumnType("datetime")
                .HasColumnName("Truck_in");
            entity.Property(e => e.Users)
                .HasMaxLength(7)
                .IsUnicode(false);

            entity.HasOne(d => d.CuscodeNavigation).WithMany(p => p.EShipps)
                .HasForeignKey(d => d.Cuscode)
                .HasConstraintName("FK_E_SHIPP_S_CUSTOMER");
        });

        modelBuilder.Entity<EShippD>(entity =>
        {
            entity.ToTable("E_SHIPP_D", "DATA");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CompanyID");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Created_time");
            entity.Property(e => e.Cuscode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DateId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DateID");
            entity.Property(e => e.DoNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DO_number");
            entity.Property(e => e.GrossWgt)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("Gross_Wgt");
            entity.Property(e => e.ItemId)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("ItemID");
            entity.Property(e => e.Lot)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.NetWgt)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("Net_Wgt");
            entity.Property(e => e.PalletId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PalletID");
            entity.Property(e => e.PosId)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("PosID");
            entity.Property(e => e.ProdId)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ProdID");
            entity.Property(e => e.PullId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PullID");
            entity.Property(e => e.Scanner)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.StoreId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("StoreID");
            entity.Property(e => e.WeightId).HasColumnName("WeightID");

            entity.HasOne(d => d.Date).WithMany(p => p.EShippDs)
                .HasForeignKey(d => d.DateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_E_SHIPP_D_E_SHIPP");
        });

        modelBuilder.Entity<EWeght>(entity =>
        {
            entity.ToTable("E_WEGHT", "DATA");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Action).HasDefaultValue(false);
            entity.Property(e => e.Code)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CompanyID");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Created_date");
            entity.Property(e => e.Cuscode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DateId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DateID");
            entity.Property(e => e.Exp).HasColumnName("EXP");
            entity.Property(e => e.Kg)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("KG");
            entity.Property(e => e.Lb)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("LB");
            entity.Property(e => e.Lot)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Mfg).HasColumnName("MFG");
            entity.Property(e => e.Mnx)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("MNX");
            entity.Property(e => e.NetRef)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Net_Ref");
            entity.Property(e => e.PalletId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PalletID");
            entity.Property(e => e.ProdId)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ProdID");
            entity.Property(e => e.Reference)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RoDo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Ro_Do");
            entity.Property(e => e.Unit)
                .HasMaxLength(2)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FFile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_S_FILES");

            entity.ToTable("F_FILES", "DATA");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedTime)
                .HasColumnType("datetime")
                .HasColumnName("Created_Time");
            entity.Property(e => e.CurrentFile).HasColumnName("Current_file");
            entity.Property(e => e.DateId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DateID");
            entity.Property(e => e.StoreId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("StoreID");
            entity.Property(e => e.UserName)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("User_Name");
        });

        modelBuilder.Entity<FImage>(entity =>
        {
            entity.ToTable("F_IMAGE", "DATA");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedTime)
                .HasColumnType("datetime")
                .HasColumnName("Created_Time");
            entity.Property(e => e.CurrentFile).HasColumnName("Current_file");
            entity.Property(e => e.DateId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DateID");
            entity.Property(e => e.FileImage)
                .HasColumnType("image")
                .HasColumnName("File_Image");
            entity.Property(e => e.StoreId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("StoreID");
            entity.Property(e => e.UserName)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("User_Name");
        });

        modelBuilder.Entity<FParking>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("F_PARKING", "DATA");

            entity.Property(e => e.Code)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.Area)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CarNumber)
                .HasMaxLength(20)
                .HasColumnName("Car_number");
            entity.Property(e => e.CodeCard)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("Code_Card");
            entity.Property(e => e.CurrentFile).HasColumnName("Current_file");
            entity.Property(e => e.FileImage)
                .HasColumnType("image")
                .HasColumnName("File_Image");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.TimeIn).HasColumnType("datetime");
            entity.Property(e => e.TimeOut).HasColumnType("datetime");
            entity.Property(e => e.UserId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<HInventoryDaily>(entity =>
        {
            entity.ToTable("H_INVENTORY_DAILY", "DATA");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Account)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CheckScan).HasColumnName("Check_Scan");
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CompanyID");
            entity.Property(e => e.CreatedTime)
                .HasColumnType("datetime")
                .HasColumnName("Created_time");
            entity.Property(e => e.DateId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DateID");
            entity.Property(e => e.DateReport).HasColumnName("Date_Report");
            entity.Property(e => e.GrossWgt)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("Gross_Wgt");
            entity.Property(e => e.ItemId)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("ItemID");
            entity.Property(e => e.LastMovement)
                .HasColumnType("datetime")
                .HasColumnName("Last_movement");
            entity.Property(e => e.Lot)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.LotComment)
                .HasMaxLength(255)
                .HasColumnName("Lot_comment");
            entity.Property(e => e.LotRemark1)
                .HasMaxLength(200)
                .HasColumnName("LOT_Remark1");
            entity.Property(e => e.LotRemark2)
                .HasMaxLength(200)
                .HasColumnName("LOT_Remark2");
            entity.Property(e => e.LotRemark3)
                .HasMaxLength(200)
                .HasColumnName("LOT_Remark3");
            entity.Property(e => e.Mfg).HasColumnName("MFG");
            entity.Property(e => e.NetAver)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("Net_Aver");
            entity.Property(e => e.NetInven)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("Net_inven");
            entity.Property(e => e.NetWgt)
                .HasColumnType("decimal(18, 5)")
                .HasColumnName("Net_Wgt");
            entity.Property(e => e.PalletId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PalletID");
            entity.Property(e => e.PosId)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("PosID");
            entity.Property(e => e.ProdId)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ProdID");
            entity.Property(e => e.QtyInven).HasColumnName("Qty_inven");
            entity.Property(e => e.QtyOrder).HasColumnName("Qty_Order");
            entity.Property(e => e.RoNumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("RO_number");
            entity.Property(e => e.Scanner)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.StoreId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("StoreID");
            entity.Property(e => e.UserName)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("User_name");
            entity.Property(e => e.WeightId).HasColumnName("WeightID");
        });

        modelBuilder.Entity<SAccountCostStorage>(entity =>
        {
            entity.ToTable("S_ACCOUNT_COST_STORAGE", "DATA");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Account)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ChargeCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Charge_Code");
            entity.Property(e => e.Classification)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedTime)
                .HasColumnType("datetime")
                .HasColumnName("Created_time");
            entity.Property(e => e.UnitPrice)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("Unit_price");
            entity.Property(e => e.UserId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("UserID");

            entity.HasOne(d => d.AccountNavigation).WithMany(p => p.SAccountCostStorages)
                .HasForeignKey(d => d.Account)
                .HasConstraintName("FK_S_ACCOUNT_COST_STORAGE_S_CUSTOMER");

            entity.HasOne(d => d.ChargeCodeNavigation).WithMany(p => p.SAccountCostStorages)
                .HasForeignKey(d => d.ChargeCode)
                .HasConstraintName("FK_S_ACCOUNT_COST_STORAGE_S_CHARGE_CODE_STORAGE");
        });

        modelBuilder.Entity<SBot>(entity =>
        {
            entity.ToTable("S_BOT", "DATA");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedTime)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Created_time");
            entity.Property(e => e.Keys)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.SerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Serial_number");
        });

        modelBuilder.Entity<SCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_S_CLASSIFICATION");

            entity.ToTable("S_CATEGORY", "DATA");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Category).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(255);
        });

        modelBuilder.Entity<SChargeCodeStorage>(entity =>
        {
            entity.HasKey(e => e.ChargeCode);

            entity.ToTable("S_CHARGE_CODE_STORAGE", "DATA");

            entity.Property(e => e.ChargeCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Charge_Code");
            entity.Property(e => e.ChargeCost)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Charge_cost");
            entity.Property(e => e.ChargeGroup)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Charge_Group");
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CompanyID");
            entity.Property(e => e.Description).HasMaxLength(250);
            entity.Property(e => e.Explain).HasMaxLength(250);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Unit).HasMaxLength(10);
        });

        modelBuilder.Entity<SChargeCost>(entity =>
        {
            entity.HasKey(e => e.ChargeId).HasName("PK_S_CHARGE_CODE");

            entity.ToTable("S_CHARGE_COST", "DATA");

            entity.Property(e => e.ChargeId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Charge_Id");
            entity.Property(e => e.ChargeName)
                .HasMaxLength(50)
                .HasColumnName("Charge_name");
            entity.Property(e => e.Cuscode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Description).HasMaxLength(250);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Unit).HasMaxLength(10);
        });

        modelBuilder.Entity<SCommand>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("S_COMMAND", "DATA");

            entity.Property(e => e.Code)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CompanyID");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Created_time");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.RoDo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("RO_DO");
            entity.Property(e => e.Title)
                .HasMaxLength(5)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SCustomer>(entity =>
        {
            entity.HasKey(e => e.Cuscode);

            entity.ToTable("S_CUSTOMER", "DATA");

            entity.Property(e => e.Cuscode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.ChargeCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ChargeCost)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("Charge_cost");
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CompanyID");
            entity.Property(e => e.Customer).HasMaxLength(255);
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Fullname).HasMaxLength(255);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.StoreId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("StoreID");
            entity.Property(e => e.TaxNumber)
                .HasMaxLength(50)
                .HasColumnName("Tax_number");
            entity.Property(e => e.Telephone).HasMaxLength(50);
        });

        modelBuilder.Entity<SEmail>(entity =>
        {
            entity.ToTable("S_EMAIL", "DATA");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CompanyID");
            entity.Property(e => e.Email)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.GrReport)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GR_Report");
        });

        modelBuilder.Entity<SEmployee>(entity =>
        {
            entity.HasKey(e => e.EmpId);

            entity.ToTable("S_EMPLOYEE", "DATA");

            entity.Property(e => e.EmpId)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("EmpID");
            entity.Property(e => e.FirstName)
                .HasMaxLength(20)
                .HasColumnName("First_name");
            entity.Property(e => e.FullName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Full_name");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.LastName)
                .HasMaxLength(30)
                .HasColumnName("Last_name");
            entity.Property(e => e.Position)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.StoreId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("StoreID");
        });

        modelBuilder.Entity<SLegalCompany>(entity =>
        {
            entity.HasKey(e => e.CompanyId);

            entity.ToTable("S_LEGAL_COMPANY", "DATA");

            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CompanyID");
            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(255)
                .HasColumnName("Company_name");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Logo).HasColumnType("image");
            entity.Property(e => e.ShostName)
                .HasMaxLength(255)
                .HasColumnName("Shost_name");
            entity.Property(e => e.TaxNumber)
                .HasMaxLength(50)
                .HasColumnName("Tax_number");
            entity.Property(e => e.Telephone).HasMaxLength(50);
        });

        modelBuilder.Entity<SLocation>(entity =>
        {
            entity.HasKey(e => new { e.PosId, e.StoreId }).HasName("PK_S_LOCALTION");

            entity.ToTable("S_LOCATION", "DATA");

            entity.Property(e => e.PosId)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("PosID");
            entity.Property(e => e.StoreId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("StoreID");
            entity.Property(e => e.Depth)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Floor)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Line)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Local)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Remark).HasMaxLength(50);
            entity.Property(e => e.Room)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.Store).WithMany(p => p.SLocations)
                .HasForeignKey(d => d.StoreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_S_Location_S_STORAGE");
        });

        modelBuilder.Entity<SPrinter>(entity =>
        {
            entity.ToTable("S_PRINTERS", "DATA");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.IdPrint)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("ID_PRINT");
            entity.Property(e => e.NamePrint)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NAME_PRINT");
            entity.Property(e => e.SetAuto).HasColumnName("Set_auto");
            entity.Property(e => e.StoreId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("StoreID");
        });

        modelBuilder.Entity<SProduct>(entity =>
        {
            entity.HasKey(e => e.ProdId);

            entity.ToTable("S_PRODUCT", "DATA");

            entity.Property(e => e.ProdId)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ProdID");
            entity.Property(e => e.Account)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Category).HasMaxLength(255);
            entity.Property(e => e.Classification)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Code)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CompanyID");
            entity.Property(e => e.GrossWgt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Gross_Wgt");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.NetWgt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Net_Wgt");
            entity.Property(e => e.ProductName)
                .HasMaxLength(255)
                .HasColumnName("Product_name");
            entity.Property(e => e.QrCode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("QR_code");
            entity.Property(e => e.StoreId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("StoreID");
            entity.Property(e => e.Unit)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.AccountNavigation).WithMany(p => p.SProducts)
                .HasForeignKey(d => d.Account)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_S_PRODUCT_S_CUSTOMER");
        });

        modelBuilder.Entity<SStore>(entity =>
        {
            entity.HasKey(e => e.StoreId).HasName("PK_S_STORAGE");

            entity.ToTable("S_STORE", "DATA");

            entity.Property(e => e.StoreId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("StoreID");
            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.CompanyId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(255)
                .HasColumnName("Company_name");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Logo).HasColumnType("image");
            entity.Property(e => e.PrinterRelo).HasColumnName("Printer_Relo");
            entity.Property(e => e.StoreName)
                .HasMaxLength(255)
                .HasColumnName("Store_Name");
            entity.Property(e => e.TaxNumber)
                .HasMaxLength(50)
                .HasColumnName("Tax_number");
            entity.Property(e => e.Telephone).HasMaxLength(50);

            entity.HasOne(d => d.Company).WithMany(p => p.SStores)
                .HasForeignKey(d => d.CompanyId)
                .HasConstraintName("FK_S_STORE_S_LEGAL_COMPANY");
        });

        modelBuilder.Entity<SSupplier>(entity =>
        {
            entity.HasKey(e => e.SuppId);

            entity.ToTable("S_SUPPLIER", "DATA");

            entity.Property(e => e.SuppId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("SuppID");
            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.StoreId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("StoreID");
            entity.Property(e => e.Supplier).HasMaxLength(255);
            entity.Property(e => e.TaxNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Tax_number");
            entity.Property(e => e.Telephone)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SUserPw>(entity =>
        {
            entity.HasKey(e => e.UserId);

            entity.ToTable("S_USER_PW", "DATA");

            entity.Property(e => e.UserId)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("UserID");
            entity.Property(e => e.Company)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Pasword)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.StaffOffice).HasColumnName("Staff_office");
            entity.Property(e => e.StaffWarehouse).HasColumnName("Staff_warehouse");
            entity.Property(e => e.StoreId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("StoreID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
