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
    public partial class FeeItemAdd : Form
    {
        school_detailsEntities8 entities;
        public FeeItemAdd()
        {
            InitializeComponent();
            entities = new school_detailsEntities8();
            
        }

        private void applicabilityLabel_Click(object sender, EventArgs e)
        {
            feesstructureBindingSource.DataSource = entities.feesstructures;

        }

        private void feesstructureBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            entities.SaveChanges();
        }
    }
}
