using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lohotron
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public class Lottery
    {
        public int[] ChPlayer = new int[5];
        public int[] ChRandom = new int[5];
        public int[] Compare = new int[5];
        List<int> Nums = new List<int>();
        List<int> Tickets = new List<int>();
        public int win = 0;
        private string result;
        public string Result { get => result; set => result = value; }

        public void Action()
        {
            int a = 1;
            int[] tickets = new int[25];
            for (int i = 0; i < tickets.Length; i++)
            {
                tickets[i] = a;
                a++;
            }

            Tickets = tickets.ToList();
            var rand = new Random();

            for (int i = 0; i < ChRandom.Length; i++)
            {
                int[] arr = Tickets.ToArray();
                int o = rand.Next(0, Tickets.Count);//как проигнорировать случайные значения.
                ChRandom[i] = arr[o];
                Tickets.RemoveAt(o);
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (ChPlayer[i] == ChRandom[j])
                    {
                        win++;
                        Nums.Add(ChPlayer[i]);////////////NENFFFEFEG
                    }
                }
                
                Result = String.Join(", ", Nums);
            }

            

            //int k;
            //var rand = new Random();

            //for (int i = 0; i < ChRandom.Length; i++)
            //{
            //    while (true)
            //    {
            //        k = rand.Next(tickets.Length);
            //        //bool flag = false;
            //        //for(int j = 0; j < Tickets.Count && !flag; j++)
            //        //{
            //        //    if(Tickets[j] == tickets[k])
            //        //    {
            //        //        flag = true;
            //        //    }
            //        //}
            //        if (!Tickets.Any(x => x == tickets[k]))//(!flag)
            //        {
            //            Tickets.Add(tickets[k]);
            //            ChRandom[i] = tickets[k];
            //            break;
            //        }
            //    }
            //}


        }
    }
}
