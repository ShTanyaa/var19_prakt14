using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class Dogs
    {
        private string breed;
        private string data;
        private string name;
        private string owner;

        public string Breed { get { return breed; } set { breed = value; } }
        public string Data { get { return data; } set { data = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Owner { get { return owner; } set { owner = value; } }

        public Dogs(string breed, string data, string name, string owner)
        {
           this.breed = breed;
            this.data = data;
            this.name = name;
            this.owner = owner;
        }

        public abstract string Info();
        /*public void Info()
        {
            while(true)
            {
                Console.Write("порода собаки: ");
                breed = Console.ReadLine();
                if (breed == "") break;
                Console.Write("дата рождения собаки: ");
                data = Console.ReadLine();
                if (data == "") break;
                Console.Write("кличка собаки: ");
                name = Console.ReadLine();
                if (name == "") break;
                Console.Write("владелец собаки: ");
                owner = Console.ReadLine();
                if (owner == "") break;
                break;
            }
        }*/
        public string info()
        {
            return ($"порода собаки: {breed}\nдата рождения собаки: {data}\nкличка собаки: {name}\nвладелец собаки: {owner}");
        }

    }
}
