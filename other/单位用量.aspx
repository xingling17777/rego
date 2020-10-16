<%@ Page Title="" Language="C#" MasterPageFile="../MainNav.master" AutoEventWireup="true" CodeFile="单位用量.aspx.cs" Inherits="other_单位用量" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <table style="width:600px;margin:0 auto;">
        <tr><td>管径</td><td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td><td></td></tr>
        <tr><td>管长</td><td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td><td></td></tr>
        <tr><td>白片材宽度</td><td><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td><td><asp:Label ID="Label1" runat="server" Text=""></asp:Label></td></tr>
        <tr><td>印刷片材</td><td></td><td><asp:Label ID="Label2" runat="server" Text=""></asp:Label></td></tr>
        <tr><td>纸箱装箱数量</td><td>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td><td><asp:Label ID="Label3" runat="server" Text=""></asp:Label></td></tr>
        <tr><td>托盘装箱数量</td><td>
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox></td><td><asp:Label ID="Label4" runat="server" Text=""></asp:Label></td></tr>
        <tr><td colspan="3">
            <asp:Button ID="Button1" runat="server" Text="提交" OnClick="Button1_Click" /></td></tr>
    </table>
</asp:Content>

