﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.33440
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OriginxWindowsClient.OriginxWindowsService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="OriginxWindowsService.IOriginxDataService")]
    internal interface IOriginxDataService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOriginxDataService/getMessage", ReplyAction="http://tempuri.org/IOriginxDataService/getMessageResponse")]
        string getMessage(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOriginxDataService/getMessage", ReplyAction="http://tempuri.org/IOriginxDataService/getMessageResponse")]
        System.Threading.Tasks.Task<string> getMessageAsync(string name);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    internal interface IOriginxDataServiceChannel : OriginxWindowsClient.OriginxWindowsService.IOriginxDataService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    internal partial class OriginxDataServiceClient : System.ServiceModel.ClientBase<OriginxWindowsClient.OriginxWindowsService.IOriginxDataService>, OriginxWindowsClient.OriginxWindowsService.IOriginxDataService {
        
        public OriginxDataServiceClient() {
        }
        
        public OriginxDataServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public OriginxDataServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OriginxDataServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OriginxDataServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string getMessage(string name) {
            return base.Channel.getMessage(name);
        }
        
        public System.Threading.Tasks.Task<string> getMessageAsync(string name) {
            return base.Channel.getMessageAsync(name);
        }
    }
}