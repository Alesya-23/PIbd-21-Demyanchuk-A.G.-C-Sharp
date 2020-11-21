using System.Drawing;

namespace WindowsFormsBoat
{
    /// <summary>
    /// Параметризованный класс для хранения набора объектов от интерфейса ITransportBoat
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Parking<T> where T : class, ITransportBoat
    {
        /// <summary>
        /// Массив объектов, которые храним
        /// </summary>
        private readonly T[] _places;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private readonly int pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private readonly int pictureHeight;
        /// <summary>
        /// Размер парковочного места (ширина)
        /// </summary>
        private readonly int _placeSizeWidth = 210;
        /// <summary>
        /// Размер парковочного места (высота)
        /// </summary>
        private readonly int _placeSizeHeight = 80;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="picWidth">Рамзер парковки - ширина</param>
        /// <param name="picHeight">Рамзер парковки - высота</param>
        public Parking(int picWidth, int picHeight)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            _places = new T[width * height];
            pictureWidth = picWidth;
            pictureHeight = picHeight;
        }
        /// <summary>
        /// Перегрузка оператора сложения
        /// Логика действия: на парковку добавляется лодка
        /// </summary>
        /// <param name="p">Парковка</param>
        /// <param name="boat">Добавляемая лодка</param>
        /// <returns></returns>
        public static bool operator +(Parking<T> p, T boat)
        {
            for (int i = 0; i < p._places.Length; i++)
            {
                if (p._places[i] == null)
                {
                    int margin = 10;
                    int x = 0;
                    int y = 0;
                    int placesWidth = p.pictureWidth / p._placeSizeWidth;
                    p._places[i] = boat;
                    boat.SetPosition(x + 4 * margin + (p._placeSizeWidth + margin) * (i % placesWidth),
                    y + margin + p._placeSizeHeight * (i / placesWidth), p.pictureWidth, p.pictureHeight);
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Перегрузка оператора вычитания
        /// Логика действия: с парковки забираем лодку
        /// </summary>
        /// <param name="p">Парковка</param>
        /// <param name="index">Индекс места, с которого пытаемся извлечь
        ///объект</param>
        /// <returns></returns>
        public static T operator -(Parking<T> p, int index)
        {
            if (index >= p._places.Length || index < 0)
            {
                return null;
            }
            T boat = p._places[index];
            p._places[index] = null;
            return boat;
        }
        /// <summary>
        /// Метод отрисовки парковки
        /// </summary>
        /// <param name="g"></param>
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Length; i++)
            {
                _places[i]?.DrawTransport(g);
            }
        }
        /// <summary>
        /// Метод отрисовки разметки парковочных мест
        /// </summary>
        /// <param name="g"></param>
        private void DrawMarking(Graphics g)
        {
            int x = 0;
            int interval = 35;
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < pictureWidth / _placeSizeWidth; i++)
            {
                for (int j = 0; j < pictureHeight / _placeSizeHeight + 1; ++j)
                {//линия рамзетки места
                    g.DrawLine(pen, x + (_placeSizeWidth + interval) * i, j * _placeSizeHeight, x + _placeSizeWidth + (_placeSizeWidth + interval) * i, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * (_placeSizeWidth + interval), 0, i * (_placeSizeWidth + interval), (pictureHeight / _placeSizeHeight) * _placeSizeHeight);
            }
        }
    }
}
