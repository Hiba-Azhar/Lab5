using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowStudentInfo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        String name2, lname2, city2, add2, mob2 ;

        private void Form2_Load(object sender, EventArgs e)

        {
            name2 = Form1.name;
            lname2 = Form1.lastName;
            city2 = Form1.City;
            add2 = Form1.Address;
            mob2 = Form1.MobNo;




            lblName.Text = name2;
;           lblLname.Text = lname2;
            lblCity.Text = city2;
            lblAdd.Text = add2;
            lblMob.Text = mob2;


        }
    }
}
