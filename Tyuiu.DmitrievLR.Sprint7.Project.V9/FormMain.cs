using System;
using System.IO;
using System.Windows.Forms;
using Tyuiu.DmitrievLR.Sprint7.Project.V9.Lib;

namespace Tyuiu.DmitrievLR.Sprint7.Project.V9
{
    public partial class FormMain : Form
    {
        private readonly DataService ds = new DataService();

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            try
            {
                ds.EnsurePlaylistExists(); // Создает файл, если его нет
                RefreshPlaylist(); // Обновляем список
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке плейлиста: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshPlaylist()
        {
            try
            {
                var data = ds.GetPlaylist(); // Получаем список записей

                dataGridViewPlaylist.Rows.Clear();
                foreach (var entry in data)
                {
                    var index = dataGridViewPlaylist.Rows.Add();
                    dataGridViewPlaylist.Rows[index].Cells[0].Value = entry[1]; // Имя файла
                    dataGridViewPlaylist.Rows[index].HeaderCell.Value = entry[0]; // Путь к файлу
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обновлении плейлиста: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAddFile_Click(object sender, EventArgs e)
        {
            using var formAddFile = new FormAddFile();
            if (formAddFile.ShowDialog() == DialogResult.OK)
            {
                RefreshPlaylist(); // Обновляем список после добавления файла
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            using var formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void FormMain_Activated(object sender, EventArgs e)
        {
            RefreshPlaylist(); // Обновляем список при активации формы
        }

        private void dataGridViewPlaylist_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0 || e.RowIndex >= dataGridViewPlaylist.RowCount)
                {
                    return;
                }

                var data = ds.GetPlaylist();
                var entry = data[e.RowIndex];

                string filePath = entry[0];
                if (File.Exists(filePath))
                {
                    WMP.URL = filePath;
                    textBoxFilePath.Text = entry[0];
                    textBoxName.Text = entry[1];
                    textBoxH.Text = entry[2];
                    textBoxM.Text = entry[3];
                    textBoxS.Text = entry[4];
                    textBoxDesc.Text = entry[5];
                }
                else
                {
                    MessageBox.Show("Файл не существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при открытии файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDeleteFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewPlaylist.SelectedCells.Count == 0)
                {
                    MessageBox.Show("Выберите строку для удаления!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int selectedIndex = dataGridViewPlaylist.SelectedCells[0].RowIndex;

                if (ds.DeleteInfo(selectedIndex))
                {
                    MessageBox.Show("Файл успешно удален", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    WMP.URL = string.Empty;
                }
                else
                {
                    MessageBox.Show("Не удалось удалить файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                RefreshPlaylist(); // Обновляем список после удаления
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
