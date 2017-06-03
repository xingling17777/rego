<%@ Page Title="" Language="C#" MasterPageFile="~/MainNav.master" AutoEventWireup="true" CodeFile="guzhangbaoxiu.aspx.cs" Inherits="machine_guzhangbaoxiu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
       
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="width:600px;margin:20px auto;text-align:left;">
        机台名称:<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        故障描述:<asp:TextBox ID="TextBox1" runat="server" Height="108px" TextMode="MultiLine" Width="500px"></asp:TextBox>
        <br />
        报修人员:<asp:TextBox ID="TextBox3" runat="server" Width="500px"></asp:TextBox>
        <br />
        报修日期:<asp:TextBox ID="TextBox5" runat="server" Width="500px"></asp:TextBox>
        <br />
        联系方式:<asp:TextBox ID="TextBox4" runat="server" Width="500px"></asp:TextBox><br />
       <div style="text-align:center;"> <asp:Button ID="Button1" runat="server" Text="提交" OnClick="Button1_Click" />
    </div></div>
</asp:Content>

