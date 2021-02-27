using System;
using System.Net.Mail;

namespace ConsoleMailSend
{
    class Program
    {
        static void Main(string[] args)
        {
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.UseDefaultCredentials = false;       //시스템에 설정된 인증정보를 사용하지 않는다.
            client.EnableSsl = true;                    //SSL 사용한다.
            client.DeliveryMethod = SmtpDeliveryMethod.Network; // 이걸해야만 인증을 받는다.
            client.Credentials = new System.Net.NetworkCredential("niceman555", "gustnr35!A");
            //client.Credentials = new System.Net.NetworkCredential("kth", "gustnr35");           //회사메일

            /*
             * 구글 계정에서 보안수준이 낮은 앱의 엑세스 권한을 허용으로 해야 함
             * */

            MailAddress from = new MailAddress("niceman555@gmail.com","김태훈", System.Text.Encoding.UTF8);
            MailAddress to = new MailAddress("kth@u-crm.com");

            MailMessage message = new MailMessage(from, to);

            message.Body = "이것은 테스트 메일입니다. 메일 발송 클라이언트에서 보냅니다.";
            string somArrows = new string(new char[] {'\u2190', '\u2191', '\u2192', '\u2193' });
            message.Body += Environment.NewLine + somArrows;
            message.BodyEncoding = System.Text.Encoding.UTF8;
            message.Subject = "test message 2" + somArrows;            
            message.SubjectEncoding = System.Text.Encoding.UTF8;

            //파일 첨부
            //var attch1 = new Attachment(@"C:\00.Dev\temp\ChartTest.xlsx");
            //var attch2 = new Attachment(@"C:\00.Dev\temp\test.xlsx");
            //var attch3 = new Attachment(@"C:\00.Dev\temp\HyprtLink_Font.xlsx");
            //message.Attachments.Add(attch1);
            //message.Attachments.Add(attch2);
            //message.Attachments.Add(attch3);

            var attch1 = new Attachment(@"D:\00.Dev\temp\코인적립신청리스트_2021-02.xlsx");
            message.Attachments.Add(attch1);

            try
            {
                client.Send(message);

                //clean up
                client.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
