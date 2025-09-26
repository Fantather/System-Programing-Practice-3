using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_Programing_Practice_3
{
    public partial class Form1 : Form
    {
        private readonly SynchronizationContext ctx;
        public Form1()
        {
            InitializeComponent(); //WindowsForms
            ctx = SynchronizationContext.Current;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Action<SynchronizationContext, ProgressBar, int> action = TaskController.SetProgressBar;

            IAsyncResult res1 = action.BeginInvoke(ctx, pb1, 100, null, null);
            IAsyncResult res2 = action.BeginInvoke(ctx, pb2, 100, null, null);
            IAsyncResult res3 = action.BeginInvoke(ctx, pb3, 100, null, null);
        }
    }
}
