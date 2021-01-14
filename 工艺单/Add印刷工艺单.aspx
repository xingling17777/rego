<%@ Page Title="" Language="C#" MasterPageFile="~/MainNav.master" AutoEventWireup="true" CodeFile="Add印刷工艺单.aspx.cs" Inherits="工艺单_Add印刷工艺单" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div>
       <!--技术部反应工艺单是随着产品编号变化，而非版本号变化-->
        <table>
            <tr>
                <td colspan="7">印刷工艺要求指示单</td>
            </tr>
           
            <tr>
                <td>客户名称</td>
                <td>
                    <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
                <td>产品名称</td>
                <td colspan="2">
                    <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
                <td>产品规格</td>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
             
            <tr>
                <td colspan="7">BOM设置</td>
            </tr>
            <tr>
                <td>物资名称</td>
                <td colspan="2">供应商</td>
                <td colspan="2">规格</td>
                <td colspan="2">备注</td>
            </tr>
            <tr>
                <td>片材类型</td>
                <td colspan="2">
                    <asp:TextBox ID="TextBox8" runat="server">瑞高</asp:TextBox>
                </td>
                <td colspan="2">
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                </td>
                <td colspan="2">
                    <asp:TextBox ID="TextBox17" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>油墨</td>
                <td colspan="2">
                    <asp:TextBox ID="TextBox9" runat="server">杭华/东洋</asp:TextBox>
                </td>
                <td colspan="2">
                    <asp:TextBox ID="TextBox10" runat="server">杭华/东洋油墨</asp:TextBox>
                </td>
                <td colspan="2">
                    <asp:TextBox ID="TextBox18" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>光油/哑油</td>
                <td colspan="2">
                    <asp:TextBox ID="TextBox11" runat="server">超彩/骏捷</asp:TextBox>
                </td>
                <td colspan="2">
                    <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
                </td>
                <td colspan="2">
                    <asp:TextBox ID="TextBox19" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>烫印</td>
                <td colspan="2">
                    <asp:TextBox ID="TextBox13" runat="server"></asp:TextBox>
                </td>
                <td colspan="2">
                    <asp:TextBox ID="TextBox14" runat="server"></asp:TextBox>
                </td>
                <td colspan="2">
                    <asp:TextBox ID="TextBox20" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>胶水</td>
                <td colspan="2">
                    <asp:TextBox ID="TextBox15" runat="server"></asp:TextBox>
                </td>
                <td colspan="2">
                    <asp:TextBox ID="TextBox16" runat="server"></asp:TextBox>
                </td>
                <td colspan="2">
                    <asp:TextBox ID="TextBox21" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="7">工艺要求</td>
            </tr>
            <tr>
                <td>是否打底油</td>
                <td colspan="2">
                    <asp:RadioButton ID="RadioButton1" runat="server" Text="是" GroupName="底油" />
                    <asp:RadioButton ID="RadioButton2" runat="server" Text="否" Checked="True" GroupName="底油" />
                </td>
                <td>是否满版</td>
                <td>
                    <asp:RadioButton ID="RadioButton3" runat="server" Text="是" GroupName="满版" />
                    <asp:RadioButton ID="RadioButton4" runat="server" Text="否" Checked="True" GroupName="满版" />
                </td>
                <td>卷芯尺寸</td>
                <td>
                    <asp:RadioButton ID="RadioButton5" runat="server" Text="3英寸" Checked="True" GroupName="卷芯尺寸" />
                    <asp:RadioButton ID="RadioButton6" runat="server" Text="6英寸" GroupName="卷芯尺寸" />
                </td>
            </tr>
            <tr>
                <td rowspan="2">第一次印刷收卷方向</td><td colspan="3">
                <asp:RadioButton ID="RadioButton7" runat="server" GroupName="收卷方向" Text="管头" />
                </td><td colspan="3">
                    <asp:RadioButton ID="RadioButton8" runat="server" GroupName="收卷方向" Text="管尾" />
                </td>
            </tr>
            <tr><td colspan="3"><img src="../img/收卷方向-管头.png" /></td><td colspan="3"><img src="../img/收卷方向-管尾.png" /></td></tr>
            <tr>
                <td colspan="7">质量要求</td>
            </tr>            
            <tr>
                <td>印刷长度</td>
                <td colspan="4">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    -<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    mm</td>
                <td colspan="2">用直尺测量</td>
            </tr>
            <tr>
                <td>切割宽度</td>
                <td colspan="4">≥<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    mm</td>
                <td colspan="2">用直尺测量</td>
            </tr>
            <tr>
                <td>色标中心距印刷边距离</td>
                <td colspan="4">
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    -<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                    mm</td>
                <td colspan="2">用直尺测量</td>
            </tr>
            <tr>
                <td>套色精度</td>
                <td colspan="4">≤<asp:TextBox ID="TextBox6" runat="server">0.3</asp:TextBox>
                    mm</td>
                <td colspan="2">用放大镜测量</td>
            </tr>
            <tr>
                <td>油墨附着力</td>
                <td colspan="4">用3M<asp:TextBox ID="TextBox22" runat="server">600</asp:TextBox>
                    胶带横纵各测试一次，油墨无脱落</td>
                <td colspan="2">3M胶带测试法</td>
            </tr>
            <tr>
                <td>其它要求</td>
                <td colspan="6">
                    <asp:TextBox ID="TextBox7" runat="server" Height="206px" TextMode="MultiLine" Width="730px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="7">
                    <asp:Button ID="Button1" runat="server" Text="提交" OnClick="Button1_Click" /></td>
            </tr>
        </table>
    </div>
</asp:Content>

