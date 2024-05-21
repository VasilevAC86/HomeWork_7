namespace HomeWork_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Flat flat = new Flat("Екатеринбург, ул. Белинского, д.30, кв. 25", 2, 43.5f, 2, false, false);
            OwnHouse own = new OwnHouse("Екатеринбург, ул. Озёрная, д.5", 2, 850f, 5, 111.11f);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Сделка по продаже квартиры:\n");
            Console.ForegroundColor= ConsoleColor.White;
            Buying_A_Property<Flat> buying_flat = new Buying_A_Property<Flat>("ООО \'Рога и копыта\'", "Вася", 2500000, flat);
            buying_flat.Info();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nСделка по продаже частного дома:\n");
            Console.ForegroundColor = ConsoleColor.White;
            Buying_A_Property<OwnHouse> buying_house = new Buying_A_Property<OwnHouse>("ООО \'Жулики\'", "Петя", 8500000, own);
            buying_house.Info();            
        }
    }
}