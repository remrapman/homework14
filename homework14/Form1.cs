using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MyStackButton_Click(object sender, EventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            MyStack.Stack();
            watch.Stop();
            var elapsedTime = watch.ElapsedMilliseconds;
            MessageBox.Show("Elapsed time is " + elapsedTime + " miliseconds");
        }

        private void DefaultStackButton_Click(object sender, EventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            DefaultStack.Stack();
            watch.Stop();
            var elapsedTime = watch.ElapsedMilliseconds;
            MessageBox.Show("Elapsed time is " + elapsedTime + " miliseconds");
        }

        private void MyQueueButton_Click(object sender, EventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            MyQueue.Queue();
            watch.Stop();
            var elapsedTime = watch.ElapsedMilliseconds;
            MessageBox.Show("Elapsed time is " + elapsedTime + " miliseconds");
        }

        private void DefaultQueueButton_Click(object sender, EventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            DefQueue.Queue();
            watch.Stop();
            var elapsedTime = watch.ElapsedMilliseconds;
            MessageBox.Show("Elapsed time is " + elapsedTime + " miliseconds");
        }
    }
}
