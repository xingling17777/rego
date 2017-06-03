<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MainNav.master"  CodeFile="compentedit.aspx.cs" Inherits="components_compentedit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="width:300px; margin:20px auto;">
       选择物资:<asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" Width="210px">
       </asp:DropDownList>
       <br /><hr />
        物资名称:<asp:TextBox ID="TextBox1" runat="server" Width="210px"></asp:TextBox><br />
        物资规格:<asp:TextBox ID="TextBox2" runat="server" Width="210px"></asp:TextBox>
        <br />
        物资单位:<asp:TextBox ID="TextBox6" runat="server" Width="210px"></asp:TextBox>
        <br />
        使用部门:<asp:TextBox ID="TextBox3" runat="server" Width="210px"></asp:TextBox><br />
        存放地点:<asp:TextBox ID="TextBox4" runat="server" Width="210px"></asp:TextBox><br />
        隶属仓库:<asp:DropDownList ID="DropDownList1" runat="server" Width="210px">
            <asp:ListItem>配件</asp:ListItem>
            <asp:ListItem>工具</asp:ListItem>
            <asp:ListItem>行政</asp:ListItem>
        </asp:DropDownList><br />
       最低库存:<asp:TextBox ID="TextBox5" runat="server" Width="210px"></asp:TextBox><br />
       <div style="text-align:center;"><asp:Button ID="Button1" runat="server" Text="确认修改" OnClick="Button1_Click" /></div>
    </div>
</asp:Content>
