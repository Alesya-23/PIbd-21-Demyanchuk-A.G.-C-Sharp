using System.Drawing;

namespace WindowsFormsBoat
{
    public class MotorBoat : Boat
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
            bool motors) : base (maxSpeed, weight, mainColor, 110, 60)
        {
            DopColor = dopColor;
            SideLine = sideLine;
            Cabin = cabin;
            Motors = motors;
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
                g.DrawLine(pen1, _startPosX - 10, _startPosY + 20, _startPosX + 100, _startPosY + 20);
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
    }
}
