using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_6
{
    public partial class frmAddPeople : Form
    {
        public frmAddPeople()
        {
            InitializeComponent();
        }

        public string PersonName
        {
            get => txtAddName.Text;
            set => txtAddName.Text = value;
        }

        public string PersonPhone
        {
            get => txtAddPhone.Text;
            set => txtAddPhone.Text = value;
        }



        private void frmAddPeople_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            // Optional: validate
            if (string.IsNullOrWhiteSpace(PersonName))
            {
                MessageBox.Show("Name required");
                this.DialogResult = DialogResult.None; // keep dialog open
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}