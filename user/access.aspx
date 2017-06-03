<%@ Page Title="" Language="C#" MasterPageFile="~/MainNav.master" AutoEventWireup="true" CodeFile="access.aspx.cs" Inherits="user_access" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    
        选择用户：<asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList><br />
    <asp:DropDownList ID="DropDownList2" runat="server">
</asp:DropDownList>
        <div style="border:1px solid green;width:200px;display:inline-block;"><asp:CheckBox ID="CheckBox1" runat="server" Text="增" /><asp:CheckBox ID="CheckBox2" runat="server" Text="删" />
    <asp:CheckBox ID="CheckBox3" runat="server" Text="改" />
    <asp:CheckBox ID="CheckBox4" runat="server" Text="查" /></div><br />
    <asp:Button ID="Button1" runat="server" Text="提交" OnClick="Button1_Click" />
</asp:Content>

