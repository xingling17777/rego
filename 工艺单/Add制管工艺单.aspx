<%@ Page Title="" Language="C#" MasterPageFile="~/MainNav.master" AutoEventWireup="true" CodeFile="Add制管工艺单.aspx.cs" Inherits="工艺单_Add制管工艺单" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
            <tr><td colspan="8">制管、包装工艺要求指示单</td></tr>
            <tr><td colspan="2">客户名称</td><td colspan="6">
                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                </asp:DropDownList>
                </td></tr>
        <tr><td colspan="2">产品名称</td><td colspan="6">
            <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
            </asp:DropDownList>
            </td></tr>
            <tr><td colspan="8">1.BOM设置</td></tr>
            <tr><td>片材规格</td><td>
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td><td>管肩描述</td><td colspan="2">
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                </td><td>模具编号</td><td colspan="2">
                <asp:TextBox ID="TextBox52" runat="server"></asp:TextBox>
                </td></tr>
            <tr><td>产品规格</td><td>
                <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                </td><td>螺纹</td><td colspan="2">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td><td>帽盖</td><td colspan="2">
                <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                </td></tr>
            <tr><td colspan="8">2.检验标准</td></tr>
            <tr><td colspan="2">要求</td><td>目标值</td><td>下限</td><td>上限</td><td>单位</td><td>精确度</td><td>测试方法</td></tr>
            <tr><td colspan="2">A.管长</td><td>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td><td>
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td><td>
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                </td><td>mm</td><td>0.50</td><td>勾尺/直尺</td></tr>
            <tr><td colspan="2">B.管身外径</td><td>
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                </td><td>
                    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                </td><td>
                    <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                </td><td>mm</td><td>0.01</td><td>通规/卡尺</td></tr>
            <tr><td colspan="2">C.管身内径</td><td>
                <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                </td><td>
                    <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
                </td><td>
                    <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
                </td><td>mm</td><td>0.10</td><td>通规</td></tr>
            <tr><td colspan="2">D.管口内径</td><td>
                <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
                </td><td>
                    <asp:TextBox ID="TextBox13" runat="server"></asp:TextBox>
                </td><td>
                    <asp:TextBox ID="TextBox14" runat="server"></asp:TextBox>
                </td><td>mm</td><td>0.01</td><td>游标卡尺</td></tr>
            <tr><td colspan="2">E.封尾管标至管尾</td><td>
                <asp:TextBox ID="TextBox15" runat="server"></asp:TextBox>
                </td><td>
                    <asp:TextBox ID="TextBox16" runat="server"></asp:TextBox>
                </td><td>
                    <asp:TextBox ID="TextBox17" runat="server"></asp:TextBox>
                </td><td>mm</td><td>0.50</td><td>直尺</td></tr>
            <tr><td colspan="2">F.封尾管标中心至焊缝</td><td>
                <asp:TextBox ID="TextBox18" runat="server"></asp:TextBox>
                </td><td>
                    <asp:TextBox ID="TextBox19" runat="server"></asp:TextBox>
                </td><td>
                    <asp:TextBox ID="TextBox20" runat="server"></asp:TextBox>
                </td><td>mm</td><td>0.50</td><td>直尺</td></tr>
            <tr><td colspan="2">G.焊缝重叠宽度</td><td>
                <asp:TextBox ID="TextBox21" runat="server"></asp:TextBox>
                </td><td>
                    <asp:TextBox ID="TextBox22" runat="server"></asp:TextBox>
                </td><td>
                    <asp:TextBox ID="TextBox23" runat="server"></asp:TextBox>
                </td><td>mm</td><td>0.10</td><td>放大镜</td></tr>
            <tr><td colspan="2">H.椭圆度</td><td>0</td><td>0</td><td>
                <asp:TextBox ID="TextBox24" runat="server"></asp:TextBox>
                </td><td>%</td><td>0.01%</td><td>直尺</td></tr>
            <tr><td colspan="2">I.压缩率</td><td>
                <asp:TextBox ID="TextBox25" runat="server"></asp:TextBox>
                </td><td>
                    <asp:TextBox ID="TextBox26" runat="server"></asp:TextBox>
                </td><td>
                    <asp:TextBox ID="TextBox27" runat="server"></asp:TextBox>
                </td><td>%</td><td>0.01%</td><td>千分尺</td></tr>
            <tr><td colspan="2">J.气泄测试</td><td>无泄漏</td><td>0.02</td><td>-</td><td>Mpa/5sec</td><td>-</td><td>气压表</td></tr>
            <tr><td colspan="2">K.管壁白线</td><td>-</td><td>
                <asp:TextBox ID="TextBox28" runat="server"></asp:TextBox>
                </td><td>
                    <asp:TextBox ID="TextBox29" runat="server"></asp:TextBox>
                </td><td>mm</td><td>0.10</td><td>放大镜</td></tr>
            <tr><td colspan="2">L.管盖定位</td><td>
                <asp:TextBox ID="TextBox30" runat="server"></asp:TextBox>
                </td><td>
                    <asp:TextBox ID="TextBox31" runat="server"></asp:TextBox>
                </td><td>
                    <asp:TextBox ID="TextBox32" runat="server"></asp:TextBox>
                </td><td>°</td><td>0.10</td><td>-</td></tr>
            <tr><td colspan="2">M.封尾强度</td><td>无破损</td><td>-</td><td>-</td><td>Mpa/10sec</td><td>-</td><td>气压表</td></tr>
            <tr><td colspan="2">N.帽盖释放扭矩</td><td>-</td><td>
                <asp:TextBox ID="TextBox33" runat="server"></asp:TextBox>
                </td><td>
                    <asp:TextBox ID="TextBox34" runat="server"></asp:TextBox>
                </td><td>N*cm</td><td>0.10</td><td>扭矩仪</td></tr>
            <tr><td colspan="2">O.滑牙力</td><td>无滑牙</td><td>
                <asp:TextBox ID="TextBox35" runat="server"></asp:TextBox>
                </td><td>0</td><td>N*cm</td><td>0.10</td><td>扭矩仪</td></tr>
            <tr><td colspan="2" class="auto-style1">P.开启力</td><td class="auto-style1">-</td><td class="auto-style1">-</td><td class="auto-style1">-</td><td class="auto-style1">Min</td><td class="auto-style1">-</td><td class="auto-style1">扭矩仪</td></tr>
            <tr><td colspan="2">Q.硫酸铜测试</td><td>无黑点</td><td>
                <asp:TextBox ID="TextBox36" runat="server"></asp:TextBox>
                </td><td>-</td><td>Min</td><td>-</td><td>硫酸铜测试</td></tr>
            <tr><td colspan="2">R.爆破测试</td><td>无破损</td><td>
                <asp:TextBox ID="TextBox37" runat="server"></asp:TextBox>
                </td><td>-</td><td>Mpa/30sec</td><td>-</td><td>气压表</td></tr>
            <tr><td colspan="2">S.跌落测试</td><td>无破损</td><td>
                <asp:TextBox ID="TextBox38" runat="server"></asp:TextBox>
                </td><td>-</td><td>米/3次</td><td>-</td><td>跌落实验</td></tr>
            <tr><td colspan="2">T.夹紧测试</td><td>无破损</td><td>-</td><td>-</td><td>-</td><td>-</td><td>手动</td></tr>
            <tr><td colspan="2">U.管肩剥离</td><td>无破损</td><td>
                <asp:TextBox ID="TextBox39" runat="server"></asp:TextBox>
                </td><td>-</td><td>N/15mm</td><td>0.10</td><td>拉力仪</td></tr>
            <tr><td colspan="2">V.外观</td><td colspan="5">1）管口无明显披锋、无破损、无严重变形、螺纹完好、无滑牙； 2）管肩无少料、无缩水、无多料变形、无下垂、无脱离、分层； 3）管身无破损、无明显划伤、无印刷不良、焊缝平整，无烫伤、无明显皱褶、无拉毛、无破损、无卷尾、无刮手、无污染、无倒管等缺陷； 4）管内外无毛发、血液、玻璃碎片、蚊虫、金属等。</td><td>目测</td></tr>
            <tr><td colspan="8">3.包装要求：</td></tr>
            <tr><td>封膜：</td><td colspan="7">
                <asp:RadioButton ID="RadioButton1" runat="server" Text="不封膜" GroupName="封膜" />
                <asp:RadioButton ID="RadioButton2" runat="server" Text="指定封单耳膜" GroupName="封膜" />
                <asp:RadioButton ID="RadioButton3" runat="server" Text="指定封双耳膜" GroupName="封膜" />
                <asp:RadioButton ID="RadioButton4" runat="server" Text="封膜不指定，单耳、双耳都可以" GroupName="封膜" />
                </td></tr>
           <tr><td>封尾：</td><td  colspan="2">
               <asp:RadioButton ID="RadioButton5" runat="server" Text="不封尾" GroupName="封尾" />
               <asp:RadioButton ID="RadioButton6" runat="server" Text="封直角" GroupName="封尾" />
               <asp:RadioButton ID="RadioButton7" runat="server" Text="封圆角" GroupName="封尾" />
               </td><td>封尾后管长</td><td>
               <asp:TextBox ID="TextBox40" runat="server"></asp:TextBox>
               mm</td><td>压纹宽度</td><td colspan="2">
               <asp:TextBox ID="TextBox41" runat="server"></asp:TextBox>
               mm</td></tr>
            <tr><td>纸箱：</td><td colspan="3">
                <asp:TextBox ID="TextBox42" runat="server"></asp:TextBox>
                mm</td><td>托盘：</td><td colspan="3">
                <asp:TextBox ID="TextBox43" runat="server"></asp:TextBox>
                mm</td></tr>
            <tr><td colspan="2">装箱支数</td><td colspan="2">
                <asp:TextBox ID="TextBox44" runat="server"></asp:TextBox>
                支</td><td>内膜袋：</td><td colspan="3">
                <asp:TextBox ID="TextBox45" runat="server"></asp:TextBox>
                mm</td></tr>
            <tr><td colspan="2">装箱方式</td><td colspan="2">
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" BorderColor="Black" RepeatDirection="Horizontal">
                    <asp:ListItem Selected="True">管尾向上</asp:ListItem>
                    <asp:ListItem>管尾向下</asp:ListItem>
                </asp:RadioButtonList>
                </td><td>内膜袋要求：</td><td colspan="3">
                <asp:TextBox ID="TextBox46" runat="server"></asp:TextBox>
                </td></tr>
            <tr><td colspan="2" class="auto-style1">封箱方式</td><td colspan="6" class="auto-style1">
                <asp:RadioButtonList ID="RadioButtonList2" runat="server" RepeatDirection="Horizontal">
                    <asp:ListItem>一字封</asp:ListItem>
                    <asp:ListItem>工字封</asp:ListItem>
                    <asp:ListItem>十字封</asp:ListItem>
                    <asp:ListItem>无特殊要求</asp:ListItem>
                </asp:RadioButtonList>
                </td></tr>
            <tr><td colspan="2">封箱胶要求</td><td colspan="6">
                <asp:RadioButtonList ID="RadioButtonList3" runat="server" RepeatDirection="Horizontal">
                    <asp:ListItem>透明带Logo</asp:ListItem>
                    <asp:ListItem>透明不带logo</asp:ListItem>
                    <asp:ListItem>专用封箱胶</asp:ListItem>
                    <asp:ListItem>无特殊要求</asp:ListItem>
                </asp:RadioButtonList>
                </td></tr>
            <tr><td colspan="2">托板规格</td><td colspan="2">
                <asp:TextBox ID="TextBox47" runat="server"></asp:TextBox>
                </td><td colspan="4">每层<asp:TextBox ID="TextBox48" runat="server" Width="87px"></asp:TextBox>
                    箱，<asp:TextBox ID="TextBox49" runat="server" Width="97px"></asp:TextBox>
                    层，共<asp:TextBox ID="TextBox50" runat="server" Width="91px"></asp:TextBox>
                    箱</td></tr>
            <tr><td colspan="2">4.其它要求</td><td colspan="6">
                <asp:TextBox ID="TextBox51" runat="server" Height="79px" TextMode="MultiLine" Width="731px"></asp:TextBox>
                </td></tr>
        <tr><td colspan="8">
            <asp:Button ID="Button1" runat="server" Text="提交" OnClick="Button1_Click" /></td></tr>
        </table>
</asp:Content>

