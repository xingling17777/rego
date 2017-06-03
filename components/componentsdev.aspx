<%@ Page Title="" Language="C#" MasterPageFile="~/MainNav.master" AutoEventWireup="true" CodeFile="componentsdev.aspx.cs" Inherits="components_componentsdev" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="width:300px; margin:20px auto;">
        配件名称:<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" Width="210px"></asp:DropDownList><br />
        配件数量:<asp:TextBox ID="TextBox1" runat="server" Width="210px"></asp:TextBox><br />
        出库入库:<asp:RadioButton ID="RadioButton1" runat="server" GroupName="grp" Text="入库" Checked="True" /><asp:RadioButton ID="RadioButton2" runat="server" GroupName="grp" Text="出库" /><br />
        相关人员:<asp:TextBox ID="TextBox2" runat="server" Width="210px"></asp:TextBox><br />
        事项说明:<asp:TextBox ID="TextBox3" runat="server" Width="210px"></asp:TextBox><br />
        <div style="text-align:center;"><asp:Button ID="Button1" runat="server" Text="出入库提交" OnClick="Button1_Click" />
            <br /><asp:Button ID="Button2" runat="server" Text="删除物资" OnClick="Button2_Click" />
            <br />
        <asp:Label ID="Label1" runat="server" Text="" ForeColor="Red"></asp:Label></div>
    </div>
</asp:Content>

