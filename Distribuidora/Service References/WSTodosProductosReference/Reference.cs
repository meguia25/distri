﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Distribuidora.WSTodosProductosReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DTOListadoTodosProducto", Namespace="http://schemas.datacontract.org/2004/07/DistribuidoraServicios")]
    [System.SerializableAttribute()]
    public partial class DTOListadoTodosProducto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WSTodosProductosReference.IListadoTodosProducto")]
    public interface IListadoTodosProducto {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IListadoTodosProducto/listado", ReplyAction="http://tempuri.org/IListadoTodosProducto/listadoResponse")]
        Distribuidora.WSTodosProductosReference.DTOListadoTodosProducto[] listado();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IListadoTodosProducto/listado", ReplyAction="http://tempuri.org/IListadoTodosProducto/listadoResponse")]
        System.Threading.Tasks.Task<Distribuidora.WSTodosProductosReference.DTOListadoTodosProducto[]> listadoAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IListadoTodosProductoChannel : Distribuidora.WSTodosProductosReference.IListadoTodosProducto, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ListadoTodosProductoClient : System.ServiceModel.ClientBase<Distribuidora.WSTodosProductosReference.IListadoTodosProducto>, Distribuidora.WSTodosProductosReference.IListadoTodosProducto {
        
        public ListadoTodosProductoClient() {
        }
        
        public ListadoTodosProductoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ListadoTodosProductoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ListadoTodosProductoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ListadoTodosProductoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Distribuidora.WSTodosProductosReference.DTOListadoTodosProducto[] listado() {
            return base.Channel.listado();
        }
        
        public System.Threading.Tasks.Task<Distribuidora.WSTodosProductosReference.DTOListadoTodosProducto[]> listadoAsync() {
            return base.Channel.listadoAsync();
        }
    }
}
