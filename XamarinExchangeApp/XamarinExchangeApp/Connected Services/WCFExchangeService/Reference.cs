﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFExchangeService
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ExchangeRateType", Namespace="http://schemas.datacontract.org/2004/07/ExchangeWS")]
    public partial class ExchangeRateType : object
    {
        
        private string CodeField;
        
        private string CurrencyField;
        
        private string DateField;
        
        private double RateField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Code
        {
            get
            {
                return this.CodeField;
            }
            set
            {
                this.CodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Currency
        {
            get
            {
                return this.CurrencyField;
            }
            set
            {
                this.CurrencyField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Date
        {
            get
            {
                return this.DateField;
            }
            set
            {
                this.DateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Rate
        {
            get
            {
                return this.RateField;
            }
            set
            {
                this.RateField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WCFExchangeService.IExchangeService")]
    public interface IExchangeService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExchangeService/GetExchangeRateForCurrency", ReplyAction="http://tempuri.org/IExchangeService/GetExchangeRateForCurrencyResponse")]
        WCFExchangeService.ExchangeRateType GetExchangeRateForCurrency(string currencyCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExchangeService/GetExchangeRateForCurrency", ReplyAction="http://tempuri.org/IExchangeService/GetExchangeRateForCurrencyResponse")]
        System.Threading.Tasks.Task<WCFExchangeService.ExchangeRateType> GetExchangeRateForCurrencyAsync(string currencyCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExchangeService/GetExchangeRateTypes", ReplyAction="http://tempuri.org/IExchangeService/GetExchangeRateTypesResponse")]
        WCFExchangeService.ExchangeRateType[] GetExchangeRateTypes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IExchangeService/GetExchangeRateTypes", ReplyAction="http://tempuri.org/IExchangeService/GetExchangeRateTypesResponse")]
        System.Threading.Tasks.Task<WCFExchangeService.ExchangeRateType[]> GetExchangeRateTypesAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface IExchangeServiceChannel : WCFExchangeService.IExchangeService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class ExchangeServiceClient : System.ServiceModel.ClientBase<WCFExchangeService.IExchangeService>, WCFExchangeService.IExchangeService
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public ExchangeServiceClient() : 
                base(ExchangeServiceClient.GetDefaultBinding(), ExchangeServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IExchangeService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ExchangeServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(ExchangeServiceClient.GetBindingForEndpoint(endpointConfiguration), ExchangeServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ExchangeServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(ExchangeServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ExchangeServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(ExchangeServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ExchangeServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public WCFExchangeService.ExchangeRateType GetExchangeRateForCurrency(string currencyCode)
        {
            return base.Channel.GetExchangeRateForCurrency(currencyCode);
        }
        
        public System.Threading.Tasks.Task<WCFExchangeService.ExchangeRateType> GetExchangeRateForCurrencyAsync(string currencyCode)
        {
            return base.Channel.GetExchangeRateForCurrencyAsync(currencyCode);
        }
        
        public WCFExchangeService.ExchangeRateType[] GetExchangeRateTypes()
        {
            return base.Channel.GetExchangeRateTypes();
        }
        
        public System.Threading.Tasks.Task<WCFExchangeService.ExchangeRateType[]> GetExchangeRateTypesAsync()
        {
            return base.Channel.GetExchangeRateTypesAsync();
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IExchangeService))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IExchangeService))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:55987/ExchangeService.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return ExchangeServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IExchangeService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return ExchangeServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IExchangeService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IExchangeService,
        }
    }
}
