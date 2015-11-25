using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LuchthavenLibrary;

namespace HerhalingsOefeningJarrikVanCampLuchthaven
{
    public partial class UserDataControl : UserControl
    {
        public UserDataControl()
        {
            InitializeComponent();
            GenderUser = Gender.Male;
        }

        public String Firstname { get; set; }
        public String Lastname { get; set; }
        public DateTime Birthdate { get; set; }
        public Gender GenderUser { get; set; }

        private void txtFirstname_TextChanged(object sender, EventArgs e)
        {
            Firstname = txtFirstname.Text;
        }

        private void txtLastname_TextChanged(object sender, EventArgs e)
        {
            Lastname = txtLastname.Text;
        }

        private void dtBirthdate_ValueChanged(object sender, EventArgs e)
        {
            Birthdate = dtBirthdate.Value;
        }

        private void rbMaleGender_CheckedChanged(object sender, EventArgs e)
        {         
            if(rbMaleGender.Checked == true)
            {
                GenderUser = Gender.Male;
            }
            else
            {
                GenderUser = Gender.Female;
            }
        }
    }
}
