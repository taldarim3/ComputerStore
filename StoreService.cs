//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ComputerStoreService
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BoolDTO", Namespace="http://schemas.datacontract.org/2004/07/ComputerStoreService")]
    public partial class BoolDTO : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private bool BoolValueField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool BoolValue
        {
            get
            {
                return this.BoolValueField;
            }
            set
            {
                this.BoolValueField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Item", Namespace="http://schemas.datacontract.org/2004/07/ComputerStoreService")]
    public partial class Item : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string ItemDescriptionField;
        
        private int ItemIdField;
        
        private string ItemNameField;
        
        private int ItemPriceField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ItemDescription
        {
            get
            {
                return this.ItemDescriptionField;
            }
            set
            {
                this.ItemDescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ItemId
        {
            get
            {
                return this.ItemIdField;
            }
            set
            {
                this.ItemIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ItemName
        {
            get
            {
                return this.ItemNameField;
            }
            set
            {
                this.ItemNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ItemPrice
        {
            get
            {
                return this.ItemPriceField;
            }
            set
            {
                this.ItemPriceField = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="IStoreService")]
public interface IStoreService
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStoreService/Registration", ReplyAction="http://tempuri.org/IStoreService/RegistrationResponse")]
    ComputerStoreService.BoolDTO Registration(string name, string email, string pass);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStoreService/Registration", ReplyAction="http://tempuri.org/IStoreService/RegistrationResponse")]
    System.Threading.Tasks.Task<ComputerStoreService.BoolDTO> RegistrationAsync(string name, string email, string pass);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStoreService/Login", ReplyAction="http://tempuri.org/IStoreService/LoginResponse")]
    int Login(string email, string pass);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStoreService/Login", ReplyAction="http://tempuri.org/IStoreService/LoginResponse")]
    System.Threading.Tasks.Task<int> LoginAsync(string email, string pass);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStoreService/GetItemById", ReplyAction="http://tempuri.org/IStoreService/GetItemByIdResponse")]
    ComputerStoreService.Item GetItemById(int id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStoreService/GetItemById", ReplyAction="http://tempuri.org/IStoreService/GetItemByIdResponse")]
    System.Threading.Tasks.Task<ComputerStoreService.Item> GetItemByIdAsync(int id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStoreService/RemoveItemById", ReplyAction="http://tempuri.org/IStoreService/RemoveItemByIdResponse")]
    void RemoveItemById(int id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStoreService/RemoveItemById", ReplyAction="http://tempuri.org/IStoreService/RemoveItemByIdResponse")]
    System.Threading.Tasks.Task RemoveItemByIdAsync(int id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStoreService/AddItem", ReplyAction="http://tempuri.org/IStoreService/AddItemResponse")]
    void AddItem(string name, int price, string description);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStoreService/AddItem", ReplyAction="http://tempuri.org/IStoreService/AddItemResponse")]
    System.Threading.Tasks.Task AddItemAsync(string name, int price, string description);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IStoreServiceChannel : IStoreService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class StoreServiceClient : System.ServiceModel.ClientBase<IStoreService>, IStoreService
{
    
    public StoreServiceClient()
    {
    }
    
    public StoreServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public StoreServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public StoreServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public StoreServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public ComputerStoreService.BoolDTO Registration(string name, string email, string pass)
    {
        return base.Channel.Registration(name, email, pass);
    }
    
    public System.Threading.Tasks.Task<ComputerStoreService.BoolDTO> RegistrationAsync(string name, string email, string pass)
    {
        return base.Channel.RegistrationAsync(name, email, pass);
    }
    
    public int Login(string email, string pass)
    {
        return base.Channel.Login(email, pass);
    }
    
    public System.Threading.Tasks.Task<int> LoginAsync(string email, string pass)
    {
        return base.Channel.LoginAsync(email, pass);
    }
    
    public ComputerStoreService.Item GetItemById(int id)
    {
        return base.Channel.GetItemById(id);
    }
    
    public System.Threading.Tasks.Task<ComputerStoreService.Item> GetItemByIdAsync(int id)
    {
        return base.Channel.GetItemByIdAsync(id);
    }
    
    public void RemoveItemById(int id)
    {
        base.Channel.RemoveItemById(id);
    }
    
    public System.Threading.Tasks.Task RemoveItemByIdAsync(int id)
    {
        return base.Channel.RemoveItemByIdAsync(id);
    }
    
    public void AddItem(string name, int price, string description)
    {
        base.Channel.AddItem(name, price, description);
    }
    
    public System.Threading.Tasks.Task AddItemAsync(string name, int price, string description)
    {
        return base.Channel.AddItemAsync(name, price, description);
    }
}
