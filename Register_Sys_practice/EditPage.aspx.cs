using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Register_Sys_practice
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        string username = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["User"] != null) username = Request.Cookies["User"].Value;
        }

        protected void Btn_Edit_OK_Click(object sender, EventArgs e)
        {
            bool i = false;
            i |= string.IsNullOrEmpty(Tb_Edit_Realname.Text);
            i |= string.IsNullOrEmpty(Tb_Edit_Birthday.Text);
            i |= string.IsNullOrEmpty(Tb_Edit_Email.Text);
            if (!i)
            {                
                MySQL_Function sql = new MySQL_Function();
                try
                {
                    sql.DataProcess("UPDATE MemberSys.Usertable SET Realname= '" + Tb_Edit_Realname.Text + "', Birthday= '" + Tb_Edit_Birthday.Text + "' , Email= '" + Tb_Edit_Email.Text + "' WHERE Username='" + username + "';");
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