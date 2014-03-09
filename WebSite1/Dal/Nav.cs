using System;
using System.Collections.Generic;

using System.Text;
using java.lang;

namespace Dal
{
   public  class Nav
    {

       public static string  NavStr()
       {
           var str=new StringBuffer();

           str.append("<dl class=\"navFirst\">");
           str.append("<dt><a class=\"\" href=\"index.aspx\">首页</a></dt>") ;
    str.append("</dl>");
    str.append("<dl>");
    str.append("     <dt><a href=\"des.aspx?type=des&id=2\">我们的服务</a></dt>");
    str.append("    <dd>");
    str.append("        <a href=\"\">项目介绍</a>");
    str.append("        <a href=\"\">团队介绍</a>");
    str.append("        <a href=\"\">产品介绍</a>");
    str.append("        <a href=\"\">服务与保障</a>");
   str.append("         <a href=\"\">产品及其资费</a>");
   str.append("     </dd>");
        
  str.append("  </dl>");
  str.append("  <dl>");
  str.append("      <dt><a href=\"des.aspx?type=des&id=1\">职业选择及定位</a></dt>");
  str.append("  </dl>");
  str.append("   <dl>");
 str.append("       <dt><a href=\"des.aspx?type=des&id=3\">人生路上</a></dt>");
  str.append("  </dl>");
  str.append("    <dl>");
  str.append("     <dt><a class=\"\" href=\"newList.aspx\">学术动态</a></dt>");
  str.append("  </dl>");
  str.append("  <dl>");
  str.append("      <dt><a href=\"talentList.aspx\">求职与招聘</a></dt>");
        
  str.append("   </dl>");
  str.append("  <dl>");
  str.append("      <dt><a  href=\"exportList.aspx\">专家支持</a></dt>");
  str.append("  </dl>");
  str.append("  <dl>");
  str.append("      <dt><a href=\"des.aspx?type=des&id=4\">关于我们</a></dt>");
  str.append("    <dd>");
  str.append("        <a href=\"\">我们的愿景</a>");
  str.append("        <a href=\"\">价值观</a>");
  str.append("        <a href=\"\">发展历程</a>");
  str.append("        <a href=\"\">联系我们</a>");
  str.append("     </dd>");
 str.append("   </dl>");
           return str.toString();
       }
    }
}
