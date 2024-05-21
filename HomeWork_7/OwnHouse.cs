using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_7
{
    public class OwnHouse:IProperty // Класс "Собственный дом"
    {
        private int floors_; // Кол-во этажей
        private float area_; // Площадь участка
        public string Type => "Собственный дом";
        public string Adress { get; } // Адрес
        public int Rooms { get; } // Кол-во комнат
        public float Square { get; } // Площадь
        public OwnHouse(string adress, int floors_, float area_, int rooms, float square)
        {
            this.floors_ = floors_;
            this.area_ = area_;
            Adress = adress;
            Rooms = rooms;
            Square = square;
        }
        public void Abilities() // Метод получения св-в квартиры
        {
            Console.WriteLine($"{Type}, по адресу: {Adress}, {Rooms} комнат, общая площадь дома = {Square} кв.м," +
                $" в доме {floors_} этажей, площадь участка = {area_} кв.м.");
        }
    }
}
