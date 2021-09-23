using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Record_R
{
    public partial class frmR : Form
    {
        private Form actForm = null;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparm);

        public frmR()
        {
            InitializeComponent();
        }
        
        private void showPelSub(Panel subPel)
        {
            if (subPel.Visible)
            {
                subPel.Visible = false;
            }
            else
            {
                hidePelSub();
                subPel.Visible = true;
            }
        }

        private void hidePelSub()
        {
            pelDocSub.Visible = false;
            pelIgSub.Visible = false;
            // ... other pelSub
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            showPelSub(pelDocSub);
        }

        private void openFromSub(Form formSub)
        {
            if (actForm != null)
                actForm.Close();
            actForm = formSub;
            actForm.TopLevel = false;
            actForm.FormBorderStyle = FormBorderStyle.None;
            actForm.Dock = DockStyle.Fill;
            actPel.Controls.Add(actForm);
            actPel.Tag = actForm;
            actForm.BringToFront();
            actForm.Show();
        }

        private void btnDocCreate_Click(object sender, EventArgs e)
        {
            openFromSub(new Form_Doc_Create());
            lbPos.Text = "Document  >>  Create";
        }

        private void btnDocSearch_Click(object sender, EventArgs e)
        {
            openFromSub(new Form_Doc_Search());
            lbPos.Text = "Document  >>  Search";
        }

        private void pbCanel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbBig_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            pbBig.Visible = false;
            pbNor.Visible = true;
        }

        private void pbNor_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            pbBig.Visible = true;
            pbNor.Visible = false;
        }

        private void pbSmall_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnIg_Click(object sender, EventArgs e)
        {
            showPelSub(pelIgSub);
        }

        private void btnIgCreate_Click(object sender, EventArgs e)
        {
            openFromSub(new Form_IG_Create());
            lbPos.Text = "IG  >>  Create";
        }

        private void btnIgSearch_Click(object sender, EventArgs e)
        {
            openFromSub(new Form_IG_Search());
            lbPos.Text = "IG  >>  Search";
        }
    }
}
