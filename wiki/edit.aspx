<%@ Page Language="C#" AutoEventWireup="true" validateRequest="false"  CodeFile="edit.aspx.cs" Inherits="wiki_edit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>新建页面</title>
    <link rel="stylesheet" href="/kindeditor/themes/default/default.css" />
	<link rel="stylesheet" href="/kindeditor/plugins/code/prettify.css" />
	<script charset="utf-8" src="/kindeditor/kindeditor.js"></script>
	<script charset="utf-8" src="/kindeditor/lang/zh_CN.js"></script>
	<script charset="utf-8" src="/kindeditor/plugins/code/prettify.js"></script>
	<script>
		KindEditor.ready(function(K) {
			var editor1 = K.create('#content1', {
			    cssPath: '/kindeditor/plugins/code/prettify.css',
			    uploadJson: '/kindeditor/asp.net/upload_json.ashx',
			    fileManagerJson: '/kindeditor/asp.net/file_manager_json.ashx',
				allowFileManager : true,
				afterCreate : function() {
					var self = this;
					K.ctrl(document, 13, function() {
						self.sync();
						K('form[name=form1]')[0].submit();
					});
					K.ctrl(self.edit.doc, 13, function() {
						self.sync();
						K('form[name=form1]')[0].submit();
					});
					
				}});
			prettyPrint();
		    
			
		});
	</script>
    <link rel="stylesheet" type="text/css" href="../MainStyle.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h3 style="display:inline;">页面标题：</h3><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
     <textarea id="content1" cols="100" rows="8" style="width:100%;height:200px;visibility:hidden;" runat="server"></textarea>
        <br />
        <asp:Button ID="Button1" runat="server" Text="提交内容" OnClick="Button1_Click" /> (提交快捷键: Ctrl + Enter)
    </div>
    </form>
</body>
</html>
