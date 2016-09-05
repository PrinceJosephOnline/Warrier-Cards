﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WarrierCards.Website.SecurityService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LoginInfo", Namespace="http://schemas.datacontract.org/2004/07/WarrierCards.Service.DataObjects.Account")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(WarrierCards.Website.SecurityService.UserInfo))]
    public partial class LoginInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
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
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="UserInfo", Namespace="http://schemas.datacontract.org/2004/07/WarrierCards.Service.DataObjects.Account")]
    [System.SerializableAttribute()]
    public partial class UserInfo : WarrierCards.Website.SecurityService.LoginInfo {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CountryCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UserIdField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CountryCode {
            get {
                return this.CountryCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.CountryCodeField, value) != true)) {
                    this.CountryCodeField = value;
                    this.RaisePropertyChanged("CountryCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Phone {
            get {
                return this.PhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneField, value) != true)) {
                    this.PhoneField = value;
                    this.RaisePropertyChanged("Phone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UserId {
            get {
                return this.UserIdField;
            }
            set {
                if ((this.UserIdField.Equals(value) != true)) {
                    this.UserIdField = value;
                    this.RaisePropertyChanged("UserId");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ShippingAddress", Namespace="http://schemas.datacontract.org/2004/07/WarrierCards.Service.DataObjects.Account")]
    [System.SerializableAttribute()]
    public partial class ShippingAddress : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AddressIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CountryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FullAddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LandmarkField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MobileField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PincodeField;
        
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
        public int AddressId {
            get {
                return this.AddressIdField;
            }
            set {
                if ((this.AddressIdField.Equals(value) != true)) {
                    this.AddressIdField = value;
                    this.RaisePropertyChanged("AddressId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Country {
            get {
                return this.CountryField;
            }
            set {
                if ((object.ReferenceEquals(this.CountryField, value) != true)) {
                    this.CountryField = value;
                    this.RaisePropertyChanged("Country");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FullAddress {
            get {
                return this.FullAddressField;
            }
            set {
                if ((object.ReferenceEquals(this.FullAddressField, value) != true)) {
                    this.FullAddressField = value;
                    this.RaisePropertyChanged("FullAddress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Landmark {
            get {
                return this.LandmarkField;
            }
            set {
                if ((object.ReferenceEquals(this.LandmarkField, value) != true)) {
                    this.LandmarkField = value;
                    this.RaisePropertyChanged("Landmark");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Mobile {
            get {
                return this.MobileField;
            }
            set {
                if ((object.ReferenceEquals(this.MobileField, value) != true)) {
                    this.MobileField = value;
                    this.RaisePropertyChanged("Mobile");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Pincode {
            get {
                return this.PincodeField;
            }
            set {
                if ((object.ReferenceEquals(this.PincodeField, value) != true)) {
                    this.PincodeField = value;
                    this.RaisePropertyChanged("Pincode");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SecurityService.ISecurityService")]
    public interface ISecurityService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISecurityService/CheckLogin", ReplyAction="http://tempuri.org/ISecurityService/CheckLoginResponse")]
        int CheckLogin(WarrierCards.Website.SecurityService.LoginInfo loginInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISecurityService/CheckLogin", ReplyAction="http://tempuri.org/ISecurityService/CheckLoginResponse")]
        System.Threading.Tasks.Task<int> CheckLoginAsync(WarrierCards.Website.SecurityService.LoginInfo loginInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISecurityService/Register", ReplyAction="http://tempuri.org/ISecurityService/RegisterResponse")]
        int Register(WarrierCards.Website.SecurityService.UserInfo userInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISecurityService/Register", ReplyAction="http://tempuri.org/ISecurityService/RegisterResponse")]
        System.Threading.Tasks.Task<int> RegisterAsync(WarrierCards.Website.SecurityService.UserInfo userInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISecurityService/GetShippingAddressesByUserId", ReplyAction="http://tempuri.org/ISecurityService/GetShippingAddressesByUserIdResponse")]
        System.Collections.Generic.List<WarrierCards.Website.SecurityService.ShippingAddress> GetShippingAddressesByUserId(int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISecurityService/GetShippingAddressesByUserId", ReplyAction="http://tempuri.org/ISecurityService/GetShippingAddressesByUserIdResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<WarrierCards.Website.SecurityService.ShippingAddress>> GetShippingAddressesByUserIdAsync(int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISecurityService/SaveShippingAddress", ReplyAction="http://tempuri.org/ISecurityService/SaveShippingAddressResponse")]
        bool SaveShippingAddress(WarrierCards.Website.SecurityService.ShippingAddress address);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISecurityService/SaveShippingAddress", ReplyAction="http://tempuri.org/ISecurityService/SaveShippingAddressResponse")]
        System.Threading.Tasks.Task<bool> SaveShippingAddressAsync(WarrierCards.Website.SecurityService.ShippingAddress address);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISecurityService/SendPasswordResetEmail", ReplyAction="http://tempuri.org/ISecurityService/SendPasswordResetEmailResponse")]
        bool SendPasswordResetEmail(string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISecurityService/SendPasswordResetEmail", ReplyAction="http://tempuri.org/ISecurityService/SendPasswordResetEmailResponse")]
        System.Threading.Tasks.Task<bool> SendPasswordResetEmailAsync(string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISecurityService/ValidateChangePasswordToken", ReplyAction="http://tempuri.org/ISecurityService/ValidateChangePasswordTokenResponse")]
        bool ValidateChangePasswordToken(string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISecurityService/ValidateChangePasswordToken", ReplyAction="http://tempuri.org/ISecurityService/ValidateChangePasswordTokenResponse")]
        System.Threading.Tasks.Task<bool> ValidateChangePasswordTokenAsync(string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISecurityService/ChangePassword", ReplyAction="http://tempuri.org/ISecurityService/ChangePasswordResponse")]
        bool ChangePassword(string token, string newPassword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISecurityService/ChangePassword", ReplyAction="http://tempuri.org/ISecurityService/ChangePasswordResponse")]
        System.Threading.Tasks.Task<bool> ChangePasswordAsync(string token, string newPassword);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISecurityServiceChannel : WarrierCards.Website.SecurityService.ISecurityService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SecurityServiceClient : System.ServiceModel.ClientBase<WarrierCards.Website.SecurityService.ISecurityService>, WarrierCards.Website.SecurityService.ISecurityService {
        
        public SecurityServiceClient() {
        }
        
        public SecurityServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SecurityServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SecurityServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SecurityServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int CheckLogin(WarrierCards.Website.SecurityService.LoginInfo loginInfo) {
            return base.Channel.CheckLogin(loginInfo);
        }
        
        public System.Threading.Tasks.Task<int> CheckLoginAsync(WarrierCards.Website.SecurityService.LoginInfo loginInfo) {
            return base.Channel.CheckLoginAsync(loginInfo);
        }
        
        public int Register(WarrierCards.Website.SecurityService.UserInfo userInfo) {
            return base.Channel.Register(userInfo);
        }
        
        public System.Threading.Tasks.Task<int> RegisterAsync(WarrierCards.Website.SecurityService.UserInfo userInfo) {
            return base.Channel.RegisterAsync(userInfo);
        }
        
        public System.Collections.Generic.List<WarrierCards.Website.SecurityService.ShippingAddress> GetShippingAddressesByUserId(int userId) {
            return base.Channel.GetShippingAddressesByUserId(userId);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<WarrierCards.Website.SecurityService.ShippingAddress>> GetShippingAddressesByUserIdAsync(int userId) {
            return base.Channel.GetShippingAddressesByUserIdAsync(userId);
        }
        
        public bool SaveShippingAddress(WarrierCards.Website.SecurityService.ShippingAddress address) {
            return base.Channel.SaveShippingAddress(address);
        }
        
        public System.Threading.Tasks.Task<bool> SaveShippingAddressAsync(WarrierCards.Website.SecurityService.ShippingAddress address) {
            return base.Channel.SaveShippingAddressAsync(address);
        }
        
        public bool SendPasswordResetEmail(string email) {
            return base.Channel.SendPasswordResetEmail(email);
        }
        
        public System.Threading.Tasks.Task<bool> SendPasswordResetEmailAsync(string email) {
            return base.Channel.SendPasswordResetEmailAsync(email);
        }
        
        public bool ValidateChangePasswordToken(string token) {
            return base.Channel.ValidateChangePasswordToken(token);
        }
        
        public System.Threading.Tasks.Task<bool> ValidateChangePasswordTokenAsync(string token) {
            return base.Channel.ValidateChangePasswordTokenAsync(token);
        }
        
        public bool ChangePassword(string token, string newPassword) {
            return base.Channel.ChangePassword(token, newPassword);
        }
        
        public System.Threading.Tasks.Task<bool> ChangePasswordAsync(string token, string newPassword) {
            return base.Channel.ChangePasswordAsync(token, newPassword);
        }
    }
}