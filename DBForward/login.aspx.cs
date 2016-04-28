using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace DBForward {
    public partial class login : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            string userName = Request.Params["name"];
            string userPassword = Request.Params["password"];
            string sqlStr1 = "select * from Account where name=N'" + userName + "'";

            SqlAccess sa = new SqlAccess();
            DataTable dt1 = sa.ExecuteDataTable(sqlStr1);
            if(dt1.Rows.Count != 1) {
                Response.Write("<span>No such a user</span>");
                return;
            }

            string sqlStr2 = "select * from Account where name=N'" + userName + "' and password='" + userPassword + "'";
            DataTable dt2 = sa.ExecuteDataTable(sqlStr2);
            if(dt2.Rows.Count > 0) {
                Response.Write("<span>Success</span>");
            } else {
                Response.Write("<span>Not match</span>");
                return;
            }

            Session["UserName"] = userName;
        }
    }
}