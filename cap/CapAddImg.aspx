<%@ Page Title="" Language="C#" MasterPageFile="~/MainNav.master" AutoEventWireup="true" CodeFile="CapAddImg.aspx.cs" Inherits="CapAddImg" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        #kbs{
            line-height:2em;
            width:400px;
            margin:0px auto;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="kbs">
        供应商<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
    帽盖名称：<asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList><br />
    图片1：<asp:FileUpload ID="FileUpload1" runat="server" /><br />
    图片2：<asp:FileUpload ID="FileUpload2" runat="server" /><br />
    图片3：<asp:FileUpload ID="FileUpload3" runat="server" /><br />
    <asp:Button ID="Button1" runat="server"  Text="提交" OnClick="Button1_Click" />
</div>
</asp:Content>

