<%@ Page Title="" Language="C#" MasterPageFile="~/MainNav.master" AutoEventWireup="true" CodeFile="产品清单.aspx.cs" Inherits="工艺单_产品清单" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    关键字：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><asp:Button ID="Button1" runat="server" Text="检索" OnClick="Button1_Click" /><br />
    <asp:Table ID="Table1" runat="server"></asp:Table>
</asp:Content>

