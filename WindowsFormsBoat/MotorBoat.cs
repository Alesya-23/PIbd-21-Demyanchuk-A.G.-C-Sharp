using System;
using System.Drawing;

namespace WindowsFormsBoat
{
    public class MotorBoat : Boat, IEquatable<MotorBoat>
    {
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
        public MotorBoat(int maxSpeed, float weight, Color mainColor, Color dopColor, bool sideLine, bool cabin,
            bool motors) : base(maxSpeed, weight, mainColor, 110, 60)
        {
            DopColor = dopColor;
            SideLine = sideLine;
            Cabin = cabin;
            Motors = motors;
        }

        /// <summary>
        /// Конструктор для загрузки с файла
        /// </summary>
        /// <param name="info"></param>
        public MotorBoat(string info) : base(info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 7)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                SideLine = Convert.ToBoolean(strs[4]);
                Cabin = Convert.ToBoolean(strs[5]);
                Motors = Convert.ToBoolean(strs[6]);
            }
        }

        /// <summary>        
        /// Отрисовка лодки      
        /// /// </summary>        
        /// <param name="g"></param>        
        public override void DrawTransport(Graphics g)
        {
            base.DrawTransport(g);
            //корпус
            Brush brush1 = new SolidBrush(DopColor);
            Pen pen1 = new Pen(Color.White);
            if (Cabin)
            {
                //кабина катера
                g.FillEllipse(brush1, _startPosX + 15, _startPosY - 3, 70, 15);
                g.FillEllipse(brush1, _startPosX + 25, _startPosY - 1, 40, 10);
            }
            if (SideLine)
            {
                //линии
                g.DrawLine(pen1, _startPosX, _startPosY + 20, _startPosX + 100, _startPosY + 20);
                g.DrawLine(pen1, _startPosX + 12, _startPosY, _startPosX + 70, _startPosY);
            }

            if (Motors)
            {
                //моторы
                Brush brush2 = new SolidBrush(Color.Black);
                g.FillRectangle(brush2, _startPosX + 100, _startPosY + 10, 5, 5);
                g.FillRectangle(brush2, _startPosX + 100, _startPosY + 16, 5, 5);
                g.FillRectangle(brush2, _startPosX + 100, _startPosY + 22, 5, 5);
            }
        }

        /// <summary>
        /// Смена дополнительного цвета
        /// </summary>
        /// <param name="color"></param>
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }
        public override string ToString()
        {
            return $"{base.ToString()}{separator}{DopColor.Name}{separator}" +
                   $"{SideLine}{separator}{Cabin}{separator}{Motors}";
        }

        /// <summary>
        /// Метод интерфейса IEquatable для класса SportCar
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(MotorBoat other)
        {
            if (other == null)
            {
                return false;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (DopColor != other.DopColor)
            {
                return false;
            }
            if (SideLine != other.SideLine)
            {
                return false;
            }
            if (Cabin != other.Cabin)
            {
                return false;
            }
            if (Motors != other.Motors)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Перегрузка метода от object
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is MotorBoat BoatObj))
            {
                return false;
            }
            else
            {
                return Equals(BoatObj);
            }
        }
    }
}
