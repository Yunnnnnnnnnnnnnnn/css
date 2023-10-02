using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace B11133232hw2
{
    public partial class B232 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Panel2.Visible = false;
            if (IsPostBack)
                Panel2.Visible = false;
        }

        protected void CheckBox1_CheckedChanged1(object sender, EventArgs e)
        {
            if (CheckBox1.Checked == true)
                Panel2.Visible = true;
            else
                Panel2.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int p = 100, m = 0, total = 0;
            string class1 = "", name = "", food = "";

            class1 = DropDownList1.SelectedValue;
            name = TextBox1.Text;
            food = RadioButtonList1.SelectedValue.ToString();

            for (int i = 0; i < CheckBoxList1.Items.Count; i++)
            {
                if (CheckBoxList1.Items[i].Selected)
                {
                    m += Convert.ToInt32(CheckBoxList1.Items[i].Value);
                }
            }
            total = p + m;

            Label3.Text = class1 +  name + " 訂購的是：" + food;
            Label3.ForeColor = System.Drawing.Color.Blue;
            Label4.Text = "金額：" + total.ToString();
            if(CheckBox1.Checked == true)
                Panel2.Visible=true;
        }

        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = "";

            for (int i = 0; i < CheckBoxList1.Items.Count; i++)
            {
                if (CheckBoxList1.Items[i].Selected)
                {
                    s += CheckBoxList1.Items[i].Text + ",";
                }
            }
            Label5.Text = "附餐有：" + s;
            Label5.ForeColor = System.Drawing.Color.Blue;

        }
        protected void Button2_Click1(object sender, EventArgs e)
        {
            DropDownList1.SelectedIndex = 0;

            TextBox1.Text = "";

            RadioButtonList1.SelectedIndex = 0;

            foreach (ListItem item in CheckBoxList1.Items)
            {
                item.Selected = false;
            }


            Panel2.Visible = false;

            Label5.Text = "";
            Label4.Text = "";
            Label3.Text = "";

            CheckBox1.Checked = false;
        }
    }
}