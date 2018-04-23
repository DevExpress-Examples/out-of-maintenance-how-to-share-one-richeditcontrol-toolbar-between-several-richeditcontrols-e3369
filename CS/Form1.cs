using System;
using System.Windows.Forms;
using DevExpress.XtraRichEdit;

namespace RichEditTwoControlsOneToolbar {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void richEditControl_Enter(object sender, EventArgs e) {
            RichEditControl richEditControl = (RichEditControl)sender;
            richEditBarController1.RichEditControl = richEditControl;
        }
    }
}