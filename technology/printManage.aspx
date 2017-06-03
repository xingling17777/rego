<%@ Page Title="" Language="C#" MasterPageFile="~/MainNav.master" AutoEventWireup="true" CodeFile="printManage.aspx.cs" Inherits="technology_printManage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
    <table style="width:300px;margin:30px auto;">
        <tr>
            <td> 动作</td><td> <asp:RadioButton ID="RadioButton1" runat="server" Text="领用" GroupName="borrow" /><asp:RadioButton ID="RadioButton2" runat="server" GroupName="borrow" Text="存档"  /><asp:RadioButton ID="RadioButton3" runat="server" GroupName="borrow" Text="报废"  /></td>
        </tr>
        <tr>
            <td>样版</td><td> <asp:CheckBox ID="CheckBox1" runat="server" /></td>
        </tr>
         <tr>
            <td> 菲林</td><td><asp:CheckBox ID="CheckBox2" runat="server" /></td>
        </tr>
         <tr>
            <td> 树脂版</td><td><asp:CheckBox ID="CheckBox3" runat="server" /></td>
        </tr>
         <tr>
            <td>片材</td><td><asp:CheckBox ID="CheckBox4" runat="server" /></td>
        </tr>
         <tr>
            <td>彩稿</td><td><asp:CheckBox ID="CheckBox5" runat="server" /></td>
        </tr>
        <tr><td colspan="2"><asp:Button ID="Button1" runat="server" Text="提交" OnClick="Button1_Click" style="margin-left: 0px" /></td></tr>
    </table>
</asp:Content>

