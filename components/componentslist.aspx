<%@ Page Title="配件库存查询" Language="C#" MasterPageFile="~/MainNav.master" AutoEventWireup="true" CodeFile="componentslist.aspx.cs" Inherits="components_componentslist" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div style="width: 850px; margin: 0 auto;">
        选择仓库：<asp:dropdownlist id="DropDownList1" runat="server" onselectedindexchanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem>所有仓库</asp:ListItem>
            <asp:ListItem>配件</asp:ListItem>
            <asp:ListItem>工具</asp:ListItem>
            <asp:ListItem>行政</asp:ListItem>
        </asp:dropdownlist>
        <asp:textbox id="TextBox1" runat="server"></asp:textbox>
        <asp:button id="Button1" runat="server" text="开始检索" onclick="Button1_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="CheckBox1" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" Text="显示库存为0的物资" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="下载库存清单" />
        <br /> 
        <asp:table id="Table1" runat="server"></asp:table>
    </div>
</asp:Content>

