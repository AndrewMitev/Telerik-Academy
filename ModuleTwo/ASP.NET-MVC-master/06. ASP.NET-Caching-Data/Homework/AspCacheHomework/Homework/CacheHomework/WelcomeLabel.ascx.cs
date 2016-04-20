using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CacheHomework
{
    public partial class WelcomeLabel : System.Web.UI.UserControl
    {
        private string message;

        protected void Page_Init()
        {
            if (this.Cache["message"] == null)
            {
                // simulate extraction from db.
                var data = new Dictionary<int, string>
                {
                    { 0, "some text"},
                    { 1, "another text"},
                    { 2, "random people all the way!"}
                };

                Random rand = new Random();
                int index = rand.Next(0, 3);

                this.Cache["message"] = data[index];
                return;
            }

            this.message = (string)this.Cache["message"];
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            this.CustomLabel.Text = this.message;
        }
    }
}