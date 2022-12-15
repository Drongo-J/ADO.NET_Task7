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

namespace ADO.NET_Task6.DataAccess.SqlServer
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="AirportDb")]
	public partial class AirportDataClassesDataContextDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertFlightType(FlightType instance);
    partial void UpdateFlightType(FlightType instance);
    partial void DeleteFlightType(FlightType instance);
    partial void InsertPilot(Pilot instance);
    partial void UpdatePilot(Pilot instance);
    partial void DeletePilot(Pilot instance);
    partial void InsertSchedule(Schedule instance);
    partial void UpdateSchedule(Schedule instance);
    partial void DeleteSchedule(Schedule instance);
    partial void InsertTicket(Ticket instance);
    partial void UpdateTicket(Ticket instance);
    partial void DeleteTicket(Ticket instance);
    partial void InsertCity(City instance);
    partial void UpdateCity(City instance);
    partial void DeleteCity(City instance);
    partial void InsertAirplane(Airplane instance);
    partial void UpdateAirplane(Airplane instance);
    partial void DeleteAirplane(Airplane instance);
    #endregion
		
		public AirportDataClassesDataContextDataContext() : 
				base(global::ADO.NET_Task6.Properties.Settings.Default.AirportDbConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public AirportDataClassesDataContextDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AirportDataClassesDataContextDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AirportDataClassesDataContextDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AirportDataClassesDataContextDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<FlightType> FlightTypes
		{
			get
			{
				return this.GetTable<FlightType>();
			}
		}
		
		public System.Data.Linq.Table<Pilot> Pilots
		{
			get
			{
				return this.GetTable<Pilot>();
			}
		}
		
		public System.Data.Linq.Table<Schedule> Schedules
		{
			get
			{
				return this.GetTable<Schedule>();
			}
		}
		
		public System.Data.Linq.Table<Ticket> Tickets
		{
			get
			{
				return this.GetTable<Ticket>();
			}
		}
		
		public System.Data.Linq.Table<City> Cities
		{
			get
			{
				return this.GetTable<City>();
			}
		}
		
		public System.Data.Linq.Table<Airplane> Airplanes
		{
			get
			{
				return this.GetTable<Airplane>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.FlightTypes")]
	public partial class FlightType : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Type;
		
		private EntitySet<Ticket> _Tickets;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnTypeChanging(string value);
    partial void OnTypeChanged();
    #endregion
		
		public FlightType()
		{
			this._Tickets = new EntitySet<Ticket>(new Action<Ticket>(this.attach_Tickets), new Action<Ticket>(this.detach_Tickets));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Type", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Type
		{
			get
			{
				return this._Type;
			}
			set
			{
				if ((this._Type != value))
				{
					this.OnTypeChanging(value);
					this.SendPropertyChanging();
					this._Type = value;
					this.SendPropertyChanged("Type");
					this.OnTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="FlightType_Ticket", Storage="_Tickets", ThisKey="Id", OtherKey="FlightTypeId")]
		public EntitySet<Ticket> Tickets
		{
			get
			{
				return this._Tickets;
			}
			set
			{
				this._Tickets.Assign(value);
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
		
		private void attach_Tickets(Ticket entity)
		{
			this.SendPropertyChanging();
			entity.FlightType = this;
		}
		
		private void detach_Tickets(Ticket entity)
		{
			this.SendPropertyChanging();
			entity.FlightType = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Pilots")]
	public partial class Pilot : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private string _Surname;
		
		private EntitySet<Airplane> _Airplanes;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnSurnameChanging(string value);
    partial void OnSurnameChanged();
    #endregion
		
		public Pilot()
		{
			this._Airplanes = new EntitySet<Airplane>(new Action<Airplane>(this.attach_Airplanes), new Action<Airplane>(this.detach_Airplanes));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Surname", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Surname
		{
			get
			{
				return this._Surname;
			}
			set
			{
				if ((this._Surname != value))
				{
					this.OnSurnameChanging(value);
					this.SendPropertyChanging();
					this._Surname = value;
					this.SendPropertyChanged("Surname");
					this.OnSurnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Pilot_Airplane", Storage="_Airplanes", ThisKey="Id", OtherKey="PilotId")]
		public EntitySet<Airplane> Airplanes
		{
			get
			{
				return this._Airplanes;
			}
			set
			{
				this._Airplanes.Assign(value);
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
		
		private void attach_Airplanes(Airplane entity)
		{
			this.SendPropertyChanging();
			entity.Pilot = this;
		}
		
		private void detach_Airplanes(Airplane entity)
		{
			this.SendPropertyChanging();
			entity.Pilot = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Schedules")]
	public partial class Schedule : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.DateTime _StartDateTime;
		
		private EntitySet<Ticket> _Tickets;
		
		private EntitySet<City> _Cities;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnStartDateTimeChanging(System.DateTime value);
    partial void OnStartDateTimeChanged();
    #endregion
		
		public Schedule()
		{
			this._Tickets = new EntitySet<Ticket>(new Action<Ticket>(this.attach_Tickets), new Action<Ticket>(this.detach_Tickets));
			this._Cities = new EntitySet<City>(new Action<City>(this.attach_Cities), new Action<City>(this.detach_Cities));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StartDateTime", DbType="DateTime NOT NULL")]
		public System.DateTime StartDateTime
		{
			get
			{
				return this._StartDateTime;
			}
			set
			{
				if ((this._StartDateTime != value))
				{
					this.OnStartDateTimeChanging(value);
					this.SendPropertyChanging();
					this._StartDateTime = value;
					this.SendPropertyChanged("StartDateTime");
					this.OnStartDateTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Schedule_Ticket", Storage="_Tickets", ThisKey="Id", OtherKey="ScheduleId")]
		public EntitySet<Ticket> Tickets
		{
			get
			{
				return this._Tickets;
			}
			set
			{
				this._Tickets.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Schedule_City", Storage="_Cities", ThisKey="Id", OtherKey="ScheduleId")]
		public EntitySet<City> Cities
		{
			get
			{
				return this._Cities;
			}
			set
			{
				this._Cities.Assign(value);
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
		
		private void attach_Tickets(Ticket entity)
		{
			this.SendPropertyChanging();
			entity.Schedule = this;
		}
		
		private void detach_Tickets(Ticket entity)
		{
			this.SendPropertyChanging();
			entity.Schedule = null;
		}
		
		private void attach_Cities(City entity)
		{
			this.SendPropertyChanging();
			entity.Schedule = this;
		}
		
		private void detach_Cities(City entity)
		{
			this.SendPropertyChanging();
			entity.Schedule = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Tickets")]
	public partial class Ticket : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private int _CityId;
		
		private int _AirplaneId;
		
		private int _ScheduleId;
		
		private int _FlightTypeId;
		
		private EntityRef<FlightType> _FlightType;
		
		private EntityRef<Schedule> _Schedule;
		
		private EntityRef<City> _City;
		
		private EntityRef<Airplane> _Airplane;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnCityIdChanging(int value);
    partial void OnCityIdChanged();
    partial void OnAirplaneIdChanging(int value);
    partial void OnAirplaneIdChanged();
    partial void OnScheduleIdChanging(int value);
    partial void OnScheduleIdChanged();
    partial void OnFlightTypeIdChanging(int value);
    partial void OnFlightTypeIdChanged();
    #endregion
		
		public Ticket()
		{
			this._FlightType = default(EntityRef<FlightType>);
			this._Schedule = default(EntityRef<Schedule>);
			this._City = default(EntityRef<City>);
			this._Airplane = default(EntityRef<Airplane>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CityId", DbType="Int NOT NULL")]
		public int CityId
		{
			get
			{
				return this._CityId;
			}
			set
			{
				if ((this._CityId != value))
				{
					if (this._City.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCityIdChanging(value);
					this.SendPropertyChanging();
					this._CityId = value;
					this.SendPropertyChanged("CityId");
					this.OnCityIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AirplaneId", DbType="Int NOT NULL")]
		public int AirplaneId
		{
			get
			{
				return this._AirplaneId;
			}
			set
			{
				if ((this._AirplaneId != value))
				{
					if (this._Airplane.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnAirplaneIdChanging(value);
					this.SendPropertyChanging();
					this._AirplaneId = value;
					this.SendPropertyChanged("AirplaneId");
					this.OnAirplaneIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ScheduleId", DbType="Int NOT NULL")]
		public int ScheduleId
		{
			get
			{
				return this._ScheduleId;
			}
			set
			{
				if ((this._ScheduleId != value))
				{
					if (this._Schedule.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnScheduleIdChanging(value);
					this.SendPropertyChanging();
					this._ScheduleId = value;
					this.SendPropertyChanged("ScheduleId");
					this.OnScheduleIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FlightTypeId", DbType="Int NOT NULL")]
		public int FlightTypeId
		{
			get
			{
				return this._FlightTypeId;
			}
			set
			{
				if ((this._FlightTypeId != value))
				{
					if (this._FlightType.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnFlightTypeIdChanging(value);
					this.SendPropertyChanging();
					this._FlightTypeId = value;
					this.SendPropertyChanged("FlightTypeId");
					this.OnFlightTypeIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="FlightType_Ticket", Storage="_FlightType", ThisKey="FlightTypeId", OtherKey="Id", IsForeignKey=true)]
		public FlightType FlightType
		{
			get
			{
				return this._FlightType.Entity;
			}
			set
			{
				FlightType previousValue = this._FlightType.Entity;
				if (((previousValue != value) 
							|| (this._FlightType.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._FlightType.Entity = null;
						previousValue.Tickets.Remove(this);
					}
					this._FlightType.Entity = value;
					if ((value != null))
					{
						value.Tickets.Add(this);
						this._FlightTypeId = value.Id;
					}
					else
					{
						this._FlightTypeId = default(int);
					}
					this.SendPropertyChanged("FlightType");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Schedule_Ticket", Storage="_Schedule", ThisKey="ScheduleId", OtherKey="Id", IsForeignKey=true)]
		public Schedule Schedule
		{
			get
			{
				return this._Schedule.Entity;
			}
			set
			{
				Schedule previousValue = this._Schedule.Entity;
				if (((previousValue != value) 
							|| (this._Schedule.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Schedule.Entity = null;
						previousValue.Tickets.Remove(this);
					}
					this._Schedule.Entity = value;
					if ((value != null))
					{
						value.Tickets.Add(this);
						this._ScheduleId = value.Id;
					}
					else
					{
						this._ScheduleId = default(int);
					}
					this.SendPropertyChanged("Schedule");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="City_Ticket", Storage="_City", ThisKey="CityId", OtherKey="Id", IsForeignKey=true)]
		public City City
		{
			get
			{
				return this._City.Entity;
			}
			set
			{
				City previousValue = this._City.Entity;
				if (((previousValue != value) 
							|| (this._City.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._City.Entity = null;
						previousValue.Tickets.Remove(this);
					}
					this._City.Entity = value;
					if ((value != null))
					{
						value.Tickets.Add(this);
						this._CityId = value.Id;
					}
					else
					{
						this._CityId = default(int);
					}
					this.SendPropertyChanged("City");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Airplane_Ticket", Storage="_Airplane", ThisKey="AirplaneId", OtherKey="Id", IsForeignKey=true)]
		public Airplane Airplane
		{
			get
			{
				return this._Airplane.Entity;
			}
			set
			{
				Airplane previousValue = this._Airplane.Entity;
				if (((previousValue != value) 
							|| (this._Airplane.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Airplane.Entity = null;
						previousValue.Tickets.Remove(this);
					}
					this._Airplane.Entity = value;
					if ((value != null))
					{
						value.Tickets.Add(this);
						this._AirplaneId = value.Id;
					}
					else
					{
						this._AirplaneId = default(int);
					}
					this.SendPropertyChanged("Airplane");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Cities")]
	public partial class City : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private int _AirplaneId;
		
		private int _ScheduleId;
		
		private EntitySet<Ticket> _Tickets;
		
		private EntityRef<Schedule> _Schedule;
		
		private EntityRef<Airplane> _Airplane;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnAirplaneIdChanging(int value);
    partial void OnAirplaneIdChanged();
    partial void OnScheduleIdChanging(int value);
    partial void OnScheduleIdChanged();
    #endregion
		
		public City()
		{
			this._Tickets = new EntitySet<Ticket>(new Action<Ticket>(this.attach_Tickets), new Action<Ticket>(this.detach_Tickets));
			this._Schedule = default(EntityRef<Schedule>);
			this._Airplane = default(EntityRef<Airplane>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AirplaneId", DbType="Int NOT NULL")]
		public int AirplaneId
		{
			get
			{
				return this._AirplaneId;
			}
			set
			{
				if ((this._AirplaneId != value))
				{
					if (this._Airplane.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnAirplaneIdChanging(value);
					this.SendPropertyChanging();
					this._AirplaneId = value;
					this.SendPropertyChanged("AirplaneId");
					this.OnAirplaneIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ScheduleId", DbType="Int NOT NULL")]
		public int ScheduleId
		{
			get
			{
				return this._ScheduleId;
			}
			set
			{
				if ((this._ScheduleId != value))
				{
					if (this._Schedule.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnScheduleIdChanging(value);
					this.SendPropertyChanging();
					this._ScheduleId = value;
					this.SendPropertyChanged("ScheduleId");
					this.OnScheduleIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="City_Ticket", Storage="_Tickets", ThisKey="Id", OtherKey="CityId")]
		public EntitySet<Ticket> Tickets
		{
			get
			{
				return this._Tickets;
			}
			set
			{
				this._Tickets.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Schedule_City", Storage="_Schedule", ThisKey="ScheduleId", OtherKey="Id", IsForeignKey=true)]
		public Schedule Schedule
		{
			get
			{
				return this._Schedule.Entity;
			}
			set
			{
				Schedule previousValue = this._Schedule.Entity;
				if (((previousValue != value) 
							|| (this._Schedule.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Schedule.Entity = null;
						previousValue.Cities.Remove(this);
					}
					this._Schedule.Entity = value;
					if ((value != null))
					{
						value.Cities.Add(this);
						this._ScheduleId = value.Id;
					}
					else
					{
						this._ScheduleId = default(int);
					}
					this.SendPropertyChanged("Schedule");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Airplane_City", Storage="_Airplane", ThisKey="AirplaneId", OtherKey="Id", IsForeignKey=true)]
		public Airplane Airplane
		{
			get
			{
				return this._Airplane.Entity;
			}
			set
			{
				Airplane previousValue = this._Airplane.Entity;
				if (((previousValue != value) 
							|| (this._Airplane.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Airplane.Entity = null;
						previousValue.Cities.Remove(this);
					}
					this._Airplane.Entity = value;
					if ((value != null))
					{
						value.Cities.Add(this);
						this._AirplaneId = value.Id;
					}
					else
					{
						this._AirplaneId = default(int);
					}
					this.SendPropertyChanged("Airplane");
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
		
		private void attach_Tickets(Ticket entity)
		{
			this.SendPropertyChanging();
			entity.City = this;
		}
		
		private void detach_Tickets(Ticket entity)
		{
			this.SendPropertyChanging();
			entity.City = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Airplanes")]
	public partial class Airplane : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private int _PassengerCount;
		
		private System.Nullable<int> _PilotId;
		
		private EntitySet<Ticket> _Tickets;
		
		private EntitySet<City> _Cities;
		
		private EntityRef<Pilot> _Pilot;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnPassengerCountChanging(int value);
    partial void OnPassengerCountChanged();
    partial void OnPilotIdChanging(System.Nullable<int> value);
    partial void OnPilotIdChanged();
    #endregion
		
		public Airplane()
		{
			this._Tickets = new EntitySet<Ticket>(new Action<Ticket>(this.attach_Tickets), new Action<Ticket>(this.detach_Tickets));
			this._Cities = new EntitySet<City>(new Action<City>(this.attach_Cities), new Action<City>(this.detach_Cities));
			this._Pilot = default(EntityRef<Pilot>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PassengerCount", DbType="Int NOT NULL")]
		public int PassengerCount
		{
			get
			{
				return this._PassengerCount;
			}
			set
			{
				if ((this._PassengerCount != value))
				{
					this.OnPassengerCountChanging(value);
					this.SendPropertyChanging();
					this._PassengerCount = value;
					this.SendPropertyChanged("PassengerCount");
					this.OnPassengerCountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PilotId", DbType="Int")]
		public System.Nullable<int> PilotId
		{
			get
			{
				return this._PilotId;
			}
			set
			{
				if ((this._PilotId != value))
				{
					if (this._Pilot.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnPilotIdChanging(value);
					this.SendPropertyChanging();
					this._PilotId = value;
					this.SendPropertyChanged("PilotId");
					this.OnPilotIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Airplane_Ticket", Storage="_Tickets", ThisKey="Id", OtherKey="AirplaneId")]
		public EntitySet<Ticket> Tickets
		{
			get
			{
				return this._Tickets;
			}
			set
			{
				this._Tickets.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Airplane_City", Storage="_Cities", ThisKey="Id", OtherKey="AirplaneId")]
		public EntitySet<City> Cities
		{
			get
			{
				return this._Cities;
			}
			set
			{
				this._Cities.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Pilot_Airplane", Storage="_Pilot", ThisKey="PilotId", OtherKey="Id", IsForeignKey=true)]
		public Pilot Pilot
		{
			get
			{
				return this._Pilot.Entity;
			}
			set
			{
				Pilot previousValue = this._Pilot.Entity;
				if (((previousValue != value) 
							|| (this._Pilot.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Pilot.Entity = null;
						previousValue.Airplanes.Remove(this);
					}
					this._Pilot.Entity = value;
					if ((value != null))
					{
						value.Airplanes.Add(this);
						this._PilotId = value.Id;
					}
					else
					{
						this._PilotId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Pilot");
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
		
		private void attach_Tickets(Ticket entity)
		{
			this.SendPropertyChanging();
			entity.Airplane = this;
		}
		
		private void detach_Tickets(Ticket entity)
		{
			this.SendPropertyChanging();
			entity.Airplane = null;
		}
		
		private void attach_Cities(City entity)
		{
			this.SendPropertyChanging();
			entity.Airplane = this;
		}
		
		private void detach_Cities(City entity)
		{
			this.SendPropertyChanging();
			entity.Airplane = null;
		}
	}
}
#pragma warning restore 1591