﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DTO
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DB_KDPM_QLGB")]
	public partial class DB_KDPM_QLGBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertChiTietDatBao(ChiTietDatBao instance);
    partial void UpdateChiTietDatBao(ChiTietDatBao instance);
    partial void DeleteChiTietDatBao(ChiTietDatBao instance);
    partial void InsertTaiKhoan(TaiKhoan instance);
    partial void UpdateTaiKhoan(TaiKhoan instance);
    partial void DeleteTaiKhoan(TaiKhoan instance);
    partial void InsertDatBao(DatBao instance);
    partial void UpdateDatBao(DatBao instance);
    partial void DeleteDatBao(DatBao instance);
    partial void InsertKhachHang(KhachHang instance);
    partial void UpdateKhachHang(KhachHang instance);
    partial void DeleteKhachHang(KhachHang instance);
    partial void InsertLoaiBao(LoaiBao instance);
    partial void UpdateLoaiBao(LoaiBao instance);
    partial void DeleteLoaiBao(LoaiBao instance);
    partial void InsertNhanVien(NhanVien instance);
    partial void UpdateNhanVien(NhanVien instance);
    partial void DeleteNhanVien(NhanVien instance);
    partial void InsertPhanQuyen(PhanQuyen instance);
    partial void UpdatePhanQuyen(PhanQuyen instance);
    partial void DeletePhanQuyen(PhanQuyen instance);
    #endregion
		
		public DB_KDPM_QLGBDataContext() : 
				base(global::DTO.Properties.Settings.Default.DB_KDPM_QLGBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DB_KDPM_QLGBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DB_KDPM_QLGBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DB_KDPM_QLGBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DB_KDPM_QLGBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<ChiTietDatBao> ChiTietDatBaos
		{
			get
			{
				return this.GetTable<ChiTietDatBao>();
			}
		}
		
		public System.Data.Linq.Table<TaiKhoan> TaiKhoans
		{
			get
			{
				return this.GetTable<TaiKhoan>();
			}
		}
		
		public System.Data.Linq.Table<DatBao> DatBaos
		{
			get
			{
				return this.GetTable<DatBao>();
			}
		}
		
		public System.Data.Linq.Table<KhachHang> KhachHangs
		{
			get
			{
				return this.GetTable<KhachHang>();
			}
		}
		
		public System.Data.Linq.Table<LoaiBao> LoaiBaos
		{
			get
			{
				return this.GetTable<LoaiBao>();
			}
		}
		
		public System.Data.Linq.Table<NhanVien> NhanViens
		{
			get
			{
				return this.GetTable<NhanVien>();
			}
		}
		
		public System.Data.Linq.Table<PhanQuyen> PhanQuyens
		{
			get
			{
				return this.GetTable<PhanQuyen>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ChiTietDatBao")]
	public partial class ChiTietDatBao : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaDatBao;
		
		private int _MaLoaiBao;
		
		private System.Nullable<int> _SoKy;
		
		private System.Nullable<int> _SoLuong;
		
		private System.Nullable<double> _ThanhTien;
		
		private EntityRef<DatBao> _DatBao;
		
		private EntityRef<LoaiBao> _LoaiBao;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaDatBaoChanging(int value);
    partial void OnMaDatBaoChanged();
    partial void OnMaLoaiBaoChanging(int value);
    partial void OnMaLoaiBaoChanged();
    partial void OnSoKyChanging(System.Nullable<int> value);
    partial void OnSoKyChanged();
    partial void OnSoLuongChanging(System.Nullable<int> value);
    partial void OnSoLuongChanged();
    partial void OnThanhTienChanging(System.Nullable<double> value);
    partial void OnThanhTienChanged();
    #endregion
		
		public ChiTietDatBao()
		{
			this._DatBao = default(EntityRef<DatBao>);
			this._LoaiBao = default(EntityRef<LoaiBao>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDatBao", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaDatBao
		{
			get
			{
				return this._MaDatBao;
			}
			set
			{
				if ((this._MaDatBao != value))
				{
					if (this._DatBao.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaDatBaoChanging(value);
					this.SendPropertyChanging();
					this._MaDatBao = value;
					this.SendPropertyChanged("MaDatBao");
					this.OnMaDatBaoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaLoaiBao", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaLoaiBao
		{
			get
			{
				return this._MaLoaiBao;
			}
			set
			{
				if ((this._MaLoaiBao != value))
				{
					if (this._LoaiBao.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaLoaiBaoChanging(value);
					this.SendPropertyChanging();
					this._MaLoaiBao = value;
					this.SendPropertyChanged("MaLoaiBao");
					this.OnMaLoaiBaoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoKy", DbType="Int")]
		public System.Nullable<int> SoKy
		{
			get
			{
				return this._SoKy;
			}
			set
			{
				if ((this._SoKy != value))
				{
					this.OnSoKyChanging(value);
					this.SendPropertyChanging();
					this._SoKy = value;
					this.SendPropertyChanged("SoKy");
					this.OnSoKyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoLuong", DbType="Int")]
		public System.Nullable<int> SoLuong
		{
			get
			{
				return this._SoLuong;
			}
			set
			{
				if ((this._SoLuong != value))
				{
					this.OnSoLuongChanging(value);
					this.SendPropertyChanging();
					this._SoLuong = value;
					this.SendPropertyChanged("SoLuong");
					this.OnSoLuongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ThanhTien", DbType="Float")]
		public System.Nullable<double> ThanhTien
		{
			get
			{
				return this._ThanhTien;
			}
			set
			{
				if ((this._ThanhTien != value))
				{
					this.OnThanhTienChanging(value);
					this.SendPropertyChanging();
					this._ThanhTien = value;
					this.SendPropertyChanged("ThanhTien");
					this.OnThanhTienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DatBao_ChiTietDatBao", Storage="_DatBao", ThisKey="MaDatBao", OtherKey="MaDatBao", IsForeignKey=true)]
		public DatBao DatBao
		{
			get
			{
				return this._DatBao.Entity;
			}
			set
			{
				DatBao previousValue = this._DatBao.Entity;
				if (((previousValue != value) 
							|| (this._DatBao.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._DatBao.Entity = null;
						previousValue.ChiTietDatBaos.Remove(this);
					}
					this._DatBao.Entity = value;
					if ((value != null))
					{
						value.ChiTietDatBaos.Add(this);
						this._MaDatBao = value.MaDatBao;
					}
					else
					{
						this._MaDatBao = default(int);
					}
					this.SendPropertyChanged("DatBao");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LoaiBao_ChiTietDatBao", Storage="_LoaiBao", ThisKey="MaLoaiBao", OtherKey="MaLoaiBao", IsForeignKey=true)]
		public LoaiBao LoaiBao
		{
			get
			{
				return this._LoaiBao.Entity;
			}
			set
			{
				LoaiBao previousValue = this._LoaiBao.Entity;
				if (((previousValue != value) 
							|| (this._LoaiBao.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._LoaiBao.Entity = null;
						previousValue.ChiTietDatBaos.Remove(this);
					}
					this._LoaiBao.Entity = value;
					if ((value != null))
					{
						value.ChiTietDatBaos.Add(this);
						this._MaLoaiBao = value.MaLoaiBao;
					}
					else
					{
						this._MaLoaiBao = default(int);
					}
					this.SendPropertyChanged("LoaiBao");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TaiKhoan")]
	public partial class TaiKhoan : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaTaiKhoan;
		
		private string _TenDangNhap;
		
		private string _MatKhau;
		
		private System.Nullable<int> _MaNV;
		
		private System.Nullable<bool> _TinhTrang;
		
		private System.Nullable<int> _MaQuyen;
		
		private EntityRef<NhanVien> _NhanVien;
		
		private EntityRef<PhanQuyen> _PhanQuyen;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaTaiKhoanChanging(int value);
    partial void OnMaTaiKhoanChanged();
    partial void OnTenDangNhapChanging(string value);
    partial void OnTenDangNhapChanged();
    partial void OnMatKhauChanging(string value);
    partial void OnMatKhauChanged();
    partial void OnMaNVChanging(System.Nullable<int> value);
    partial void OnMaNVChanged();
    partial void OnTinhTrangChanging(System.Nullable<bool> value);
    partial void OnTinhTrangChanged();
    partial void OnMaQuyenChanging(System.Nullable<int> value);
    partial void OnMaQuyenChanged();
    #endregion
		
		public TaiKhoan()
		{
			this._NhanVien = default(EntityRef<NhanVien>);
			this._PhanQuyen = default(EntityRef<PhanQuyen>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaTaiKhoan", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaTaiKhoan
		{
			get
			{
				return this._MaTaiKhoan;
			}
			set
			{
				if ((this._MaTaiKhoan != value))
				{
					this.OnMaTaiKhoanChanging(value);
					this.SendPropertyChanging();
					this._MaTaiKhoan = value;
					this.SendPropertyChanged("MaTaiKhoan");
					this.OnMaTaiKhoanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenDangNhap", DbType="NVarChar(100)")]
		public string TenDangNhap
		{
			get
			{
				return this._TenDangNhap;
			}
			set
			{
				if ((this._TenDangNhap != value))
				{
					this.OnTenDangNhapChanging(value);
					this.SendPropertyChanging();
					this._TenDangNhap = value;
					this.SendPropertyChanged("TenDangNhap");
					this.OnTenDangNhapChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MatKhau", DbType="NVarChar(100)")]
		public string MatKhau
		{
			get
			{
				return this._MatKhau;
			}
			set
			{
				if ((this._MatKhau != value))
				{
					this.OnMatKhauChanging(value);
					this.SendPropertyChanging();
					this._MatKhau = value;
					this.SendPropertyChanged("MatKhau");
					this.OnMatKhauChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNV", DbType="Int")]
		public System.Nullable<int> MaNV
		{
			get
			{
				return this._MaNV;
			}
			set
			{
				if ((this._MaNV != value))
				{
					if (this._NhanVien.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaNVChanging(value);
					this.SendPropertyChanging();
					this._MaNV = value;
					this.SendPropertyChanged("MaNV");
					this.OnMaNVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TinhTrang", DbType="Bit")]
		public System.Nullable<bool> TinhTrang
		{
			get
			{
				return this._TinhTrang;
			}
			set
			{
				if ((this._TinhTrang != value))
				{
					this.OnTinhTrangChanging(value);
					this.SendPropertyChanging();
					this._TinhTrang = value;
					this.SendPropertyChanged("TinhTrang");
					this.OnTinhTrangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaQuyen", DbType="Int")]
		public System.Nullable<int> MaQuyen
		{
			get
			{
				return this._MaQuyen;
			}
			set
			{
				if ((this._MaQuyen != value))
				{
					if (this._PhanQuyen.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaQuyenChanging(value);
					this.SendPropertyChanging();
					this._MaQuyen = value;
					this.SendPropertyChanged("MaQuyen");
					this.OnMaQuyenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NhanVien_TaiKhoan", Storage="_NhanVien", ThisKey="MaNV", OtherKey="MaNV", IsForeignKey=true)]
		public NhanVien NhanVien
		{
			get
			{
				return this._NhanVien.Entity;
			}
			set
			{
				NhanVien previousValue = this._NhanVien.Entity;
				if (((previousValue != value) 
							|| (this._NhanVien.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._NhanVien.Entity = null;
						previousValue.TaiKhoans.Remove(this);
					}
					this._NhanVien.Entity = value;
					if ((value != null))
					{
						value.TaiKhoans.Add(this);
						this._MaNV = value.MaNV;
					}
					else
					{
						this._MaNV = default(Nullable<int>);
					}
					this.SendPropertyChanged("NhanVien");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PhanQuyen_TaiKhoan", Storage="_PhanQuyen", ThisKey="MaQuyen", OtherKey="MaQuyen", IsForeignKey=true)]
		public PhanQuyen PhanQuyen
		{
			get
			{
				return this._PhanQuyen.Entity;
			}
			set
			{
				PhanQuyen previousValue = this._PhanQuyen.Entity;
				if (((previousValue != value) 
							|| (this._PhanQuyen.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._PhanQuyen.Entity = null;
						previousValue.TaiKhoans.Remove(this);
					}
					this._PhanQuyen.Entity = value;
					if ((value != null))
					{
						value.TaiKhoans.Add(this);
						this._MaQuyen = value.MaQuyen;
					}
					else
					{
						this._MaQuyen = default(Nullable<int>);
					}
					this.SendPropertyChanged("PhanQuyen");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DatBao")]
	public partial class DatBao : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaDatBao;
		
		private System.Nullable<System.DateTime> _NgayDat;
		
		private System.Nullable<int> _MaKH;
		
		private System.Nullable<int> _MaNV;
		
		private System.Nullable<double> _TongTien;
		
		private System.Nullable<bool> _TinhTrang;
		
		private EntitySet<ChiTietDatBao> _ChiTietDatBaos;
		
		private EntityRef<KhachHang> _KhachHang;
		
		private EntityRef<NhanVien> _NhanVien;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaDatBaoChanging(int value);
    partial void OnMaDatBaoChanged();
    partial void OnNgayDatChanging(System.Nullable<System.DateTime> value);
    partial void OnNgayDatChanged();
    partial void OnMaKHChanging(System.Nullable<int> value);
    partial void OnMaKHChanged();
    partial void OnMaNVChanging(System.Nullable<int> value);
    partial void OnMaNVChanged();
    partial void OnTongTienChanging(System.Nullable<double> value);
    partial void OnTongTienChanged();
    partial void OnTinhTrangChanging(System.Nullable<bool> value);
    partial void OnTinhTrangChanged();
    #endregion
		
		public DatBao()
		{
			this._ChiTietDatBaos = new EntitySet<ChiTietDatBao>(new Action<ChiTietDatBao>(this.attach_ChiTietDatBaos), new Action<ChiTietDatBao>(this.detach_ChiTietDatBaos));
			this._KhachHang = default(EntityRef<KhachHang>);
			this._NhanVien = default(EntityRef<NhanVien>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDatBao", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaDatBao
		{
			get
			{
				return this._MaDatBao;
			}
			set
			{
				if ((this._MaDatBao != value))
				{
					this.OnMaDatBaoChanging(value);
					this.SendPropertyChanging();
					this._MaDatBao = value;
					this.SendPropertyChanged("MaDatBao");
					this.OnMaDatBaoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayDat", DbType="DateTime")]
		public System.Nullable<System.DateTime> NgayDat
		{
			get
			{
				return this._NgayDat;
			}
			set
			{
				if ((this._NgayDat != value))
				{
					this.OnNgayDatChanging(value);
					this.SendPropertyChanging();
					this._NgayDat = value;
					this.SendPropertyChanged("NgayDat");
					this.OnNgayDatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKH", DbType="Int")]
		public System.Nullable<int> MaKH
		{
			get
			{
				return this._MaKH;
			}
			set
			{
				if ((this._MaKH != value))
				{
					if (this._KhachHang.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaKHChanging(value);
					this.SendPropertyChanging();
					this._MaKH = value;
					this.SendPropertyChanged("MaKH");
					this.OnMaKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNV", DbType="Int")]
		public System.Nullable<int> MaNV
		{
			get
			{
				return this._MaNV;
			}
			set
			{
				if ((this._MaNV != value))
				{
					if (this._NhanVien.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaNVChanging(value);
					this.SendPropertyChanging();
					this._MaNV = value;
					this.SendPropertyChanged("MaNV");
					this.OnMaNVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TongTien", DbType="Float")]
		public System.Nullable<double> TongTien
		{
			get
			{
				return this._TongTien;
			}
			set
			{
				if ((this._TongTien != value))
				{
					this.OnTongTienChanging(value);
					this.SendPropertyChanging();
					this._TongTien = value;
					this.SendPropertyChanged("TongTien");
					this.OnTongTienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TinhTrang", DbType="Bit")]
		public System.Nullable<bool> TinhTrang
		{
			get
			{
				return this._TinhTrang;
			}
			set
			{
				if ((this._TinhTrang != value))
				{
					this.OnTinhTrangChanging(value);
					this.SendPropertyChanging();
					this._TinhTrang = value;
					this.SendPropertyChanged("TinhTrang");
					this.OnTinhTrangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DatBao_ChiTietDatBao", Storage="_ChiTietDatBaos", ThisKey="MaDatBao", OtherKey="MaDatBao")]
		public EntitySet<ChiTietDatBao> ChiTietDatBaos
		{
			get
			{
				return this._ChiTietDatBaos;
			}
			set
			{
				this._ChiTietDatBaos.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KhachHang_DatBao", Storage="_KhachHang", ThisKey="MaKH", OtherKey="MaKH", IsForeignKey=true)]
		public KhachHang KhachHang
		{
			get
			{
				return this._KhachHang.Entity;
			}
			set
			{
				KhachHang previousValue = this._KhachHang.Entity;
				if (((previousValue != value) 
							|| (this._KhachHang.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._KhachHang.Entity = null;
						previousValue.DatBaos.Remove(this);
					}
					this._KhachHang.Entity = value;
					if ((value != null))
					{
						value.DatBaos.Add(this);
						this._MaKH = value.MaKH;
					}
					else
					{
						this._MaKH = default(Nullable<int>);
					}
					this.SendPropertyChanged("KhachHang");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NhanVien_DatBao", Storage="_NhanVien", ThisKey="MaNV", OtherKey="MaNV", IsForeignKey=true)]
		public NhanVien NhanVien
		{
			get
			{
				return this._NhanVien.Entity;
			}
			set
			{
				NhanVien previousValue = this._NhanVien.Entity;
				if (((previousValue != value) 
							|| (this._NhanVien.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._NhanVien.Entity = null;
						previousValue.DatBaos.Remove(this);
					}
					this._NhanVien.Entity = value;
					if ((value != null))
					{
						value.DatBaos.Add(this);
						this._MaNV = value.MaNV;
					}
					else
					{
						this._MaNV = default(Nullable<int>);
					}
					this.SendPropertyChanged("NhanVien");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_ChiTietDatBaos(ChiTietDatBao entity)
		{
			this.SendPropertyChanging();
			entity.DatBao = this;
		}
		
		private void detach_ChiTietDatBaos(ChiTietDatBao entity)
		{
			this.SendPropertyChanging();
			entity.DatBao = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.KhachHang")]
	public partial class KhachHang : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaKH;
		
		private string _TenKH;
		
		private string _Email;
		
		private string _DiaChi;
		
		private string _SDT;
		
		private EntitySet<DatBao> _DatBaos;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaKHChanging(int value);
    partial void OnMaKHChanged();
    partial void OnTenKHChanging(string value);
    partial void OnTenKHChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnDiaChiChanging(string value);
    partial void OnDiaChiChanged();
    partial void OnSDTChanging(string value);
    partial void OnSDTChanged();
    #endregion
		
		public KhachHang()
		{
			this._DatBaos = new EntitySet<DatBao>(new Action<DatBao>(this.attach_DatBaos), new Action<DatBao>(this.detach_DatBaos));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKH", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaKH
		{
			get
			{
				return this._MaKH;
			}
			set
			{
				if ((this._MaKH != value))
				{
					this.OnMaKHChanging(value);
					this.SendPropertyChanging();
					this._MaKH = value;
					this.SendPropertyChanged("MaKH");
					this.OnMaKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenKH", DbType="NVarChar(100)")]
		public string TenKH
		{
			get
			{
				return this._TenKH;
			}
			set
			{
				if ((this._TenKH != value))
				{
					this.OnTenKHChanging(value);
					this.SendPropertyChanging();
					this._TenKH = value;
					this.SendPropertyChanged("TenKH");
					this.OnTenKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(100)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiaChi", DbType="NVarChar(100)")]
		public string DiaChi
		{
			get
			{
				return this._DiaChi;
			}
			set
			{
				if ((this._DiaChi != value))
				{
					this.OnDiaChiChanging(value);
					this.SendPropertyChanging();
					this._DiaChi = value;
					this.SendPropertyChanged("DiaChi");
					this.OnDiaChiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SDT", DbType="VarChar(10)")]
		public string SDT
		{
			get
			{
				return this._SDT;
			}
			set
			{
				if ((this._SDT != value))
				{
					this.OnSDTChanging(value);
					this.SendPropertyChanging();
					this._SDT = value;
					this.SendPropertyChanged("SDT");
					this.OnSDTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KhachHang_DatBao", Storage="_DatBaos", ThisKey="MaKH", OtherKey="MaKH")]
		public EntitySet<DatBao> DatBaos
		{
			get
			{
				return this._DatBaos;
			}
			set
			{
				this._DatBaos.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_DatBaos(DatBao entity)
		{
			this.SendPropertyChanging();
			entity.KhachHang = this;
		}
		
		private void detach_DatBaos(DatBao entity)
		{
			this.SendPropertyChanging();
			entity.KhachHang = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LoaiBao")]
	public partial class LoaiBao : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaLoaiBao;
		
		private string _TenLoaiBao;
		
		private System.Nullable<double> _GiaTien;
		
		private EntitySet<ChiTietDatBao> _ChiTietDatBaos;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaLoaiBaoChanging(int value);
    partial void OnMaLoaiBaoChanged();
    partial void OnTenLoaiBaoChanging(string value);
    partial void OnTenLoaiBaoChanged();
    partial void OnGiaTienChanging(System.Nullable<double> value);
    partial void OnGiaTienChanged();
    #endregion
		
		public LoaiBao()
		{
			this._ChiTietDatBaos = new EntitySet<ChiTietDatBao>(new Action<ChiTietDatBao>(this.attach_ChiTietDatBaos), new Action<ChiTietDatBao>(this.detach_ChiTietDatBaos));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaLoaiBao", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaLoaiBao
		{
			get
			{
				return this._MaLoaiBao;
			}
			set
			{
				if ((this._MaLoaiBao != value))
				{
					this.OnMaLoaiBaoChanging(value);
					this.SendPropertyChanging();
					this._MaLoaiBao = value;
					this.SendPropertyChanged("MaLoaiBao");
					this.OnMaLoaiBaoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenLoaiBao", DbType="NVarChar(100)")]
		public string TenLoaiBao
		{
			get
			{
				return this._TenLoaiBao;
			}
			set
			{
				if ((this._TenLoaiBao != value))
				{
					this.OnTenLoaiBaoChanging(value);
					this.SendPropertyChanging();
					this._TenLoaiBao = value;
					this.SendPropertyChanged("TenLoaiBao");
					this.OnTenLoaiBaoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GiaTien", DbType="Float")]
		public System.Nullable<double> GiaTien
		{
			get
			{
				return this._GiaTien;
			}
			set
			{
				if ((this._GiaTien != value))
				{
					this.OnGiaTienChanging(value);
					this.SendPropertyChanging();
					this._GiaTien = value;
					this.SendPropertyChanged("GiaTien");
					this.OnGiaTienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LoaiBao_ChiTietDatBao", Storage="_ChiTietDatBaos", ThisKey="MaLoaiBao", OtherKey="MaLoaiBao")]
		public EntitySet<ChiTietDatBao> ChiTietDatBaos
		{
			get
			{
				return this._ChiTietDatBaos;
			}
			set
			{
				this._ChiTietDatBaos.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_ChiTietDatBaos(ChiTietDatBao entity)
		{
			this.SendPropertyChanging();
			entity.LoaiBao = this;
		}
		
		private void detach_ChiTietDatBaos(ChiTietDatBao entity)
		{
			this.SendPropertyChanging();
			entity.LoaiBao = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NhanVien")]
	public partial class NhanVien : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaNV;
		
		private string _TenNV;
		
		private string _GioiTinh;
		
		private string _DiaChi;
		
		private string _SDT;
		
		private EntitySet<TaiKhoan> _TaiKhoans;
		
		private EntitySet<DatBao> _DatBaos;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaNVChanging(int value);
    partial void OnMaNVChanged();
    partial void OnTenNVChanging(string value);
    partial void OnTenNVChanged();
    partial void OnGioiTinhChanging(string value);
    partial void OnGioiTinhChanged();
    partial void OnDiaChiChanging(string value);
    partial void OnDiaChiChanged();
    partial void OnSDTChanging(string value);
    partial void OnSDTChanged();
    #endregion
		
		public NhanVien()
		{
			this._TaiKhoans = new EntitySet<TaiKhoan>(new Action<TaiKhoan>(this.attach_TaiKhoans), new Action<TaiKhoan>(this.detach_TaiKhoans));
			this._DatBaos = new EntitySet<DatBao>(new Action<DatBao>(this.attach_DatBaos), new Action<DatBao>(this.detach_DatBaos));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNV", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaNV
		{
			get
			{
				return this._MaNV;
			}
			set
			{
				if ((this._MaNV != value))
				{
					this.OnMaNVChanging(value);
					this.SendPropertyChanging();
					this._MaNV = value;
					this.SendPropertyChanged("MaNV");
					this.OnMaNVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenNV", DbType="NVarChar(100)")]
		public string TenNV
		{
			get
			{
				return this._TenNV;
			}
			set
			{
				if ((this._TenNV != value))
				{
					this.OnTenNVChanging(value);
					this.SendPropertyChanging();
					this._TenNV = value;
					this.SendPropertyChanged("TenNV");
					this.OnTenNVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GioiTinh", DbType="NVarChar(5)")]
		public string GioiTinh
		{
			get
			{
				return this._GioiTinh;
			}
			set
			{
				if ((this._GioiTinh != value))
				{
					this.OnGioiTinhChanging(value);
					this.SendPropertyChanging();
					this._GioiTinh = value;
					this.SendPropertyChanged("GioiTinh");
					this.OnGioiTinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiaChi", DbType="NVarChar(100)")]
		public string DiaChi
		{
			get
			{
				return this._DiaChi;
			}
			set
			{
				if ((this._DiaChi != value))
				{
					this.OnDiaChiChanging(value);
					this.SendPropertyChanging();
					this._DiaChi = value;
					this.SendPropertyChanged("DiaChi");
					this.OnDiaChiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SDT", DbType="VarChar(10)")]
		public string SDT
		{
			get
			{
				return this._SDT;
			}
			set
			{
				if ((this._SDT != value))
				{
					this.OnSDTChanging(value);
					this.SendPropertyChanging();
					this._SDT = value;
					this.SendPropertyChanged("SDT");
					this.OnSDTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NhanVien_TaiKhoan", Storage="_TaiKhoans", ThisKey="MaNV", OtherKey="MaNV")]
		public EntitySet<TaiKhoan> TaiKhoans
		{
			get
			{
				return this._TaiKhoans;
			}
			set
			{
				this._TaiKhoans.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NhanVien_DatBao", Storage="_DatBaos", ThisKey="MaNV", OtherKey="MaNV")]
		public EntitySet<DatBao> DatBaos
		{
			get
			{
				return this._DatBaos;
			}
			set
			{
				this._DatBaos.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_TaiKhoans(TaiKhoan entity)
		{
			this.SendPropertyChanging();
			entity.NhanVien = this;
		}
		
		private void detach_TaiKhoans(TaiKhoan entity)
		{
			this.SendPropertyChanging();
			entity.NhanVien = null;
		}
		
		private void attach_DatBaos(DatBao entity)
		{
			this.SendPropertyChanging();
			entity.NhanVien = this;
		}
		
		private void detach_DatBaos(DatBao entity)
		{
			this.SendPropertyChanging();
			entity.NhanVien = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PhanQuyen")]
	public partial class PhanQuyen : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaQuyen;
		
		private string _TenQuyen;
		
		private string _GhiChu;
		
		private EntitySet<TaiKhoan> _TaiKhoans;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaQuyenChanging(int value);
    partial void OnMaQuyenChanged();
    partial void OnTenQuyenChanging(string value);
    partial void OnTenQuyenChanged();
    partial void OnGhiChuChanging(string value);
    partial void OnGhiChuChanged();
    #endregion
		
		public PhanQuyen()
		{
			this._TaiKhoans = new EntitySet<TaiKhoan>(new Action<TaiKhoan>(this.attach_TaiKhoans), new Action<TaiKhoan>(this.detach_TaiKhoans));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaQuyen", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaQuyen
		{
			get
			{
				return this._MaQuyen;
			}
			set
			{
				if ((this._MaQuyen != value))
				{
					this.OnMaQuyenChanging(value);
					this.SendPropertyChanging();
					this._MaQuyen = value;
					this.SendPropertyChanged("MaQuyen");
					this.OnMaQuyenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenQuyen", DbType="NVarChar(100)")]
		public string TenQuyen
		{
			get
			{
				return this._TenQuyen;
			}
			set
			{
				if ((this._TenQuyen != value))
				{
					this.OnTenQuyenChanging(value);
					this.SendPropertyChanging();
					this._TenQuyen = value;
					this.SendPropertyChanged("TenQuyen");
					this.OnTenQuyenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GhiChu", DbType="NVarChar(100)")]
		public string GhiChu
		{
			get
			{
				return this._GhiChu;
			}
			set
			{
				if ((this._GhiChu != value))
				{
					this.OnGhiChuChanging(value);
					this.SendPropertyChanging();
					this._GhiChu = value;
					this.SendPropertyChanged("GhiChu");
					this.OnGhiChuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="PhanQuyen_TaiKhoan", Storage="_TaiKhoans", ThisKey="MaQuyen", OtherKey="MaQuyen")]
		public EntitySet<TaiKhoan> TaiKhoans
		{
			get
			{
				return this._TaiKhoans;
			}
			set
			{
				this._TaiKhoans.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_TaiKhoans(TaiKhoan entity)
		{
			this.SendPropertyChanging();
			entity.PhanQuyen = this;
		}
		
		private void detach_TaiKhoans(TaiKhoan entity)
		{
			this.SendPropertyChanging();
			entity.PhanQuyen = null;
		}
	}
}
#pragma warning restore 1591
