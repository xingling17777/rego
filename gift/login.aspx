<%@ Page Title="" Language="C#" MasterPageFile="MasterPage.master" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="gift_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
       <div>
            <table>
                <tr><td>用户名</td><td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td></tr>
                <tr><td>密码</td><td>
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox></td></tr>
                <tr><td colspan="2">
                    <asp:Button ID="Button1" runat="server" Text="提交" OnClick="Button1_Click" /></td></tr>
</table>
            <a href="">注册新用户......</a>
        </div>
</asp:Content>

