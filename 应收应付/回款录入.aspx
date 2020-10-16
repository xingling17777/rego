<%@ Page Title="" Language="C#" MasterPageFile="../MainNav.master" AutoEventWireup="true" CodeFile="回款录入.aspx.cs" Inherits="应收应付_回款录入" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
        <tr><td>客户名称</td><td>
            <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList></td></tr>
                <tr><td>回款金额</td><td>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td></tr>
        
        <tr><td colspan="2">
            <asp:Button ID="Button1" runat="server" Text="提交" /></td></tr>
    </table>
</asp:Content>

