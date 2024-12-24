using System;
using System.Collections.Generic;
using System.IO;

namespace Tyuiu.DmitrievLR.Sprint7.Project.V9.Lib
{
    public class DataService
    {
        private static readonly string DBFilePath = Path.Combine(Directory.GetCurrentDirectory(), "Playlist.txt");

        // Метод для получения данных из файла Playlist.txt
        public List<string[]> GetPlaylist()
        {
            if (!File.Exists(DBFilePath))
            {
                EnsurePlaylistExists();
            }

            var allData = new List<string[]>();
            string[] lines = File.ReadAllLines(DBFilePath);

            foreach (var line in lines)
            {
                var parts = line.Split(';');
                if (parts.Length < 2)
                {
                    throw new InvalidDataException($"Некорректная строка в Playlist.txt: {line}");
                }

                allData.Add(parts);
            }

            return allData;
        }

        // Метод для создания файла с заготовленными данными
        public void EnsurePlaylistExists()
        {
            if (!File.Exists(DBFilePath))
            {
                File.WriteAllText(DBFilePath, string.Empty); // Создаем пустой файл
            }
        }

        // Метод для добавления новой записи
        public bool SaveInfo(string filePath, string fileName, int hours, int minutes, int seconds, string description)
        {
            try
            {
                if (!IsExists(filePath))
                {
                    string newEntry = $"{filePath};{fileName};{hours};{minutes};{seconds};{description}";
                    File.AppendAllText(DBFilePath, newEntry + Environment.NewLine);
                    return true;
                }
                return false; // Файл уже существует
            }
            catch (Exception ex)
            {
                // Логгирование ошибки ex при необходимости
                return false;
            }
        }

        // Метод для проверки существования записи
        public bool IsExists(string filePath)
        {
            var data = GetPlaylist();
            foreach (var entry in data)
            {
                if (entry[0] == filePath)
                {
                    return true;
                }
            }
            return false;
        }

        // Метод для удаления записи
        public bool DeleteInfo(int row)
        {
            try
            {
                var data = GetPlaylist();
                if (row < 0 || row >= data.Count)
                {
                    return false; // Некорректный индекс строки
                }

                data.RemoveAt(row);
                File.WriteAllLines(DBFilePath, data.ConvertAll(d => string.Join(";", d)));
                return true;
            }
            catch (Exception ex)
            {
                // Логгирование ошибки ex при необходимости
                return false;
            }
        }
    }
}
