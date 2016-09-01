﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WarrierCards.Website.CatalogueService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SearchCriteria", Namespace="http://schemas.datacontract.org/2004/07/WarrierCards.Service.DataObjects")]
    [System.SerializableAttribute()]
    public partial class SearchCriteria : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<string> CardColorsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WarrierCards.Website.CatalogueService.CardTypes CardTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal HighPriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ItemsReturnedPerRequestField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string KeywordsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int LastItemIndexField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal LowPriceField;
        
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
        public System.Collections.Generic.List<string> CardColors {
            get {
                return this.CardColorsField;
            }
            set {
                if ((object.ReferenceEquals(this.CardColorsField, value) != true)) {
                    this.CardColorsField = value;
                    this.RaisePropertyChanged("CardColors");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WarrierCards.Website.CatalogueService.CardTypes CardType {
            get {
                return this.CardTypeField;
            }
            set {
                if ((this.CardTypeField.Equals(value) != true)) {
                    this.CardTypeField = value;
                    this.RaisePropertyChanged("CardType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal HighPrice {
            get {
                return this.HighPriceField;
            }
            set {
                if ((this.HighPriceField.Equals(value) != true)) {
                    this.HighPriceField = value;
                    this.RaisePropertyChanged("HighPrice");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ItemsReturnedPerRequest {
            get {
                return this.ItemsReturnedPerRequestField;
            }
            set {
                if ((this.ItemsReturnedPerRequestField.Equals(value) != true)) {
                    this.ItemsReturnedPerRequestField = value;
                    this.RaisePropertyChanged("ItemsReturnedPerRequest");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Keywords {
            get {
                return this.KeywordsField;
            }
            set {
                if ((object.ReferenceEquals(this.KeywordsField, value) != true)) {
                    this.KeywordsField = value;
                    this.RaisePropertyChanged("Keywords");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int LastItemIndex {
            get {
                return this.LastItemIndexField;
            }
            set {
                if ((this.LastItemIndexField.Equals(value) != true)) {
                    this.LastItemIndexField = value;
                    this.RaisePropertyChanged("LastItemIndex");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal LowPrice {
            get {
                return this.LowPriceField;
            }
            set {
                if ((this.LowPriceField.Equals(value) != true)) {
                    this.LowPriceField = value;
                    this.RaisePropertyChanged("LowPrice");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CardTypes", Namespace="http://schemas.datacontract.org/2004/07/WarrierCards.Service.DataObjects.Common")]
    public enum CardTypes : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        AllWeddingCard = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        HinduWeddingCard = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ChristianWeddingCard = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        MuslimWeddingCard = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        GeneralInvitationCard = 4,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CardBasicInfo", Namespace="http://schemas.datacontract.org/2004/07/WarrierCards.Service.DataObjects")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(WarrierCards.Website.CatalogueService.CardDetails))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(WarrierCards.Website.CatalogueService.CardQuickViewData))]
    public partial class CardBasicInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CardIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CardMainImagePathField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CardModelNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CardNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal CardOrginalPriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal CardSellingPriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsPortraitField;
        
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
        public int CardId {
            get {
                return this.CardIdField;
            }
            set {
                if ((this.CardIdField.Equals(value) != true)) {
                    this.CardIdField = value;
                    this.RaisePropertyChanged("CardId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CardMainImagePath {
            get {
                return this.CardMainImagePathField;
            }
            set {
                if ((object.ReferenceEquals(this.CardMainImagePathField, value) != true)) {
                    this.CardMainImagePathField = value;
                    this.RaisePropertyChanged("CardMainImagePath");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CardModelNumber {
            get {
                return this.CardModelNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.CardModelNumberField, value) != true)) {
                    this.CardModelNumberField = value;
                    this.RaisePropertyChanged("CardModelNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CardName {
            get {
                return this.CardNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CardNameField, value) != true)) {
                    this.CardNameField = value;
                    this.RaisePropertyChanged("CardName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal CardOrginalPrice {
            get {
                return this.CardOrginalPriceField;
            }
            set {
                if ((this.CardOrginalPriceField.Equals(value) != true)) {
                    this.CardOrginalPriceField = value;
                    this.RaisePropertyChanged("CardOrginalPrice");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal CardSellingPrice {
            get {
                return this.CardSellingPriceField;
            }
            set {
                if ((this.CardSellingPriceField.Equals(value) != true)) {
                    this.CardSellingPriceField = value;
                    this.RaisePropertyChanged("CardSellingPrice");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsPortrait {
            get {
                return this.IsPortraitField;
            }
            set {
                if ((this.IsPortraitField.Equals(value) != true)) {
                    this.IsPortraitField = value;
                    this.RaisePropertyChanged("IsPortrait");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CardDetails", Namespace="http://schemas.datacontract.org/2004/07/WarrierCards.Service.DataObjects")]
    [System.SerializableAttribute()]
    public partial class CardDetails : WarrierCards.Website.CatalogueService.CardBasicInfo {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<string> CardImagesField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<string> CardImages {
            get {
                return this.CardImagesField;
            }
            set {
                if ((object.ReferenceEquals(this.CardImagesField, value) != true)) {
                    this.CardImagesField = value;
                    this.RaisePropertyChanged("CardImages");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CardQuickViewData", Namespace="http://schemas.datacontract.org/2004/07/WarrierCards.Service.DataObjects")]
    [System.SerializableAttribute()]
    public partial class CardQuickViewData : WarrierCards.Website.CatalogueService.CardBasicInfo {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<string> CardImagesField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<string> CardImages {
            get {
                return this.CardImagesField;
            }
            set {
                if ((object.ReferenceEquals(this.CardImagesField, value) != true)) {
                    this.CardImagesField = value;
                    this.RaisePropertyChanged("CardImages");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SelectedCard", Namespace="http://schemas.datacontract.org/2004/07/WarrierCards.Service.DataObjects")]
    [System.SerializableAttribute()]
    public partial class SelectedCard : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CardIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int QuantityField;
        
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
        public int CardId {
            get {
                return this.CardIdField;
            }
            set {
                if ((this.CardIdField.Equals(value) != true)) {
                    this.CardIdField = value;
                    this.RaisePropertyChanged("CardId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Quantity {
            get {
                return this.QuantityField;
            }
            set {
                if ((this.QuantityField.Equals(value) != true)) {
                    this.QuantityField = value;
                    this.RaisePropertyChanged("Quantity");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="SelectedCardInfo", Namespace="http://schemas.datacontract.org/2004/07/WarrierCards.Service.DataObjects")]
    [System.SerializableAttribute()]
    public partial class SelectedCardInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WarrierCards.Website.CatalogueService.CardBasicInfo CardField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int QuantityField;
        
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
        public WarrierCards.Website.CatalogueService.CardBasicInfo Card {
            get {
                return this.CardField;
            }
            set {
                if ((object.ReferenceEquals(this.CardField, value) != true)) {
                    this.CardField = value;
                    this.RaisePropertyChanged("Card");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Quantity {
            get {
                return this.QuantityField;
            }
            set {
                if ((this.QuantityField.Equals(value) != true)) {
                    this.QuantityField = value;
                    this.RaisePropertyChanged("Quantity");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="EnquiryData", Namespace="http://schemas.datacontract.org/2004/07/WarrierCards.Service.DataObjects")]
    [System.SerializableAttribute()]
    public partial class EnquiryData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CardIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string QueryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> UserIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WarrierCards.Website.CatalogueService.UserData UserInfoField;
        
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
        public int CardId {
            get {
                return this.CardIdField;
            }
            set {
                if ((this.CardIdField.Equals(value) != true)) {
                    this.CardIdField = value;
                    this.RaisePropertyChanged("CardId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Query {
            get {
                return this.QueryField;
            }
            set {
                if ((object.ReferenceEquals(this.QueryField, value) != true)) {
                    this.QueryField = value;
                    this.RaisePropertyChanged("Query");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> UserId {
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WarrierCards.Website.CatalogueService.UserData UserInfo {
            get {
                return this.UserInfoField;
            }
            set {
                if ((object.ReferenceEquals(this.UserInfoField, value) != true)) {
                    this.UserInfoField = value;
                    this.RaisePropertyChanged("UserInfo");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="UserData", Namespace="http://schemas.datacontract.org/2004/07/WarrierCards.Service.DataObjects")]
    [System.SerializableAttribute()]
    public partial class UserData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CountryCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UserIdField;
        
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
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CatalogueService.ICatalogueService")]
    public interface ICatalogueService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICatalogueService/GetCardsList", ReplyAction="http://tempuri.org/ICatalogueService/GetCardsListResponse")]
        System.Collections.Generic.List<WarrierCards.Website.CatalogueService.CardBasicInfo> GetCardsList(WarrierCards.Website.CatalogueService.SearchCriteria searchCriteria);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICatalogueService/GetCardsList", ReplyAction="http://tempuri.org/ICatalogueService/GetCardsListResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<WarrierCards.Website.CatalogueService.CardBasicInfo>> GetCardsListAsync(WarrierCards.Website.CatalogueService.SearchCriteria searchCriteria);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICatalogueService/GetCardDetailsById", ReplyAction="http://tempuri.org/ICatalogueService/GetCardDetailsByIdResponse")]
        WarrierCards.Website.CatalogueService.CardDetails GetCardDetailsById(int cardId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICatalogueService/GetCardDetailsById", ReplyAction="http://tempuri.org/ICatalogueService/GetCardDetailsByIdResponse")]
        System.Threading.Tasks.Task<WarrierCards.Website.CatalogueService.CardDetails> GetCardDetailsByIdAsync(int cardId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICatalogueService/GetCardQuickViewData", ReplyAction="http://tempuri.org/ICatalogueService/GetCardQuickViewDataResponse")]
        WarrierCards.Website.CatalogueService.CardQuickViewData GetCardQuickViewData(int cardId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICatalogueService/GetCardQuickViewData", ReplyAction="http://tempuri.org/ICatalogueService/GetCardQuickViewDataResponse")]
        System.Threading.Tasks.Task<WarrierCards.Website.CatalogueService.CardQuickViewData> GetCardQuickViewDataAsync(int cardId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICatalogueService/GetCardsInfoByIds", ReplyAction="http://tempuri.org/ICatalogueService/GetCardsInfoByIdsResponse")]
        System.Collections.Generic.List<WarrierCards.Website.CatalogueService.SelectedCardInfo> GetCardsInfoByIds(System.Collections.Generic.List<WarrierCards.Website.CatalogueService.SelectedCard> selectedCards);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICatalogueService/GetCardsInfoByIds", ReplyAction="http://tempuri.org/ICatalogueService/GetCardsInfoByIdsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<WarrierCards.Website.CatalogueService.SelectedCardInfo>> GetCardsInfoByIdsAsync(System.Collections.Generic.List<WarrierCards.Website.CatalogueService.SelectedCard> selectedCards);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICatalogueService/SendEnquiry", ReplyAction="http://tempuri.org/ICatalogueService/SendEnquiryResponse")]
        bool SendEnquiry(WarrierCards.Website.CatalogueService.EnquiryData enquiry);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICatalogueService/SendEnquiry", ReplyAction="http://tempuri.org/ICatalogueService/SendEnquiryResponse")]
        System.Threading.Tasks.Task<bool> SendEnquiryAsync(WarrierCards.Website.CatalogueService.EnquiryData enquiry);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICatalogueServiceChannel : WarrierCards.Website.CatalogueService.ICatalogueService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CatalogueServiceClient : System.ServiceModel.ClientBase<WarrierCards.Website.CatalogueService.ICatalogueService>, WarrierCards.Website.CatalogueService.ICatalogueService {
        
        public CatalogueServiceClient() {
        }
        
        public CatalogueServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CatalogueServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CatalogueServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CatalogueServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<WarrierCards.Website.CatalogueService.CardBasicInfo> GetCardsList(WarrierCards.Website.CatalogueService.SearchCriteria searchCriteria) {
            return base.Channel.GetCardsList(searchCriteria);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<WarrierCards.Website.CatalogueService.CardBasicInfo>> GetCardsListAsync(WarrierCards.Website.CatalogueService.SearchCriteria searchCriteria) {
            return base.Channel.GetCardsListAsync(searchCriteria);
        }
        
        public WarrierCards.Website.CatalogueService.CardDetails GetCardDetailsById(int cardId) {
            return base.Channel.GetCardDetailsById(cardId);
        }
        
        public System.Threading.Tasks.Task<WarrierCards.Website.CatalogueService.CardDetails> GetCardDetailsByIdAsync(int cardId) {
            return base.Channel.GetCardDetailsByIdAsync(cardId);
        }
        
        public WarrierCards.Website.CatalogueService.CardQuickViewData GetCardQuickViewData(int cardId) {
            return base.Channel.GetCardQuickViewData(cardId);
        }
        
        public System.Threading.Tasks.Task<WarrierCards.Website.CatalogueService.CardQuickViewData> GetCardQuickViewDataAsync(int cardId) {
            return base.Channel.GetCardQuickViewDataAsync(cardId);
        }
        
        public System.Collections.Generic.List<WarrierCards.Website.CatalogueService.SelectedCardInfo> GetCardsInfoByIds(System.Collections.Generic.List<WarrierCards.Website.CatalogueService.SelectedCard> selectedCards) {
            return base.Channel.GetCardsInfoByIds(selectedCards);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<WarrierCards.Website.CatalogueService.SelectedCardInfo>> GetCardsInfoByIdsAsync(System.Collections.Generic.List<WarrierCards.Website.CatalogueService.SelectedCard> selectedCards) {
            return base.Channel.GetCardsInfoByIdsAsync(selectedCards);
        }
        
        public bool SendEnquiry(WarrierCards.Website.CatalogueService.EnquiryData enquiry) {
            return base.Channel.SendEnquiry(enquiry);
        }
        
        public System.Threading.Tasks.Task<bool> SendEnquiryAsync(WarrierCards.Website.CatalogueService.EnquiryData enquiry) {
            return base.Channel.SendEnquiryAsync(enquiry);
        }
    }
}