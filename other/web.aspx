<%@ Page Title="" Language="C#" MasterPageFile="../MainNav.master" AutoEventWireup="true" CodeFile="web.aspx.cs" Inherits="other_web" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            height: 28px;
        }
          table{
            width:80%;
            text-align:center;
            border-collapse:collapse;
            border:1px solid;
            margin-left:10%;
        }
        th,td{
            border:1px solid;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="width:80%;margin-left:10%;line-height:1.5em;">
        <table>
            <tr><th>管径</th><th>(四楼或AISA)</th><th>PSG</th><th>五楼化妆品</th><th>跟线产品</th><th>外卖片材</th><th>厚度ABL</th><th>厚度PBL</th></tr>
            <tr><td>12.7</td><td>126</td><td>-</td><td>-</td><td></td><td>129</td><td>170-200</td><td>&nbsp;</td></tr>
           <tr><td>16</td><td>160</td><td>-</td><td>-</td><td></td><td>164</td><td>200-220</td><td>&nbsp;</td></tr>
            <tr><td>19</td><td>186</td><td>-</td><td>-</td><td></td><td>192</td><td>200-220</td><td>&nbsp;</td></tr>
            <tr><td>22</td><td>142</td><td>-</td><td>148</td><td>152</td><td>144</td><td>220</td><td>275</td></tr>
            <tr><td>25</td><td>160</td><td>-</td><td>166</td><td>164</td><td>164</td><td>220</td><td>275</td></tr>
            <tr><td class="auto-style1">28</td><td class="auto-style1">180</td><td class="auto-style1">-</td><td class="auto-style1">186</td><td class="auto-style1">192</td><td class="auto-style1">182</td><td>220</td><td>275</td></tr>
            <tr><td>30</td><td>192</td><td>-</td><td>198</td><td>204</td><td>194</td><td>220-250</td><td>275</td></tr>
            <tr><td>32</td><td>206</td><td>206</td><td>210</td><td>216</td><td>206</td><td>250</td><td>300</td></tr>
            <tr><td>35</td><td>224</td><td>224</td><td>230</td><td>236</td><td>226</td><td>250</td><td>300</td></tr>
            <tr><td>38</td><td>244</td><td>244</td><td>250</td><td>256</td><td>246</td><td>250-275</td><td>300</td></tr>
            <tr><td>40</td><td>129</td><td>-</td><td></td><td>133</td><td>131</td><td>275</td><td>325</td></tr>
            <tr><td>50</td><td>-</td><td>-</td><td></td><td>164</td><td>-</td><td>300</td><td>350</td></tr>
            <tr><td>55</td><td>-</td><td>-</td><td>-</td><td>-</td><td>-</td><td>300</td><td>350</td></tr>
        </table>
    </div>
</asp:Content>

