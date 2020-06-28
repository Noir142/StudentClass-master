using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClass
{
    class Undergard
    {
        public double price { get; set; }
        public int age { get; set; }
        public string place { get; set; }
        public string name { get; set; }

        public void GetUndergradInfo()
        {
            Console.WriteLine($"Имя: {name}| |Возраст: {age}| |Группа: {place}|");
        }
    }

    
    class Classman : Undergard
    {
        public string type { get; set; }

        public virtual void GetClassmanInfo()
        {
            Console.WriteLine($"Имя: {name}| |Возраст: {age}| |Группа: {place}| |Стоимость обучения (в руб): {price}| |Тип: {type}");
        }
    }
}