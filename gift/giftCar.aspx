<%@ Page Title="" Language="C#" MasterPageFile="~/gift/MasterPage.master" AutoEventWireup="true" CodeFile="giftCar.aspx.cs" Inherits="gift_giftCar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Table ID="Table1" runat="server"></asp:Table>
    <asp:Button ID="Button1" runat="server" Text="提交" OnClick="Button1_Click" />
</asp:Content>

