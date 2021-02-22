using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Register_Sys_practice
{
    public partial class LoginPage : System.Web.UI.Page
    {
        MySQL_Function sql = new MySQL_Function();
        protected void Page_Load(object sender, EventArgs e)
        {
//            CREATE TABLE IF NOT EXISTS `MemberSys`.`Usertable` (
//                          `User_ID` INT NOT NULL auto_increment,
//                          `Username` VARCHAR(45) NOT NULL UNIQUE,
//                          `Password` VARCHAR(45) NOT NULL,
//                          `Realname` VARCHAR(45) NOT NULL,
//                          `Birthday` VARCHAR(45) NOT NULL,
//                          `Email` VARCHAR(45) NOT NULL,
//                          `Buildday` VARCHAR(45) NOT NULL,
//                          `Authority` INT NOT NULL,
//                          PRIMARY KEY(`User_ID`))
//                          ENGINE = InnoDB;
        }

        protected void Btn_Login_Click(object sender, EventArgs e)
        {
            bool i = false;
            i |= string.IsNullOrEmpty(Tb_Login_Username.Text);
            i |= string.IsNullOrEmpty(Tb_Login_Password.Text);
            if (!i)
            {
                List<List<string>> data = sql.Select("SELECT Username, Password FROM MemberSys.Usertable WHERE Username = '" + Tb_Login_Username.Text + "';");
                if (data.Count == 0)
                {
                    Lab_Warning.Text = "帳號錯誤!";
                    return;
                }
                if (data[0][1] != Tb_Login_Password.Text)
                {
                    Lab_Warning.Text = "密碼錯誤!";
                    return;
                }
                HttpCookie cok = new HttpCookie("User");
                cok.Value = Tb_Login_Username.Text;
                Response.Cookies.Add(cok);
                Response.Redirect("UserCenter.aspx", false);
                return;
            }
            Lab_Warning.Text = "各項資料請勿留白!";
        }

        protected void Btn_Register_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegisterPage.aspx", false);
        }

        
    }
}