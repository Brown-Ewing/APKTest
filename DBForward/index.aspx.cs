using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DBForward {
    public partial class index : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            //string sqlStr1 = "INSERT INTO Account (name, password, level) VALUES ('carpton', '123456', 0)";
            //string sqlStr2 = "INSERT INTO Account (name, password, level) VALUES (2, 'user1', '654321', 2)";
            //string sqlStr3 = "INSERT INTO Billboard (name, mission) VALUES ('carpton', 12)";
            //string sqlStr4 = "INSERT INTO Billboard (name, mission) VALUES ('user1', 3)";
            //string sqlStr5 = "if exists(select * from Account where A='A1' and B='B1') update t set c=100 where A='A1' and B='B1' else insert into t (A,B,C) Values('A1','B1',100)";
            //string sqlStr6 = "select row_number() over(order by mission desc) as rank,* from Billboard";
            //SqlAccess sa = new SqlAccess();
            //sa.ExecuteNonQuery(sqlStr1);
            //sa.ExecuteNonQuery(sqlStr2);
            //sa.ExecuteNonQuery(sqlStr3);
            //sa.ExecuteNonQuery(sqlStr4);
            //sa.sortByRowNumber(sqlStr6);
            //string sqlStr7 = "TRUNCATE TABLE Account";
            //string sqlStr8 = "TRUNCATE TABLE Billboard";
            //string sqlStr9 = "UPDATE Billboard SET Id = 2 WHERE Id = 1";
            //string sqlStr10 = "ALTER TABLE Account ALTER COLUMN name NVARCHAR (50) NOT NULL";
            //string sqlStr11 = "ALTER TABLE Billboard ALTER COLUMN name NVARCHAR (50) NOT NULL";
            //string sqlStr12 = "DROP TABLE Account";
            //string sqlStr13 = "DROP TABLE Billboard";
            //string sqlStr14 = "CREATE TABLE [dbo].[Account] ( [Id] INT IDENTITY (1, 1) NOT NULL, [name] NVARCHAR (50) DEFAULT ('username') NOT NULL, [password] VARCHAR (50) NULL, [picture] IMAGE NULL, [gender] CHAR (10) NULL, [level] INT DEFAULT ((0)) NULL, [class] VARCHAR (50) NULL, CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED ([name] ASC));";
            //string sqlStr15 = "CREATE TABLE [dbo].[Billboard] ( [Id] INT IDENTITY (1, 1) NOT NULL, [name] NVARCHAR (50) DEFAULT ('username') NOT NULL, [mission] INT DEFAULT ((1)) NULL, [picture] IMAGE NULL, PRIMARY KEY CLUSTERED ([name] ASC), CONSTRAINT [FK_Billboard_ToTable] FOREIGN KEY ([name]) REFERENCES [dbo].[Account] ([name]));";
            //string sqlStr16 = "DELETE FROM [表名] WHERE [字段名]>100";
            //string sqlStr17 = "ALTER TABLE Account DROP COLUMN Id";
            //SqlAccess sa = new SqlAccess();
            //sa.ExecuteNonQuery(sqlStr12);
            //sa.ExecuteNonQuery(sqlStr13);
            //sa.ExecuteNonQuery(sqlStr14);
            //sa.ExecuteNonQuery(sqlStr15);
        }
    }
}