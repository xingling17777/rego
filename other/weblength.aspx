﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MainNav.master" AutoEventWireup="true" CodeFile="weblength.aspx.cs" Inherits="other_weblength" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div style="width: 400px; margin: 20px auto; line-height:2em;">
        <table>
            <tr><td>纸  芯</td><td><asp:radiobutton runat="server" text="3英寸" id="radiobtn3" groupname="core" Checked="True"></asp:radiobutton><asp:radiobutton runat="server" text="6英寸" groupname="core"></asp:radiobutton></td></tr>
            <tr><td>片材厚度</td><td> <asp:textbox runat="server" id="txtbox1"></asp:textbox></td></tr>
            <tr><td> <asp:radiobutton runat="server" id="rbtncor" groupname="rol" text="片材长度"></asp:radiobutton>
        <asp:radiobutton runat="server" id="rbtrol" groupname="rol" text="片材外径" Checked="True"></asp:radiobutton></td><td><asp:textbox runat="server" id="txtdia"></asp:textbox></td></tr>
            <tr><td colspan="2"><asp:button runat="server" text="提交" id="btnOK" OnClick="btnOK_Click" /></td></tr>
            <tr><td colspan="2"><asp:Label ID="Label1" runat="server" Text=""></asp:Label></td></tr>
        </table>
    </div>
</asp:Content>

