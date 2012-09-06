using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestProject
{
    public partial class frmMain : Form
    {

        frmFinaMain m_pFrmFinaMain;

        public frmMain()
        {
            InitializeComponent();
        }


        private void frmMain_Load(object sender, EventArgs e)
        {
            m_pFrmFinaMain = new frmFinaMain();
            m_pFrmFinaMain.Visible = false;
            m_pFrmFinaMain.TopLevel = false;
            splitContainerMain.Panel2.Controls.Add(m_pFrmFinaMain);
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFina_Click(object sender, EventArgs e)
        {
            m_pFrmFinaMain.Visible = true;
        }

    }
}
