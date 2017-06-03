<%@ Page Title="" Language="C#" MasterPageFile="~/MainNav.master" AutoEventWireup="true" CodeFile="video.aspx.cs" Inherits="other_video" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="videojs/css/video-js.min.css" rel="stylesheet">
<script src="video/js/video.min.js"></script>
    <script>
    videojs.options.flash.swf = "video-js.swf";
</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True">
        <asp:ListItem Value="D:\瑞高2016年会视频\瑞高晚会1.mp4">晚会花絮</asp:ListItem>
        <asp:ListItem Value="D:\瑞高2016年会视频\瑞高包装2016迎春晚会A.mp4">瑞高包装2016迎春晚会A</asp:ListItem>
    </asp:ListBox><br />
    <video id="example_video_1" class="video-js vjs-default-skin" controls preload="none" width="640" height="264"
      poster="http://video-js.zencoder.com/oceans-clip.png"
      data-setup="{}">
    <source src="D:\瑞高2016年会视频\瑞高晚会1.mp4" type='video/mp4' />
  
   <script type="text/javascript">
    var myPlayer = videojs('example_video_1');
    videojs("example_video_1").ready(function(){
        var myPlayer = this;
        myPlayer.play();
    });
</script>

</asp:Content>

