using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System.Collections.Generic;
using System.IO;
using HorizontalAlignment = NPOI.SS.UserModel.HorizontalAlignment;

namespace ExportData2Excel
{
    /// <summary>
    /// 导出数据到Excel
    /// </summary>
    public class Export2Excel
    {
        /// <summary>
        /// Export2s the excel.
        /// </summary>
        /// <param name="contentList"></param>
        /// <param name="sheetName">Name of the sheet.</param>
        /// <param name="filename">The filename.</param>
        /// <returns></returns>
        public static bool ExportToExcel(List<string[]> contentList, string sheetName, string filename)
        {
            try
            {
                HSSFWorkbook workbook = new HSSFWorkbook();
                ISheet sheet = workbook.CreateSheet(sheetName);
                IRow rowHead = sheet.CreateRow(0);
                ICellStyle style = workbook.CreateCellStyle();
                style.Alignment = HorizontalAlignment.Center;
                style.VerticalAlignment = VerticalAlignment.Center;
                sheet.CreateFreezePane(6, 1, 6, 1);
                //填写表头
                for (int i = 0; i < contentList.Count; i++)
                {
                    ICell cell = rowHead.CreateCell(i, CellType.String);
                    cell.SetCellValue(contentList[i][0]);
                    cell.CellStyle = style;
                }
                //填写内容
                for (int i = 0; i < contentList.Count; i++)
                {
                    IRow row = sheet.CreateRow(i + 1);
                    for (int j = 1; j < contentList[i].Length; j++)
                    {
                        ICell cell = row.CreateCell(j, CellType.String);
                        cell.SetCellValue(contentList[i][j]);
                        cell.CellStyle = style;
                    }
                }

                using (FileStream stream = File.Create(filename))
                {
                    workbook.Write(stream);
                    stream.Close();
                }
                return true;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Export2s the excel.
        /// </summary>
        /// <param name="contentDic">The content dictionary.</param>
        /// <param name="columnName">Name of the column.</param>
        /// <param name="sheetName">Name of the sheet.</param>
        /// <param name="filename">The filename.</param>
        /// <returns></returns>
        public static bool ExportToExcel(Dictionary<string, string> contentDic, string columnName, string sheetName, string filename)
        {
            try
            {
                HSSFWorkbook workbook = new HSSFWorkbook();
                ISheet sheet = workbook.CreateSheet(sheetName);
                ICellStyle style = workbook.CreateCellStyle();

                style.Alignment = HorizontalAlignment.Center;
                style.VerticalAlignment = VerticalAlignment.Center;
                sheet.CreateFreezePane(0, 1, 0, 1);

                //填写表头
                IRow rowHead = sheet.CreateRow(0);
                ICell cell = rowHead.CreateCell(0, CellType.String);
                cell.SetCellValue("时间");
                cell.CellStyle = style;

                cell = rowHead.CreateCell(1, CellType.String);
                cell.SetCellValue(columnName);
                cell.CellStyle = style;

                //填写内容
                int y = 1;
                foreach (KeyValuePair<string, string> keyValuePair in contentDic)
                {
                    IRow row = sheet.CreateRow(y++);
                    cell = row.CreateCell(0, CellType.String);
                    cell.SetCellValue(keyValuePair.Key);
                    cell.CellStyle = style;

                    cell = row.CreateCell(1, CellType.String);
                    cell.SetCellValue(keyValuePair.Value);
                    cell.CellStyle = style;
                }

                using (FileStream stream = File.Create(filename))
                {
                    workbook.Write(stream);
                    stream.Close();
                }
                return true;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Export2s the excel.
        /// </summary>
        /// <param name="contentDics">The content dics.</param>
        /// <param name="sheetColumnDics">The sheet column dics.</param>
        /// <param name="filename">The filename.</param>
        /// <returns></returns>
        public static bool ExportToExcel(Dictionary<string, Dictionary<string, List<string>>> contentDics, Dictionary<string, List<string>> sheetColumnDics, string filename)
        {
            try
            {
                HSSFWorkbook workbook = new HSSFWorkbook();
                foreach (KeyValuePair<string, Dictionary<string, List<string>>> keyValuePair in contentDics)
                {
                    ISheet sheet = workbook.CreateSheet(keyValuePair.Key);
                    ICellStyle style = workbook.CreateCellStyle();

                    style.Alignment = HorizontalAlignment.Center;
                    style.VerticalAlignment = VerticalAlignment.Center;
                    sheet.CreateFreezePane(0, 1, 0, 1);

                    IRow rowHead = sheet.CreateRow(0);

                    ICell cell = rowHead.CreateCell(0, CellType.String);
                    cell.SetCellValue("时间");
                    cell.CellStyle = style;

                    int y = 1;
                    for (int x = 0; x < sheetColumnDics[keyValuePair.Key].Count; x++)
                    {
                        cell = rowHead.CreateCell(x + 1, CellType.String);
                        cell.SetCellValue(sheetColumnDics[keyValuePair.Key][x]);
                        cell.CellStyle = style;
                    }
                    Dictionary<string, List<string>> data = keyValuePair.Value;

                    foreach (KeyValuePair<string, List<string>> subKeyValuePair in data)
                    {
                        IRow row = sheet.CreateRow(y++);
                        cell = row.CreateCell(0, CellType.String);
                        cell.SetCellValue(subKeyValuePair.Key);
                        cell.CellStyle = style;

                        for (int index = 0; index < subKeyValuePair.Value.Count; index++)
                        {
                            string p = subKeyValuePair.Value[index];
                            cell = row.CreateCell(index + 1, CellType.String);
                            cell.SetCellValue(p);
                            cell.CellStyle = style;
                        }
                    }
                }

                using (FileStream stream = File.Create(filename))
                {
                    workbook.Write(stream);
                    stream.Close();
                }
                return true;
            }
            catch
            {
                throw;
            }
        }
    }
}