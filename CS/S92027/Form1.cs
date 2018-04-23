using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;

namespace S92027 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void OnShowMessaageClick(object sender, EventArgs e) {
            XtraMessageBox.Show("Test", "DXSample");
        }

        private void OnCloseClick(object sender, EventArgs e) {
            Close();
        }
    }
}