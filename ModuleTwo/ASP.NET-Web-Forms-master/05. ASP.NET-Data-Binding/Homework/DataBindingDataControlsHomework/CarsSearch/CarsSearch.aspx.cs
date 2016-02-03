namespace CarsSearch
{
    using System;
    using Models;
    using System.Collections.Generic;
    using System.Web.UI.WebControls;

    public partial class CarsSearch : System.Web.UI.Page
    {
        private Producer[] producers = new Producer[] {
                new Producer("Bmw", new List<Model>() { new Model("M3"), new Model("318"), new Model("i7")}),
                new Producer("Audi", new List<Model>() { new Model("A3"), new Model("A4"), new Model("TT")})
        };
        protected void Page_Load(object sender, EventArgs e)
        {
            this.producersDropDown.DataSource = producers;
            this.producersDropDown.DataBind();
        }

        protected void UpdateModelsList(object sender, EventArgs e)
        {
            var models = this.producers[this.producersDropDown.SelectedIndex].Models;
            this.modelsDropDown.DataSource = models;
            this.modelsDropDown.DataBind();
        }

        protected void DisplayInfo(object sender, EventArgs e)
        {
            var label = new Literal();
            label.Text = this.producersDropDown.SelectedItem.Text;
            label.Text += " " + this.modelsDropDown.SelectedItem.Text + "<br />";
            label.Text += "Engine:";
            label.Text += this.radioBoxList.SelectedItem.Text + "<br />";
            label.Text += "Extras:" + "<br />";

            foreach (var item in this.checkBoxList.Items)
            {
                label.Text += " " + item;
            }

            this.Controls.Add(label);
        }
    }
}