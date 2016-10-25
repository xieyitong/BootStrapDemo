using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace EntityFrameworkDemo.DataAccess
{
    public class SendEmail
    {
        public static string SendEmailByUser(string email)
        {
            SmtpClient mailClient = new SmtpClient("smtp.163.com");
            //Credentials登陆SMTP服务器的身份验证.
            mailClient.Credentials = new NetworkCredential("18109176085", "xyt13636765500");
            //test@qq.com发件人地址、test@tom.com收件人地址
            MailMessage message = new MailMessage(new MailAddress("18109176085@163.com"), new MailAddress(email));

            // message.Bcc.Add(new MailAddress("tst@qq.com")); //可以添加多个收件人
            message.Body = "你好，你的密码修改为123456，请及时修改";//邮件内容
            message.Subject = "修改密码";//邮件主题
                                          //Attachment 附件
                                          //Attachment att = new Attachment(@"C:/hello.txt");
                                          //message.Attachments.Add(att);//添加附件
                                          //Console.WriteLine("Start Send Mail....");
                                          //发送....
            try
            {
                mailClient.Send(message);
            }
            catch (Exception e)
            {

                return "发送失败" + e;
            }
            //Console.WriteLine("Send Mail Successed");
            //Console.ReadLine();
            return "发送成功！";
        }
    }
}