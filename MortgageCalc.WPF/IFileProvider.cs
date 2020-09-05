using Calculator;
using Microsoft.Win32;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MortgageCalc.WPF
{
    public interface IFileProvider
    {
        public bool FileExists(string path);
        public IEnumerable<MortgageCalculator> ReadParametersFromExcel(string path);
        public Task<IEnumerable<MortgageCalculator>> ReadParametersFromExcelAsync(string path);
        public void ExportToExcel(IEnumerable<MortgageCalculator> history);
    }

    public class RealFileProvider : IFileProvider
    {
        public bool FileExists(string path) => File.Exists(path);

        public IEnumerable<MortgageCalculator> ReadParametersFromExcel(string path)
        {
            var rows = new List<MortgageCalculator>();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage package = new ExcelPackage(new FileInfo(path)))
            {
                var sheet = package.Workbook.Worksheets.First();
                for (int row = 2; row <= sheet.Dimension.End.Row; row++) {
                    rows.Add(new MortgageCalculator
                    {
                        MyMortgageAmount = (double)sheet.Cells[row, 1].Value,
                        MyInterestRate = (double)sheet.Cells[row, 2].Value,
                        MyMortgagePeriod = (double)sheet.Cells[row, 3].Value
                    });
                }
            }
            return rows;
        }

        public async Task<IEnumerable<MortgageCalculator>> ReadParametersFromExcelAsync(string path)
        {
            return await Task.Run(() =>
            {
                var rows = new List<MortgageCalculator>();
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                using (ExcelPackage package = new ExcelPackage(new FileInfo(path)))
                {
                    var sheet = package.Workbook.Worksheets.First();
                    for (int row = 2; row <= sheet.Dimension.End.Row; row++)
                    {
                        rows.Add(new MortgageCalculator
                        {
                            MyMortgageAmount = (double)sheet.Cells[row, 1].Value,
                            MyInterestRate = (double)sheet.Cells[row, 2].Value,
                            MyMortgagePeriod = (double)sheet.Cells[row, 3].Value
                        });
                    }
                }
                return rows;
            });
        }

        public void ExportToExcel(IEnumerable<MortgageCalculator> history)
        {
            var fileName = getFileName();
            if (fileName == null)
                return;
            if (File.Exists(fileName))
            {
                var result = MessageBox.Show("File exists, overwrite it?", "Overwrite Existing?", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                    File.Delete(fileName);
                else
                    return;
            }

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage package = new ExcelPackage(new FileInfo(fileName)))
            {
                var sheet = package.Workbook.Worksheets.Add("Export");
                sheet.Cells[1, 1].Value = "Mortgage Amount";
                sheet.Cells[1, 2].Value = "Interest Rate";
                sheet.Cells[1, 3].Value = "Mortgage Period";
                sheet.Cells[1, 4].Value = "Monthly Payment";

                var row = 1;
                foreach(var calc in history)
                {
                    row++;
                    sheet.Cells[row, 1].Value = calc.MyMortgageAmount;
                    sheet.Cells[row, 2].Value = calc.MyInterestRate;
                    sheet.Cells[row, 3].Value = calc.MyMortgagePeriod;
                    sheet.Cells[row, 4].Value = calc.MonthlyPaymentAmount;
                }

                sheet.Tables.Add(sheet.Cells[1, 1, row, 4], "ExportTable");

                var currencyFormat = "_ $* #, ##0.00_-;$* #,##0.00_~;_$* \"-\"??_-;_-@_-";
                sheet.Column(1).Style.Numberformat.Format = currencyFormat;
                sheet.Column(2).Style.Numberformat.Format = "0.000%";
                sheet.Column(3).Style.Numberformat.Format = "0";
                sheet.Column(4).Style.Numberformat.Format = currencyFormat;

                sheet.Column(1).Width = 20;
                sheet.Column(2).Width = 15;
                sheet.Column(3).Width = 10;
                sheet.Column(4).Width = 25;

                package.Save();
            }

            new Process
            {
                StartInfo = new ProcessStartInfo(fileName)
                {
                    UseShellExecute = true
                }
            }.Start();
        }
        private string getFileName()
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
            openFileDialog.Title = "Locate your Excel Input File";
            openFileDialog.CheckFileExists = false;
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() ?? false)
            {
                return openFileDialog.FileName;
            }
            return null;
        }
    }
}
