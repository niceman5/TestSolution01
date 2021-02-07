using System;
using System.Collections.Generic;
using System.Text;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using NPOI.HSSF.Util;
using NPOI.POIFS.FileSystem;
using NPOI.HPSF;
using System.IO;
using System.Runtime.InteropServices.ComTypes;

namespace ConsoleExcelTest01
{
    class MembershipUser
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastLoginDate { get; set; }
        public Boolean? IsApproved { get; set; }
        public string Comment { get; set; }
    }

    class BaseExcelCreate01
    {
        public void Run()
        {
            // 새 통합 문서 개체를 만들고 시트를 추가합니다.
            // Create a new workbook and a sheet named "User Accounts"
            var workbook = new HSSFWorkbook();          //xls           지원되는 기능이 틀림 확인해야 함.

            var sheet = workbook.CreateSheet("User Accounts");
            sheet.TabColorIndex = HSSFColor.Red.Index;

            var sheet2 = workbook.CreateSheet("Tab2");
            sheet2.TabColorIndex = HSSFColor.Blue.Index;

            var sheet3 = workbook.CreateSheet("Tab3");
            sheet3.TabColorIndex = HSSFColor.Blue.Index;
            sheet3.TabColorIndex = HSSFColor.Aqua.Index;


            // 다음으로 각 사용자(사용자 이름, 이메일 등)에 대해 표시되는 데이터 포인트에 레이블을 지정하는 헤더 행을 만들어야합니다. 
            // 시트에 행을 추가하려면 시트의 CreateRow 메서드를 사용하여 행의 인덱스를 전달합니다. CreateRow는 Row 인터페이스를 구현하는
            // 개체를 반환합니다. 이 행 개체를 사용하면 CreateCell 메서드를 호출하여 행에 하나 이상의 셀을 추가 할 수 있습니다.마찬가지로 
            // CreateCell은 Cell 인터페이스를 구현하는 객체를 반환합니다.셀 개체에는 다양한 메서드와 속성이 있으며 가장 밀접한 중 하나는 셀에 값을 할당하는 SetCellValue입니다.


            // CreateCell 메서드는 Cell 인터페이스를 구현하는 개체를 반환하므로 메서드 체인을 사용하여 SetCellValue를 호출 할 수 있습니다.
            // 셀의 다른 메서드를 호출하거나 속성을 할당 할 필요가없는 경우 유용한 바로 가기입니다. 또한 CreateRow 및 CreateCell의 인덱스는 
            // 모두 0에서 시작합니다. Excel 스프레드 시트에서 행 1로 레이블이 지정된 첫 번째 행을 추가하려면 CreateRow(0)을 호출합니다.

            // Add header labels
            var rowIndex = 0;
            var row = sheet.CreateRow(rowIndex);
            row.CreateCell(0).SetCellValue("Username");
            row.CreateCell(1).SetCellValue("Email");
            row.CreateCell(2).SetCellValue("Joined");
            row.CreateCell(3).SetCellValue("Last Login");
            row.CreateCell(4).SetCellValue("Approved?");
            row.CreateCell(5).SetCellValue("Comments");
            rowIndex++;

            MembershipUser[] userAccounts = new MembershipUser[]
            {
                new MembershipUser {UserName="김태훈1", Email="aaaa1@aaa.com", CreationDate=new DateTime( 2021,01,12,11,25,33), LastLoginDate=new DateTime( 2021,2,1,13,22,34), Comment="사용자생성테스트", IsApproved=true   },
                new MembershipUser {UserName="김태훈2", Email="aaaa2@aaa.com", CreationDate=new DateTime( 2021,01,12,11,25,33), LastLoginDate=new DateTime( 2021,2,1,13,22,34), Comment="사용자생성테스트", IsApproved=true  },
                new MembershipUser {UserName="김태훈3", Email="aaaa3@aaa.com", CreationDate=new DateTime( 2021,01,12,11,25,33), LastLoginDate=new DateTime( 2021,2,1,13,22,34), Comment="사용자생성테스트", IsApproved=false   },
                new MembershipUser {UserName="김태훈4", Email="aaaa4@aaa.com", CreationDate=new DateTime( 2021,01,12,11,25,33), LastLoginDate=new DateTime( 2021,2,1,13,22,34), Comment="사용자생성테스트", IsApproved=false  }
            };

            //// Add data rows
            foreach (MembershipUser account in userAccounts)
            {
                row = sheet.CreateRow(rowIndex);
                row.CreateCell(0).SetCellValue(account.UserName);
                row.CreateCell(1).SetCellValue(account.Email);
                row.CreateCell(2).SetCellValue(account.CreationDate.ToShortDateString());
                row.CreateCell(3).SetCellValue(account.LastLoginDate.ToShortDateString());
                row.CreateCell(4).SetCellValue((bool)account.IsApproved);
                row.CreateCell(5).SetCellValue(account.Comment);
                rowIndex++;
            }



            //스프레드 시트를 웹 서버의 파일 시스템에있는 파일로 저장합니다.
            // Save the Excel spreadsheet to a file on the web server's file system
            using (var fileData = new FileStream(@"C:\00.Dev\temp\baseexcelcreate01.xlsx", FileMode.Create))
            {
                workbook.Write(fileData);
            }
            //FileStream sw = new FileStream(@"C:\00.Dev\temp\baseexcelcreate01.xls", FileMode.Create);
            //workbook.Write(sw);
            //sw.Close();

            // Excel 스프레드 시트가 MemoryStream에 저장되고 클라이언트로 스트리밍됩니다.
            //// Save the Excel spreadsheet to a MemoryStream and return it to the client
            //using (var exportData = new MemoryStream())
            //{
            //    workbook.Write(exportData);
            //    string saveAsFileName = string.Format("MembershipExport-{0:d}.xls", DateTime.Now).Replace("/", "-");
            //    Response.ContentType = "application/vnd.ms-excel";
            //    Response.AddHeader("Content-Disposition", string.Format("attachment;filename={0}", saveAsFileName));
            //    Response.Clear();
            //    Response.BinaryWrite(exportData.GetBuffer());
            //    Response.End();
            //}
        }
    }

}
