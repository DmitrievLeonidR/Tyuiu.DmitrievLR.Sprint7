using System;
using System.IO;
using System.Windows.Forms;
using Tyuiu.DmitrievLR.Sprint7.Project.V9.Lib;



namespace Tyuiu.DmitrievLR.Sprint7.Project.V9
{
    public partial class FormAddFile : Form
    {
        private readonly DataService ds = new DataService();

        public FormAddFile()
        {
            InitializeComponent();
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            using var openFileDialog = new OpenFileDialog
            {
                Filter = "Видео файл|*.mp4;*.mov;*.wmv;*.avi",
                Title = "Выберите видеофайл"
            };

            if (openFileDialog.ShowDialog(this) == DialogResult.OK && File.Exists(openFileDialog.FileName))
            {
                textBoxFilePath.Text = openFileDialog.FileName;
            }
            else
            {
                MessageBox.Show("Файл не существует или не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonSaveInfo_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput(out string errorMessage))
                {
                    MessageBox.Show(errorMessage, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Считываем значения из текстовых полей
                string filePath = textBoxFilePath.Text;
                string fileName = textBoxName.Text;
                string description = textBoxDesc.Text;

                int hours = int.Parse(textBoxH.Text);
                int minutes = int.Parse(textBoxM.Text);
                int seconds = int.Parse(textBoxS.Text);

                // Вызов SaveInfo с правильным порядком и типами аргументов
                bool isSaved = ds.SaveInfo(filePath, fileName, hours, minutes, seconds, description);

                if (isSaved)
                {
                    MessageBox.Show("Файл успешно сохранен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Файл уже существует в списке", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool ValidateInput(out string errorMessage)
        {
            errorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(textBoxFilePath.Text) || !File.Exists(textBoxFilePath.Text))
            {
                errorMessage = "Укажите существующий файл.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                errorMessage = "Введите название файла.";
                return false;
            }

            if (!int.TryParse(textBoxH.Text, out int hours) || hours < 0)
            {
                errorMessage = "Введите корректное значение часов.";
                return false;
            }

            if (!int.TryParse(textBoxM.Text, out int minutes) || minutes < 0 || minutes > 59)
            {
                errorMessage = "Введите корректное значение минут (0-59).";
                return false;
            }

            if (!int.TryParse(textBoxS.Text, out int seconds) || seconds < 0 || seconds > 59)
            {
                errorMessage = "Введите корректное значение секунд (0-59).";
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxDesc.Text))
            {
                errorMessage = "Введите описание файла.";
                return false;
            }

            return true;
        }
    }
}
