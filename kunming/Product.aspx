<%@ Page Title="" Language="C#" MasterPageFile="MasterPage.master" AutoEventWireup="true" CodeFile="Product.aspx.cs" Inherits="kunming_Product" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <div>
    产品名字：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
        <br />
        <br />
    <asp:Button ID="Button1" runat="server" Text="提交" OnClick="Button1_Click" />
    </div>

</asp:Content>

