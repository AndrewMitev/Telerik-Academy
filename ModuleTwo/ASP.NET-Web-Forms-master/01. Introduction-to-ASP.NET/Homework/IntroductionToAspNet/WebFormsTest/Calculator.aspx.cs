using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsTest
{
    public partial class Calculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var resultSum = decimal.Parse(this.firstNumber.Text) + decimal.Parse(this.secondNumber.Text);
            this.result.Text = resultSum.ToString();
        }
    }
}