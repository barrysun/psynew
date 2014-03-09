<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login2.aspx.cs" Inherits="Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>领航人生管理系统</title>
    <%--曾沿用--%>
    <link rel="stylesheet" href="style/base/jw.css" type="text/css" media="all" />
    <link rel="stylesheet" href="style/standard/jw.css" type="text/css" media="all" />
    <style type="text/css">
        .fangshua
        {
            font-weight: bold;
            font-size: 14px;
            color: red;
        }
        .boder1
        {
            border: none;
            border-bottom-style: none;
            border-left: none;
            border-left-style: none;
        }
    </style>
    <%--曾沿用--%>
</head>
<body class="login_bg">
    <form id="form1" runat="server">
    <div class="login_main">
        <div class="login_logo">
            <div style="font-size: large;">
                <font style="color: red;">欢迎进入《领航人生管理系统》</font><br />
            </div>
        </div>
        <div class="login_left">
            <img class="login_pic" src="images/login_pic.png" />
        </div>
        <div class="login_right">
            <dl>
                <table>
                    <tr>
                        <td>
                            <dt class="uesr">
                                <label>
                                    用户名：</label></dt>
                        </td>
                        <td>
                            <dd>
                                <asp:TextBox ID="TxtID" runat="server" Style="margin-bottom: 0px" Width="90px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TxtID"
                                    ErrorMessage="*" ValidationGroup="login"></asp:RequiredFieldValidator>
                            </dd>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <dt class="passw">
                                <label>
                                    密 码：</label></dt>
                        </td>
                        <td>
                            <dd >
                                <asp:TextBox ID="TxtPwd" runat="server" TextMode="Password" Width="90px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TxtPwd"
                                    ErrorMessage="*" ValidationGroup="login"></asp:RequiredFieldValidator>
                            </dd>
                        </td>
                    </tr>
                </table>
                <dt></dt>
                <dd>
                    <table id="RadioButtonList1" border="0">
                        <tr>
                            <td>
                                <asp:RadioButton ID="RBtnStudent" runat="server"   GroupName="Login"
                                    Text="销售" BorderStyle="None" BorderWidth="0px" EnableTheming="True" />
                            </td>
                            <td>
                                <asp:RadioButton ID="RBtnTeacher"  Checked="true"  runat="server" GroupName="Login" Text="管理员" BorderStyle="None"
                                    BorderWidth="0px" />
                            </td>
                            <td>
                                <asp:RadioButton ID="RBtnAdmin" runat="server" Text="门户" GroupName="Login" BorderStyle="None"
                                    BorderWidth="0px" />
                            </td>
                            <td>
                            </td>
                        </tr>
                    </table>
                </dd>
                <dt></dt>
                <dd>
                    <asp:Button ID="BtnLogin" runat="server" CssClass="btn_dl" 
                        OnClick="BtnLogin_Click" ValidationGroup="login" />
                    <asp:Button ID="BtnReset" runat="server" CssClass="btn_cz" OnClick="BtnReset_Click" />
                </dd>
            </dl>
        </div>
        <div class="login_copyright">
        </div>
    </div>
    </form>
</body>
</html>
