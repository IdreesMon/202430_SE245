using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submit_box_Click(object sender, EventArgs e)
        {
            PersonV2 Person = new PersonV2(
               Fname_box.Text,
               Mname_box.Text,
               Lname_box.Text,
               Phone_box.Text,
               Email_box.Text,
               Streetone_box.Text,
               Streettwo_box.Text,
               Zipcode_box.Text,
               City_box.Text,
               State_box.Text,
               Date_box.Value,
               Instagram_box.Text,
               Cell_box.Text

               );
            if (Person.CatchError())
            {
                Feedback_box.Text = string.Join("\n", Person.Catch);
            }

            Feedback_box.Text = Person.GetFeedBack();
        }

        private void Fname_box_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
