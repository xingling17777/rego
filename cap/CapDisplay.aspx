<%@ Page Title="" Language="C#" MasterPageFile="~/MainNav.master" AutoEventWireup="true" CodeFile="CapDisplay.aspx.cs" Inherits="CapDisplay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        #one{
            width:700px;
            margin:20px auto;
        }
        table{
            margin-left:100px;
            margin-top:30px;
            width:500px;
            line-height:1.5em;
            text-align:center;
            border-collapse:collapse;
        }
       td{
            border:1px solid black;
            
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="one">
    <table style="border:1px solid black">
        <tr><td colspan="2"><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></td></tr>
              <tr><td>模具编号</td><td>
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></td></tr>
         <tr><td>每模（pcs）</td><td>
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label></td></tr>
         <tr><td>净重（g）</td><td>
            <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label></td></tr>
         <tr><td>日产（pcs）</td><td>
            <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label></td></tr>
        <tr><td>备注</td><td>
            <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine"></asp:TextBox></td></tr>
    </table>
    <br />
    <div id="img" style="text-align:center;" runat="server"></div>
        </div>
</asp:Content>

