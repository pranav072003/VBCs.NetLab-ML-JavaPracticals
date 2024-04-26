using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multithreading_Programming_in_Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_multithread_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(WorkerThread);
            thread.Start();
        }

        private void WorkerThread()
        {
            // Simulate some work
            for (int i = 1; i <= 10; i++)
            {
                // Update the UI from the worker thread
                UpdateUI($"Task {i} completed.");

                // Simulate some delay
                Thread.Sleep(1000);
            }
        }

        // Method to update the UI from the worker thread
        private void UpdateUI(string message)
        {
            if (outputTextBox.InvokeRequired)
            {
                // outputTextBox.Invoke(new MethodInvoker(() => { outputTextBox.AppendText(message + Environment.NewLine); }));
                MessageBox.Show(message);
            }
            else
            {
                // outputTextBox.AppendText(message + Environment.NewLine);
                MessageBox.Show(message);
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
