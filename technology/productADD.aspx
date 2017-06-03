<%@ Page Title="" Language="C#" MasterPageFile="~/MainNav.master" AutoEventWireup="true" CodeFile="productADD.aspx.cs" Inherits="technology_productADD" %>

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
        <tr><td colspan="2">新增产品</td></tr>
        <tr><td>选择客户</td><td><asp:DropDownList ID="DropDownList1" runat="server" Width="200px" AutoPostBack="True"></asp:DropDownList></td></tr>
        <tr><td>产品名称</td><td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td></tr>
        <tr><td>色数</td><td>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td></tr>
        <tr><td>版筒</td><td>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td></tr>
        <tr><td>个数</td><td>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td></tr>
        <tr><td>备注</td><td>
            <asp:TextBox ID="TextBox6" runat="server" Height="67px" TextMode="MultiLine"></asp:TextBox></td></tr>
        <tr><td colspan="2"><asp:Button ID="Button1" runat="server" Text="提交" OnClick="Button1_Click" /></td></tr>
     
    </table>
       <hr />
    <table><tr><td colspan="2">修改产品信息</td></tr>
        <tr><td>选择客户</td><td><asp:DropDownList ID="DropDownList2" runat="server" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" Width="200px" AutoPostBack="True">
    </asp:DropDownList></td></tr>
        <tr><td>选择产品</td><td>
            <asp:DropDownList ID="DropDownList3" runat="server" Width="200px" AutoPostBack="True" OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged"></asp:DropDownList></td></tr>
        <tr><td>新名字</td><td><asp:TextBox ID="TextBox5" runat="server"></asp:TextBox></td></tr>
        <tr><td>色数</td><td>
            <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox></td></tr>
        <tr><td>版筒</td><td>
            <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox></td></tr>
        <tr><td>个数</td><td>
            <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox></td></tr>
        <tr><td>备注</td><td>
            <asp:TextBox ID="TextBox10" runat="server" Height="67px" TextMode="MultiLine"></asp:TextBox></td></tr>
        <tr><td colspan="2">  <asp:Button ID="Button2" runat="server" Text="确认修改" OnClick="Button2_Click" /></td></tr>
    </table>
    <hr />
    <table><tr><td colspan="2">报废产品</td></tr>
        <tr><td>选择客户</td><td><asp:DropDownList ID="DropDownList4" runat="server" Width="200px" OnSelectedIndexChanged="DropDownList4_SelectedIndexChanged" AutoPostBack="True">
    </asp:DropDownList></td></tr>
        <tr><td>选择产品</td><td>
            <asp:DropDownList ID="DropDownList5" runat="server" Width="200px" OnSelectedIndexChanged="DropDownList5_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList></td></tr>
        <tr><td>即将报废</td><td>
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label></td></tr>
        <tr><td colspan="2">  <asp:Button ID="Button3" runat="server" Text="确认报废" OnClick="Button3_Click" /></td></tr>
    </table>
</asp:Content>

