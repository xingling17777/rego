<%@ Page Title="" Language="C#" MasterPageFile="~/MainNav.master" AutoEventWireup="true" CodeFile="list_a.aspx.cs" Inherits="technology_list_a" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    选择客户<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" ToolTip="按首字母拼音排序">
    </asp:DropDownList><a href="customerADD.aspx">客户信息管理</a>
    <hr />
    <table style="width:400px;margin:0 auto;">
        <tr><td>产品编码</td><td> <asp:TextBox ID="TextBox2" runat="server" ToolTip="请输入产品成品编码."></asp:TextBox></td><td rowspan="2"><asp:Button ID="Button1" runat="server" Text="开始检索" OnClick="Button1_Click" /></td></tr>
        <tr><td>产品名称</td><td><asp:TextBox ID="TextBox1" runat="server" ToolTip="请输入产品名字的关键字,区分大小写."></asp:TextBox></td></tr>
    </table>
    <asp:Button ID="Button2" runat="server" Text="导出清单" OnClick="Button2_Click" />
    
    
   <hr />
    <asp:Table ID="Table1" runat="server">
    </asp:Table>
</asp:Content>

