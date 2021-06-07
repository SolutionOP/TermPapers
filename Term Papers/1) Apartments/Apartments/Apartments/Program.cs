using System;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            string positionOfApartment;
            Console.WriteLine("Введите количество подъездов:");
            int entrance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество этажей:");
            int floor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите номер квартиры:");
            double apartments = Convert.ToDouble(Console.ReadLine());

            double IndexOfApartment = apartments % 4;
            switch (IndexOfApartment)
            {
                case 2:
                    positionOfApartment = "Верх лево";
                    break;
                case 0:
                    positionOfApartment = "Низ право";
                    break;
                case 1:
                    positionOfApartment = "Низ лево";
                    break;
                case 3:
                    positionOfApartment = "Верх право";
                    break;
                default:
                    positionOfApartment = "Неизвестное местоположение квартиры";
                    break;
            }
            int CountOfAllApartments = entrance * floor * 4;
            int CountOfRoomsInOneEntrance = CountOfAllApartments / entrance;
            int NumberOfEntrance = Convert.ToInt32((apartments / CountOfRoomsInOneEntrance));
            int CountOfLossRooms = (Convert.ToInt32(apartments) / 12) * 12;
            int MinApartmentsNumber = CountOfLossRooms + 1;
            double NumberOfFloor = ((apartments - MinApartmentsNumber) + 1) / 4;
            double NewNumberOfFloor = Math.Ceiling(NumberOfFloor);
            if (apartments > CountOfAllApartments)
            {
                Console.WriteLine("Такой квартиры в доме нет");
            }
            else
            {
                Console.WriteLine("Расположение квартиры: {0}",positionOfApartment);
                Console.WriteLine("Квартира находится на {0} этаже",NewNumberOfFloor);
                Console.WriteLine("Квартира находится в {0} подъезде",NumberOfEntrance);
            }
        }
    }
}
