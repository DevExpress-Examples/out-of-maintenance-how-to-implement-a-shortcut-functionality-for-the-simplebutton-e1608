using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using System;
using System.Windows.Forms;

namespace DXSample {
    public class MySimpleButton : SimpleButton {
        public MySimpleButton() : base() { }

        private BarManager manager;
        public BarManager Manager {
            get { return manager; }
            set { manager = value; }
        }

        private Keys shortcut;
        public Keys Shortcut {
            get { return shortcut; }
            set { shortcut = value; }
        }

        protected override void OnHandleCreated(EventArgs e) {
            base.OnHandleCreated(e);
            if (manager == null || shortcut == Keys.None) return;
            int item = manager.Items.Add(new BarButtonItem(manager, string.Concat("bbi_", Name), -1, new BarShortcut(Shortcut)));
            manager.Items[item].ItemClick += new ItemClickEventHandler(OnBarButtonItemItemClick);
        }

        private void OnBarButtonItemItemClick(object sender, ItemClickEventArgs e) {
            this.PerformClick();
        }
    }
}