using forms_app.Models;
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
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
            instructorBindingSource.DataSource = context.Instructor.ToList();
        }

        StudiesContext context = new StudiesContext();

        private void button1_Click(object sender, EventArgs e)
        {
            var selectedInstructor = (Instructor)instructorBindingSource.Current;
            var oktatóTörlése = (from x in context.Instructor
                                 where x.InstructorSk == selectedInstructor.InstructorSk
                                 select x).FirstOrDefault();
            context.Instructor.Remove(oktatóTörlése);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            OktatóLista();
        }

        private void OktatóLista()
        {
            var oktatóLista = from x in context.Instructor
                              select x;
            instructorBindingSource.DataSource = oktatóLista.ToList();
        }

    }
}
