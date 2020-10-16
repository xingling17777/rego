<%@ Page Language="C#" MasterPageFile="../MainNav.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style1 {
          
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div style="margin-left: 50px">
        &nbsp;<hr />
        <p style="color: Red;">装箱支数计算(不适用于已封尾管或扁管)，仅做参考,<a href="pcs.aspx">查看已验证的装箱支数</a></p>
        <asp:label id="Label1" runat="server" text="纸箱长度(mm)："></asp:label>
        <asp:textbox id="TextBox1" runat="server"></asp:textbox>
        <br />

        <asp:label id="Label2" runat="server" text="纸箱宽度(mm)："></asp:label>
        <asp:textbox id="TextBox2" runat="server"></asp:textbox>
        <br />

        <asp:label id="Label3" runat="server" text="管径大小(mm)："></asp:label>
        <asp:textbox id="TextBox3" runat="server"></asp:textbox>
        <br />

        <span style="margin-left: 50px;">
            <asp:button id="Button1" runat="server" onclick="Button1_Click" text="计算" />
        </span>
       </div> 
    <hr />
    <div style="width:500px;margin:auto;">
        <p style="color: Red;">软管容量计算(已包含封尾长度)，仅做参考</p>
        
            <table>
                <tr><td>  <asp:label id="Label4" runat="server" text="容量"></asp:label></td><td class="auto-style1"> <asp:textbox id="TextBox4" runat="server" autopostback="True"
                ontextchanged="TextBox4_TextChanged" tooltip="在此处输入数值并回车,右侧可选择单位" Width="81px"></asp:textbox></td><td>
            <asp:radiobutton id="radioButton1" runat="server" autopostback="True"
                checked="True" groupname="unit" oncheckedchanged="radioButton1_CheckedChanged"
                text="ml" />
            <asp:radiobutton id="radioButton2" runat="server" autopostback="True"
                groupname="unit" oncheckedchanged="radioButton2_CheckedChanged" text="OZ" />
            <asp:radiobutton id="radioButton3" runat="server" autopostback="True"
                groupname="unit" oncheckedchanged="radioButton3_CheckedChanged" text="g" /></td></tr>
                 <tr><td> <asp:label id="Label5" runat="server" text="内容物"></asp:label></td><td class="auto-style1"> 
        <asp:dropdownlist id="DropDownList1" runat="server" autopostback="True" onselectedindexchanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem Value="1.0">水</asp:ListItem>
            <asp:ListItem Value="1.05">化妆品</asp:ListItem>            
            <asp:ListItem Value="1.26">药膏</asp:ListItem>           
            <asp:ListItem Value="1.40">牙膏</asp:ListItem>            
        </asp:dropdownlist>
                     </td><td>
                         <asp:Label ID="Label9" runat="server" Text="左侧选择内容物或者在下方手动输入密度（g/ml)" Visible="False" Width="200px"></asp:Label><br />
                     <asp:TextBox ID="TextBox6" runat="server" Visible="False" Width="81px"></asp:TextBox>
                     </td></tr>
                 <tr><td> <asp:Label ID="Label6" runat="server" Text="管型"></asp:Label></td><td class="auto-style1">  <asp:RadioButton ID="RadioButton4" runat="server" Checked="True" GroupName="tubetype" Text="圆管" OnCheckedChanged="RadioButton4_CheckedChanged" AutoPostBack="True" />
                     <br />
                     <asp:RadioButton ID="RadioButton5" runat="server" GroupName="tubetype" Text="扁管或椭圆管" AutoPostBack="True" OnCheckedChanged="RadioButton5_CheckedChanged" /></td><td>
                     <asp:Label ID="Label7" runat="server" Text="长轴"></asp:Label><asp:TextBox ID="TextBox7" runat="server" Width="60px"></asp:TextBox><br />
                     <asp:Label ID="Label8" runat="server" Text="短轴"></asp:Label><asp:TextBox ID="TextBox8" runat="server" Width="60px"></asp:TextBox>
                     </td></tr>
            <tr><td colspan="3"> <asp:button runat="server" text="开始计算" id="btnokC" onclick="btnokC_Click" /></td></tr>
            </table>         
               <asp:TextBox ID="TextBox5" runat="server" Height="200px" TextMode="MultiLine" Width="481px" Font-Names="等线" Font-Size="Larger"></asp:TextBox>
           </div>
</asp:Content>
