<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login2.aspx.cs" Inherits="Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>�캽��������ϵͳ</title>
    <%--������--%>
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
    <%--������--%>
</head>
<body class="login_bg">
    <form id="form1" runat="server">
    <div class="login_main">
        <div class="login_logo">
            <div style="font-size: large;">
                <font style="color: red;">��ӭ���롶�캽��������ϵͳ��</font><br />
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
                                    �û�����</label></dt>
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
                                    �� �룺</label></dt>
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
                                    Text="����" BorderStyle="None" BorderWidth="0px" EnableTheming="True" />
                            </td>
                            <td>
                                <asp:RadioButton ID="RBtnTeacher"  Checked="true"  runat="server" GroupName="Login" Text="����Ա" BorderStyle="None"
                                    BorderWidth="0px" />
                            </td>
                            <td>
                                <asp:RadioButton ID="RBtnAdmin" runat="server" Text="�Ż�" GroupName="Login" BorderStyle="None"
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
