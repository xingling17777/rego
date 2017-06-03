 <%@ Page Title="" Language="C#" MasterPageFile="~/MainNav.master" AutoEventWireup="true" CodeFile="capList.aspx.cs" Inherits="capList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
       #table{
           width:900px;
           margin:20px auto;
       }
       table{
           border-collapse:collapse;
       }
      table tr td{
           padding:5px;
           border:1px solid black;
          text-align:center;
          
       }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="table">
    <asp:Button ID="Button1" runat="server" Text="以图文模式查看" OnClick="Button1_Click" /><br /><br />
    <asp:Table ID="Table1" runat="server"></asp:Table>

    </div>
</asp:Content>

