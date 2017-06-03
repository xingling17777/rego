<%@ Page Title="设备维修解决方案" Language="C#" MasterPageFile="~/MainNav.master" AutoEventWireup="true" CodeFile="shebeiweixiu.aspx.cs" Inherits="machine_shebeiweixiu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <style type="text/css">
     
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
    设备名称:<asp:label runat="server" text="" ID="lblname"></asp:label><br />
    故障描述:<asp:textbox runat="server" ID="txtdescription" Height="120px" Width="520px"></asp:textbox><br />
    报修日期:<asp:textbox runat="server" ID="rpDate"></asp:textbox><br />
    联系方式:<asp:textbox runat="server" ID="Condate"></asp:textbox><br />
    <hr />
    原因分析:<asp:textbox runat="server" ID="txtRes" Height="120px" Width="520px"></asp:textbox><br /><br />
    解决方案:<asp:textbox runat="server" ID="txtSolution" Height="120px" Width="520px"></asp:textbox><br />
        维修人员:<asp:textbox runat="server" ID="txtDuty"></asp:textbox><br />
        维修日期:<asp:textbox runat="server" ID="fixDate" ToolTip="不填则系统自动使用当天日期"></asp:textbox><br />
        <asp:button id="btnOK" runat="server" text="提交" onclick="btnOK_Click" />
     </div>
</asp:Content>

