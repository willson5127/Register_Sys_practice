using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Register_Sys_practice
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        MySQL_Function sql = new MySQL_Function();
        string username = "";
        string root = "";
        int i = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["User"] != null) username = Request.Cookies["User"].Value;
            if (Request.Cookies["root"] != null) root = Request.Cookies["root"].Value;
            Lab_Authroity_Username.Text += root;
            //rbl_Edit_Authority.Items[Convert.ToInt32(sql.Select("SELECT Authority FROM MemberSys.Usertable WHERE Username = '" + root + "';")[0][0])-1].Selected = true;
        }

        protected void Btn_Edit_OK_Click(object sender, EventArgs e)
        {
            sql.DataProcess("UPDATE MemberSys.Usertable SET Authority= '" + i + "' WHERE Username='" + root + "';");
            HttpCookie cok2 = new HttpCookie("User");
            cok2.Value = username;
            Response.Cookies.Add(cok2);
            Response.Redirect("AuthorityTable.aspx",false);
            sql.close();
        }

        protected void rbl_Edit_Authority_SelectedIndexChanged(object sender, EventArgs e)
        {
            i = Convert.ToInt32(rbl_Edit_Authority.SelectedItem.Value);
        }
    }
}