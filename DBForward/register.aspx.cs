using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace DBForward {
    public partial class register : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            string userName = Request.Params["name"];
            string userPassword = Request.Params["password"];
            string sqlStr1 = "select * from Account where name=N'" + userName + "' and password='" + userPassword + "'";

            SqlAccess sa = new SqlAccess();
            DataTable dt = sa.ExecuteDataTable(sqlStr1);
            if(dt.Rows.Count > 0) {
                Response.Write("<span>Has used</span>");
                return;
            }

            string sqlStr2 = "INSERT INTO Account (name, password) VALUES (N'" + userName + "', '" + userPassword + "')";
            string sqlStr3 = "INSERT INTO Billboard (name) VALUES (N'" + userName + "')";
            int count2 = sa.ExecuteNonQuery(sqlStr2);
            int count3 = sa.ExecuteNonQuery(sqlStr3);
            if(count2 == 1 && count3 == 1) {
                Response.Write("<span>Success</span>");
            } else {
                Response.Write("<span>Error</span>");
                return;
            }

            //Session["UserName"] = userName;
        }
    }
}