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

namespace Al_Basit_Corporation.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Albbasitcorporation")]
	public partial class detailpumpDataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Inserttblpetroldetail(tblpetroldetail instance);
    partial void Updatetblpetroldetail(tblpetroldetail instance);
    partial void Deletetblpetroldetail(tblpetroldetail instance);
    #endregion
		
		public detailpumpDataClasses1DataContext() : 
				base(global::Al_Basit_Corporation.Properties.Settings.Default.AlbbasitcorporationConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public detailpumpDataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public detailpumpDataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public detailpumpDataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public detailpumpDataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tblpetroldetail> tblpetroldetails
		{
			get
			{
				return this.GetTable<tblpetroldetail>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblpetroldetail")]
	public partial class tblpetroldetail : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _Station_Name;
		
		private string _Owner_Name;
		
		private string _Account_No;
		
		private string _Adress;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnStation_NameChanging(string value);
    partial void OnStation_NameChanged();
    partial void OnOwner_NameChanging(string value);
    partial void OnOwner_NameChanged();
    partial void OnAccount_NoChanging(string value);
    partial void OnAccount_NoChanged();
    partial void OnAdressChanging(string value);
    partial void OnAdressChanged();
    #endregion
		
		public tblpetroldetail()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Station Name]", Storage="_Station_Name", DbType="NVarChar(300)")]
		public string Station_Name
		{
			get
			{
				return this._Station_Name;
			}
			set
			{
				if ((this._Station_Name != value))
				{
					this.OnStation_NameChanging(value);
					this.SendPropertyChanging();
					this._Station_Name = value;
					this.SendPropertyChanged("Station_Name");
					this.OnStation_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Owner Name]", Storage="_Owner_Name", DbType="NVarChar(50)")]
		public string Owner_Name
		{
			get
			{
				return this._Owner_Name;
			}
			set
			{
				if ((this._Owner_Name != value))
				{
					this.OnOwner_NameChanging(value);
					this.SendPropertyChanging();
					this._Owner_Name = value;
					this.SendPropertyChanged("Owner_Name");
					this.OnOwner_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Account No]", Storage="_Account_No", DbType="NVarChar(50)")]
		public string Account_No
		{
			get
			{
				return this._Account_No;
			}
			set
			{
				if ((this._Account_No != value))
				{
					this.OnAccount_NoChanging(value);
					this.SendPropertyChanging();
					this._Account_No = value;
					this.SendPropertyChanged("Account_No");
					this.OnAccount_NoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Adress", DbType="NVarChar(500)")]
		public string Adress
		{
			get
			{
				return this._Adress;
			}
			set
			{
				if ((this._Adress != value))
				{
					this.OnAdressChanging(value);
					this.SendPropertyChanging();
					this._Adress = value;
					this.SendPropertyChanged("Adress");
					this.OnAdressChanged();
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
}
#pragma warning restore 1591
