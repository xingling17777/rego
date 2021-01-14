<%@ Page Title="" Language="C#" MasterPageFile="MasterPage.master" AutoEventWireup="true" CodeFile="guanzhuang.aspx.cs" Inherits="kunming_Translate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
        <table>
            <tr><td colspan="2">白药灌装</td></tr>
            <tr><td>订单号：</td><td>
                <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList></td></tr>
            <tr><td>灌装数量：</td><td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td></tr>
            <tr><td>灌装日期：</td><td>
                <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
            </td></tr>
            <tr><td>备注：</td><td>
                <asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine"></asp:TextBox>
                </td></tr>
            <tr><td colspan="2">
                <asp:Button ID="Button1" runat="server" Text="提交" OnClick="Button1_Click" /></td></tr>
        </table>

    </div>
</asp:Content>

