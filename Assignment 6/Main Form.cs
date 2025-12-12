using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.EntityFrameworkCore;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Assignment_6
{
    public partial class frmMain : Form
    {

        private readonly IPersonDataSource _dataSource;

        public frmMain(IPersonDataSource dataSource)
        {
            _dataSource = dataSource;
            InitializeComponent();

        }



        private void personBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            personBindingSource.EndEdit();
            _dataSource.SaveChanges();
            dgvMain.Refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var current = personBindingSource.Current as Person;
            if (current == null) return;

            var confirm = MessageBox.Show($"Delete {current.Name}?", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

 
            personBindingSource.RemoveCurrent();

            _dataSource.SaveChanges();

            FilterPeople(txtSearch.Text);
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var dlg = new frmAddPeople())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    
                    var newPerson = new Person { Name = dlg.PersonName, Phone = dlg.PersonPhone };

                    
                    var list = personBindingSource.DataSource as IList<Person>;
                    if (list != null)
                    {
                        list.Add(newPerson);
                        personBindingSource.ResetBindings(false);
                    }
                    else
                    {
                       
                    }

                    _dataSource.SaveChanges();

                    
                    FilterPeople(txtSearch.Text);
                }
            }
        }

        


        private void FilterPeople(string filter)
        {
            var filtered = _dataSource.GetPeople(filter);
            
            personBindingSource.DataSource = filtered;
            personBindingSource.ResetBindings(false);

            
            if (dgvMain.Columns["Id"] != null)
                dgvMain.Columns["Id"].Visible = false;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNameBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
