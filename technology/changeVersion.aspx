<%@ Page Title="" Language="C#" MasterPageFile="../MainNav.master" AutoEventWireup="true" CodeFile="changeVersion.aspx.cs" Inherits="technology_changeVersion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 
    <table style="width:400px;margin:30px auto;">
        <tr><td>当前版本为</td><td><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></td></tr>
         <tr><td> 即将变更为</td><td><asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></td></tr>
         <tr><td>当前版本</td><td><asp:RadioButton ID="RadioButton1" runat="server" Checked="True" GroupName="version" Text="作废" /><asp:RadioButton ID="RadioButton2" runat="server" GroupName="version" Text="不作废" /></td></tr>
         <tr><td colspan="2">仅报废当前版本，无新版产生<asp:CheckBox ID="CheckBox1" runat="server" /></td></tr>
        <tr><td colspan="2"><asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="确认提交" /></td></tr>
    </table>
</asp:Content>

