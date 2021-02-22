using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Register_Sys_practice
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        MySQL_Function sql = new MySQL_Function();
        string username = "";
        List<List<string>> detail;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["User"] != null) username = Request.Cookies["User"].Value;
            Lab_Center_Title.Text = "Wellcome! " + username;
            try
            {
                detail = sql.Select("SELECT Username, Realname, Birthday, Email, Buildday, Authority FROM MemberSys.Usertable WHERE Username = '" + username + "';");
            }
            catch
            {
                return;
            }
            if (detail[0][5] != "3")
            {
                Lab_Center_Username.Text += detail[0][0];
                Lab_Center_Realname.Text += detail[0][1];
                Lab_Center_Birthday.Text += detail[0][2];
                Lab_Center_Email.Text += detail[0][3];
                Lab_Center_Buildday.Text += detail[0][4];
            }else
            {
                Lab_Center_Username.Visible = false;
                Lab_Center_Realname.Visible = false;
                Lab_Center_Birthday.Visible = false;
                Lab_Center_Email.Visible = false;
                Lab_Center_Buildday.Visible = false;
                Btn_Center_Edit.Visible = false;
                Btn_Center_Edit.Enabled = false;
            }
            if (detail[0][5] == "1")
            {
                Btn_Center_Edit.Visible = false;
                Btn_Center_Edit.Enabled = false;
            }
            switch (detail[0][5])
            {
                case "1":
                    Lab_Center_Authority.Text += "一般會員";
                    break;
                case "2":
                    Lab_Center_Authority.Text += "VIP會員";
                    break;
                case "3":
                    Lab_Center_Authority.Text += "管理者";
                    break;
                default:
                    Lab_Center_Authority.Text += "一般會員";
                    break;
            }

        }

        protected void Btn_Center_Logout_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginPage.aspx", false);
        }

        protected void Btn_Center_Edit_Click(object sender, EventArgs e)
        {
            HttpCookie cok = new HttpCookie("User");
            cok.Value = detail[0][0];
            Response.Cookies.Add(cok);
            Response.Redirect("EditPage.aspx", false);
        }

        protected void Btn_Center_Editpassword_Click(object sender, EventArgs e)
        {
            HttpCookie cok = new HttpCookie("User");
            cok.Value = detail[0][0];
            Response.Cookies.Add(cok);
            Response.Redirect("EditPasswordPage.aspx", false);
        }

        protected void btn_Center_Authoritytable_Click(object sender, EventArgs e)
        {
            HttpCookie cok = new HttpCookie("User");
            cok.Value = detail[0][0];
            Response.Cookies.Add(cok);
            Response.Redirect("AuthorityTable.aspx", false);
        }
    }
}