<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="wiki_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Wiki首页</title>
    
    <style type="text/css">
        div{
            text-align:center;
        }
       table {
                         width:100%;
            border-collapse: collapse;
            margin:10px 0;
        }

            table tr td {
                padding: 5px;
                border-bottom: 1px solid black;
                text-align: center;
                word-break: break-all;
                word-wrap: break-word;
            }

    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="Button1" runat="server" Text="新建文件夹……" OnClick="Button1_Click" /><asp:Button ID="Button2" runat="server" Text="新建页面……" OnClick="Button2_Click" />
        <hr />
        <asp:Table ID="Table1" runat="server"></asp:Table>
      
    </div>
    </form>
</body>
</html>
