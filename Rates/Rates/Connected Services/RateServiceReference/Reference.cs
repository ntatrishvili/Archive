﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Rates.RateServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CurrencyRate", Namespace="http://www.nbg.ge/")]
    [System.SerializableAttribute()]
    public partial class CurrencyRate : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodeField;
        
        private int QuantityField;
        
        private decimal RateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        private decimal DiffField;
        
        private System.DateTime DateField;
        
        private System.DateTime ValidFromDateField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Code {
            get {
                return this.CodeField;
            }
            set {
                if ((object.ReferenceEquals(this.CodeField, value) != true)) {
                    this.CodeField = value;
                    this.RaisePropertyChanged("Code");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public decimal Rate {
            get {
                return this.RateField;
            }
            set {
                if ((this.RateField.Equals(value) != true)) {
                    this.RateField = value;
                    this.RaisePropertyChanged("Rate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public decimal Diff {
            get {
                return this.DiffField;
            }
            set {
                if ((this.DiffField.Equals(value) != true)) {
                    this.DiffField = value;
                    this.RaisePropertyChanged("Diff");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=5)]
        public System.DateTime Date {
            get {
                return this.DateField;
            }
            set {
                if ((this.DateField.Equals(value) != true)) {
                    this.DateField = value;
                    this.RaisePropertyChanged("Date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=6)]
        public System.DateTime ValidFromDate {
            get {
                return this.ValidFromDateField;
            }
            set {
                if ((this.ValidFromDateField.Equals(value) != true)) {
                    this.ValidFromDateField = value;
                    this.RaisePropertyChanged("ValidFromDate");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.nbg.ge/", ConfigurationName="RateServiceReference.ServiceSoap")]
    public interface ServiceSoap {
        
        // CODEGEN: Generating message contract since element name Currencies from namespace http://www.nbg.ge/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nbg.ge/GetCurrentRates", ReplyAction="*")]
        Rates.RateServiceReference.GetCurrentRatesResponse GetCurrentRates(Rates.RateServiceReference.GetCurrentRatesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nbg.ge/GetCurrentRates", ReplyAction="*")]
        System.Threading.Tasks.Task<Rates.RateServiceReference.GetCurrentRatesResponse> GetCurrentRatesAsync(Rates.RateServiceReference.GetCurrentRatesRequest request);
        
        // CODEGEN: Generating message contract since element name Currencies from namespace http://www.nbg.ge/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nbg.ge/GetLastRates", ReplyAction="*")]
        Rates.RateServiceReference.GetLastRatesResponse GetLastRates(Rates.RateServiceReference.GetLastRatesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.nbg.ge/GetLastRates", ReplyAction="*")]
        System.Threading.Tasks.Task<Rates.RateServiceReference.GetLastRatesResponse> GetLastRatesAsync(Rates.RateServiceReference.GetLastRatesRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCurrentRatesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCurrentRates", Namespace="http://www.nbg.ge/", Order=0)]
        public Rates.RateServiceReference.GetCurrentRatesRequestBody Body;
        
        public GetCurrentRatesRequest() {
        }
        
        public GetCurrentRatesRequest(Rates.RateServiceReference.GetCurrentRatesRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.nbg.ge/")]
    public partial class GetCurrentRatesRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Currencies;
        
        public GetCurrentRatesRequestBody() {
        }
        
        public GetCurrentRatesRequestBody(string Currencies) {
            this.Currencies = Currencies;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCurrentRatesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCurrentRatesResponse", Namespace="http://www.nbg.ge/", Order=0)]
        public Rates.RateServiceReference.GetCurrentRatesResponseBody Body;
        
        public GetCurrentRatesResponse() {
        }
        
        public GetCurrentRatesResponse(Rates.RateServiceReference.GetCurrentRatesResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.nbg.ge/")]
    public partial class GetCurrentRatesResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Rates.RateServiceReference.CurrencyRate[] GetCurrentRatesResult;
        
        public GetCurrentRatesResponseBody() {
        }
        
        public GetCurrentRatesResponseBody(Rates.RateServiceReference.CurrencyRate[] GetCurrentRatesResult) {
            this.GetCurrentRatesResult = GetCurrentRatesResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetLastRatesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetLastRates", Namespace="http://www.nbg.ge/", Order=0)]
        public Rates.RateServiceReference.GetLastRatesRequestBody Body;
        
        public GetLastRatesRequest() {
        }
        
        public GetLastRatesRequest(Rates.RateServiceReference.GetLastRatesRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.nbg.ge/")]
    public partial class GetLastRatesRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Currencies;
        
        public GetLastRatesRequestBody() {
        }
        
        public GetLastRatesRequestBody(string Currencies) {
            this.Currencies = Currencies;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetLastRatesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetLastRatesResponse", Namespace="http://www.nbg.ge/", Order=0)]
        public Rates.RateServiceReference.GetLastRatesResponseBody Body;
        
        public GetLastRatesResponse() {
        }
        
        public GetLastRatesResponse(Rates.RateServiceReference.GetLastRatesResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.nbg.ge/")]
    public partial class GetLastRatesResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Rates.RateServiceReference.CurrencyRate[] GetLastRatesResult;
        
        public GetLastRatesResponseBody() {
        }
        
        public GetLastRatesResponseBody(Rates.RateServiceReference.CurrencyRate[] GetLastRatesResult) {
            this.GetLastRatesResult = GetLastRatesResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServiceSoapChannel : Rates.RateServiceReference.ServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceSoapClient : System.ServiceModel.ClientBase<Rates.RateServiceReference.ServiceSoap>, Rates.RateServiceReference.ServiceSoap {
        
        public ServiceSoapClient() {
        }
        
        public ServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Rates.RateServiceReference.GetCurrentRatesResponse Rates.RateServiceReference.ServiceSoap.GetCurrentRates(Rates.RateServiceReference.GetCurrentRatesRequest request) {
            return base.Channel.GetCurrentRates(request);
        }
        
        public Rates.RateServiceReference.CurrencyRate[] GetCurrentRates(string Currencies) {
            Rates.RateServiceReference.GetCurrentRatesRequest inValue = new Rates.RateServiceReference.GetCurrentRatesRequest();
            inValue.Body = new Rates.RateServiceReference.GetCurrentRatesRequestBody();
            inValue.Body.Currencies = Currencies;
            Rates.RateServiceReference.GetCurrentRatesResponse retVal = ((Rates.RateServiceReference.ServiceSoap)(this)).GetCurrentRates(inValue);
            return retVal.Body.GetCurrentRatesResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Rates.RateServiceReference.GetCurrentRatesResponse> Rates.RateServiceReference.ServiceSoap.GetCurrentRatesAsync(Rates.RateServiceReference.GetCurrentRatesRequest request) {
            return base.Channel.GetCurrentRatesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Rates.RateServiceReference.GetCurrentRatesResponse> GetCurrentRatesAsync(string Currencies) {
            Rates.RateServiceReference.GetCurrentRatesRequest inValue = new Rates.RateServiceReference.GetCurrentRatesRequest();
            inValue.Body = new Rates.RateServiceReference.GetCurrentRatesRequestBody();
            inValue.Body.Currencies = Currencies;
            return ((Rates.RateServiceReference.ServiceSoap)(this)).GetCurrentRatesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Rates.RateServiceReference.GetLastRatesResponse Rates.RateServiceReference.ServiceSoap.GetLastRates(Rates.RateServiceReference.GetLastRatesRequest request) {
            return base.Channel.GetLastRates(request);
        }
        
        public Rates.RateServiceReference.CurrencyRate[] GetLastRates(string Currencies) {
            Rates.RateServiceReference.GetLastRatesRequest inValue = new Rates.RateServiceReference.GetLastRatesRequest();
            inValue.Body = new Rates.RateServiceReference.GetLastRatesRequestBody();
            inValue.Body.Currencies = Currencies;
            Rates.RateServiceReference.GetLastRatesResponse retVal = ((Rates.RateServiceReference.ServiceSoap)(this)).GetLastRates(inValue);
            return retVal.Body.GetLastRatesResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Rates.RateServiceReference.GetLastRatesResponse> Rates.RateServiceReference.ServiceSoap.GetLastRatesAsync(Rates.RateServiceReference.GetLastRatesRequest request) {
            return base.Channel.GetLastRatesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Rates.RateServiceReference.GetLastRatesResponse> GetLastRatesAsync(string Currencies) {
            Rates.RateServiceReference.GetLastRatesRequest inValue = new Rates.RateServiceReference.GetLastRatesRequest();
            inValue.Body = new Rates.RateServiceReference.GetLastRatesRequestBody();
            inValue.Body.Currencies = Currencies;
            return ((Rates.RateServiceReference.ServiceSoap)(this)).GetLastRatesAsync(inValue);
        }
    }
}