using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_7
{
    class Buying_A_Property<T> where T : IProperty // Обобщённый класс "Покупка недвижимости"
    {
        private string name_buyer_; // Имя покупателя
        private string name_salesman_; // Имя продавца
        private int price_; // Стоимость покупки
        private T property_; // Недвижимость
        private float price_one_metr_; // Стоимость 1 кв.м.
        public Buying_A_Property(string buyer_, string salesman, int price, T property)
        {
            this.name_buyer_ = buyer_;
            this.name_salesman_ = salesman;
            this.price_ = price;
            this.property_ = property;
        }
        public void Info() // Метод для получения информации о сделке
        {
            Console.WriteLine($"Продавец: {name_buyer_}, покупатель: {name_salesman_}, стоимость сделки = {price_} рублей" +
                $".\nОбъект сделки:");
            property_.Abilities();
            Console.WriteLine($"Стоимость квадратного метра = {Price_One_Metr()} рубля за квадратный метр.");
        }
        public float Price_One_Metr() // Метод расчёта стоимости квадратного метра
        {
            return price_ / property_.Square;
        }
    }
}
