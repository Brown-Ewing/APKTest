using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DBForward {
    public partial class login : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            string sqlStr1 = "select row_number() over(order by mission desc) as rank,* from Billboard";
            SqlAccess sa = new SqlAccess();
            sa.sortByRowNumber(sqlStr1);
        }
    }
}