using BAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class AprioriForm : Form
    {
        public AprioriForm()
        {
            InitializeComponent();
            label1.Text = string.Format("Support {0}", trackBar1.Value + 1);
        }

        //Menu Click Events
        private void menu_viewBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            ViewBook book = new ViewBook();
            book.Show();
        }

        private void menu_viewStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewStudent student = new ViewStudent();
            student.Show();
        }

        private void menu_exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You Really Want to Exit?", "Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void menu_contact_Click(object sender, EventArgs e)
        {
            this.Hide();
            ContactUs contact = new ContactUs();
            contact.Show();
        }

        private void menu_about_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutUs about = new AboutUs();
            about.Show();
        }

        private void menu_logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You Want to Logout?", "Logout", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                MainLogin login = new MainLogin();
                login.Show();
            }
        }
        //end of menu events

        string FileName = string.Empty;
        private void LoadFromFile_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Filter = "Text|*.txt";
            if (dialog.ShowDialog() != DialogResult.OK) return;
            FileName = dialog.FileName;
            trackBar1.Enabled = true;
            DoThingThread();
            RefreshButton.Enabled = true;
        }

        //private void DoThings()
        //{
        //    int Support = trackBar1.Value;
        //    flowLayoutPanel1.Controls.Clear();
        //    flowLayoutPanel1.Controls.Add(new TableUserControl(File.ReadAllLines(FileName).ToList()));
        //    Refresh();
        //    BAL.Apriori apriori = new BAL.Apriori(FileName);
        //    int k = 1;
        //    List<BAL.ItemSet> ItemSets = new List<BAL.ItemSet>();
        //    bool next;
        //    do
        //    {
        //        next = false;
        //        if (k > 1)
        //        {
        //            List<string> values = new List<string>();
        //            foreach (var item in ItemSets[ItemSets.Count - 1])
        //            {
        //                if (item.Value >= Support)
        //                    values.Add(item.Key.ToDisplay(" "));
        //            }
        //            apriori.SetDistinctValues(values);
        //            values = null;
        //            var C = apriori.GetItemSet(k, Support, Candidates: true);
        //            TableUserControl tableC = new TableUserControl(C);
        //            if (C.Count > 0)
        //            {
        //                flowLayoutPanel1.Controls.Add(tableC);
        //                flowLayoutPanel1.VerticalScroll.Value = flowLayoutPanel1.VerticalScroll.Maximum;
        //                Refresh();
        //            }
        //            //tableC.Dispose();
        //        }
        //        var L = apriori.GetItemSet(k, Support, IsFirstItemList: k == 1);
        //        TableUserControl tableL = new TableUserControl(L);
        //        if (L.Count > 0)
        //        {
        //            next = true;
        //            k++;
        //            ItemSets.Add(L);
        //            flowLayoutPanel1.Controls.Add(tableL);
        //            flowLayoutPanel1.VerticalScroll.Value = flowLayoutPanel1.VerticalScroll.Maximum;
        //            Refresh();
        //        }
        //        //tableL.Dispose();
        //    } while (next);
        //}

        private void DoThings()
        {
            int Support = 2;
            if (trackBar1.InvokeRequired)
                trackBar1.Invoke(new MethodInvoker(delegate
                {
                    Support = trackBar1.Value + 1;
                    trackBar1.Enabled = false;
                }
                ));
            if (flowLayoutPanel1.InvokeRequired)
                flowLayoutPanel1.Invoke(new MethodInvoker(delegate
                {
                    flowLayoutPanel1.Controls.Clear();
                    flowLayoutPanel1.Controls.Add(new TableUserControl(File.ReadAllLines(FileName).ToList()));
                }
                ));
            BAL.Apriori apriori = new BAL.Apriori(FileName);
            int k = 1;
            List<BAL.ItemSet> ItemSets = new List<BAL.ItemSet>();
            bool next;
            do
            {
                next = false;
                var L = apriori.GetItemSet(k, Support, IsFirstItemList: k == 1);
                if (L.Count > 0)
                {
                    List<AssociationRule> rules = new List<AssociationRule>();
                    if (k != 1)
                        rules = apriori.GetRules(L);
                    TableUserControl tableL = new TableUserControl(L, rules);
                    next = true;
                    k++;
                    ItemSets.Add(L);
                    if (flowLayoutPanel1.InvokeRequired)
                        flowLayoutPanel1.Invoke(new MethodInvoker(delegate
                        {
                            flowLayoutPanel1.Controls.Add(tableL);
                            flowLayoutPanel1.VerticalScroll.Value = flowLayoutPanel1.VerticalScroll.Maximum;
                        }
                        ));
                }
            } while (next);

            if (trackBar1.InvokeRequired)
                trackBar1.Invoke(new MethodInvoker(delegate
                {
                    trackBar1.Enabled = true;
                }
                ));
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = string.Format("Support {0}", trackBar1.Value + 1);
            DoThingThread();
        }
        List<Thread> threads = new List<Thread>();
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            AbortThread();
            DoThingThread();
        }

        private void AbortThread()
        {
            foreach (var thread in threads)
            {
                thread.Abort();
            }
            threads.Clear();
        }

        private void DoThingThread()
        {
            Thread t = new Thread(delegate()
            {
                pictureBox1.Invoke(new MethodInvoker(delegate
                {
                    pictureBox1.Show();
                }));
                DoThings();
                pictureBox1.Invoke(new MethodInvoker(delegate
                {
                    pictureBox1.Hide();
                }));
            }) { Name = "DoThings" };
            threads.Add(t);
            t.Start();
        }

        private void AprioriForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            AbortThread();
        }

        private void AprioriForm_Load(object sender, EventArgs e)
        {
            menu_user.Text = global.user;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            DataAnalysis da = new DataAnalysis();
            da.Show();
        }

    }
}
