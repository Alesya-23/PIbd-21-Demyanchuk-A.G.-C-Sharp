using System;
namespace WindowsFormsBoat
{
    /// <summary>
    /// Класс-ошибка "Если не найден автомобиль по определенному месту"
    /// </summary>
    public class ParkingNotFoundException : Exception
    {
        public ParkingNotFoundException(int i) : base("Не найдена лодка по месту "
       + i)
        { }
    }
}
