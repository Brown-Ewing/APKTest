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
            string sqlStr1 = "select * from Account where name='" + userName + "' and password='" + userPassword + "'";

            SqlAccess sa = new SqlAccess();
            DataTable dt = sa.ExecuteDataTable(sqlStr1);
            if(dt.Rows.Count > 0) {
                Response.Write("Success!");
            } else {
                Response.Write("No such a user!");
                return;
            }

            Session["UserName"] = userName;
        }
    }
}