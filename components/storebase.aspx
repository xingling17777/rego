<%@ Page Title="" Language="C#" MasterPageFile="~/MainNav.master" AutoEventWireup="true" CodeFile="storebase.aspx.cs" Inherits="machine_storebase" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="width:300px; margin:20px auto; ">
        物资名称:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
        物资规格:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        物资单位:<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        <br />
        使用设备:<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
        存放地点:<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br />
        隶属仓库:<asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>配件</asp:ListItem>
            <asp:ListItem>工具</asp:ListItem>
            <asp:ListItem>行政</asp:ListItem>
        </asp:DropDownList><br />
        安全库存:<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox><br />
        <div style="text-align:center;"><asp:Button ID="Button1" runat="server" Text="提交" OnClick="Button1_Click" />
    </div></div>
</asp:Content>

