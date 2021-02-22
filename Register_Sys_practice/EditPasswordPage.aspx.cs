using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Register_Sys_practice
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        string username = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["User"] != null) username = Request.Cookies["User"].Value;
        }

        protected void Btn_Editpassword_OK_Click(object sender, EventArgs e)
        {
            bool i = false;
            i |= string.IsNullOrEmpty(Tb_Editpassword_Password.Text);
            i |= string.IsNullOrEmpty(Tb_Editpassword_Confirm.Text);
            if (Tb_Editpassword_Password.Text != Tb_Editpassword_Confirm.Text)
            {
                Lab_Warning.Text = "密碼有誤!";
                return; 
            }
            if (!i)
            {
                MySQL_Function sql = new MySQL_Function();
                try
                {
                    sql.DataProcess("UPDATE MemberSys.Usertable SET Password= '" + Tb_Editpassword_Password.Text + "' WHERE Username='" + username + "';");
                }
                catch
                {
                    Lab_Warning.Text = "資料有誤!";
                    return;
                }
                HttpCookie cok = new HttpCookie("User");
                cok.Value = username;
                Response.Cookies.Add(cok);
                Response.Redirect("UserCenter.aspx", false);
                return;
            }
            Lab_Warning.Text = "各項資料請勿留白!";
        }
    }
}