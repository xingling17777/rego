<%@ Page Title="" Language="C#" MasterPageFile="~/MainNav.master" AutoEventWireup="true" CodeFile="Cap.aspx.cs" Inherits="Cap" %>




<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
       
       供应商: <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
        帽盖:<asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged"></asp:DropDownList>
        编号:<asp:TextBox ID="txtID" runat="server"></asp:TextBox>
       <hr />
        <div style="width:500px;margin:0 auto;">
        <table>
            <tr><td>供应商</td><td>
                <asp:Label ID="lblsup" runat="server" Text="Label"></asp:Label>
                </td><td rowspan="11"><asp:ImageButton ID="ImageButton1" runat="server" OnClick="ImageButton1_Click" Width="300px" /></td></tr>
            <tr><td>帽盖名称</td><td>
                <asp:Label ID="lblname" runat="server" Text="Label"></asp:Label>
                </td></tr>
            <tr><td>上沿外径</td><td>
                <asp:Label ID="lblupdia" runat="server" Text="Label"></asp:Label>
                </td></tr>
            <tr><td>下沿外径</td><td>
                <asp:Label ID="lbldowndia" runat="server" Text="Label"></asp:Label>
                </td></tr>
            <tr><td>帽盖高度</td><td>
                <asp:Label ID="lblheight" runat="server" Text="Label"></asp:Label>
                </td></tr>
            <tr><td>顶螺纹</td><td>
                <asp:Label ID="lbltopdia" runat="server" Text="Label"></asp:Label>
                </td></tr>
            <tr><td>底螺纹</td><td>
                <asp:Label ID="lblbotdia" runat="server" Text="Label"></asp:Label>
                </td></tr>
            <tr><td>内口径</td><td>
                <asp:Label ID="lblori" runat="server" Text="Label"></asp:Label>
                </td></tr>
             <tr><td>重量</td><td>
                <asp:Label ID="lblweight" runat="server" Text="Label"></asp:Label>
                </td></tr>
            <tr><td>颜色</td><td>
                <asp:Label ID="lblcolor" runat="server" Text="Label"></asp:Label>
                </td></tr>
            <tr><td>备注</td><td>
                <asp:Label ID="Label10" runat="server" Text="Label"></asp:Label>
                </td></tr>
           
        </table>
  </div>
   </div>
   
    </asp:Content>

