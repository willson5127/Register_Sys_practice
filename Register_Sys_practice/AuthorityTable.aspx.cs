using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Register_Sys_practice
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        MySQL_Function sql = new MySQL_Function();
        string username = "";
        List<List<string>> detial;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["User"] != null) username = Request.Cookies["User"].Value;

            detial = sql.Select("SELECT Username, Authority FROM MemberSys.Usertable;");

            for(int i = 0; i < detial.Count; i++)
            {
                TableRow row = new TableRow();
                for (int j = 0; j < detial[i].Count; j++)
                {
                    TableCell cell = new TableCell();
                    Button button = new Button();
                    if (j == 0)
                    {                        
                        cell.Text = detial[i][j];
                        row.Cells.Add(cell);
                    }
                    else
                    {
                        button.Click += new EventHandler(button_Click);
                        button.Text = detial[i][j];
                        button.TabIndex = Convert.ToInt16(sql.Select("SELECT User_ID FROM MemberSys.Usertable WHERE Username = '" + detial[i][j-1] + "';")[0][0]);
                        cell.Controls.Add(button);
                        row.Cells.Add(cell);
                    }
                }
                table_Authority_Table.Rows.Add(row);                
            }

            //TableRow row = new TableRow();
            //TableCell cell = new TableCell();
            //cell.Text = "NO1";
            //row.Cells.Add(cell);
            //table_Authority_Table.Rows.Add(row);
        }
        protected void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            HttpCookie cok = new HttpCookie("root");
            cok.Value = sql.Select("SELECT Username FROM MemberSys.Usertable WHERE User_ID = " + btn.TabIndex + ";")[0][0];
            Response.Cookies.Add(cok);
            HttpCookie cok2 = new HttpCookie("User");
            cok2.Value = username;
            Response.Cookies.Add(cok2);
            Response.Redirect("EditAuthority.aspx", false);
        }

        protected void btn_Authority_Goback_Click(object sender, EventArgs e)
        {
            HttpCookie cok = new HttpCookie("User");
            cok.Value = username;
            Response.Cookies.Add(cok);
            Response.Redirect("UserCenter.aspx", false);
        }
    }

    
}