using ComputerStoreService.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using System.Web.ModelBinding;
using System.Web.UI.WebControls;


namespace ComputerStoreService
{
    public class StoreService : IStoreService
    {
        //Создание объекта "context" с помощью которого мы обращаемся к бд
        ComputerStoreDbContex context = new ComputerStoreDbContex();

        //Метод AddItem cоздает новый Item с указанными параметрами и добавляет его в бд
        public void AddItem(string name, int price, string description, int authorId)
        {
            if (String.IsNullOrEmpty(name) || price == 0)
                throw new FaultException(new FaultReason("Вы ввели некорректные данные"));
            
            Data.Item item = new Data.Item()
            {
                Name = name,
                Price = price,
                Description = description,
                AuthorId = authorId
            };
            context.Items.Add(item);
            context.SaveChanges();
        }
        //Метод GetItemByName с помощью Linq запроса "выцепляет" Item с интересующим нас Name из базы данных 
        //Создает Item (DataContract) с такими же свойствами и возвращет его
        public Item GetItemByName(string name)
        {
            Data.Item item = context.Items.FirstOrDefault(x => x.Name == name);
            if (item != null)
            {
                Item itemDTO = new Item
                {
                    ItemId = item.Id,
                    ItemName = item.Name,
                    ItemPrice = item.Price,
                    ItemDescription = item.Description,
                    ItemAuthor = item.AuthorId

                };
                return itemDTO; ;
            }
            else
            {
                throw new FaultException(new FaultReason("Товар с таким названием не найден"));
            }


        }
        //Метод Login с помощью Linq запроса обращается к бд и проверяет существует ли User с введнными данными
        //Возвращает булевскую переменную для дальнейших действий WPF клиета
        public int Login(string login, string pass)
        {   
            int temp = 0;
            Data.User user = context.Users.FirstOrDefault(u => u.Email == login && u.Password == pass);
            if (user != null)
            {
                temp = user.Id;
            } else throw new FaultException(new FaultReason("Пользователь не найден"));
            return temp;
        }


        //Метод Registration проверяет есть ли User с указынными данными в бд, если нет то вносит нового пользователя
        //Возвращает булевское значение для дальнейшей работы WPF клиента
        public bool Registration(string name, string email, string pass)
        {
            if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(email) || String.IsNullOrEmpty(pass))
            {

                throw new FaultException(new FaultReason("Вы не ввели данные для регистрации"));
            }

            bool temp = false;

            ComputerStoreService.Data.User user = context.Users.FirstOrDefault(u => u.Email == email);
            if (user != null)
                throw new FaultException(new FaultReason("Пользователь с такими данными уже существует"));
            else
            {
                context.Users.Add(new Data.User()
                {
                    Name = name,
                    Email = email,
                    Password = pass,
                });
                context.SaveChanges();
                temp = true;
            }
            return temp;
        }
        //Метод RemoveItemById ищет Item c указанным Id в бд, если такой находится, то удаляет его
        public void RemoveItemById(int id)
        {
            Data.Item item = context.Items.FirstOrDefault(i => i.Id == id);
            if (item != null)
            {
                context.Items.Remove(item);
                context.SaveChanges();
            } else throw new FaultException(new FaultReason("Данный товар не найден"));
        }

        public List<Data.Item> GetAllItems()
        {
            return context.Items.ToList();
        }

        public Task<List<Data.Item>> GetItmesLike(string str)
        {
            return context.Items.Where(i => EF.Functions.Like(i.Name.ToLower(), $"{str.ToLower()}%")).ToListAsync();
        }


    }
}

