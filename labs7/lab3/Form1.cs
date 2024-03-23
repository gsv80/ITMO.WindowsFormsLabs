using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class AsyncStart : Form
    {
        public AsyncStart()
        {
            InitializeComponent();
            PrintDelegateFunc = new PrintLabel(PrintFunc);
            
        }

        private delegate int AsyncSum(int a, int b);

        private int Sum(int a, int b) 
        {
            System.Threading.Thread.Sleep(9000);
            return a + b;
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int a,b;
            try 
            { 
                a=Int32.Parse(textBoxAVal.Text);
                b=Int32.Parse(textBoxBVal.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("An Error occured during types casting process");
                textBoxAVal.Text=textBoxBVal.Text="";
                return;
            }
            AsyncSum sumDelegate = new AsyncSum(Sum);
            AsyncCallback cb = new AsyncCallback(CallBackMethod);
            sumDelegate.BeginInvoke(a, b, cb, sumDelegate);

        }

        private void CallBackMethod(IAsyncResult ar)
        {
            string str;
            AsyncSum sumDelegate = (AsyncSum)ar.AsyncState;
            str = String.Format("A sum of inputed values is equal to {0}", sumDelegate.EndInvoke(ar));
            MessageBox.Show(str, "A result of operation");
            labelResult.Invoke(PrintDelegateFunc, new object[] { str });
        }

        private void btnOperate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The operation in process!!");
        }

        void PrintFunc(string str)
        {
            labelResult.Text = str;
        }
        delegate void PrintLabel(string str);
        private PrintLabel PrintDelegateFunc;

        private async void buttonSubtract_Click(object sender, EventArgs e)
        {
            int a, b;
            try
            {
                a = Int32.Parse(textBoxAVal.Text);
                b = Int32.Parse(textBoxBVal.Text);
            }
            catch(Exception) 
            {
                MessageBox.Show("An Error occured during types casting process");
                textBoxAVal.Text = textBoxBVal.Text = "";
                return;
            }
            int res = await Subtr(a, b);
            labelResult.Text = res.ToString();
        }

        private async Task<int> Subtr(int a, int b)
        {
            return await Task.Run(() =>
            {
                System.Threading.Thread.Sleep(5000);
                return a - b;
            });
        }
    }
}
