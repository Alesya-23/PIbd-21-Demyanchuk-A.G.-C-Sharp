using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsBoat
{
    public partial class FormBoat : Form
    {
        private ITransportBoat boat;
        public FormBoat()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Передача лодки на форму
        /// </summary>
        /// <param name="boat"></param>
        public void SetBoat(ITransportBoat boat)
        {
            this.boat = boat;
            Draw();
        }
        /// <summary>       
        /// Метод отрисовки лодки       
        /// </summary>         
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoat.Width, pictureBoat.Height);
            Graphics gr = Graphics.FromImage(bmp);
            boat.DrawTransport(gr);
            pictureBoat.Image = bmp;
        }

       /// <summary>     
        /// Обработка нажатия кнопки "Создать катер"   
        /// </summary> 
        /// <param name="sender"></param>  
        /// <param name="e"></param>     
        private void buttonCreatBoat_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            boat = new Boat(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Green);
            boat.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoat.Width,
            pictureBoat.Height);
            Draw();
        }
        /// <summary>     
        /// Обработка нажатия кнопки "Создать лодку"   
        /// </summary> 
        /// <param name="sender"></param>  
        /// <param name="e"></param>   
        private void createMotorBoat_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            boat = new MotorBoat(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Green, Color.Red, true, true, true);
            boat.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoat.Width, pictureBoat.Height);
            Draw();
        }
        /// <summary>    
        /// Обработка нажатия кнопок управления     
        /// </summary>         
        /// <param name="sender"></param>     
        /// <param name="e"></param>      
        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки            
            string name = (sender as Button).Name;
            switch (name)
            {
                case "btUp":
                    boat.MoveTransport(Direction.Up);
                    break;
                case "btDown":
                    boat.MoveTransport(Direction.Down);
                    break;
                case "btLeft":
                    boat.MoveTransport(Direction.Left);
                    break;
                case "btRigth":
                    boat.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }
    }
}
