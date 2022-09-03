using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace MnemotestProject.Model
{
    public static class ResultsToExcel
    {
        public static void Add(List<UserResult> results, string path)
        {
            if (results == null)
                throw new ArgumentNullException("Нет данных для сохранения.");
            Excel.Application application = new Excel.Application();

            var book = application.Workbooks.Add();
            Excel.Worksheet ws = (Excel.Worksheet)book.Worksheets[1];
            try
            {
                AddTitlesToFile(ws);

                int row = 2;
                foreach (var result in results)
                {
                    ws.Cells[row, 1].Value = result.Person.LastName;
                    ws.Cells[row, 2].Value = result.Person.FirstName;
                    ws.Cells[row, 3].Value = result.Person.FatherName;
                    ws.Cells[row, 4].Value = result.AverageCorrectAnswersCount;
                    ws.Cells[row, 5].Value = result.CorrectAnswersDispersion;
                    ws.Cells[row, 6].Value = result.AverageInvalidAnswersCount;
                    ws.Cells[row, 7].Value = result.InvalidAnswersDispersion;
                    ws.Cells[row, 8].Value = result.AverageTime;
                    ws.Cells[row, 9].Value = result.TimeDispersion;
                    ws.Cells[row, 10].Value = result.Parameters.ExposureTime;
                    ws.Cells[row, 11].Value = result.Parameters.PreExposureTime;
                    ws.Cells[row, 12].Value = result.Parameters.PostExposureTime;
                    ws.Cells[row, 13].Value = result.Parameters.Difficult;
                    ws.Cells[row, 14].Value = result.Parameters.ReproductionMode == true ? "Да" : "Нет";
                    ws.Cells[row, 15].Value = result.Parameters.RotateCount == 0 ? 0 : (result.Parameters.RotateCount == 1 ? 90 : (result.Parameters.RotateCount == 2 ? 180 : (result.Parameters.RotateCount == 3 ? 270 : 0)));
                    ws.Cells[row, 16].Value = result.Parameters.Size;
                    ws.Cells[row, 17].Value = result.Parameters.Attempts;
                    ws.Cells[row, 18].Value = result.Parameters.Scatter;
                    row++;
                }

                ws.StandardWidth = 30;

                book.SaveAs(path);
            }
            catch(Exception)
            {
                throw new Exception("При добавлении в файл произошла ошибка.");
            }
            finally
            {
                book.Close();
            }
        }

        private static void AddTitlesToFile(Excel.Worksheet ws)
        {
            ws.Cells[1, 1].Value = "Фамилия";
            ws.Cells[1, 2].Value = "Имя";
            ws.Cells[1, 3].Value = "Отчество";
            ws.Cells[1, 4].Value = "Среднее количество правильных ответов";
            ws.Cells[1, 5].Value = "Дисперсия правильных ответов";
            ws.Cells[1, 6].Value = "Среднее количество неправильных ответов";
            ws.Cells[1, 7].Value = "Дисперсия неправильных ответов";
            ws.Cells[1, 8].Value = "Среднее время воспроизведения";
            ws.Cells[1, 9].Value = "Дисперсия времени воспроизведения";
            ws.Cells[1, 10].Value = "Время экспозиции";
            ws.Cells[1, 11].Value = "Время преэкспозиции";
            ws.Cells[1, 12].Value = "Время постэкспозиции";
            ws.Cells[1, 13].Value = "Количество закрашеваемых ячеек";
            ws.Cells[1, 14].Value = "Инверсия цвета";
            ws.Cells[1, 15].Value = "Угол поворота";
            ws.Cells[1, 16].Value = "Размер матрицы";
            ws.Cells[1, 17].Value = "Количество попыток";
            ws.Cells[1, 18].Value = "Разброс";
        }
    }
}
