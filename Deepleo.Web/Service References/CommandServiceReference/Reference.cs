﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Deepleo.Web.CommandServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CommandServiceReference.ICommanderService")]
    public interface ICommanderService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICommanderService/GetAccessToken", ReplyAction="http://tempuri.org/ICommanderService/GetAccessTokenResponse")]
        string GetAccessToken(string appid, string appSecret, bool force);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICommanderService/GetJsTicket", ReplyAction="http://tempuri.org/ICommanderService/GetJsTicketResponse")]
        string GetJsTicket(string appid, string appSecret, bool force);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICommanderServiceChannel : Deepleo.Web.CommandServiceReference.ICommanderService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CommanderServiceClient : System.ServiceModel.ClientBase<Deepleo.Web.CommandServiceReference.ICommanderService>, Deepleo.Web.CommandServiceReference.ICommanderService {
        
        public CommanderServiceClient() {
        }
        
        public CommanderServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CommanderServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CommanderServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CommanderServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetAccessToken(string appid, string appSecret, bool force) {
            return base.Channel.GetAccessToken(appid, appSecret, force);
        }
        
        public string GetJsTicket(string appid, string appSecret, bool force) {
            return base.Channel.GetJsTicket(appid, appSecret, force);
        }
    }
}