<%@ Page Title="" Language="C#" MasterPageFile="MasterPage.master" AutoEventWireup="true" CodeFile="不合格品.aspx.cs" Inherits="kunming_不合格品" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
        <tr><td>订单号</td><td>
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True"></asp:DropDownList></td></tr>
        <tr><td>产生环节</td><td>
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged" AutoPostBack="True">
                <asp:ListItem>生产</asp:ListItem>
                <asp:ListItem>送货</asp:ListItem>
                <asp:ListItem>入库</asp:ListItem>
                <asp:ListItem>灌装</asp:ListItem>
            </asp:RadioButtonList></td></tr>
        <tr><td>日期</td><td>
            <asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList></td></tr>
        <tr><td>数量</td><td>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td></tr>
        <tr><td colspan="2">
            <asp:Button ID="Button1" runat="server" Text="提交" OnClick="Button1_Click" /></td></tr>
    </table>
</asp:Content>

