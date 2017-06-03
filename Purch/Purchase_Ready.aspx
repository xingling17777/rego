<%@ Page Title="" Language="C#" MasterPageFile="~/MainNav.master" AutoEventWireup="true" CodeFile="Purchase_Ready.aspx.cs" Inherits="Purch_Purchase_Ready" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="width:300px;margin:20px auto;align-content:center;line-height:1.5em;">
        <div style="float:left;">
        <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox></div>
        <div style="width:50px; margin-left:5px;float:left; align-items:center;">
        <asp:Button ID="Button1" runat="server" Text="右移" /><br />
        <asp:Button ID="Button2" runat="server" Text="左移" /><br />
        <asp:Button ID="Button3" runat="server" Text="修改" /><br />
        <asp:Button ID="Button4" runat="server" Text="删除" /><br />
</div>
        <div style="float:left;">
        <asp:ListBox ID="ListBox2" runat="server"></asp:ListBox></div>
        <div style="clear:both;"></div>
        <div>
            <table></table>
        </div>
    </div>
    
</asp:Content>

