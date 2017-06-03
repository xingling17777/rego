<%@ Page Title="" Language="C#" MasterPageFile="~/MainNav.master" AutoEventWireup="true" CodeFile="capAdd.aspx.cs" Inherits="capAdd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        
        table{
            
            width:500px;
            line-height:2em;
            text-align:center;
            border-collapse:collapse;
        }
       td{
            border:1px solid black;
            
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   <div style="text-align:center; margin:20px auto; width:500px;"> <table>
        <tr><td>供应商</td><td>
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
            </td></tr>
        <tr><td>帽盖名称</td><td>
            <asp:TextBox ID="txtname" runat="server"></asp:TextBox></td></tr>
        <tr><td>帽盖编号</td><td>
            <asp:TextBox ID="txtID" runat="server"></asp:TextBox></td></tr>
        <tr><td>上沿外径</td><td>
            <asp:TextBox ID="txtud" runat="server"></asp:TextBox></td></tr>
        <tr><td>下沿外径</td><td>
            <asp:TextBox ID="txtdd" runat="server"></asp:TextBox></td></tr>
        <tr><td>高度</td><td>
            <asp:TextBox ID="txth" runat="server"></asp:TextBox></td></tr>
        <tr><td>顶螺纹</td><td>
            <asp:TextBox ID="txttd" runat="server"></asp:TextBox></td></tr>
         <tr><td>底螺纹</td><td>
            <asp:TextBox ID="txtbd" runat="server"></asp:TextBox></td></tr>
         <tr><td>内口径</td><td>
            <asp:TextBox ID="txtor" runat="server"></asp:TextBox></td></tr>
         <tr><td>重量</td><td>
            <asp:TextBox ID="txtw" runat="server"></asp:TextBox></td></tr>
        <tr><td>颜色</td><td>
            <asp:TextBox ID="txtc" runat="server" ></asp:TextBox></td></tr>
         <tr><td>备注</td><td>
            <asp:TextBox ID="txtreMark" runat="server"></asp:TextBox></td></tr>
        <tr><td colspan="2">
            <asp:Button ID="Button1" runat="server" Text="提交" OnClick="Button1_Click" /></td></tr>
    </table></div>
</asp:Content>

