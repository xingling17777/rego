<%@ Page Title="" Language="C#" MasterPageFile="MasterPage.master" AutoEventWireup="true" CodeFile="AddOrders.aspx.cs" Inherits="kunming_AddOrders" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
    <table>
        <tr><td colspan="2">录入订单</td></tr>
        <tr><td>订单号：</td><td>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td></tr>
        <tr><td>产品名称：</td><td>
            <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList></td></tr>
        <tr><td>订单数量：</td><td>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td></tr>
        <tr><td>下单日期：</td><td>
            <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
            </td></tr>
        <tr><td>备注：</td><td>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td></tr>        
        <tr><td colspan="2">
            <asp:Button ID="Button1" runat="server" Text="提交" OnClick="Button1_Click" /></td></tr>
    </table>
        <br />
        <hr />
        <br />

        </div>
</asp:Content>

