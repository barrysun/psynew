using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;

namespace Dal
{
   public class SendEmail
    {
       public void Send()
       {
       
       MailMessage msg = new MailMessage();
       msg.To.Add("1096490965@qq.com");//收件者，以逗号分隔开
       msg.From = new MailAddress("wubinsun@gmail.com", "孙武斌", System.Text.Encoding.UTF8);
       msg.Subject = "测试邮件";//邮件标题
       msg.SubjectEncoding = System.Text.Encoding.UTF8;//邮件标题编码
       msg.Body = "你的内容为：";//有劲啊内容
       msg.BodyEncoding = System.Text.Encoding.UTF8;
       msg.IsBodyHtml = false;//是否是HTML邮件
       msg.Priority = MailPriority.Normal;//邮件优先级
       try
       {
           //建立 SmtpClient 物件 并设定Gmail的smtp主机及Port
           SmtpClient MySmtp = new SmtpClient("smtp.gmail.com", 587);
           //设定你的账号密码
           MySmtp.Credentials = new System.Net.NetworkCredential("wubinsun@gmail.com", "sunwubin");
           //Gmail的smtp使用SSL
           MySmtp.EnableSsl = true;
           //发送Email
           MySmtp.Send(msg);
       }
       catch (System.Net.Mail.SmtpException ex)
       { 
       
       }

       }

       public void Test()
       {
           Send();
       }

       

    }
}
