<%@ Page Title="" Language="C#" MasterPageFile="../MainNav.master" AutoEventWireup="true" CodeFile="addpur.aspx.cs" Inherits="Purch_addpur" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div style="width: 400px; text-align: left; margin: 20px auto;">
        客户名称:<asp:DropDownList ID="DropDownList1" runat="server" Width="180px">
        </asp:DropDownList><a href="customer.aspx">增加新客户</a><br />
        <asp:TextBox ID="TextBox12" runat="server" OnTextChanged="TextBox12_TextChanged" Width="105px"></asp:TextBox><asp:Button ID="Button2" runat="server" Text="检索客户" OnClick="Button2_Click" />
        <br />
        项目名称:<asp:TextBox ID="TextBox11" runat="server" Width="227px"></asp:TextBox>
        <br />
        产品名称:<asp:TextBox ID="TextBox1" runat="server" Width="228px"></asp:TextBox>
        <br />
        产品类别:<asp:DropDownList ID="DropDownList2" runat="server">
            <asp:ListItem>牙膏管</asp:ListItem>
            <asp:ListItem>化妆品管</asp:ListItem>
            <asp:ListItem>食品管</asp:ListItem>
            <asp:ListItem>药管</asp:ListItem>
            <asp:ListItem>工业用管</asp:ListItem>
        </asp:DropDownList>
        <br />
        软管规格:<asp:TextBox ID="TextBox2" runat="server" Width="38px"></asp:TextBox>
        *<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        片材规格:<asp:DropDownList ID="DropDownList3" runat="server">
        </asp:DropDownList>
        <br />
        印刷方式:<asp:TextBox ID="TextBox4" runat="server">普通</asp:TextBox>
        <br />
        是否封膜:<asp:RadioButton ID="RadioButton1" runat="server" GroupName="fengmo" Text="是" Checked="True" />
        <asp:RadioButton ID="RadioButton2" runat="server" GroupName="fengmo" Text="否" />

        <br />
        盖子名称:<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <br />
        是否封尾:<asp:RadioButton ID="RadioButton3" runat="server" GroupName="fengwei" Text="是" />
        <asp:RadioButton ID="RadioButton4" runat="server" GroupName="fengwei" Text="否" Checked="True" />
        <br />
        运输地方:<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        <br />
        订单数量:<asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        <br />
        是否含税:<asp:RadioButton ID="RadioButton5" runat="server" GroupName="hanshui" Text="是" Checked="True" />
        <asp:RadioButton ID="RadioButton6" runat="server" GroupName="hanshui" Text="否" />
        <br />
        报价日期:<asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
        <br />
        报出价格:<asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
        <br />
        备注内容：<asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
        <br />
        <div style="text-align: center;">
            <asp:Button ID="Button1" runat="server" Text="提交" OnClick="Button1_Click" />
        </div>
    </div>
</asp:Content>

