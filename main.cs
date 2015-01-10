using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ESIS;
using ESIS.visitors;
using ESIS.appointment;
using ESIS.rooms;

namespace ESIS
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            this.ForeColor = Color.Crimson;
            this.BackColor = Color.MintCream;
            
        }

        private void applaunch_Click(object sender, EventArgs e)
        {
            
            appointdash ad = new appointdash();
            ad.Show();
        }

        private void visitbtn_Click(object sender, EventArgs e)
        {
            
            visitor v = new visitor();
            v.Show();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void classbtn_Click(object sender, EventArgs e)
        {
            roomdash rd = new roomdash();
            rd.Show();
        }
    }
}
