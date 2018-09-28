﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Distribuidora.WSAsignacionReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DTOAsignacionTecnico", Namespace="http://schemas.datacontract.org/2004/07/DistribuidoraServicios")]
    [System.SerializableAttribute()]
    public partial class DTOAsignacionTecnico : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CodigoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
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
        public int Codigo {
            get {
                return this.CodigoField;
            }
            set {
                if ((this.CodigoField.Equals(value) != true)) {
                    this.CodigoField = value;
                    this.RaisePropertyChanged("Codigo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WSAsignacionReference.IAsignacionTecnico")]
    public interface IAsignacionTecnico {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAsignacionTecnico/ListaTecnicos", ReplyAction="http://tempuri.org/IAsignacionTecnico/ListaTecnicosResponse")]
        Distribuidora.WSAsignacionReference.DTOAsignacionTecnico[] ListaTecnicos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAsignacionTecnico/ListaTecnicos", ReplyAction="http://tempuri.org/IAsignacionTecnico/ListaTecnicosResponse")]
        System.Threading.Tasks.Task<Distribuidora.WSAsignacionReference.DTOAsignacionTecnico[]> ListaTecnicosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAsignacionTecnico/ListaProductos", ReplyAction="http://tempuri.org/IAsignacionTecnico/ListaProductosResponse")]
        Distribuidora.WSAsignacionReference.DTOAsignacionTecnico[] ListaProductos(string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAsignacionTecnico/ListaProductos", ReplyAction="http://tempuri.org/IAsignacionTecnico/ListaProductosResponse")]
        System.Threading.Tasks.Task<Distribuidora.WSAsignacionReference.DTOAsignacionTecnico[]> ListaProductosAsync(string email);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAsignacionTecnicoChannel : Distribuidora.WSAsignacionReference.IAsignacionTecnico, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AsignacionTecnicoClient : System.ServiceModel.ClientBase<Distribuidora.WSAsignacionReference.IAsignacionTecnico>, Distribuidora.WSAsignacionReference.IAsignacionTecnico {
        
        public AsignacionTecnicoClient() {
        }
        
        public AsignacionTecnicoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AsignacionTecnicoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AsignacionTecnicoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AsignacionTecnicoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Distribuidora.WSAsignacionReference.DTOAsignacionTecnico[] ListaTecnicos() {
            return base.Channel.ListaTecnicos();
        }
        
        public System.Threading.Tasks.Task<Distribuidora.WSAsignacionReference.DTOAsignacionTecnico[]> ListaTecnicosAsync() {
            return base.Channel.ListaTecnicosAsync();
        }
        
        public Distribuidora.WSAsignacionReference.DTOAsignacionTecnico[] ListaProductos(string email) {
            return base.Channel.ListaProductos(email);
        }
        
        public System.Threading.Tasks.Task<Distribuidora.WSAsignacionReference.DTOAsignacionTecnico[]> ListaProductosAsync(string email) {
            return base.Channel.ListaProductosAsync(email);
        }
    }
}