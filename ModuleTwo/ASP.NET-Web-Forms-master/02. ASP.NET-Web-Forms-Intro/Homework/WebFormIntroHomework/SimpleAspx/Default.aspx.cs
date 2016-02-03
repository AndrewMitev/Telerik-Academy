using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SimpleAspx
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string text = this.textBox.Text;

            if (text == null || !Regex.IsMatch(text, @"^[A-z]+$"))
            {
                label.Text = "Enter only letters!";
                return;
            }

            label.Text = string.Format("Hello, {0}, you stupid motherf@cker!", text);
        }
    }
}