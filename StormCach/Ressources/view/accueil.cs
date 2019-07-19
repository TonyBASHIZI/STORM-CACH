using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using StormCach.Ressources;
using StormCach.InerfacesForms;

namespace StormCach.Ressources.view
{
    public partial class accueil : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        

        public accueil()
        {
            InitializeComponent();
        }
        
        void barButtonNavigation_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int barItemIndex = barSubItemNavigation.ItemLinks.IndexOf(e.Link);
            navBarControl.ActiveGroup = navBarControl.Groups[barItemIndex];
        }

        private void accueil_Load(object sender, EventArgs e)
        {
            page1 ac = new page1();
            ac.MdiParent = this;
            ac.Show();

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            foreach (Form a in MdiChildren)
            {
                a.Close();
            }
            nouvelAgent ac = new nouvelAgent();
            ac.MdiParent = this;
            ac.Show();
            //nouvelAgent ag = new nouvelAgent();
            //ag.ShowDialog();


        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form a in MdiChildren)
            {
                a.Close();
            }
            interfaceClient ac = new interfaceClient();
            ac.MdiParent = this;
            ac.Show();
            //nouvelAgent ag = new nouvelAgent();
            //ag.ShowDialog();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form a in MdiChildren)
            {
                a.Close();
            }
            interfaceBareme ac = new interfaceBareme();
            ac.MdiParent = this;
            ac.Show();
            //nouvelAgent ag = new nouvelAgent();
            //ag.ShowDialog();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form a in MdiChildren)
            {
                a.Close();
            }
            interfaceAgent ac = new interfaceAgent();
            ac.MdiParent = this;
            ac.Show();
            //nouvelAgent ag = new nouvelAgent();
            //ag.ShowDialog();

        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form a in MdiChildren)
            {
                a.Close();
            }
            interfaceBusiness ac = new interfaceBusiness();
            ac.MdiParent = this;
            ac.Show();
            //nouvelAgent ag = new nouvelAgent();
            //ag.ShowDialog();
        }
    }
}