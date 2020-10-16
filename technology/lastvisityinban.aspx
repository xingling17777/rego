<%@ Page Title="" Language="C#" MasterPageFile="../MainNav.master" AutoEventWireup="true" CodeFile="lastvisityinban.aspx.cs" Inherits="technology_lastvisityinban" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:300px;margin:30px auto;">
          <tr><td>请输入产品编码，版本号转化成数字输入，如127001A请输入1270011</td></tr>
        <tr><td>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><asp:Button ID="Button1" runat="server" Text="提交" OnClick="Button1_Click" /></td></tr>
      
    </table>
</asp:Content>

