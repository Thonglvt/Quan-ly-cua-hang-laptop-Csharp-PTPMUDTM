using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data;

namespace BLL
{
    public class BLLXuLyTrenFile
    {
        public DataTable importExcel(string filePath)
        {
            using (ExcelPackage excelPackage = new ExcelPackage(new FileInfo(filePath)))
            {
                ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets[0];
                DataTable dataTable = new DataTable();
                //Add tên cột cho dataTable
                for(int i = excelWorksheet.Dimension.Start.Column;i< excelWorksheet.Dimension.End.Column;i++)
                {
                    //Thường tên cột nằm ở dòng 1
                    dataTable.Columns.Add(excelWorksheet.Cells[1, i].Value.ToString().Trim());
                }
                //Add dữ liệu cho từng dòng nhưng i bắt đầu từ dòng +1
                for (int i = excelWorksheet.Dimension.Start.Row+1; i < excelWorksheet.Dimension.End.Row; i++)
                {
                    List<string> lstRow = new List<string>();
                    //Duyệt qua từng cột của dóng hiện tại
                    for (int j = excelWorksheet.Dimension.Start.Column; j < excelWorksheet.Dimension.End.Column; j++)
                    {
                        lstRow.Add(excelWorksheet.Cells[i, j].Value.ToString().Trim());
                    }
                    dataTable.Rows.Add(lstRow.ToArray());
                }
                return dataTable;
            }  
        }
    }
}
