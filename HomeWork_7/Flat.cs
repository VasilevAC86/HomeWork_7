using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_7
{
    public class Flat: IProperty // Класс "Квартира"
    {
        private int floor_; // Номер этажа
        private bool loggia_; // Наличие лоджии
        private bool gas_; // Наличие газа
        public string Type => "Квартира";
        public string Adress { get; } // Адрес
        public int Rooms { get; } // Кол-во комнат
        public float Square { get; } // Площадь
        public Flat(string adress, int rooms, float square, int floor_, bool loggia_, bool gas_)
        {
            this.Adress = adress;
            this.Rooms = rooms;
            this.Square = square;
            this.floor_ = floor_;
            this.loggia_ = loggia_;
            this.gas_ = gas_;
        }
        public void Abilities() // Метод получения св-в квартиры
        {
            Console.Write($"{Type}, по адресу: {Adress}, {Rooms} комнат, общая площадь = {Square} кв.м., этаж = {floor_}, лоджия ");
            if (loggia_)
                Console.Write("есть, газ ");
            else
                Console.Write("нет, газ ");
            if (gas_)
                Console.WriteLine("eсть.");
            else
                Console.WriteLine("нет.");
        }
    }
}
