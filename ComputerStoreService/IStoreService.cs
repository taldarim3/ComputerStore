using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStoreService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IStoreService //Сервис контракт с пятью методами
    {

        [OperationContract]
        [FaultContract(typeof(NullReferenceException))]
        bool Registration(string name, string email, string pass);

        [OperationContract]
        int Login(string email, string pass);

        [OperationContract]
        Item GetItemByName(string name);

        [OperationContract]
        void RemoveItemById(int id);

        [OperationContract]
        void AddItem(string name, int price, string description, int authorId);

        [OperationContract]
        List<Data.Item> GetAllItems();
        [OperationContract]
        Task<List<Data.Item>> GetItmesLike(string str);
    }

    [DataContract]
    public class Item
    {

        [DataMember]
        public string ItemName { get; set; }

        [DataMember]
        public int ItemPrice { get; set; }

        [DataMember]
        public string ItemDescription { get; set; }

        [DataMember]
        public int ItemId { get; set; }
        [DataMember]
        public int ItemAuthor { get; set; }

    }
    [DataContract]
    public class User
    {
        [DataMember]
        public int UserId { get; set; }
        [DataMember]
        public string USerName { get; set; }
        [DataMember]
        public string UserEmail { get; set; }
        [DataMember]
        public string UserPassword { get; set; }

    }

    [DataContract]
    public class BoolDTO
    {
        [DataMember]
        public bool BoolValue { get; set; }

    }
}
