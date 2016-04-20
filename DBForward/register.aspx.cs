using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DBForward {
    public partial class register : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            string sqlStr1 = "INSERT INTO Account (Id, name, password, level) VALUES (1, 'carpton', '123456', 0)";
            string sqlStr2 = "INSERT INTO Account (Id, name, password, level) VALUES (2, 'user1', '654321', 2)";
            string sqlStr3 = "INSERT INTO Billboard (Id, name, mission) VALUES (1, 'carpton', 12)";
            string sqlStr4 = "INSERT INTO Billboard (Id, name, mission) VALUES (2, 'user1', 3)";
            SqlAccess sa = new SqlAccess();
            sa.ExecuteNonQuery(sqlStr1);
            sa.ExecuteNonQuery(sqlStr2);
            sa.ExecuteNonQuery(sqlStr3);
            sa.ExecuteNonQuery(sqlStr4);
        }
    }
}