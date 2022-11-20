using System;
using System.Windows.Forms;

namespace MailCourier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LogManager.Default.OnLogAdded += (s, e) => { AddLog(e); };
        }

        private void AddLog(string logMessage)
        {
            if (lbMessage.InvokeRequired)
            {
                lbMessage.Invoke(new Action(() => AddLog(logMessage)));
                return;
            }
            logMessage = $"[{DateTime.Now:dd.MM.yyyy HH:mm:ss:fff}]- {logMessage}";
            lbMessage.Items.Add(logMessage);
            lbMessage.SelectedIndex = lbMessage.Items.Count - 1;
        }

        private void btnListMailTasks_Click(object sender, EventArgs e)
        {
            var mailTask = new MailTask() { Second = 60 };

            mailTaskBindingSource.Clear();
            mailTaskBindingSource.Add(mailTask);
        }

        private void mailTaskBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            var mailTask = mailTaskBindingSource.Current as MailTask;
            if (mailTask == null) return;

            btnStartTask.Enabled = !mailTask.IsStarted;
            btnStopTask.Enabled = mailTask.IsStarted;
            btnRunTask.Enabled = mailTask.IsStarted && !mailTask.IsRunning;
        }

        private async void btnStartTask_Click(object sender, EventArgs e)
        {
            var mailTask = mailTaskBindingSource.Current as MailTask;
            mailTask.Start();
        }

        private async void btnRunTask_Click(object sender, EventArgs e)
        {
            var mailTask = mailTaskBindingSource.Current as MailTask;
            await mailTask.Run();
        }

        private void btnStopTask_Click(object sender, EventArgs e)
        {
            var mailTask = mailTaskBindingSource.Current as MailTask;
            mailTask.Stop();
        }
    }
}
