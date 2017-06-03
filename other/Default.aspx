<%@ Page Language="C#" MasterPageFile="~/MainNav.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
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
        <hr />
    </div>
    <div style="margin-left: 50px">
        <p style="color: Red;">软管容量计算(已包含封尾长度)，仅做参考</p>
        <div>

            <asp:label id="Label4" runat="server" text="容量："></asp:label>
            <asp:textbox id="TextBox4" runat="server" autopostback="True"
                ontextchanged="TextBox4_TextChanged" tooltip="在此处输入数值并回车,右侧可选择单位"></asp:textbox>

            <asp:radiobutton id="radioButton1" runat="server" autopostback="True"
                checked="True" groupname="unit" oncheckedchanged="radioButton1_CheckedChanged"
                text="ml" />
            <asp:radiobutton id="radioButton2" runat="server" autopostback="True"
                groupname="unit" oncheckedchanged="radioButton2_CheckedChanged" text="OZ" />
            <asp:radiobutton id="radioButton3" runat="server" autopostback="True"
                groupname="unit" oncheckedchanged="radioButton3_CheckedChanged" text="g" />
        </div>

        <asp:label id="Label5" runat="server" text="内容物："></asp:label>
        <asp:dropdownlist id="DropDownList1" runat="server" autopostback="True"
            width="188px"
            onselectedindexchanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem Value="1.0">水</asp:ListItem>
            <asp:ListItem Value="1.05">化妆品</asp:ListItem>
            
            <asp:ListItem Value="1.26">药膏</asp:ListItem>
           
            <asp:ListItem Value="1.40">牙膏</asp:ListItem>
            
        </asp:dropdownlist>
        <asp:button runat="server" text="开始计算" id="btnokC" onclick="btnokC_Click" />
        <br />

        <asp:TextBox ID="TextBox5" runat="server" Height="200px" TextMode="MultiLine" Width="321px" Font-Names="等线" Font-Size="Larger"></asp:TextBox>
        <hr />
    </div>


</asp:Content>
