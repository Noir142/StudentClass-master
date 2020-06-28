using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClass
{
    class Program
    {
        static void Main(string[] args)
        {

            Undergard undergrad = new Undergard();
            undergrad.name = "Тест Тестович";
            undergrad.price = 45;
            undergrad.age = 19;
            undergrad.place = "ПКС-18-01";
            
            undergrad.GetUndergradInfo();

            Classman classman = new Classman();
            classman.type = "Платник";
            classman.name = "Иванов.И.И";
            classman.place = "ССА-20-01";
            classman.price = 35000;
            classman.age = 20;

            classman.GetClassmanInfo();

            Console.ReadLine();
        }
    }
}
