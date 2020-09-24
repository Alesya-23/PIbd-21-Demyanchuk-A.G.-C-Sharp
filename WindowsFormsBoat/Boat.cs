using System.Drawing;


namespace WindowsFormsBoat
{
    class Boat
    {
        /// <summary>        
        /// Левая координата отрисовки лодки       
        /// /// </summary>       
        private float _startPosX;

        /// <summary>         
        /// Правая кооридната отрисовки лодки       
        /// </summary>         
        private float _startPosY;

        /// <summary>         
        /// Ширина окна отрисовки         /// </summary>        
        private int _pictureWidth;

        /// <summary>        
        /// Высота окна отрисовки         
        /// </summary>         
        private int _pictureHeight;
        /// <summary>         
        /// Ширина отрисовки лодки         
        /// </summary> 
        private readonly int boatWidth = 103;
        /// <summary>         
        /// Высота отрисовки лодки         
        /// </summary>         
        private readonly int boatHeight = 42;


        /// <summary>        
        /// Максимальная скорость        
        /// </summary>         
        public int MaxSpeed { private set; get; }

        /// <summary>         
        /// Вес лодки        
        /// </summary>        

        public float Weight { private set; get; }

        /// <summary>         
        /// Основной цвет корпуса         
        /// </summary>         
        public Color MainColor { private set; get; }

        /// <summary>         
        ///Дополнительный цвет   (для полос)      
        /// </summary>         
        public Color DopColor { private set; get; }

        /// <summary>      
        /// Признак наличия боковых линий        
        /// </summary>         
        public bool SideLine { private set; get; }

        // наличие кабины
        public bool Cabin { private set; get; }

        // наличие мотора
        public bool Motors { private set; get; }


        /// <summary>        
        /// Конструктор         
        /// </summary>         
        /// <param name="maxSpeed">Максимальная скорость</param>         
        /// <param name="weight">Вес лодки</param>         
        /// <param name="mainColor">Основной цвет корпуса</param>        
        /// <param name="dopColor">Дополнительный цвет (для полос) </param>                 
        /// <param name="sideLine">Признак наличия боковых полос</param>   
        /// <param name="cabin"><кабина катера/param>
        /// <param name="motors">мотор </param>

        public Boat(int maxSpeed, float weight, Color mainColor, Color dopColor, bool sideLine, bool cabin, bool motors)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            SideLine = sideLine;
            Cabin = cabin;
            Motors = motors;
        }

        /// <summary>         
        /// Установка позиции лодки
        /// </summary>      
        /// <param name="x">Координата X</param>        
        /// <param name="y">Координата Y</param>         
        /// <param name="width">Ширина картинки</param>        
        /// <param name="height">Высота картинки</param>        
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }

        /// <summary>         
        ///Изменение направления пермещения         
        /// </summary>        
        /// <param name="direction">Направление</param>         
        public void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо                 
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - boatWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево               
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;

                    }
                    break;
                //вверх              
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз                 
                case Direction.Down:

                    if (_startPosY + step < _pictureHeight - boatHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }

        /// <summary>        
        /// Отрисовка лодки      
        /// /// </summary>        
        /// <param name="g"></param>        
        public void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            //корпус
            Brush brush = new SolidBrush(MainColor);
            Brush brush1 = new SolidBrush(DopColor);
            Pen pen1 = new Pen(Color.White);
            g.FillEllipse(brush, _startPosX, _startPosY, 100, 35);
            g.DrawLine(pen1, _startPosX + 12, _startPosY, _startPosX + 70, _startPosY);
            if (Cabin)
            {
                //кабина катера
                g.FillEllipse(brush1, _startPosX + 15, _startPosY - 3, 70, 15);
                g.FillEllipse(brush1, _startPosX + 25, _startPosY - 1, 40, 10);
            }
            if (SideLine)
            {
                //линии
                g.DrawLine(pen1, _startPosX - 10, _startPosY + 20, _startPosX + 100, _startPosY + 20);
                g.DrawLine(pen1, _startPosX - 10, _startPosY + 22, _startPosX + 100, _startPosY + 22);
                g.DrawLine(pen1, _startPosX + 12, _startPosY, _startPosX + 70, _startPosY);
            }

            if (Motors)
            {
                //
                Brush brush2 = new SolidBrush(Color.Black);
                g.FillRectangle(brush2, _startPosX + 100, _startPosY + 10, 5, 5);
                g.FillRectangle(brush2, _startPosX + 100, _startPosY + 16, 5, 5);
                g.FillRectangle(brush2, _startPosX + 100, _startPosY + 22, 5, 5);
            }
        }
    }
}
