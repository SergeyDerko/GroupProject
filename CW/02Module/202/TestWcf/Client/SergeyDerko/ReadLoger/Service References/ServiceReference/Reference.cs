﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ReadLoger.ServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ReadLog", Namespace="http://schemas.datacontract.org/2004/07/SergeyDerkoLibrary")]
    [System.SerializableAttribute()]
    public partial class ReadLog : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ReadLogInServiseField;
        
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
        public string ReadLogInServise {
            get {
                return this.ReadLogInServiseField;
            }
            set {
                if ((object.ReferenceEquals(this.ReadLogInServiseField, value) != true)) {
                    this.ReadLogInServiseField = value;
                    this.RaisePropertyChanged("ReadLogInServise");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IReadLog")]
    public interface IReadLog {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReadLog/ReadServiseLog", ReplyAction="http://tempuri.org/IReadLog/ReadServiseLogResponse")]
        ReadLoger.ServiceReference.ReadLog ReadServiseLog();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReadLog/ReadServiseLog", ReplyAction="http://tempuri.org/IReadLog/ReadServiseLogResponse")]
        System.Threading.Tasks.Task<ReadLoger.ServiceReference.ReadLog> ReadServiseLogAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IReadLogChannel : ReadLoger.ServiceReference.IReadLog, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ReadLogClient : System.ServiceModel.ClientBase<ReadLoger.ServiceReference.IReadLog>, ReadLoger.ServiceReference.IReadLog {
        
        public ReadLogClient() {
        }
        
        public ReadLogClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ReadLogClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ReadLogClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ReadLogClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ReadLoger.ServiceReference.ReadLog ReadServiseLog() {
            return base.Channel.ReadServiseLog();
        }
        
        public System.Threading.Tasks.Task<ReadLoger.ServiceReference.ReadLog> ReadServiseLogAsync() {
            return base.Channel.ReadServiseLogAsync();
        }
    }
}
