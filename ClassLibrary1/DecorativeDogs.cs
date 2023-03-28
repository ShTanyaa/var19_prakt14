using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibrary1
{
    public  class DecorativeDogs:Dogs
    {
        private string show;
        private string haircut;
        private string kol_medalei;

       
        public string Show { get { return show; } set { show = value; } }
        public string Haircut { get { return haircut; } set { haircut = value; } }
        public string Kol_medalei { get { return kol_medalei; } set { kol_medalei = value; } }

        public DecorativeDogs(string show, string haircut,string kol_medalei, string breed, string data, string name, string owner) : base(breed, data, name, owner)
        {
            this.show = show;
            this.haircut = haircut;
            this.kol_medalei = kol_medalei;
        }
        public override string Info()
        {
            return ($"участие в выставках(да или нет): {show}\nнуждается ли собака в стрижке: {haircut}\nкол-во медалей у собаки: {kol_medalei}");
        }
       /* public void Inform()
        {
            while(true)
            {
                Console.Write("участие в выставках(да или нет): ");
                show = Console.ReadLine();
                if (show == "") break;
                Console.Write("нуждается ли собака в стрижке: ");
                haircut = Console.ReadLine();
                if (haircut == "") break;
                Console.Write("кол-во медалей у собаки: ");
                kol_medalei = Console.ReadLine();
                if (kol_medalei == "") break;
                break;
            }
            
        }*/
    }
}
