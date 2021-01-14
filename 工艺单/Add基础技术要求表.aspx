<%@ Page Title="" Language="C#" MasterPageFile="~/MainNav.master" AutoEventWireup="true" CodeFile="Add基础技术要求表.aspx.cs" Inherits="工艺单_Add基础技术要求表" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            height: 51px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
        <table>
            <tr><td>客户名称</td><td> <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList></td></tr>
            <tr><td>产品名称</td><td><asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList></td></tr>
            <tr><td> 管径</td><td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>mm</td></tr>
            <tr><td>印刷节距</td><td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>mm</td></tr>
            <tr><td>客户要求管长</td><td><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td></tr>
            <tr><td>执行标准</td><td>
                <asp:RadioButton ID="RadioButton1" runat="server" GroupName="标准" Text="企业标准" Checked="True" /><asp:RadioButton ID="RadioButton2" runat="server" GroupName="标准" Text="客户标准" /></td></tr>
            <tr><td>内容物</td><td>
                <asp:RadioButton ID="RadioButton3" runat="server" GroupName="内容物" Text="牙膏" Checked="True" /><asp:RadioButton ID="RadioButton4" runat="server" GroupName="内容物" Text="化妆品" /><asp:RadioButton ID="RadioButton5" runat="server" GroupName="内容物" Text="其它" /></td></tr>
            <tr><td>过油</td><td>
                <asp:RadioButton ID="RadioButton6" runat="server" GroupName="过油" Text="光油" Checked="True" />
                <asp:RadioButton ID="RadioButton7" runat="server" GroupName="过油" Text="哑油" />
                <asp:RadioButton ID="RadioButton8" runat="server" GroupName="过油" Text="局部光哑油" />
                </td></tr>
            <tr><td>片材规格</td><td>
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td></tr>
            <tr><td>片材宽度</td><td>
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                mm</td></tr>
            <tr><td class="auto-style1">满版制管</td><td class="auto-style1">
                <asp:RadioButton ID="RadioButton9" runat="server" GroupName="满版制管" Text="是" />
                <asp:RadioButton ID="RadioButton10" runat="server" GroupName="满版制管" Text="否" Checked="True" />
                </td></tr>
            <tr><td>注肩模具编号</td><td>
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                </td></tr>
       <tr><td>管口内径</td><td>
           <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
           mm</td></tr>
            <tr><td>封膜</td><td>
                <asp:RadioButton ID="RadioButton11" runat="server" GroupName="封膜" Text="是" Checked="True" />
                <asp:RadioButton ID="RadioButton12" runat="server" GroupName="封膜" Text="否" />
                </td></tr>
            <tr><td>封尾</td><td>
                <asp:RadioButton ID="RadioButton13" runat="server" GroupName="封尾" Text="否" Checked="True" />
                <asp:RadioButton ID="RadioButton14" runat="server" GroupName="封尾" Text="封直角" />
                <asp:RadioButton ID="RadioButton15" runat="server" GroupName="封尾" Text="封圆角" />
                <asp:RadioButton ID="RadioButton16" runat="server" GroupName="封尾" Text="封扇形" />
                </td></tr>
            <tr><td>帽盖名称</td><td>
                <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                </td></tr>
            <tr><td class="auto-style1">帽盖颜色</td><td class="auto-style1">
                <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                </td></tr>
            <tr><td>管肩颜色</td><td>
                <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
                </td></tr>
            <tr><td>帽盖定位</td><td>
                <asp:RadioButton ID="RadioButton17" runat="server" GroupName="帽盖定位" Text="是" />
                <asp:RadioButton ID="RadioButton18" runat="server" GroupName="帽盖定位" Text="否" Checked="True" />
                </td></tr>
            <tr><td>纸箱尺寸</td><td>
                <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
                </td></tr>
            <tr><td>托盘尺寸</td><td>
                <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
                </td></tr>
            <tr><td>纸箱纸质</td><td>
                <asp:RadioButton ID="RadioButton19" runat="server" GroupName="纸箱纸质" Text="B4B" />
                <asp:RadioButton ID="RadioButton20" runat="server" GroupName="纸箱纸质" Text="A4B" Checked="True" />
                <asp:RadioButton ID="RadioButton21" runat="server" GroupName="纸箱纸质" Text="BL3LB" />
                <asp:RadioButton ID="RadioButton22" runat="server" GroupName="纸箱纸质" Text="KOK" />
                <asp:RadioButton ID="RadioButton23" runat="server" GroupName="纸箱纸质" Text="K=A" />
                </td></tr>
            <tr><td>装箱支数</td><td>
                <asp:TextBox ID="TextBox13" runat="server"></asp:TextBox>
                支</td></tr>
            <tr><td>装箱方向</td><td>
                <asp:RadioButton ID="RadioButton24" runat="server" GroupName="装箱方向" Text="管尾向上" Checked="True" />
                <asp:RadioButton ID="RadioButton25" runat="server" GroupName="装箱方向" Text="管尾向下" />
                </td></tr>
            <tr><td>内膜袋规格</td><td>
                <asp:TextBox ID="TextBox14" runat="server"></asp:TextBox>
                </td></tr>
            <tr><td class="auto-style1">封箱胶要求</td><td class="auto-style1">
                <asp:RadioButton ID="RadioButton26" runat="server" GroupName="封箱胶" Text="无" Checked="True" />
                <asp:RadioButton ID="RadioButton27" runat="server" GroupName="封箱胶" Text="有LOGO" />
                <asp:RadioButton ID="RadioButton28" runat="server" GroupName="封箱胶" Text="无LOGO" />
                </td></tr>
            <tr><td>封箱方式</td><td>
                <asp:RadioButton ID="RadioButton29" runat="server" GroupName="封箱方式" Text="一字封" />
                <asp:RadioButton ID="RadioButton30" runat="server" GroupName="封箱方式" Text="工字封" />
                <asp:RadioButton ID="RadioButton31" runat="server" GroupName="封箱方式" Text="十字封" />
                <asp:RadioButton ID="RadioButton32" runat="server" GroupName="封箱方式" Text="无" Checked="True" />
                </td></tr>
            <tr><td>备注</td><td>
                <asp:TextBox ID="TextBox15" runat="server" Height="100px" TextMode="MultiLine" Width="348px"></asp:TextBox>
                </td></tr>
            <tr><td colspan="2">
                <asp:Button ID="Button1" runat="server" Text="提交" OnClick="Button1_Click" /></td></tr>
            </table>
    </div>
</asp:Content>

