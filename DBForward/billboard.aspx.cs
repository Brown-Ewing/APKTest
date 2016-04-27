using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace DBForward {
    public partial class billboard : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            //返回包含自己在内的总共11个数据(自己+前10名)
            List<string> results = new List<string>();
            string sqlStr1 = "select row_number() over(order by mission desc) as rank,* from Billboard";
            //string sqlStr2 = "select top 2 * from Billboard order by mission desc";
            SqlAccess sa = new SqlAccess();
            DataTable dt = sa.sortByRowNumber(sqlStr1);
            DataRowCollection drc = dt.Rows;

            int len = drc.Count;
            bool findUserRank = false;
            string userName = (string)Session["UserName"];
            for(int i = 0; i < len; i++) {
                if(i < 10) {
                    results.Add((string)drc[i]["name"]);
                    results.Add((i + 1).ToString());
                } else if(findUserRank){
                    break;
                }

                if(!findUserRank) {
                    string name = (string)drc[i]["name"];
                    if(name == userName) {
                        results.Insert(0, (string)drc[i]["rank"]);
                        results.Insert(0, userName);
                        findUserRank = true;
                    }
                }
            }
            Response.Write(results);
        }
    }
}