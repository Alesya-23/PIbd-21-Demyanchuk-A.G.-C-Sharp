﻿using NLog;
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

        /// <summary>
        /// Логгер
        /// </summary>
        private readonly Logger logger;
        public FormParking()
        {
            InitializeComponent();
            parkingCollection = new ParkingCollection(pictureBoxParcing.Width,
            pictureBoxParcing.Height);
            logger = LogManager.GetCurrentClassLogger();
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
            logger.Info($"Добавили парковку {maskedTextBoxParking.Text}");
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
                        logger.Info($"Удалили парковку{ listBoxParkings.SelectedItem.ToString()} ");
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
                try
                {
                    if ((parkingCollection[listBoxParkings.SelectedItem.ToString()]) +
                   boat)
                    {
                        Draw();
                        logger.Info($"Добавлена лодка {boat}");
                    }
                    else
                    {
                        MessageBox.Show("Лодку не удалось поставить");
                    }
                    Draw();
                }
                catch (ParkingOverflowException ex)
                {
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                    logger.Warn(ex);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn(ex);
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
                try
                {
                    var boat = parkingCollection[listBoxParkings.SelectedItem.ToString()] -
                   Convert.ToInt32(maskedTextBox.Text);
                    if (boat != null)
                    {
                        FormBoat form = new FormBoat();
                        form.SetBoat(boat);
                        form.ShowDialog();
                        logger.Info($"Изъят автомобиль {boat} с места{ maskedTextBox.Text}");
                        Draw();
                    }
                }
                catch (ParkingNotFoundException ex)
                {
                    MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                    logger.Warn(ex);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn(ex);
                }
            }
        }

        /// <summary>
        /// Метод обработки выбора элемента на listBoxLevels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxParkings_SelectedIndexChanged(object sender, EventArgs e)
        {
            logger.Info($"Перешли на парковку { listBoxParkings.SelectedItem.ToString()}");
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
                try
                {
                    parkingCollection.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                }
                catch
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
                try
                {
                    parkingCollection.LoadData(openFileDialog.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog.FileName);
                    ReloadLevels();
                    Draw();
                }
                catch (ParkingOverflowException ex)
                {
                    MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
