﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HumanResourcesTool.ServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="tblCity", Namespace="http://schemas.datacontract.org/2004/07/WCFResourceHumanServices")]
    [System.SerializableAttribute()]
    public partial class tblCity : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Cit_CityIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Cit_NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Pro_ProvinceIdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Cit_CityId {
            get {
                return this.Cit_CityIdField;
            }
            set {
                if ((this.Cit_CityIdField.Equals(value) != true)) {
                    this.Cit_CityIdField = value;
                    this.RaisePropertyChanged("Cit_CityId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Cit_Name {
            get {
                return this.Cit_NameField;
            }
            set {
                if ((object.ReferenceEquals(this.Cit_NameField, value) != true)) {
                    this.Cit_NameField = value;
                    this.RaisePropertyChanged("Cit_Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Pro_ProvinceId {
            get {
                return this.Pro_ProvinceIdField;
            }
            set {
                if ((this.Pro_ProvinceIdField.Equals(value) != true)) {
                    this.Pro_ProvinceIdField = value;
                    this.RaisePropertyChanged("Pro_ProvinceId");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="tblPosition", Namespace="http://schemas.datacontract.org/2004/07/WCFResourceHumanServices")]
    [System.SerializableAttribute()]
    public partial class tblPosition : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Pos_DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Pos_PositionIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private HumanResourcesTool.ServiceReference.tblEmployee[] tblEmployeesField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Pos_Description {
            get {
                return this.Pos_DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.Pos_DescriptionField, value) != true)) {
                    this.Pos_DescriptionField = value;
                    this.RaisePropertyChanged("Pos_Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Pos_PositionId {
            get {
                return this.Pos_PositionIdField;
            }
            set {
                if ((this.Pos_PositionIdField.Equals(value) != true)) {
                    this.Pos_PositionIdField = value;
                    this.RaisePropertyChanged("Pos_PositionId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HumanResourcesTool.ServiceReference.tblEmployee[] tblEmployees {
            get {
                return this.tblEmployeesField;
            }
            set {
                if ((object.ReferenceEquals(this.tblEmployeesField, value) != true)) {
                    this.tblEmployeesField = value;
                    this.RaisePropertyChanged("tblEmployees");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="tblEmployee", Namespace="http://schemas.datacontract.org/2004/07/WCFResourceHumanServices")]
    [System.SerializableAttribute()]
    public partial class tblEmployee : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Cit_CityIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Dep_DepartmentIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Emp_AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<decimal> Emp_AnualSalaryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime Emp_BirthOfDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Emp_CellPhoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Emp_EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Emp_EmployeeIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Emp_FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Emp_GenderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<decimal> Emp_HourlyRateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Emp_LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Emp_PhoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] Emp_PhotoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Emp_PostalCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime Emp_StartDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime Emp_TerminationDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Pos_PositionIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Tit_TitleIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private HumanResourcesTool.ServiceReference.tblDepartment tblDepartmentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private HumanResourcesTool.ServiceReference.tblPosition tblPositionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private HumanResourcesTool.ServiceReference.tblTitle tblTitleField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Cit_CityId {
            get {
                return this.Cit_CityIdField;
            }
            set {
                if ((this.Cit_CityIdField.Equals(value) != true)) {
                    this.Cit_CityIdField = value;
                    this.RaisePropertyChanged("Cit_CityId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Dep_DepartmentId {
            get {
                return this.Dep_DepartmentIdField;
            }
            set {
                if ((this.Dep_DepartmentIdField.Equals(value) != true)) {
                    this.Dep_DepartmentIdField = value;
                    this.RaisePropertyChanged("Dep_DepartmentId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Emp_Address {
            get {
                return this.Emp_AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.Emp_AddressField, value) != true)) {
                    this.Emp_AddressField = value;
                    this.RaisePropertyChanged("Emp_Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<decimal> Emp_AnualSalary {
            get {
                return this.Emp_AnualSalaryField;
            }
            set {
                if ((this.Emp_AnualSalaryField.Equals(value) != true)) {
                    this.Emp_AnualSalaryField = value;
                    this.RaisePropertyChanged("Emp_AnualSalary");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Emp_BirthOfDate {
            get {
                return this.Emp_BirthOfDateField;
            }
            set {
                if ((this.Emp_BirthOfDateField.Equals(value) != true)) {
                    this.Emp_BirthOfDateField = value;
                    this.RaisePropertyChanged("Emp_BirthOfDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Emp_CellPhone {
            get {
                return this.Emp_CellPhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.Emp_CellPhoneField, value) != true)) {
                    this.Emp_CellPhoneField = value;
                    this.RaisePropertyChanged("Emp_CellPhone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Emp_Email {
            get {
                return this.Emp_EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.Emp_EmailField, value) != true)) {
                    this.Emp_EmailField = value;
                    this.RaisePropertyChanged("Emp_Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Emp_EmployeeId {
            get {
                return this.Emp_EmployeeIdField;
            }
            set {
                if ((this.Emp_EmployeeIdField.Equals(value) != true)) {
                    this.Emp_EmployeeIdField = value;
                    this.RaisePropertyChanged("Emp_EmployeeId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Emp_FirstName {
            get {
                return this.Emp_FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.Emp_FirstNameField, value) != true)) {
                    this.Emp_FirstNameField = value;
                    this.RaisePropertyChanged("Emp_FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Emp_Gender {
            get {
                return this.Emp_GenderField;
            }
            set {
                if ((object.ReferenceEquals(this.Emp_GenderField, value) != true)) {
                    this.Emp_GenderField = value;
                    this.RaisePropertyChanged("Emp_Gender");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<decimal> Emp_HourlyRate {
            get {
                return this.Emp_HourlyRateField;
            }
            set {
                if ((this.Emp_HourlyRateField.Equals(value) != true)) {
                    this.Emp_HourlyRateField = value;
                    this.RaisePropertyChanged("Emp_HourlyRate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Emp_LastName {
            get {
                return this.Emp_LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.Emp_LastNameField, value) != true)) {
                    this.Emp_LastNameField = value;
                    this.RaisePropertyChanged("Emp_LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Emp_Phone {
            get {
                return this.Emp_PhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.Emp_PhoneField, value) != true)) {
                    this.Emp_PhoneField = value;
                    this.RaisePropertyChanged("Emp_Phone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] Emp_Photo {
            get {
                return this.Emp_PhotoField;
            }
            set {
                if ((object.ReferenceEquals(this.Emp_PhotoField, value) != true)) {
                    this.Emp_PhotoField = value;
                    this.RaisePropertyChanged("Emp_Photo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Emp_PostalCode {
            get {
                return this.Emp_PostalCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.Emp_PostalCodeField, value) != true)) {
                    this.Emp_PostalCodeField = value;
                    this.RaisePropertyChanged("Emp_PostalCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Emp_StartDate {
            get {
                return this.Emp_StartDateField;
            }
            set {
                if ((this.Emp_StartDateField.Equals(value) != true)) {
                    this.Emp_StartDateField = value;
                    this.RaisePropertyChanged("Emp_StartDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Emp_TerminationDate {
            get {
                return this.Emp_TerminationDateField;
            }
            set {
                if ((this.Emp_TerminationDateField.Equals(value) != true)) {
                    this.Emp_TerminationDateField = value;
                    this.RaisePropertyChanged("Emp_TerminationDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Pos_PositionId {
            get {
                return this.Pos_PositionIdField;
            }
            set {
                if ((this.Pos_PositionIdField.Equals(value) != true)) {
                    this.Pos_PositionIdField = value;
                    this.RaisePropertyChanged("Pos_PositionId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Tit_TitleId {
            get {
                return this.Tit_TitleIdField;
            }
            set {
                if ((this.Tit_TitleIdField.Equals(value) != true)) {
                    this.Tit_TitleIdField = value;
                    this.RaisePropertyChanged("Tit_TitleId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HumanResourcesTool.ServiceReference.tblDepartment tblDepartment {
            get {
                return this.tblDepartmentField;
            }
            set {
                if ((object.ReferenceEquals(this.tblDepartmentField, value) != true)) {
                    this.tblDepartmentField = value;
                    this.RaisePropertyChanged("tblDepartment");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HumanResourcesTool.ServiceReference.tblPosition tblPosition {
            get {
                return this.tblPositionField;
            }
            set {
                if ((object.ReferenceEquals(this.tblPositionField, value) != true)) {
                    this.tblPositionField = value;
                    this.RaisePropertyChanged("tblPosition");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HumanResourcesTool.ServiceReference.tblTitle tblTitle {
            get {
                return this.tblTitleField;
            }
            set {
                if ((object.ReferenceEquals(this.tblTitleField, value) != true)) {
                    this.tblTitleField = value;
                    this.RaisePropertyChanged("tblTitle");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="tblDepartment", Namespace="http://schemas.datacontract.org/2004/07/WCFResourceHumanServices")]
    [System.SerializableAttribute()]
    public partial class tblDepartment : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Dep_DepartmentIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Dep_NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private HumanResourcesTool.ServiceReference.tblEmployee[] tblEmployeesField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Dep_DepartmentId {
            get {
                return this.Dep_DepartmentIdField;
            }
            set {
                if ((this.Dep_DepartmentIdField.Equals(value) != true)) {
                    this.Dep_DepartmentIdField = value;
                    this.RaisePropertyChanged("Dep_DepartmentId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Dep_Name {
            get {
                return this.Dep_NameField;
            }
            set {
                if ((object.ReferenceEquals(this.Dep_NameField, value) != true)) {
                    this.Dep_NameField = value;
                    this.RaisePropertyChanged("Dep_Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HumanResourcesTool.ServiceReference.tblEmployee[] tblEmployees {
            get {
                return this.tblEmployeesField;
            }
            set {
                if ((object.ReferenceEquals(this.tblEmployeesField, value) != true)) {
                    this.tblEmployeesField = value;
                    this.RaisePropertyChanged("tblEmployees");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="tblTitle", Namespace="http://schemas.datacontract.org/2004/07/WCFResourceHumanServices")]
    [System.SerializableAttribute()]
    public partial class tblTitle : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Tit_NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Tit_TitleIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private HumanResourcesTool.ServiceReference.tblEmployee[] tblEmployeesField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Tit_Name {
            get {
                return this.Tit_NameField;
            }
            set {
                if ((object.ReferenceEquals(this.Tit_NameField, value) != true)) {
                    this.Tit_NameField = value;
                    this.RaisePropertyChanged("Tit_Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Tit_TitleId {
            get {
                return this.Tit_TitleIdField;
            }
            set {
                if ((this.Tit_TitleIdField.Equals(value) != true)) {
                    this.Tit_TitleIdField = value;
                    this.RaisePropertyChanged("Tit_TitleId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HumanResourcesTool.ServiceReference.tblEmployee[] tblEmployees {
            get {
                return this.tblEmployeesField;
            }
            set {
                if ((object.ReferenceEquals(this.tblEmployeesField, value) != true)) {
                    this.tblEmployeesField = value;
                    this.RaisePropertyChanged("tblEmployees");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.HRWebServices")]
    public interface HRWebServices {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HRWebServices/GetCities", ReplyAction="http://tempuri.org/HRWebServices/GetCitiesResponse")]
        HumanResourcesTool.ServiceReference.tblCity[] GetCities();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HRWebServices/GetCities", ReplyAction="http://tempuri.org/HRWebServices/GetCitiesResponse")]
        System.Threading.Tasks.Task<HumanResourcesTool.ServiceReference.tblCity[]> GetCitiesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HRWebServices/GetPositions", ReplyAction="http://tempuri.org/HRWebServices/GetPositionsResponse")]
        HumanResourcesTool.ServiceReference.tblPosition[] GetPositions();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HRWebServices/GetPositions", ReplyAction="http://tempuri.org/HRWebServices/GetPositionsResponse")]
        System.Threading.Tasks.Task<HumanResourcesTool.ServiceReference.tblPosition[]> GetPositionsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HRWebServices/GetDepartments", ReplyAction="http://tempuri.org/HRWebServices/GetDepartmentsResponse")]
        HumanResourcesTool.ServiceReference.tblDepartment[] GetDepartments();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HRWebServices/GetDepartments", ReplyAction="http://tempuri.org/HRWebServices/GetDepartmentsResponse")]
        System.Threading.Tasks.Task<HumanResourcesTool.ServiceReference.tblDepartment[]> GetDepartmentsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface HRWebServicesChannel : HumanResourcesTool.ServiceReference.HRWebServices, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HRWebServicesClient : System.ServiceModel.ClientBase<HumanResourcesTool.ServiceReference.HRWebServices>, HumanResourcesTool.ServiceReference.HRWebServices {
        
        public HRWebServicesClient() {
        }
        
        public HRWebServicesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public HRWebServicesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HRWebServicesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HRWebServicesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public HumanResourcesTool.ServiceReference.tblCity[] GetCities() {
            return base.Channel.GetCities();
        }
        
        public System.Threading.Tasks.Task<HumanResourcesTool.ServiceReference.tblCity[]> GetCitiesAsync() {
            return base.Channel.GetCitiesAsync();
        }
        
        public HumanResourcesTool.ServiceReference.tblPosition[] GetPositions() {
            return base.Channel.GetPositions();
        }
        
        public System.Threading.Tasks.Task<HumanResourcesTool.ServiceReference.tblPosition[]> GetPositionsAsync() {
            return base.Channel.GetPositionsAsync();
        }
        
        public HumanResourcesTool.ServiceReference.tblDepartment[] GetDepartments() {
            return base.Channel.GetDepartments();
        }
        
        public System.Threading.Tasks.Task<HumanResourcesTool.ServiceReference.tblDepartment[]> GetDepartmentsAsync() {
            return base.Channel.GetDepartmentsAsync();
        }
    }
}
