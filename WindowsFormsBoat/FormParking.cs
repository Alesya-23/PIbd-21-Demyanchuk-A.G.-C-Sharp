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
        private readonly ParkingCollection parkingCollection;
        public FormParking()
        {
            InitializeComponent();
            parkingCollection = new ParkingCollection(pictureBoxParcing.Width,
            pictureBoxParcing.Height);
        }

        /// <summary>
        /// Заполнение listBoxLevels
        /// </summary>
        private void ReloadLevels()
        {
            int index = listBoxParkings.SelectedIndex;
            listBoxParkings.Items.Clear();
            for (int i = 0; i < parkingCollection.Keys.Count; i++)
            {
                listBoxParkings.Items.Add(parkingCollection.Keys[i]);
            }
            if (listBoxParkings.Items.Count > 0 && (index == -1 || index >=
           listBoxParkings.Items.Count))
            {
                listBoxParkings.SelectedIndex = 0;
            }
            else if (listBoxParkings.Items.Count > 0 && index > -1 && index <
           listBoxParkings.Items.Count)
            {
                listBoxParkings.SelectedIndex = index;
            }
        }
        /// <summary>
        /// Метод отрисовки парковки
        /// </summary>
        private void Draw()
        {
            if (listBoxParkings.SelectedIndex > -1)
            {
                //если выбран один из пуктов в listBox (при старте программы ни один пункт 
                //не будет выбран и может возникнуть ошибка, если мы попытаемся обратиться к элементу
                // listBox)
                Bitmap bmp = new Bitmap(pictureBoxParcing.Width, pictureBoxParcing.Height);
                Graphics gr = Graphics.FromImage(bmp);
                pictureBoxParcing.Image = bmp;
                parkingCollection[listBoxParkings.SelectedItem.ToString()].Draw(gr);
                pictureBoxParcing.Image = bmp;
            }
        }
        /// <summary>
        /// Обработка нажатия кнопки "Добавить парковку"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddParking_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maskedTextBoxParking.Text))
            {
                MessageBox.Show("Введите название парковки", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            parkingCollection.AddParking(maskedTextBoxParking.Text);
            ReloadLevels();
        }
        /// <summary>
        /// Обработка нажатия кнопки "Удалить парковку"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelParking_Click(object sender, EventArgs e)
        {
            {
                if (listBoxParkings.SelectedIndex > -1)
                {
                    if (MessageBox.Show($"Удалить парковку { listBoxParkings.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        parkingCollection.DelParking(maskedTextBoxParking.Text);
                        ReloadLevels();
                    }
                }
                Draw();
            }
        }
        /// <summary>
        /// Обработка нажатия кнопки "Припарковать лодку"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddBoat(object sender, EventArgs e)
        {
            FormBoatConfig formBoatConfig = new FormBoatConfig();
            formBoatConfig.AddEvent(AddBoat);
            formBoatConfig.ShowDialog();
        }

        /// <summary>
        /// Метод добавления лодки
        /// </summary>
        /// <param name="car"></param>
        private void AddBoat(Vehicle boat)
        {
            if (boat != null && listBoxParkings.SelectedIndex > -1)
            {
                if ((parkingCollection[listBoxParkings.SelectedItem.ToString()]) + boat)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Лодку не удалось поставить");
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
            if (listBoxParkings.SelectedIndex > -1 && maskedTextBox.Text != "")
            {
                var boat = parkingCollection[listBoxParkings.SelectedItem.ToString()] -
               Convert.ToInt32(maskedTextBox.Text);
                if (boat != null)
                {
                    FormBoat form = new FormBoat();
                    form.SetBoat(boat);
                    form.ShowDialog();
                }
                Draw();
            }
        }

        /// <summary>
        /// Метод обработки выбора элемента на listBoxLevels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxParkings_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }

        /// <summary>
        /// Обработка нажатия пункта меню "Сохранить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (parkingCollection.SaveData(saveFileDialog.FileName))
                {
                    MessageBox.Show("Сохранение прошло успешно", "Результат",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не сохранилось", "Результат",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Обработка нажатия пункта меню "Загрузить"
        /// </summary
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (parkingCollection.LoadData(openFileDialog.FileName))
                {
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                    ReloadLevels();
                    Draw();
                }
                else
                {
                    MessageBox.Show("Не загрузили", "Результат", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
        }
    }
}
