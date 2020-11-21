using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsBoat
{
    public partial class FormParking : Form
    {
        /// <summary>
        /// Объект от класса-парковки
        /// </summary>
        private readonly Parking<Boat> parking;
        public FormParking()
        {
            InitializeComponent();
            parking = new Parking<Boat>(pictureBoxParcing.Width,
            pictureBoxParcing.Height);
            Draw();
        }
        /// <summary>
        /// Метод отрисовки парковки
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxParcing.Width, pictureBoxParcing.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            pictureBoxParcing.Image = bmp;
        }
        /// <summary>
        /// Обработка нажатия кнопки "Припарковать автомобиль"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetBoat_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var boat = new Boat(100, 1000, dialog.Color);

                if (parking + boat)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Парковка переполнена");
                }
            }
        }
        /// <summary>
        /// Обработка нажатия кнопки "Припарковать гоночный автомобиль"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetMotorBoat_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var boat = new MotorBoat(100, 1000, dialog.Color, dialogDop.Color, true, true, true);
                    if (parking + boat)
                    {
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Парковка переполнена");
                    }
                }
            }
        }
        /// <summary>
        /// Обработка нажатия кнопки "Забрать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTakeBoat_Click(object sender, EventArgs e)
        {
            if (maskedTextBox.Text != "")
            {
                var boat = parking - Convert.ToInt32(maskedTextBox.Text);
                if (boat != null)
                {
                    FormBoat form = new FormBoat();
                    form.SetBoat(boat);
                    form.ShowDialog();
                }
                Draw();
            }
        }
    }
}
