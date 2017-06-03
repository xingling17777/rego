<%@ Page Title="" Language="C#" MasterPageFile="~/MainNav.master" AutoEventWireup="true" CodeFile="customerADD.aspx.cs" Inherits="technology_customerADD" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        table{
            width:300px;
            margin:30px auto;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
        <tr><td colspan="2">新增客户</td></tr>
        <tr><td>客户名称</td><td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td></tr>
        <tr><td colspan="2"><asp:Button ID="Button1" runat="server" Text="提交" OnClick="Button1_Click" /></td></tr>
     
    </table>
       <hr />
    <table style="width:500px;"><tr><td colspan="2">修改客户信息</td></tr>
        <tr><td>选择客户</td><td><asp:DropDownList ID="DropDownList1" runat="server">
    </asp:DropDownList></td></tr>
        <tr><td>修改为</td><td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td></tr>
        <tr><td colspan="2">  <asp:Button ID="Button2" runat="server" Text="确认修改" OnClick="Button2_Click" /></td></tr>
    </table>
     

  
</asp:Content>

