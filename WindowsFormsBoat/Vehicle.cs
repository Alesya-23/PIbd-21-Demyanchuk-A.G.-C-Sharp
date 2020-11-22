using System.Drawing;
using WindowsFormsBoat;

namespace WindowsFormsBoat
{
    public abstract class Vehicle : ITransportBoat
    {
        /// <summary>        
        /// Левая координата отрисовки лодки       
        /// /// </summary>       
        protected float _startPosX;

        /// <summary>         
        /// Правая кооридната отрисовки лодки       
        /// </summary>         
        protected float _startPosY;

        /// <summary>         
        /// Ширина окна отрисовки         
        /// </summary>        
        protected int _pictureWidth;

        /// <summary>        
        /// Высота окна отрисовки         
        /// </summary>         
        protected int _pictureHeight;

        /// <summary>        
        /// Максимальная скорость        
        /// </summary>         
        public int MaxSpeed { protected set; get; }

        /// <summary>         
        /// Вес лодки        
        /// </summary>        

        public float Weight { protected set; get; }

        /// <summary>         
        /// Основной цвет корпуса         
        /// </summary>         
        public Color MainColor { protected set; get; }

        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }

        public abstract void DrawTransport(Graphics g);
        public abstract void MoveTransport(Direction direction);
    }
}
