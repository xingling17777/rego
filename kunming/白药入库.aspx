<%@ Page Title="" Language="C#" MasterPageFile="MasterPage.master" AutoEventWireup="true" CodeFile="白药入库.aspx.cs" Inherits="kunming_Translate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>白药入库</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
        <table>
            <tr><td colspan="2">白药入库</td></tr>
            <tr><td>订单号：</td><td>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                <asp:Button ID="Button2" runat="server" Text="查询" OnClick="Button2_Click" />
                </td></tr>
            <tr><td>产品名称</td><td>
                <asp:Label ID="Label1" runat="server" Text="此处将显示白药产品名称"></asp:Label></td></tr>
            <tr><td>入库数量：</td><td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td></tr>
            <tr><td>入库日期：</td><td>
                <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
            </td></tr>
            <tr><td>备注：</td><td>
                <asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine" Width="635px"></asp:TextBox>
                </td></tr>
            <tr><td colspan="2">
                <asp:Button ID="Button1" runat="server" Text="提交" OnClick="Button1_Click" /></td></tr>
        </table>

    </div>
</asp:Content>

