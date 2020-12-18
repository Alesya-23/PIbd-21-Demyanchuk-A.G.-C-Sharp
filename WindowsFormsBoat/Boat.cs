﻿using System;
using System.Drawing;

namespace WindowsFormsBoat
{
    public class Boat : Vehicle, IEquatable<Boat>
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
        /// Разделитель для записи информации в файл
        /// </summary>
        public readonly char separator = ';';

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
        /// Конструктор для загрузки с файла
        /// </summary>
        /// <param name="info">Информация по объекту</param>
        public Boat(string info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
            }
        }

        /// <summary>
        /// Конструкторс изменением размеров лодки
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
            g.DrawLine(pen1, _startPosX, _startPosY + 22, _startPosX + 100, _startPosY + 22);
        }
        public override string ToString()
        {
            return $"{MaxSpeed}{separator}{Weight}{separator}{MainColor.Name}";
        }

        /// <summary>
        /// Метод интерфейса IEquatable для класса Boat
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(Boat other)
        {
            if (other == null)
            {
                return false;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return false;
            }
            if (Weight != other.Weight)
            {
                return false;
            }
            if (MainColor != other.MainColor)
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
            if (!(obj is Boat boatObj))
            {
                return false;
            }
            else
            {
                return Equals(boatObj);
            }
        }
    }
}
