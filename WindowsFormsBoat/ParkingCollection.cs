using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WindowsFormsBoat
{
    /// <summary>
    /// Класс-коллекция парковок
    /// </summary>
    public class ParkingCollection
    {
        /// <summary>
        /// Словарь (хранилище) с парковками
        /// </summary>
        readonly Dictionary<string, Parking<Vehicle>> parkingStages;
        /// <summary>
        /// Возвращение списка названий парковок
        /// </summary>
        public List<string> Keys => parkingStages.Keys.ToList();

        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private readonly int pictureWidth;

        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private readonly int pictureHeight;

        /// <summary>
        /// Разделитель для записи информации в файл
        /// </summary>
        private readonly char separator = ':';

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="pictureWidth"></param>
        /// <param name="pictureHeight"></param>
        public ParkingCollection(int pictureWidth, int pictureHeight)
        {
            parkingStages = new Dictionary<string, Parking<Vehicle>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }
        /// <summary>
        /// Добавление парковки
        /// </summary>
        /// <param name="name">Название парковки</param>
        public void AddParking(string name)
        {
            if (parkingStages.ContainsKey(name))
            {
                return;
            }
            parkingStages.Add(name, new Parking<Vehicle>(pictureWidth, pictureHeight));
        }
        /// <summary>
        /// Удаление парковки
        /// </summary>
        /// <param name="name">Название парковки</param>
        public void DelParking(string name)
        {
            if (parkingStages.ContainsKey(name))
            {
                parkingStages.Remove(name);
            }
        }
        public void DelParking(int index)
        {
            if (parkingStages.ContainsKey(Keys[index]))
            {
                parkingStages.Remove(Keys[index]);
            }
        }
        /// <summary>
        /// Доступ к парковке
        /// </summary>
        /// <param name="ind"></param>
        /// <returns></returns>
        public Parking<Vehicle> this[string ind]
        {
            get
            {
                if (parkingStages.ContainsKey(ind))
                {
                    return parkingStages[ind];
                }
                return null;
            }
        }
        /// <summary>
        /// Сохранение информации по лодке на парковках в файл
        /// </summary>
        /// <param name="filename">Путь и имя файла</param>
        /// <returns></returns>
        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter fs = new StreamWriter(filename))
            {
                fs.Write($"ParkingCollection{Environment.NewLine}");
                foreach (var level in parkingStages)
                {
                    //Начинаем парковку
                    fs.Write($"Parking{separator}{level.Key}{Environment.NewLine}");
                    ITransportBoat boat = null;
                    for (int i = 0; (boat = level.Value.GetNext(i)) != null; i++)
                    {
                        if (boat != null)
                        {
                            //если место не пустое
                            //Записываем тип лодки
                            if (boat.GetType().Name == "Boat")
                            {
                                fs.Write($"Boat{separator}");
                            }
                            if (boat.GetType().Name == "MotorBoat")
                            {
                                fs.Write($"MotorBoat{separator}");
                            }
                            //Записываемые параметры
                            fs.Write(boat + Environment.NewLine);
                        }
                    }
                }
            }
            return true;
        }
        /// <summary>
        /// Загрузка нформации по лодкам на парковках из файла
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }
            using (StreamReader fs = new StreamReader(filename))
            {
                UTF8Encoding temp = new UTF8Encoding(true);
                string strs = fs.ReadLine();
                if (!strs.Contains("ParkingCollection"))
                {
                    //если нет такой записи, то это не те данные
                    return false;
                }
                Vehicle boat = null;
                string key = string.Empty;
                while ((strs = fs.ReadLine()) != null)
                {
                    //идем по считанным записям
                    if (strs.Contains("Parking"))
                    {
                        key = strs.Split(separator)[1];
                        parkingStages.Add(key, new Parking<Vehicle>(pictureWidth, pictureHeight));
                    }
                    else if (strs.Contains(separator))
                    {
                        if (strs.Contains("Boat"))
                        {
                            boat = new Boat(strs.Split(separator)[1]);
                        }
                        if (strs.Contains("MotorBoat"))
                        {
                            boat = new MotorBoat(strs.Split(separator)[1]);
                        }
                        if (!(parkingStages[key] + boat))
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
        }
    }
}
