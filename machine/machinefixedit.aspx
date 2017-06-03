<%@ Page Title="" Language="C#" MasterPageFile="~/MainNav.master" AutoEventWireup="true" CodeFile="machinefixedit.aspx.cs" Inherits="machine_machinefixedit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="width:90%;margin:20px auto;line-height:1.5em; text-align:center;">
        <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
        <br />
        <asp:Label ID="Label2" runat="server" Text="日期" Width="10%" Font-Bold="False" ForeColor="Black" BorderStyle="None" BorderColor="Black"></asp:Label><asp:Label ID="Label1" runat="server" Text="保养内容" Width="75%"  ForeColor="Black" Font-Bold="False" BorderStyle="None" BorderColor="Black"></asp:Label><asp:Label ID="Label3" runat="server" Text="保养人" Width="10%" ForeColor="Black" Font-Bold="False" BorderStyle="None" BorderColor="Black" Font-Underline="False"></asp:Label><br />
        <asp:TextBox ID="TextBox11" runat="server" Width="10%"></asp:TextBox><asp:TextBox ID="TextBox12"  Width="75%" runat="server" ></asp:TextBox><asp:TextBox ID="TextBox13" runat="server" Width="10%"></asp:TextBox><br />
        <asp:TextBox ID="TextBox21" runat="server" Width="10%"></asp:TextBox><asp:TextBox ID="TextBox22"  Width="75%" runat="server" ></asp:TextBox><asp:TextBox ID="TextBox23" runat="server" Width="10%"></asp:TextBox><br />
        <asp:TextBox ID="TextBox31" runat="server" Width="10%"></asp:TextBox><asp:TextBox ID="TextBox32"  Width="75%" runat="server" ></asp:TextBox><asp:TextBox ID="TextBox33" runat="server" Width="10%"></asp:TextBox><br />
        <asp:TextBox ID="TextBox41" runat="server" Width="10%"></asp:TextBox><asp:TextBox ID="TextBox42"  Width="75%" runat="server" ></asp:TextBox><asp:TextBox ID="TextBox43" runat="server" Width="10%"></asp:TextBox><br />
        <asp:TextBox ID="TextBox51" runat="server" Width="10%"></asp:TextBox><asp:TextBox ID="TextBox52"  Width="75%" runat="server" ></asp:TextBox><asp:TextBox ID="TextBox53" runat="server" Width="10%"></asp:TextBox><br />
        <div style="text-align:center;"><asp:Button ID="Button1" runat="server" Text="提交" OnClick="Button1_Click" /></div>

    </div>
</asp:Content>

