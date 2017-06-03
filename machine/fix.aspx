<%@ Page Title="" Language="C#" MasterPageFile="~/MainNav.master" AutoEventWireup="true" CodeFile="fix.aspx.cs" Inherits="machine_fix" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
   
    <style type="text/css">

.font7
	{color:windowtext;
	font-size:10.0pt;
	font-weight:400;
	font-style:normal;
	text-decoration:none;
	font-family:宋体;
	}
        .auto-style1 {
            height: 55.5pt;
            width: 80pt;
            color: windowtext;
            font-size: 11.5pt;
            font-weight: 700;
            font-style: normal;
            text-decoration: none;
            font-family: 宋体;
            text-align: center;
            vertical-align: middle;
            white-space: nowrap;
            border: .5pt solid windowtext;
            padding-left: 1px;
            padding-right: 1px;
            padding-top: 1px;
        }
        .auto-style2 {
            width: 62pt;
            color: windowtext;
            font-size: 11.5pt;
            font-weight: 700;
            font-style: normal;
            text-decoration: none;
            font-family: 宋体;
            text-align: center;
            vertical-align: middle;
            white-space: nowrap;
            border: .5pt solid windowtext;
            padding-left: 1px;
            padding-right: 1px;
            padding-top: 1px;
        }
        .auto-style3 {
            width: 360pt;
            color: windowtext;
            font-size: 11.0pt;
            font-weight: 700;
            font-style: normal;
            text-decoration: none;
            font-family: 宋体;
            text-align: center;
            vertical-align: middle;
            white-space: nowrap;
            border: .5pt solid windowtext;
            padding-left: 1px;
            padding-right: 1px;
            padding-top: 1px;
        }
        .auto-style4 {
            height: 26.25pt;
            color: windowtext;
            font-size: 11.5pt;
            font-weight: 700;
            font-style: normal;
            text-decoration: none;
            font-family: 宋体;
            text-align: center;
            vertical-align: middle;
            white-space: nowrap;
            border: .5pt solid windowtext;
            padding-left: 1px;
            padding-right: 1px;
            padding-top: 1px;
        }
        .auto-style5 {
            color: windowtext;
            font-size: 11.5pt;
            font-weight: 700;
            font-style: normal;
            text-decoration: none;
            font-family: 宋体;
            text-align: center;
            vertical-align: middle;
            white-space: nowrap;
            border: .5pt solid windowtext;
            padding-left: 1px;
            padding-right: 1px;
            padding-top: 1px;
        }
        .auto-style6 {
            height: 17.25pt;
            color: windowtext;
            font-size: 10.0pt;
            font-weight: 400;
            font-style: normal;
            text-decoration: none;
            font-family: 宋体;
            text-align: general;
            vertical-align: middle;
            white-space: nowrap;
            border: .5pt solid windowtext;
            padding-left: 1px;
            padding-right: 1px;
            padding-top: 1px;
        }
        .auto-style7 {
            color: windowtext;
            font-size: 10.0pt;
            font-weight: 400;
            font-style: normal;
            text-decoration: none;
            font-family: 宋体;
            text-align: general;
            vertical-align: middle;
            white-space: nowrap;
            border: .5pt solid windowtext;
            padding-left: 1px;
            padding-right: 1px;
            padding-top: 1px;
        }
        .auto-style8 {
            color: windowtext;
            font-size: 11.5pt;
            font-weight: 400;
            font-style: normal;
            text-decoration: none;
            font-family: 宋体;
            text-align: center;
            vertical-align: middle;
            white-space: nowrap;
            border: .5pt solid windowtext;
            padding-left: 1px;
            padding-right: 1px;
            padding-top: 1px;
        }
        .auto-style9 {
            color: red;
            font-size: 11.5pt;
            font-weight: 400;
            font-style: normal;
            text-decoration: none;
            font-family: 宋体;
            text-align: center;
            vertical-align: middle;
            white-space: nowrap;
            border: .5pt solid windowtext;
            padding-left: 1px;
            padding-right: 1px;
            padding-top: 1px;
        }
        .auto-style10 {
            color: black;
            font-size: 11.0pt;
            font-weight: 400;
            font-style: normal;
            text-decoration: none;
            font-family: 宋体;
            text-align: general;
            vertical-align: bottom;
            white-space: nowrap;
            border: .5pt solid windowtext;
            padding-left: 1px;
            padding-right: 1px;
            padding-top: 1px;
        }
        .auto-style11 {
            color: red;
            font-size: 11.5pt;
            font-weight: 400;
            font-style: normal;
            text-decoration: none;
            font-family: 楷体_GB2312, monospace;
            text-align: center;
            vertical-align: middle;
            white-space: nowrap;
            border: .5pt solid windowtext;
            padding-left: 1px;
            padding-right: 1px;
            padding-top: 1px;
        }
        .auto-style12 {
            color: red;
            font-size: 11.0pt;
            font-weight: 400;
            font-style: normal;
            text-decoration: none;
            font-family: 宋体;
            text-align: general;
            vertical-align: bottom;
            white-space: nowrap;
            border: .5pt solid windowtext;
            padding-left: 1px;
            padding-right: 1px;
            padding-top: 1px;
        }
        .auto-style13 {
            color: red;
            font-size: 11.5pt;
            font-weight: 400;
            font-style: normal;
            text-decoration: none;
            font-family: 宋体;
            text-align: general;
            vertical-align: bottom;
            white-space: nowrap;
            border: .5pt solid windowtext;
            padding-left: 1px;
            padding-right: 1px;
            padding-top: 1px;
        }
        .auto-style14 {
            color: windowtext;
            font-size: 11.5pt;
            font-weight: 400;
            font-style: normal;
            text-decoration: none;
            font-family: 宋体;
            text-align: general;
            vertical-align: bottom;
            white-space: nowrap;
            border: .5pt solid windowtext;
            padding-left: 1px;
            padding-right: 1px;
            padding-top: 1px;
        }
        .auto-style15 {
            color: red;
            font-size: 11.5pt;
            font-weight: 700;
            font-style: normal;
            text-decoration: none;
            font-family: 宋体;
            text-align: general;
            vertical-align: bottom;
            white-space: nowrap;
            border: .5pt solid windowtext;
            padding-left: 1px;
            padding-right: 1px;
            padding-top: 1px;
        }
    </style>
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="text-align:center;width:700px;margin:20px auto;">
    <table border="0" cellpadding="0" cellspacing="0" style="border-collapse:
 collapse;width:502pt" width="670">
        <colgroup>
            <col style="mso-width-source:userset;mso-width-alt:3424;width:80pt" width="107" />
            <col style="mso-width-source:userset;mso-width-alt:2656;width:62pt" width="83" />
            <col span="12" style="mso-width-source:userset;mso-width-alt:1280;
 width:30pt" width="40" />
        </colgroup>
        <tr height="39" style="mso-height-source:userset;height:29.25pt">
            <td class="auto-style1" height="74" rowspan="2" width="107">设备名称</td>
            <td class="auto-style2" rowspan="2" width="83">设备编号</td>
            <td class="auto-style3" colspan="12" width="480">计划保养时间（2017.1.1）</td>
        </tr>
        <tr height="35" style="mso-height-source:userset;height:26.25pt">
            <td class="auto-style4" height="35">1</td>
            <td class="auto-style5">2</td>
            <td class="auto-style5">3</td>
            <td class="auto-style5">4</td>
            <td class="auto-style5">5</td>
            <td class="auto-style5">6</td>
            <td class="auto-style5">7</td>
            <td class="auto-style5">8</td>
            <td class="auto-style5">9</td>
            <td class="auto-style5">10</td>
            <td class="auto-style5">11</td>
            <td class="auto-style5">12</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">挤出复合机</td>
            <td class="auto-style7">RG01-1</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style10">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">分切机</td>
            <td class="auto-style7">RG01-2</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style8">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">检品机</td>
            <td class="auto-style7">RG01-3</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">倒卷机</td>
            <td class="auto-style7">RG01-4</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">吹膜机</td>
            <td class="auto-style7">RG01-5</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">六色印刷机1</td>
            <td class="auto-style7">RG01-6</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">七色印刷机2</td>
            <td class="auto-style7">RG01-7</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">八色印刷机3</td>
            <td class="auto-style7">RG01-8</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style8">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">六色印刷机4</td>
            <td class="auto-style7">RG01-9</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">三色丝印机6</td>
            <td class="auto-style7">RG01-10</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">八色丝印机7</td>
            <td class="auto-style7">RG01-11</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">丝网印刷机5</td>
            <td class="auto-style7">RG01-12</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">卧式注塑机1</td>
            <td class="auto-style7">RG01-13</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">卧式注塑机2</td>
            <td class="auto-style7">RG01-14</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">卧式注塑机3</td>
            <td class="auto-style7">RG01-15</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">卧式注塑机4</td>
            <td class="auto-style7">RG01-16</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">卧式注塑机5</td>
            <td class="auto-style7">RG01-17</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">卧式注塑机6</td>
            <td class="auto-style7">RG01-18</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">卧式注塑机7</td>
            <td class="auto-style7">RG01-19</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">卧式注塑机8</td>
            <td class="auto-style7">RG01-20</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">卧式注塑机9</td>
            <td class="auto-style7">RG01-21</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">卧式注塑机10</td>
            <td class="auto-style7">RG01-22</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">卧式注塑机11</td>
            <td class="auto-style7">RG01-23</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style8">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">卧式注塑机12</td>
            <td class="auto-style7">RG01-24</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">卧式注塑机13</td>
            <td class="auto-style7">RG01-25</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">卧式注塑机14</td>
            <td class="auto-style7">RG01-26</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">卧式注塑机15</td>
            <td class="auto-style7">RG01-27</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">注塑机1</td>
            <td class="auto-style7">RG04-01</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">注塑机2</td>
            <td class="auto-style7">RG04-02</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">注塑机3</td>
            <td class="auto-style7">RG04-03</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style8">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">注塑机4</td>
            <td class="auto-style7">RG04-04</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">注塑机5</td>
            <td class="auto-style7">RG04-05</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">注塑机6</td>
            <td class="auto-style7">RG04-06</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">注塑机7</td>
            <td class="auto-style7">RG04-07</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">注塑机8</td>
            <td class="auto-style7">RG04-08</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">注塑机9</td>
            <td class="auto-style7">RG04-09</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">注塑机10</td>
            <td class="auto-style7">RG04-10</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">注塑机11</td>
            <td class="auto-style7">RG04-11</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">注塑机12</td>
            <td class="auto-style7">RG04-12</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">注塑机13</td>
            <td class="auto-style7">RG04-13</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style11">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style11">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">注塑机14</td>
            <td class="auto-style7">RG04-14</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">注塑机15</td>
            <td class="auto-style7">RG04-15</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">注塑机16</td>
            <td class="auto-style7">RG04-16</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style8">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">注塑机17</td>
            <td class="auto-style7">RG04-17</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">注塑机18</td>
            <td class="auto-style7">RG04-18</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">注塑机19</td>
            <td class="auto-style7">RG04-19</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">注塑机20</td>
            <td class="auto-style7">RG04-20</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">注塑机21</td>
            <td class="auto-style7">RG04-21</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">注塑机22</td>
            <td class="auto-style7">RG04-22</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">注塑机23</td>
            <td class="auto-style7">RG04-23</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">注塑机24</td>
            <td class="auto-style7">RG04-24</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">注塑机25</td>
            <td class="auto-style7">RG04-25</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">注塑机26</td>
            <td class="auto-style7">RG04-26</td>
            <td class="auto-style12">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style8">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">注塑机27</td>
            <td class="auto-style7">RG04-27</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">注塑机28</td>
            <td class="auto-style7">RG04-28</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style8">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">拧盖封膜机1#</td>
            <td class="auto-style7">RG04-29</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">拧盖封膜机2#</td>
            <td class="auto-style7">RG04-30</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">拧盖封膜机3#</td>
            <td class="auto-style7">RG04-31</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">拧盖封膜机4#</td>
            <td class="auto-style7">RG04-32</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">拧盖封膜机5#</td>
            <td class="auto-style7">RG04-33</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">拧盖封膜机6#</td>
            <td class="auto-style7">RG04-34</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">拧盖封膜机7#</td>
            <td class="auto-style7">RG04-35</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">旋盖机科雅盖8#</td>
            <td class="auto-style7">RG04-36</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">拧盖封膜机9#</td>
            <td class="auto-style7">RG04-37</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style8">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">封膜机10#</td>
            <td class="auto-style7">RG04-38</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">制管机1#</td>
            <td class="auto-style7">RG04-39</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style11">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style11">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">制管机2#</td>
            <td class="auto-style7">RG04-40</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">制管机3#</td>
            <td class="auto-style7">RG04-41</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style8">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">制管机4#</td>
            <td class="auto-style7">RG04-42</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">制管机5#</td>
            <td class="auto-style7">RG04-43</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style8">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">制管机6#</td>
            <td class="auto-style7">RG04-44</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">制管机7#</td>
            <td class="auto-style7">RG04-45</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">制管机8#</td>
            <td class="auto-style7">RG04-46</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">制管机9#</td>
            <td class="auto-style7">RG04-47</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">注塑机1</td>
            <td class="auto-style7">RG05-01</td>
            <td class="auto-style8">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style8">　</td>
            <td class="auto-style8">　</td>
            <td class="auto-style8">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style8">　</td>
            <td class="auto-style8">　</td>
            <td class="auto-style8">　</td>
            <td class="auto-style8">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style8">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">注塑机2</td>
            <td class="auto-style7">RG05-02</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">注塑机3</td>
            <td class="auto-style7">RG05-03</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style11">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">注塑机4</td>
            <td class="auto-style7">RG05-04</td>
            <td class="auto-style13">　</td>
            <td class="auto-style13">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style13">　</td>
            <td class="auto-style13">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style13">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style13">　</td>
            <td class="auto-style13">　</td>
            <td class="auto-style8">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">注塑机5</td>
            <td class="auto-style7">RG05-05</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style13">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style13">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style13">　</td>
            <td class="auto-style13">　</td>
            <td class="auto-style14">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">注塑机6</td>
            <td class="auto-style7">RG05-06</td>
            <td class="auto-style13">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style13">　</td>
            <td class="auto-style13">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style13">　</td>
            <td class="auto-style9">△</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">注塑机7</td>
            <td class="auto-style7">RG05-07</td>
            <td class="auto-style15">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style15">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style15">　</td>
            <td class="auto-style15">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style15">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style8">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">注塑机8</td>
            <td class="auto-style7">RG05-08</td>
            <td class="auto-style12">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style12">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style12">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style10">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">注塑机9</td>
            <td class="auto-style7">RG05-09</td>
            <td class="auto-style12">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style12">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">注塑机10</td>
            <td class="auto-style7">RG05-10</td>
            <td class="auto-style12">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style12">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">拧盖封膜机</td>
            <td class="auto-style7">RG05-11</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style10">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">封尾机</td>
            <td class="auto-style7">RG05-12</td>
            <td class="auto-style12">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style12">　</td>
            <td class="auto-style10">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">全自动注头机2<font class="font7">#</font></td>
            <td class="auto-style7">RG05-13-1</td>
            <td class="auto-style12">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style12">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style11">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style12">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style10">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">拧盖机连线2<font class="font7">#</font></td>
            <td class="auto-style7">RG05-13-2</td>
            <td class="auto-style12">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style12">　</td>
            <td class="auto-style10">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">全自动注头机1#</td>
            <td class="auto-style7">RG05-14-1</td>
            <td class="auto-style12">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style12">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style12">　</td>
            <td class="auto-style8">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">拧盖机连线1#</td>
            <td class="auto-style7">RG05-14-2</td>
            <td class="auto-style12">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style8">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">制管机全塑5<font class="font7">#</font></td>
            <td class="auto-style7">RG05-15</td>
            <td class="auto-style12">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style12">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style12">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style8">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">制管机全塑3<font class="font7">#</font></td>
            <td class="auto-style7">RG05-16</td>
            <td class="auto-style9">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style12">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style12">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style9">△</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">制管机全塑6#</td>
            <td class="auto-style7">RG05-17</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style9">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style12">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style10">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">制管机全塑1<font class="font7">#</font></td>
            <td class="auto-style7">RG05-18</td>
            <td class="auto-style12">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style12">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style8">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">AISA80<font class="font7">-4#</font></td>
            <td class="auto-style7">RG05-19</td>
            <td class="auto-style12">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style12">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style10">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">AISA80<font class="font7">-3#</font></td>
            <td class="auto-style7">RG05-20</td>
            <td class="auto-style12">　</td>
            <td class="auto-style11">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style12">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style10">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">AISA150-2#</td>
            <td class="auto-style7">RG05-21</td>
            <td class="auto-style12">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style12">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style12">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style10">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">AISA80<font class="font7">-1#</font></td>
            <td class="auto-style7">RG05-22</td>
            <td class="auto-style9">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style10">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">KMK全自动</td>
            <td class="auto-style7">RG06-01</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style12">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style12">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style10">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">KMK全自动</td>
            <td class="auto-style7">RG06-02</td>
            <td class="auto-style12">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style12">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style12">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style10">　</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">AISA全自动</td>
            <td class="auto-style7">RG06-03</td>
            <td class="auto-style9">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style9">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style8">〇</td>
        </tr>
        <tr height="23" style="mso-height-source:userset;height:17.25pt">
            <td class="auto-style6" height="23">AISA全自动</td>
            <td class="auto-style7">RG06-04</td>
            <td class="auto-style12">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style9">△</td>
            <td class="auto-style12">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style8">〇</td>
            <td class="auto-style12">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style12">　</td>
            <td class="auto-style9">　</td>
            <td class="auto-style10">　</td>
        </tr>
    </table>
        </div>    
       △:重点保养(润滑+更换)<br />
       〇:日常保养(检查+处理)
       
</asp:Content>

