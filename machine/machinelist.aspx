<%@ Page Title="" Language="C#" MasterPageFile="~/MainNav.master" AutoEventWireup="true" CodeFile="machinelist.aspx.cs" Inherits="machine_machinelist" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
      
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div>
        <div style="margin-left: 10%">
            排序依据:<asp:DropDownList ID="drporder" runat="server" AutoPostBack="True" OnSelectedIndexChanged="drporder_SelectedIndexChanged">
                <asp:ListItem>设备类型</asp:ListItem>
                <asp:ListItem>设备编号</asp:ListItem>
                <asp:ListItem>设备名称</asp:ListItem>
                <asp:ListItem Value="进厂年月">进厂日期</asp:ListItem>
                <asp:ListItem>安装地点</asp:ListItem>
            </asp:DropDownList><asp:DropDownList ID="orderbyasc" runat="server" AutoPostBack="True" OnSelectedIndexChanged="orderbyasc_SelectedIndexChanged">
                <asp:ListItem>升序</asp:ListItem>
                <asp:ListItem Value="desc">降序</asp:ListItem>
            </asp:DropDownList>
            <asp:Button ID="Button1" runat="server" Text="导出为文件" OnClick="Button1_Click" />
        </div>
        <asp:Table ID="Table1" runat="server"></asp:Table>

    </div>
</asp:Content>

