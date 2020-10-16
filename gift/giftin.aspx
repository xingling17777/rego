<%@ Page Title="" Language="C#" MasterPageFile="MasterPage.master" AutoEventWireup="true" CodeFile="giftin.aspx.cs" Inherits="gift_giftin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    礼物名称：<asp:DropDownList id="drp1" runat="server"></asp:DropDownList>
    <br />
    数量：<asp:TextBox id="txtbox1" runat="server"></asp:TextBox><br />
    单位：<asp:TextBox id="txtbox2" runat="server"></asp:TextBox><br />
    <asp:Button id="btnOK" runat="server" Text="提交" OnClick="btnOK_Click" />

</asp:Content>

