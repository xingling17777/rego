<%@ Page Title="登录页面" Language="C#" MasterPageFile="~/MainNav.master" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="user_login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div style="width: 300px; margin: 20px auto;">
        <table style="text-align: center;">
            <tr>
                <td colspan="2">登录系统</td>
            </tr>
            <tr>
                <td>用户名：</td>
                <td>
                    <asp:TextBox ID="txtbox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>密&nbsp;&nbsp;码：</td>
                <td>
                    <asp:TextBox ID="txtbox2" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button ID="btnOK" runat="server" Text="登录" OnClick="btnOK_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="2" style="color: red; font-style: italic;"><a href="/user/register.aspx">注册新用户?</a></td>
            </tr>
        </table>
    </div>
</asp:Content>

