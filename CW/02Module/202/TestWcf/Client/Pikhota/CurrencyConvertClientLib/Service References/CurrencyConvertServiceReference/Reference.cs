﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CurrencyConvertClientLib.CurrencyConvertServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CurrencyConvertServiceReference.ICurrencyConvert")]
    public interface ICurrencyConvert {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICurrencyConvert/ChangeCurrency", ReplyAction="http://tempuri.org/ICurrencyConvert/ChangeCurrencyResponse")]
        double ChangeCurrency(string fromCurrency, string toCurrency, int count, string action);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICurrencyConvert/ChangeCurrency", ReplyAction="http://tempuri.org/ICurrencyConvert/ChangeCurrencyResponse")]
        System.Threading.Tasks.Task<double> ChangeCurrencyAsync(string fromCurrency, string toCurrency, int count, string action);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICurrencyConvertChannel : CurrencyConvertClientLib.CurrencyConvertServiceReference.ICurrencyConvert, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CurrencyConvertClient : System.ServiceModel.ClientBase<CurrencyConvertClientLib.CurrencyConvertServiceReference.ICurrencyConvert>, CurrencyConvertClientLib.CurrencyConvertServiceReference.ICurrencyConvert {
        
        public CurrencyConvertClient() {
        }
        
        public CurrencyConvertClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CurrencyConvertClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CurrencyConvertClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CurrencyConvertClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double ChangeCurrency(string fromCurrency, string toCurrency, int count, string action) {
            return base.Channel.ChangeCurrency(fromCurrency, toCurrency, count, action);
        }
        
        public System.Threading.Tasks.Task<double> ChangeCurrencyAsync(string fromCurrency, string toCurrency, int count, string action) {
            return base.Channel.ChangeCurrencyAsync(fromCurrency, toCurrency, count, action);
        }
    }
}
