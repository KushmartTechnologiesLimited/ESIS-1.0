using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESIS.Config
{
    public partial class FeesItem : Form
    {
        school_detailsEntities8 entity;
        public FeesItem()
        {
            InitializeComponent();
            entity = new school_detailsEntities8();
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FeeItemAdd add = new FeeItemAdd();
            this.Hide();
            add.ShowDialog();
            this.Show();
        }

        private void FeesItem_Load(object sender, EventArgs e)
        {
            feesstructureBindingSource.DataSource = entity.feesstructures;
        }

        private void feesstructureBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            entity.SaveChanges();
        }
    }
}
