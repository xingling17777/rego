<%@ Page Title="" Language="C#" MasterPageFile="~/MainNav.master" AutoEventWireup="true" CodeFile="customer.aspx.cs" Inherits="Purch_customer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        span {
            width: 80px;
            text-align: justify;
            display: inline-block;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div style="margin: auto; line-height: 2em; width: 300px; text-align: center;">
         
        <span>修改客户</span><asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList><hr />
        <span>客户名称</span><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
        <span>客户昵称</span><asp:TextBox ID="TextBox12" runat="server"></asp:TextBox><br />
        <span>联系人</span><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
        <span>手机</span><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
        <span>QQ</span><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br />
        <span>微信</span><asp:TextBox ID="TextBox5" runat="server"></asp:TextBox><br />
        <span>网址</span><asp:TextBox ID="TextBox6" runat="server"></asp:TextBox><br />
        <span>固定电话</span><asp:TextBox ID="TextBox7" runat="server"></asp:TextBox><br />
        <span>传真</span><asp:TextBox ID="TextBox8" runat="server"></asp:TextBox><br />
        <span>邮箱</span><asp:TextBox ID="TextBox9" runat="server"></asp:TextBox><br />
        <span>地址</span><asp:TextBox ID="TextBox10" runat="server"></asp:TextBox><br />
        <span>备注信息</span><asp:TextBox ID="TextBox11" runat="server"></asp:TextBox><br />
        <asp:Button ID="Button1" runat="server" Text="提交" Style="" OnClick="Button1_Click" />
    </div>
</asp:Content>

