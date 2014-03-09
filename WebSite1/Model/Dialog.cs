using System;
using System.Collections.Generic;

using System.Text;

namespace Model
{
    /// <summary>
    /// 提示框
    /// </summary>
   public  class Dialog
    {
       public string Message(string title, string message)
       {
           StringBuilder MessageStr = new StringBuilder();
          MessageStr.Append(" <div class=\"opSucc\" id=\"diaBox\" style=\"display:none;\">");
	MessageStr.Append("<div class=\"\">"+title+"</div>");
    MessageStr.Append("<div class=\"\">"+message+"</div>");
MessageStr.Append("</div>");
           MessageStr.Append("");
        MessageStr.Append("   <script type=\"text/javascript\" src=\"js/artDialog.js?skin=blue\"></script>");
MessageStr.Append("<script type=\"text/javascript\">");
   MessageStr.Append("         art.dialog({");
   MessageStr.Append("             title: '系统通知',");
   MessageStr.Append("             icon: 'succeed',");
   MessageStr.Append("             content: document.getElementById(\"diaBox\"),");
   MessageStr.Append("             ok: function () {");
   MessageStr.Append("             },");
   MessageStr.Append("             cancelValue: '取消',");
   MessageStr.Append("             cancel: true,");
   MessageStr.Append("             lock: true");
   MessageStr.Append("         });");
MessageStr.Append("</script>");
           return MessageStr.ToString();
       }
        //Failure
       public string Message(string title, string message,string type)
       {
           StringBuilder MessageStr = new StringBuilder();
           MessageStr.Append(" <div class=\"opSucc\" id=\"diaBox\" style=\"display:none;\">");
           MessageStr.Append("<div class=\"\">" + title + "</div>");
           MessageStr.Append("<div class=\"\">" + message + "</div>");
           MessageStr.Append("</div>");
           MessageStr.Append("");
           MessageStr.Append("   <script type=\"text/javascript\" src=\"js/artDialog.js?skin=blue\"></script>");
           MessageStr.Append("<script type=\"text/javascript\">");
           MessageStr.Append("         art.dialog({");
           MessageStr.Append("             title: '系统通知',");
           MessageStr.Append("             icon: '"+type+"',");
           MessageStr.Append("             content: document.getElementById(\"diaBox\"),");
           MessageStr.Append("             ok: function () {");
           MessageStr.Append("             },");
           MessageStr.Append("             cancelValue: '取消',");
           MessageStr.Append("             cancel: true,");
           MessageStr.Append("             lock: true");
           MessageStr.Append("         });");
           MessageStr.Append("</script>");
           return MessageStr.ToString();
       }
    }
}
