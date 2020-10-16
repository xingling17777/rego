<%@ Page Title="" Language="C#" MasterPageFile="../MainNav.master" AutoEventWireup="true" CodeFile="list.aspx.cs" Inherits="components_list" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
      table{
          width:90%;
        
           border-collapse:collapse;
       }
      
      table tr td{
           padding:5px;
           border:1px solid black;
          text-align:center;
          word-break:break-all;
          word-wrap:break-word;
       }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div style="margin-left:15%;">
     
    <asp:Table ID="Table1" runat="server"></asp:Table>

    </div>
</asp:Content>

