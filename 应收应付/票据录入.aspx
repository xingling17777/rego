<%@ Page Title="" Language="C#" MasterPageFile="../MainNav.master" AutoEventWireup="true" CodeFile="票据录入.aspx.cs" Inherits="应收应付_票据录入" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
        <tr><td>票据号码</td><td>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td></tr>
        <tr><td>票面金额</td><td>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td></tr>
        <tr><td>客户名称</td><td>
            <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList></td></tr>
        <tr><td colspan="2">
            <asp:Button ID="Button1" runat="server" Text="提交" /></td></tr>
    </table>
</asp:Content>

