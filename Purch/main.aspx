<%@ Page Title="" Language="C#" MasterPageFile="../MainNav.master" AutoEventWireup="true" CodeFile="main.aspx.cs" Inherits="Purch_main" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="margin:0 auto;width:350px;line-height:2em; ">
客户名称<asp:dropdownlist id="drpcus" runat="server" AutoPostBack="True"></asp:dropdownlist>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        产品名称<asp:textbox id="txtpro" runat="server"></asp:textbox><br />
        产品类别<asp:dropdownlist id="drptype" runat="server" AutoPostBack="True">
            <asp:ListItem>牙膏管</asp:ListItem>
            <asp:ListItem>化妆品管</asp:ListItem>
            <asp:ListItem>药品管</asp:ListItem>
            <asp:ListItem>食品管</asp:ListItem>
        </asp:dropdownlist>
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <br />
        订单数量<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
        产品规格<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
            <asp:ListItem>12.7</asp:ListItem>
            <asp:ListItem>13.5</asp:ListItem>
            <asp:ListItem>16</asp:ListItem>
            <asp:ListItem>19</asp:ListItem>
            <asp:ListItem>22</asp:ListItem>
            <asp:ListItem>25</asp:ListItem>
            <asp:ListItem>28</asp:ListItem>
            <asp:ListItem>30</asp:ListItem>
            <asp:ListItem>32</asp:ListItem>
            <asp:ListItem>35</asp:ListItem>
            <asp:ListItem>38</asp:ListItem>
            <asp:ListItem>40</asp:ListItem>
            <asp:ListItem>50</asp:ListItem>
            <asp:ListItem>55</asp:ListItem>
        </asp:DropDownList>×<asp:TextBox ID="TextBox1" runat="server" Width="63px"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        <br />
        片材规格<asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged"></asp:DropDownList>
        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
        <br />
        是否印刷<asp:RadioButton ID="RadioButton1" runat="server" GroupName="是否印刷" Text="是" Checked="True" AutoPostBack="true" /><asp:RadioButton ID="RadioButton2" runat="server" GroupName="是否印刷" Text="否" AutoPostBack="true" />
        <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
        <br />
        丝印数量<asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="True">
            <asp:ListItem>0</asp:ListItem>
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
        <br />
        烫印数量<asp:DropDownList ID="DropDownList4" runat="server" AutoPostBack="True">
            <asp:ListItem>0</asp:ListItem>
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
        <br />
        是否满版<asp:RadioButton ID="RadioButton3" runat="server" GroupName="是否满版" Text="是" /><asp:RadioButton ID="RadioButton4" runat="server" GroupName="是否满版" Text="否" Checked="True" /><br />
        是否封膜<asp:RadioButton ID="RadioButton5" runat="server" GroupName="是否封膜" Text="是" /><asp:RadioButton ID="RadioButton6" runat="server" GroupName="是否封膜" Text="否" Checked="True" />
        <br />
        是否定位<asp:RadioButton ID="RadioButton11" runat="server" GroupName="是否定位" Text="是" /><asp:RadioButton ID="RadioButton12" runat="server" GroupName="是否定位" Text="否" Checked="True" />
        <br />
        是否封尾<asp:RadioButton ID="RadioButton7" runat="server" GroupName="是否封尾" Text="是" /><asp:RadioButton ID="RadioButton8" runat="server" GroupName="是否封尾" Text="否" Checked="True" />
        <br />
        使用盖子<asp:DropDownList ID="DropDownList10" runat="server" AutoPostBack="True">
        </asp:DropDownList>
        <asp:Label ID="Label12" runat="server" Text="Label"></asp:Label>
        <br />
        所用纸箱<asp:DropDownList ID="DropDownList5" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList5_SelectedIndexChanged">
        </asp:DropDownList><asp:DropDownList ID="DropDownList6" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList6_SelectedIndexChanged"></asp:DropDownList>
        <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
        <br />
        所用托盘<asp:DropDownList ID="DropDownList7" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList7_SelectedIndexChanged"></asp:DropDownList>
        <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>
        <br />
        装箱数量<asp:TextBox ID="TextBox6" runat="server" Width="68px"></asp:TextBox>
&nbsp;支×
        <asp:TextBox ID="TextBox7" runat="server" Width="67px"></asp:TextBox>
        层<br />
 运费核算<asp:DropDownList ID="DropDownList9" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList9_SelectedIndexChanged">
            <asp:ListItem>无运费</asp:ListItem>
            <asp:ListItem>广东省内</asp:ListItem>
            <asp:ListItem>广东省外</asp:ListItem>
            <asp:ListItem>FOB</asp:ListItem>
            <asp:ListItem>其它</asp:ListItem>
        </asp:DropDownList>
        <asp:TextBox ID="TextBox3" runat="server" Visible="False" Width="87px"></asp:TextBox>
        <asp:Label ID="Label11" runat="server" Text="Label"></asp:Label>
        <br />
        附加费用<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>元/支<br />
        是否开票<asp:RadioButton ID="RadioButton9" runat="server" GroupName="是否开票" Text="是" /><asp:RadioButton ID="RadioButton10" runat="server" GroupName="是否开票" Text="否" Checked="True" />
        <br />
       备注信息<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox><br />
        <asp:Button ID="Button1" runat="server" Text="提交" style="text-align:center;" OnClick="Button1_Click1"/>
    </div>
</asp:Content>

