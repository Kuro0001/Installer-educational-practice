using System;
using System.Windows.Forms;


namespace MyLauncher
{
    public partial class Form1 : Form
    {
        MyClassToWork myClass;
        public Form1()
        {
            InitializeComponent();
        }

        private void bSelectPathToOriginal_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "exe files (*.exe)|*.exe";
                openFileDialog.FilterIndex = 1;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of .exe file
                    tbOriginalPath.Text = openFileDialog.FileName;
                }
            }
        }

        private void bSelectPathToDestination_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of destination folder
                    tbDestinationPath.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }

        private void bExecuteInstallation_Click(object sender, EventArgs e)
        {
            try
            {
                SetToStart();
                myClass.ExecuteInstallation();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void bExecuteUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SetToStart();
                myClass.ExecuteUpdate();                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        public void SetToStart()
        {
            pbContextProgress.Value = 0;
            rtbContextInfo.Text = "";
            myClass = new MyClassToWork(tbOriginalPath.Text, tbDestinationPath.Text);
            myClass.ProgressBarTick += BarTick;
            myClass.MessageInTextBox += ContextInfoUpdate;
            myClass.MessageInforming += ShowInformingMessage;
            myClass.ShowEnd += CheckBar;
            pbContextProgress.Maximum = myClass.CalculateFileCount();
        }

        public void CheckBar()
        {
            if (pbContextProgress.Value < pbContextProgress.Maximum)
                pbContextProgress.Value = pbContextProgress.Maximum;
        }

        public void BarTick(int tick)
        {
            pbContextProgress.Value += tick;
        }

        public void ContextInfoUpdate(string action)
        {
            rtbContextInfo.Text += action;
        }

        public void ShowInformingMessage(string message)
        {
            MessageBox.Show(message, "Informing", MessageBoxButtons.OK);
        }
    }
}
