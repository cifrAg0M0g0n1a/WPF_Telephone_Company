using Microsoft.Win32;
using System;
using System.IO;
using System.Text;
using System.Windows.Controls;
using System.Windows;

namespace DBAapp.Models
{
    internal class CSVExporter
    {
        public void ExportDataGridToCSV(DataGrid dataGrid)
        {
            // Диалог выбора папки для сохранения файла
            var dialog = new SaveFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv",
                FileName = $"report_{DateTime.Now:dd_MM_yyyy_HH-mm-ss}.csv"
            };

            if (dialog.ShowDialog() == true)
            {
                string filePath = dialog.FileName;

                // Преобразование данных в формат CSV
                StringBuilder csvData = new StringBuilder();

                foreach (var item in dataGrid.Items)
                {
                    DataGridRow row = (DataGridRow)dataGrid.ItemContainerGenerator.ContainerFromItem(item);

                    if (row != null)
                    {
                        string fio = "";
                        string street = "";
                        string house = "";
                        string homePhone = "";
                        string workPhone = "";
                        string mobilePhone = "";

                        // Получаем ячейки строки
                        for (int i = 0; i < dataGrid.Columns.Count; i++)
                        {
                            var cellContent = dataGrid.Columns[i].GetCellContent(row);
                            var cellValue = (cellContent as TextBlock)?.Text;

                            switch (i)
                            {
                                case 0:
                                    fio = cellValue;
                                    break;
                                case 1:
                                    street = cellValue;
                                    break;
                                case 2:
                                    house = cellValue;
                                    break;
                                case 3:
                                    // Если homePhone пуст, вывести "пусто"
                                    homePhone = string.IsNullOrEmpty(cellValue) ? "пусто" : cellValue;
                                    break;
                                case 4:
                                    // Если workPhone пуст, вывести "пусто"
                                    workPhone = string.IsNullOrEmpty(cellValue) ? "пусто" : cellValue;
                                    break;
                                case 5:
                                    // Если homePhone пуст, вывести "пусто"
                                    mobilePhone = string.IsNullOrEmpty(cellValue) ? "пусто" : cellValue;
                                    break;
                            }
                        }

                        // Формируем строку для CSV
                        string csvRow = $"{fio}, ул.{street}, д.{house}. Домашний телефон: {homePhone}, рабочий телефон: {workPhone}, мобильный телефон: {mobilePhone}";
                        csvData.AppendLine(csvRow);
                    }
                }

                // Сохранение данных в файл
                File.WriteAllText(filePath, csvData.ToString(), Encoding.UTF8);

                MessageBox.Show("Данные были успешно сохранены", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}