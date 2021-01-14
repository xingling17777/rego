<%@ Page Title="" Language="C#" MasterPageFile="../MainNav.master" AutoEventWireup="true" CodeFile="list_a.aspx.cs" Inherits="technology_list_a" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table style="width:800px;margin:0 auto;">
        <tr><td>客户关键字</td><td><asp:textbox ID="txtCustomer" runat="server"></asp:textbox></td><td><asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="检索客户" /></td></tr>
        <tr><td>选择客户</td><td><asp:ListBox ID="ListBox1" runat="server" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged"></asp:ListBox></td><td><asp:Button ID="Button4" runat="server" Text="选定该客户" OnClick="Button4_Click" Height="48px" Width="86px" /></td></tr>
    </table>
    
   
    <hr />
    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" ToolTip="按首字母拼音排序" Visible="False">
    </asp:DropDownList>
    <table style="width:400px;margin:0 auto;">
        <tr><td>产品编码</td><td> <asp:TextBox ID="TextBox2" runat="server" ToolTip="请输入产品成品编码."></asp:TextBox></td><td rowspan="2"><asp:Button ID="Button1" runat="server" Text="开始检索" OnClick="Button1_Click" /></td></tr>
        <tr><td>产品名称</td><td><asp:TextBox ID="TextBox1" runat="server" ToolTip="请输入产品名字的关键字,区分大小写."></asp:TextBox></td></tr>
    </table>
    <asp:Button ID="Button2" runat="server" Text="导出清单" OnClick="Button2_Click" />
    
    
   <hr />
    <asp:Table ID="Table1" runat="server">
    </asp:Table>
</asp:Content>

