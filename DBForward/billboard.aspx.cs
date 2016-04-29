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
            string userName = Request.Params["name"];
            string mission = Request.Params["mission"];
            if(string.IsNullOrEmpty(mission)) {
                this.getBillboard(userName);
            } else {
                this.passAMission(userName, mission);
            }
        }

        void passAMission(string userName, string mission) {
            string sqlStr = "UPDATE Billboard SET mission = " + mission + " WHERE name=N'" + userName + "'";
            SqlAccess sa = new SqlAccess();
            sa.ExecuteNonQuery(sqlStr);
        }

        /// <summary>
        /// 返回包含自己在内的总共11个数据(自己+前10名)，即：
        /// 排名+用户名+关卡
        /// </summary>
        /// <param name="userName"></param>
        void getBillboard(string userName) {
            //List<string> results = new List<string>();
            String results = "";
            string sqlStr1 = "select row_number() over(order by mission desc) as rank,* from Billboard";
            //string sqlStr2 = "select top 2 * from Billboard order by mission desc";
            SqlAccess sa = new SqlAccess();
            DataTable dt = sa.sortByRowNumber(sqlStr1);
            DataRowCollection drc = dt.Rows;

            int len = drc.Count;
            bool findUserRank = false;
            //string userName = (string)Session["UserName"];
            //string test1 = "", test2 = "";
            for(int i = 0; i < len; i++) {
                if(i < 10) {
                    results = results + (i + 1) + "," + (string)drc[i]["name"] + "," + drc[i]["mission"].ToString() + ",";
                    //test1 = results;
                } else if(findUserRank) {
                    break;
                }

                if(!findUserRank) {
                    string name = (string)drc[i]["name"];
                    //Response.Write(" AAA " + name + " BBB " + userName);
                    if(name.Equals(userName)) {
                        //Response.Write("CCC");
                        //results.Insert(0, (string)drc[i]["rank"] + ",");
                        //results.Insert(0, results + userName + ",");
                        results = drc[i]["rank"].ToString() + "," + userName + "," + drc[i]["mission"].ToString() + "," + results;
                        //test2 = results + "DDD";
                        findUserRank = true;
                    }
                }
            }
            Response.Write("<span>" + results + "</span>");
        }
    }
}