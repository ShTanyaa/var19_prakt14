using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public  class WorkingDogs:Dogs
    {
        private string trainer;
        private string type_of_service;

        public string Trainer { get { return trainer; } set { trainer = value; } }
        public string Type_of_service { get { return type_of_service; } set { type_of_service = value; } }

        public WorkingDogs(string trainer, string type_of_service, string breed, string data, string name, string owner):base( breed,  data,  name, owner)
        {
            this.trainer = trainer;
            this.type_of_service = type_of_service;
        }

        public override string Info()
        {
            return($"дрессировщик: {trainer}\nвид занятия: {type_of_service}");
        }
        /*public void Zanatie()
        {
            while (true)
            {
                Console.Write("введите дрессировщика: ");
                trainer = Console.ReadLine();
                if (trainer == "") break;
                Console.Write("введите вид занятие: ");
                type_of_service = Console.ReadLine();
                if (type_of_service == "") break;
                break;
            }
        }*/
    }
}
