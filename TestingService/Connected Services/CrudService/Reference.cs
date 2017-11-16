﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestingService.CrudService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Laptop", Namespace="http://schemas.datacontract.org/2004/07/Models")]
    [System.SerializableAttribute()]
    public partial class Laptop : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BrandField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HardDiskField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] ImageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ModelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OSField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProcessorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int RamField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double ScreenField;
        
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
        public string Brand {
            get {
                return this.BrandField;
            }
            set {
                if ((object.ReferenceEquals(this.BrandField, value) != true)) {
                    this.BrandField = value;
                    this.RaisePropertyChanged("Brand");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string HardDisk {
            get {
                return this.HardDiskField;
            }
            set {
                if ((object.ReferenceEquals(this.HardDiskField, value) != true)) {
                    this.HardDiskField = value;
                    this.RaisePropertyChanged("HardDisk");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] Image {
            get {
                return this.ImageField;
            }
            set {
                if ((object.ReferenceEquals(this.ImageField, value) != true)) {
                    this.ImageField = value;
                    this.RaisePropertyChanged("Image");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Model {
            get {
                return this.ModelField;
            }
            set {
                if ((object.ReferenceEquals(this.ModelField, value) != true)) {
                    this.ModelField = value;
                    this.RaisePropertyChanged("Model");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string OS {
            get {
                return this.OSField;
            }
            set {
                if ((object.ReferenceEquals(this.OSField, value) != true)) {
                    this.OSField = value;
                    this.RaisePropertyChanged("OS");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Processor {
            get {
                return this.ProcessorField;
            }
            set {
                if ((object.ReferenceEquals(this.ProcessorField, value) != true)) {
                    this.ProcessorField = value;
                    this.RaisePropertyChanged("Processor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Ram {
            get {
                return this.RamField;
            }
            set {
                if ((this.RamField.Equals(value) != true)) {
                    this.RamField = value;
                    this.RaisePropertyChanged("Ram");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Screen {
            get {
                return this.ScreenField;
            }
            set {
                if ((this.ScreenField.Equals(value) != true)) {
                    this.ScreenField = value;
                    this.RaisePropertyChanged("Screen");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CrudService.ICrudServiceOf_Laptop")]
    public interface ICrudServiceOf_Laptop {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudServiceOf_Laptop/GetAllLaptops", ReplyAction="http://tempuri.org/ICrudServiceOf_Laptop/GetAllLaptopsResponse")]
        TestingService.CrudService.Laptop[] GetAllLaptops();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudServiceOf_Laptop/GetAllLaptops", ReplyAction="http://tempuri.org/ICrudServiceOf_Laptop/GetAllLaptopsResponse")]
        System.Threading.Tasks.Task<TestingService.CrudService.Laptop[]> GetAllLaptopsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudServiceOf_Laptop/GetLaptopById", ReplyAction="http://tempuri.org/ICrudServiceOf_Laptop/GetLaptopByIdResponse")]
        TestingService.CrudService.Laptop GetLaptopById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudServiceOf_Laptop/GetLaptopById", ReplyAction="http://tempuri.org/ICrudServiceOf_Laptop/GetLaptopByIdResponse")]
        System.Threading.Tasks.Task<TestingService.CrudService.Laptop> GetLaptopByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICrudServiceOf_Laptop/DeleteLaptop")]
        void DeleteLaptop(TestingService.CrudService.Laptop entity);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICrudServiceOf_Laptop/DeleteLaptop")]
        System.Threading.Tasks.Task DeleteLaptopAsync(TestingService.CrudService.Laptop entity);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICrudServiceOf_Laptop/DeleteLaptopById")]
        void DeleteLaptopById(int id);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICrudServiceOf_Laptop/DeleteLaptopById")]
        System.Threading.Tasks.Task DeleteLaptopByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICrudServiceOf_Laptop/CreateLaptop")]
        void CreateLaptop(TestingService.CrudService.Laptop entity);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICrudServiceOf_Laptop/CreateLaptop")]
        System.Threading.Tasks.Task CreateLaptopAsync(TestingService.CrudService.Laptop entity);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICrudServiceOf_Laptop/Update")]
        void Update(TestingService.CrudService.Laptop entity);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICrudServiceOf_Laptop/Update")]
        System.Threading.Tasks.Task UpdateAsync(TestingService.CrudService.Laptop entity);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrudServiceOf_LaptopChannel : TestingService.CrudService.ICrudServiceOf_Laptop, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CrudServiceOf_LaptopClient : System.ServiceModel.ClientBase<TestingService.CrudService.ICrudServiceOf_Laptop>, TestingService.CrudService.ICrudServiceOf_Laptop {
        
        public CrudServiceOf_LaptopClient() {
        }
        
        public CrudServiceOf_LaptopClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrudServiceOf_LaptopClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudServiceOf_LaptopClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrudServiceOf_LaptopClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public TestingService.CrudService.Laptop[] GetAllLaptops() {
            return base.Channel.GetAllLaptops();
        }
        
        public System.Threading.Tasks.Task<TestingService.CrudService.Laptop[]> GetAllLaptopsAsync() {
            return base.Channel.GetAllLaptopsAsync();
        }
        
        public TestingService.CrudService.Laptop GetLaptopById(int id) {
            return base.Channel.GetLaptopById(id);
        }
        
        public System.Threading.Tasks.Task<TestingService.CrudService.Laptop> GetLaptopByIdAsync(int id) {
            return base.Channel.GetLaptopByIdAsync(id);
        }
        
        public void DeleteLaptop(TestingService.CrudService.Laptop entity) {
            base.Channel.DeleteLaptop(entity);
        }
        
        public System.Threading.Tasks.Task DeleteLaptopAsync(TestingService.CrudService.Laptop entity) {
            return base.Channel.DeleteLaptopAsync(entity);
        }
        
        public void DeleteLaptopById(int id) {
            base.Channel.DeleteLaptopById(id);
        }
        
        public System.Threading.Tasks.Task DeleteLaptopByIdAsync(int id) {
            return base.Channel.DeleteLaptopByIdAsync(id);
        }
        
        public void CreateLaptop(TestingService.CrudService.Laptop entity) {
            base.Channel.CreateLaptop(entity);
        }
        
        public System.Threading.Tasks.Task CreateLaptopAsync(TestingService.CrudService.Laptop entity) {
            return base.Channel.CreateLaptopAsync(entity);
        }
        
        public void Update(TestingService.CrudService.Laptop entity) {
            base.Channel.Update(entity);
        }
        
        public System.Threading.Tasks.Task UpdateAsync(TestingService.CrudService.Laptop entity) {
            return base.Channel.UpdateAsync(entity);
        }
    }
}