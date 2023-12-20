// 1 st cs logic 
            String name, rn, pwd, gd, hb, dob;
            name = Server.UrlEncode(Name.Text);
            rn = Server.UrlEncode(Rno.Text);
            pwd = Server.UrlEncode(Pwd.Text);
            gd = Server.UrlEncode(Gd.Text);
            hb = Server.UrlEncode(Hb.Text);
            dob = Server.UrlEncode(Dob.SelectedDate.Date.ToString());
            String Url = "Read.aspx?" + "&nn=" + name + "&rr=" + rn
                 + "&pd=" + pwd
            + "&gg=" + gd + "&hh=" + hb + "&dd=" + dob;
            Response.Redirect(Url);
// 2nd  cs logic 

            String name = Server.UrlDecode(Request.QueryString["nn"]);
            String rno = Server.UrlDecode(Request.QueryString["rr"]);
            String pwd = Server.UrlDecode(Request.QueryString["pd"]);
            String gd = Server.UrlDecode(Request.QueryString["gg"]);
            String hb = Server.UrlDecode(Request.QueryString["hh"]);
            String dob = Server.UrlDecode(Request.QueryString["dd"]);
            Label1.Text = "User Name :" + name;
            Label2.Text = "User RollNo. :" + rno;
            Label3.Text = "User Password :" + pwd;
            Label4.Text = "User Gender :" + gd;
            Label5.Text = "User Hobbies :" + hb;
            Label6.Text = "User DOB :" + dob;