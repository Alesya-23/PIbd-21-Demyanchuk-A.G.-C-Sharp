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
        /// Метод записи информации в файл
        /// </summary>
        /// <param name="text">Строка, которую следует записать</param>
        /// <param name="stream">Поток для записи</param>
        private void WriteToFile(string text, FileStream stream)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(text);
            stream.Write(info, 0, info.Length);
        }
        /// <summary>
        /// Сохранение информации по автомобилям на парковках в файл
        /// </summary>
        /// <param name="filename">Путь и имя файла</param>
        public void SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                WriteToFile($"ParkingCollection{Environment.NewLine}", fs);
                foreach (var level in parkingStages)
                {
                    //Начинаем парковку
                    WriteToFile($"Parking{separator}{level.Key}{Environment.NewLine}",
                    fs);
                    foreach (ITransportBoat boat in level.Value)
                    {
                        //Записываем тип мшаины
                        if (boat.GetType().Name == "Boat")
                        {
                            WriteToFile($"Boat{separator}", fs);
                        }
                        if (boat.GetType().Name == "MotorBoat")
                        {
                            WriteToFile($"MotorBoat{separator}", fs);
                        }
                        //Записываемые параметры
                        WriteToFile(boat + Environment.NewLine, fs);
                    }
                }
            }
        }
        /// <summary>
        /// Загрузка нформации по лодкам на парковках из файла
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public void LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }
            using (StreamReader fs = new StreamReader(filename))
            {
                UTF8Encoding temp = new UTF8Encoding(true);
                string strs = fs.ReadLine();
                if (!strs.Contains("ParkingCollection"))
                {
                    throw new ArgumentException("Неверный формат файла");
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
                            throw new IndexOutOfRangeException("Не удалось загрузить лодку на парковку");
                        }
                    }
                }
            }
        }
    }
}
