<%@ Page Title="" Language="C#" MasterPageFile="MasterPage.master" AutoEventWireup="true" CodeFile="giftbase.aspx.cs" Inherits="gift_giftbase" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
            <table>
                <tr><td>礼品名称</td><td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td></tr>
               <tr><td>图片</td><td>
                   <asp:FileUpload ID="FileUpload1" runat="server" />
                   </td></tr>
                <tr><td colspan="2">
                    <asp:Button ID="Button1" runat="server" Text="提交" OnClick="Button1_Click" /></td></tr>
</table>
            
        </div>
</asp:Content>

