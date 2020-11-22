using System.Drawing;
using WindowsFormsCars;

namespace WindowsFormsBoat
{
    public class Boat : Vehicle
    {
        /// <summary>         
        /// Ширина отрисовки лодки         
        /// </summary> 
        protected readonly int boatWidth = 103;
        /// <summary>         
        /// Высота отрисовки лодки         
        /// </summary>         
        protected readonly int boatHeight = 42;

        /// <summary>        
        /// Конструктор         
        /// </summary>         
        /// <param name="maxSpeed">Максимальная скорость</param>         
        /// <param name="weight">Вес лодки</param>         
        /// <param name="mainColor">Основной цвет корпуса</param>        
        public Boat(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }

        /// <summary>
        /// Конструкторс изменением размеров машины
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес лодки</param>
        /// <param name="mainColor">Основной цвет корпуса лодки</param>
        /// <param name="boatWidth">Ширина отрисовки лодки</param>
        /// <param name="boatHeight">Высота отрисовки лодки</param>
        protected Boat(int maxSpeed, float weight, Color mainColor, int boatWidth, int
            boatHeight)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            this.boatWidth = boatWidth;
            this.boatHeight = boatHeight;
        }

        /// <summary>         
        ///Изменение направления пермещения         
        /// </summary>        
        /// <param name="direction">Направление</param>         
        public override void MoveTransport(Direction direction)
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
        public override void DrawTransport(Graphics g)
        {
            //корпус
            Brush brush = new SolidBrush(MainColor);
            Pen pen1 = new Pen(Color.White);
            g.FillEllipse(brush, _startPosX, _startPosY, 100, 35);
            g.DrawLine(pen1, _startPosX - 10, _startPosY + 22, _startPosX + 100, _startPosY + 22);
        }
    }
}
