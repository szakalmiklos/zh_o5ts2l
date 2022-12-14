using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms_app
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            Oktatólista();
        }

        Models.StudiesContext context = new Models.StudiesContext();


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Oktatólista();
        }

        private void Oktatólista()
        {
            var oktatók = from x in context.Instructor
                          where x.Name.StartsWith(textBox1.Text)
                          select x;
            listBox1.DisplayMember = "Name";
            listBox1.DataSource = oktatók.ToList();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Models.Instructor instructor = (Models.Instructor)listBox1.SelectedItem;
            var órák = from x in context.Lesson
                       where x.InstructorFk == instructor.InstructorSk
                       select new Órák
                       {
                           Kurzus = x.CourseFkNavigation.Name,
                           Nap = x.DayFkNavigation.Name,
                           Sáv = x.TimeFkNavigation.Name,
                           Terem = x.RoomFkNavigation.Name
                       };
            órákBindingSource.DataSource = órák.ToList();
        }
    }
}
