﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Finanzauto.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Relaciones.Estudiante", Namespace="http://schemas.datacontract.org/2004/07/Finanzauto.Web.Clases")]
    [System.SerializableAttribute()]
    public partial class RelacionesEstudiante : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApellidoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CursoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TelefonoField;
        
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
        public string Apellido {
            get {
                return this.ApellidoField;
            }
            set {
                if ((object.ReferenceEquals(this.ApellidoField, value) != true)) {
                    this.ApellidoField = value;
                    this.RaisePropertyChanged("Apellido");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Curso {
            get {
                return this.CursoField;
            }
            set {
                if ((object.ReferenceEquals(this.CursoField, value) != true)) {
                    this.CursoField = value;
                    this.RaisePropertyChanged("Curso");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Telefono {
            get {
                return this.TelefonoField;
            }
            set {
                if ((object.ReferenceEquals(this.TelefonoField, value) != true)) {
                    this.TelefonoField = value;
                    this.RaisePropertyChanged("Telefono");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Relaciones.Profesor", Namespace="http://schemas.datacontract.org/2004/07/Finanzauto.Web.Clases")]
    [System.SerializableAttribute()]
    public partial class RelacionesProfesor : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApellidoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EspecialidadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
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
        public string Apellido {
            get {
                return this.ApellidoField;
            }
            set {
                if ((object.ReferenceEquals(this.ApellidoField, value) != true)) {
                    this.ApellidoField = value;
                    this.RaisePropertyChanged("Apellido");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Especialidad {
            get {
                return this.EspecialidadField;
            }
            set {
                if ((object.ReferenceEquals(this.EspecialidadField, value) != true)) {
                    this.EspecialidadField = value;
                    this.RaisePropertyChanged("Especialidad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertarEstudiante", ReplyAction="http://tempuri.org/IService1/InsertarEstudianteResponse")]
        void InsertarEstudiante(string nombre, string apellido, string telefono, string curso);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertarEstudiante", ReplyAction="http://tempuri.org/IService1/InsertarEstudianteResponse")]
        System.Threading.Tasks.Task InsertarEstudianteAsync(string nombre, string apellido, string telefono, string curso);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ActualizarEstudiante", ReplyAction="http://tempuri.org/IService1/ActualizarEstudianteResponse")]
        void ActualizarEstudiante(int ID, string nombre, string apellido, string telefono, string curso);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ActualizarEstudiante", ReplyAction="http://tempuri.org/IService1/ActualizarEstudianteResponse")]
        System.Threading.Tasks.Task ActualizarEstudianteAsync(int ID, string nombre, string apellido, string telefono, string curso);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EliminarEstudiantes", ReplyAction="http://tempuri.org/IService1/EliminarEstudiantesResponse")]
        void EliminarEstudiantes(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EliminarEstudiantes", ReplyAction="http://tempuri.org/IService1/EliminarEstudiantesResponse")]
        System.Threading.Tasks.Task EliminarEstudiantesAsync(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/BuscarEstudiantes", ReplyAction="http://tempuri.org/IService1/BuscarEstudiantesResponse")]
        Finanzauto.ServiceReference1.RelacionesEstudiante[] BuscarEstudiantes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/BuscarEstudiantes", ReplyAction="http://tempuri.org/IService1/BuscarEstudiantesResponse")]
        System.Threading.Tasks.Task<Finanzauto.ServiceReference1.RelacionesEstudiante[]> BuscarEstudiantesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertarProfesor", ReplyAction="http://tempuri.org/IService1/InsertarProfesorResponse")]
        void InsertarProfesor(string nombre, string apellido, string especialidad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertarProfesor", ReplyAction="http://tempuri.org/IService1/InsertarProfesorResponse")]
        System.Threading.Tasks.Task InsertarProfesorAsync(string nombre, string apellido, string especialidad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EliminarProfesores", ReplyAction="http://tempuri.org/IService1/EliminarProfesoresResponse")]
        void EliminarProfesores(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EliminarProfesores", ReplyAction="http://tempuri.org/IService1/EliminarProfesoresResponse")]
        System.Threading.Tasks.Task EliminarProfesoresAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ActualizarProfesor", ReplyAction="http://tempuri.org/IService1/ActualizarProfesorResponse")]
        void ActualizarProfesor(int id, string nombre, string apellido, string especialidad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ActualizarProfesor", ReplyAction="http://tempuri.org/IService1/ActualizarProfesorResponse")]
        System.Threading.Tasks.Task ActualizarProfesorAsync(int id, string nombre, string apellido, string especialidad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/BuscarProfesores", ReplyAction="http://tempuri.org/IService1/BuscarProfesoresResponse")]
        Finanzauto.ServiceReference1.RelacionesProfesor[] BuscarProfesores();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/BuscarProfesores", ReplyAction="http://tempuri.org/IService1/BuscarProfesoresResponse")]
        System.Threading.Tasks.Task<Finanzauto.ServiceReference1.RelacionesProfesor[]> BuscarProfesoresAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Finanzauto.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Finanzauto.ServiceReference1.IService1>, Finanzauto.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void InsertarEstudiante(string nombre, string apellido, string telefono, string curso) {
            base.Channel.InsertarEstudiante(nombre, apellido, telefono, curso);
        }
        
        public System.Threading.Tasks.Task InsertarEstudianteAsync(string nombre, string apellido, string telefono, string curso) {
            return base.Channel.InsertarEstudianteAsync(nombre, apellido, telefono, curso);
        }
        
        public void ActualizarEstudiante(int ID, string nombre, string apellido, string telefono, string curso) {
            base.Channel.ActualizarEstudiante(ID, nombre, apellido, telefono, curso);
        }
        
        public System.Threading.Tasks.Task ActualizarEstudianteAsync(int ID, string nombre, string apellido, string telefono, string curso) {
            return base.Channel.ActualizarEstudianteAsync(ID, nombre, apellido, telefono, curso);
        }
        
        public void EliminarEstudiantes(int ID) {
            base.Channel.EliminarEstudiantes(ID);
        }
        
        public System.Threading.Tasks.Task EliminarEstudiantesAsync(int ID) {
            return base.Channel.EliminarEstudiantesAsync(ID);
        }
        
        public Finanzauto.ServiceReference1.RelacionesEstudiante[] BuscarEstudiantes() {
            return base.Channel.BuscarEstudiantes();
        }
        
        public System.Threading.Tasks.Task<Finanzauto.ServiceReference1.RelacionesEstudiante[]> BuscarEstudiantesAsync() {
            return base.Channel.BuscarEstudiantesAsync();
        }
        
        public void InsertarProfesor(string nombre, string apellido, string especialidad) {
            base.Channel.InsertarProfesor(nombre, apellido, especialidad);
        }
        
        public System.Threading.Tasks.Task InsertarProfesorAsync(string nombre, string apellido, string especialidad) {
            return base.Channel.InsertarProfesorAsync(nombre, apellido, especialidad);
        }
        
        public void EliminarProfesores(int id) {
            base.Channel.EliminarProfesores(id);
        }
        
        public System.Threading.Tasks.Task EliminarProfesoresAsync(int id) {
            return base.Channel.EliminarProfesoresAsync(id);
        }
        
        public void ActualizarProfesor(int id, string nombre, string apellido, string especialidad) {
            base.Channel.ActualizarProfesor(id, nombre, apellido, especialidad);
        }
        
        public System.Threading.Tasks.Task ActualizarProfesorAsync(int id, string nombre, string apellido, string especialidad) {
            return base.Channel.ActualizarProfesorAsync(id, nombre, apellido, especialidad);
        }
        
        public Finanzauto.ServiceReference1.RelacionesProfesor[] BuscarProfesores() {
            return base.Channel.BuscarProfesores();
        }
        
        public System.Threading.Tasks.Task<Finanzauto.ServiceReference1.RelacionesProfesor[]> BuscarProfesoresAsync() {
            return base.Channel.BuscarProfesoresAsync();
        }
    }
}