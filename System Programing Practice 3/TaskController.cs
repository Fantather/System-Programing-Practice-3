using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_Programing_Practice_3
{
    internal class TaskController
    {
        public static void SetProgressBar(SynchronizationContext ctx, ProgressBar pb, int count)
        {
            int number = 0;
            Random rnd = new Random();
            for (int i = 0; i < count; i++)
            {
                lock (ctx)
                {
                    number = rnd.Next(0, 100);
                    ctx.Post(s => pb.Value = number, null);
                    Thread.Sleep(100);
                }
            }
        }
    }
}
