<%@ Page Title="" Language="C#" MasterPageFile="~/MainNav.master" AutoEventWireup="true" CodeFile="cartoon.aspx.cs" Inherits="other_cartoon" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
      
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="width:80%;margin:20px 10%;text-align:left;">
        请输入软管长度(含盖):
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:button ID="btnOK" runat="server" text="提交" OnClick="btnOK_Click" />
        <br />
        <br />
        <asp:ListBox ID="ListBox1" runat="server" Height="100px" Width="365px"></asp:ListBox>
        <br />
        <hr />
        <h2>含盖管长计算参考:=管长+下表数值</h2>
      <table>
          <tr><th>管径</th><th>无盖</th><th>小旋盖</th><th>小翻盖</th><th>28光身</th><th>32光身</th><th>32直纹</th><th>35光身</th><th>红兴35翻盖</th><th>余姚35翻盖</th></tr>
          <tr><td>22</td><td>14</td><td>20</td><td>22</td><td></td><td></td><td></td><td></td><td></td><td></td></tr>
          <tr><td>25</td><td>14</td><td>20</td><td>21</td><td></td><td></td><td></td><td></td><td></td><td></td></tr>
          <tr><td>28</td><td>15</td><td>21</td><td>23</td><td>19</td><td></td><td></td><td></td><td></td><td></td></tr>
          <tr><td>30</td><td>16</td><td>22</td><td>23</td><td>19</td><td></td><td></td><td></td><td></td><td></td></tr>
          <tr><td>32</td><td>16</td><td>22</td><td>23</td><td>19</td><td>21</td><td>21</td><td></td><td></td><td></td></tr>
          <tr><td>35</td><td>17</td><td>23</td><td>24</td><td>20&nbsp;</td><td>22</td><td>21</td><td>20</td><td>24</td><td>24</td></tr>
          <tr><td>38</td><td>17</td><td>25</td><td>26</td><td>21</td><td>23</td><td>22</td><td>22</td><td>25</td><td>25</td></tr>
      </table>
    </div>
</asp:Content>

