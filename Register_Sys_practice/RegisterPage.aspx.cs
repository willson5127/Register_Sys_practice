using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Register_Sys_practice
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        New_Member member = new New_Member();
        protected void Page_Load(object sender, EventArgs e)
        {
            Lab_Warning.Text = "";
        }

        protected void Btn_Register_Accept_Click(object sender, EventArgs e)
        {
            bool i = false;
            i |= string.IsNullOrEmpty(Tb_Register_Username.Text);
            i |= string.IsNullOrEmpty(Tb_Register_Password.Text);
            i |= string.IsNullOrEmpty(Tb_Register_Realname.Text);
            i |= string.IsNullOrEmpty(Tb_Register_Birthday.Text);
            i |= string.IsNullOrEmpty(Tb_Register_Email.Text);
            if (!i)
            {
                New_Member nm = new New_Member();
                nm.username = Tb_Register_Username.Text;
                nm.password = Tb_Register_Password.Text;
                nm.realname = Tb_Register_Realname.Text;
                nm.birthday = Tb_Register_Birthday.Text;
                nm.e_mail = Tb_Register_Email.Text;

                MySQL_Function sql = new MySQL_Function();
                string s = "success";
                try
                {
                    sql.DataProcess("INSERT INTO MemberSys.Usertable VALUES" +
                        "(0, '" + nm.username + "', '" + nm.password + "', '" + nm.realname + "', '" + nm.e_mail + "', '" + nm.birthday + "', '" + DateTime.Now + "', '1');");
                }
                catch
                {
                    Lab_Warning.Text = "資料有誤或帳號重複!";
                    return;
                }
                Response.Redirect("LoginPage.aspx?result=" + s, false);
                return;
            }
            Lab_Warning.Text = "各項資料請勿留白!";
            
        }
    }
}