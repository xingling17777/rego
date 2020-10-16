<%@ Page Title="" Language="C#" MasterPageFile="../MainNav.master" AutoEventWireup="true" CodeFile="订单金额录入.aspx.cs" Inherits="应收应付_订单金额录入" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
        <tr><td>订单编号</td><td>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td></tr>
        <tr><td>订单金额</td><td>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td></tr>
        <tr><td>客户名称</td><td>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><asp:ListBox ID="ListBox1" runat="server"></asp:ListBox></td></tr>
        <tr><td colspan="2">
            <asp:Button ID="Button1" runat="server" Text="提交" OnClick="Button1_Click" /></td></tr>
    </table>
</asp:Content>

