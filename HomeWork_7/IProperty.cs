using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_7
{
    interface IProperty // Интерфейс "Имущество"
    {
        string Type { get; } // Вид недвижимости
        string Adress { get; } // Адрес объекта
        int Rooms { get; } // Кол-во комнат объекта
        float Square { get; } // Площадь объекта
        void Abilities(); // Метод получения св-в объекта
    }
}
