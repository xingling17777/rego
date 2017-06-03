<%@ Page Title="注册新用户" Language="C#" MasterPageFile="~/MainNav.master" AutoEventWireup="true" CodeFile="register.aspx.cs" Inherits="user_register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .left {
            width: 70px;
            text-align: justify;
            display: inline-block;
        }

        .right {
            width: 130px;
            text-align: justify;
            display: inline-block;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div style="text-align: center; margin-top: 20px;">
        <span class="left">用户名</span><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><span class="right">登录使用</span><br />
        <span class="left">输入密码</span><asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox><span class="right">密码不能为空</span><br />
        <span class="left">确认密码</span><asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox><span class="right">再次确认密码</span><br />
        <span class="left">姓名</span><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><span class="right">依据姓名分配权限</span><br />
        <asp:Button ID="Button1" runat="server" Text="提交" OnClick="Button1_Click" />
    </div>
</asp:Content>

