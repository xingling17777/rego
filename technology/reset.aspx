<%@ Page Title="" Language="C#" MasterPageFile="../MainNav.master" AutoEventWireup="true" CodeFile="reset.aspx.cs" Inherits="technology_reset" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h3>警告：以下操作将重置相应数据库，以往所有输入内容将清空。若确认使用，请输入管理密码</h3>
    重置最后使用日期：<asp:TextBox ID="TextBox1" runat="server" ToolTip="请输入密码以确认"></asp:TextBox><asp:Button ID="Button1" runat="server" Text="提交" OnClick="Button1_Click" />
</asp:Content>

