<%@ Page Title="" Language="C#" MasterPageFile="./MainNav.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        li {
            list-style-type: none;
        }

        h3 {
            background-color: green;
            color: white;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div style="text-indent: 2em; margin-top: 20px; text-align: left;">
        <h2 style="text-align: center;">更新历史</h2>
          <h3>2017年4月24日:</h3>
        <ul>
            <li>1.完善日志;</li>            
        </ul>
        <h3>2017年4月15日:</h3>
        <ul>
            <li>1.增加日志;</li>            
        </ul>
        <h3>2017年3月7日:</h3>
        <ul>
            <li>1.修正软管容量核算页面;</li>
            <li>2.更新设备保养计划;</li>
        </ul>
        <h3>2016年12月17日:</h3>
        <ul>
            <li>1.增加库存导出为Excel功能;</li>
        </ul>
        <h3>2016年11月26日:</h3>
        <ul>
            <li>1.修改用户注册及登录逻辑;</li>
            <li>2.增加权限管理;</li>
            <li>3.增加报价清单方面功能;</li>

        </ul>
        <h3>2016年11月20日:</h3>
        <ul>
            <li>1.修正技术部物资编码生成及使用逻辑;</li>
            <li>2.增加查看产品详细信息功能;</li>

        </ul>
        <h3>2016年11月19日:</h3>
        <ul>
            <li>1.登录页面增加登录成功提示并会跳转到登录前页面;</li>
            <li>2.设备管理下的维修查询页面增加故障处理接口;</li>
            <li>3.修正设备管理下的故障报修页面问题;</li>
        </ul>

        <h3>2016年11月15日:</h3>
        <ul>
            <li>1.配件库存查询时筛选条件增加所有仓库选项;</li>
            <li>2.修改配件库存查询时筛选条件的筛选逻辑;</li>
            <li>3.库存查询增加最低库存项;</li>
            <li>4.增加更新内容历史记录;</li>
        </ul>

    </div>
</asp:Content>

