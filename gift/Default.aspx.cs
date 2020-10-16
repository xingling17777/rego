using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//todo:默认登陆的页面，登录后显示待处理事项，比如待审批的单据
public partial class gift_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
if(Session["userName"]==null)
        {
            Response.Redirect("login.aspx");
        }
        else
        {


        }
    }
}