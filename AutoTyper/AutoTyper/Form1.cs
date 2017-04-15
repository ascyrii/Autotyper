using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AutoTyper
{
    public partial class Form1 : Form
    {
        public bool started = false;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            startTool.SetToolTip(startBtn, "Shortcut: F12");
            addTool.SetToolTip(addMsgBtn, "Shortcut: Enter");
            removeTool.SetToolTip(removeBtn, "Shortcut: Delete");
            removeAllTool.SetToolTip(removeAllBtn, "Shortcut: Shift + Delete");
            alwaysOnTool.SetToolTip(alwaysOn, "Should enter be pressed before typing?");
        }
        /*
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F12:
                    startBtn_Click(null, null);
                    return true;
                case Keys.Enter:
                    addMsgBtn_Click(null, null);
                    return true;
                case Keys.Delete:
                    button1_Click(null, null);
                    return true;
                case Keys.Shift | Keys.Delete:
                    listBox1.Items.Clear();
                    return true;
                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
        }
        
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F10)
            {
                startBtn_Click(null, null);
            }

            else if(e.KeyCode == Keys.F11)
            {
                stopBtn_Click(null, null);
            }

            else if (e.KeyCode == Keys.Enter)
            {
                addMsgBtn_Click(null, null);
            }
        }*/

        private void startBtn_Click(object sender, EventArgs e)
        {
            if (started == true)
            {
                startBtn.Text = "Start (F12)";
                intBox.Enabled = true;
                listBox1.Enabled = true;
                removeBtn.Enabled = true;
                addMsgBtn.Enabled = true;
                alwaysOn.Enabled = true;
                textBox1.ShortcutsEnabled = true;
                textBox1.AcceptsReturn = true;

                timer1.Stop();
                started = false;
            }

            else if (started == false)
            {
                if (listBox1.Items.Count == 0)
                {
                    string caption = "Error detected in Input";
                    MessageBoxIcon icon1 = MessageBoxIcon.Error;
                    MessageBoxOptions options1 = MessageBoxOptions.ServiceNotification;
                    MessageBox.Show("You must have at least one item added!", caption, MessageBoxButtons.OK, icon1, MessageBoxDefaultButton.Button1, options1);
                    return;
                }

                if (listBox1.Items.Count > 0)
                {
                    intBox.Enabled = false;
                    listBox1.Enabled = false;
                    removeBtn.Enabled = false;
                    addMsgBtn.Enabled = false;
                    alwaysOn.Enabled = false;
                    textBox1.ShortcutsEnabled = false;
                    textBox1.AcceptsReturn = false;


                    Random rnd = new Random();
                    double randomness = new Random().NextDouble() * 1.1;
                    randomness = randomness * 1000;
                    timer1.Interval = Convert.ToInt32(intBox.Text) * 1000 + Convert.ToInt32(randomness);
                    //MessageBox.Show(timer1.Interval.ToString());
                    timer1.Start();
                    started = true;
                    startBtn.Text = "Stop (F12)";
                }
            }
        }

        private void addMsgBtn_Click(object sender, EventArgs e)
        {
            if(textBox1.TextLength <= 0)
            {
                return;
            }

            listBox1.Items.Add(textBox1.Text);
            listBox1.SelectedIndex = 0;
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Remove(listBox1.SelectedIndex);
            if (listBox1.Items.Count <= 0)
            {
                return;
            }
            else
            {
                if (listBox1.SelectedIndex >= 0)
                {
                    int dex = listBox1.SelectedIndex - 1;
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                    listBox1.SelectedIndex = dex;
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sendSub();
        }

        private void sendSub()
        {
            int index = listBox1.SelectedIndex;
            if (!alwaysOn.Checked)
            {
                SendKeys.Send("{ENTER}");
            }

            SendKeys.Send(listBox1.Items[index].ToString());
            SendKeys.Send("{ENTER}");

            if (index + 1 > listBox1.Items.Count - 1)
            {
                index = 0;
                listBox1.SelectedIndex = index;
            }
            else listBox1.SelectedIndex++;
        }

        private void intBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void intBox_ValueChanged(object sender, EventArgs e)
        {
            if (intBox.Value < 0) intBox.Value = 0;
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            System.IO.Stream textStream = null;
            try
            {
                if((textStream = openFileDialog1.OpenFile()) != null)
                {
                    using (textStream)
                    {
                        string formatter;
                        char[] bannedChar = { '{', '}', '/', '\\' };
                        string filen = openFileDialog1.FileName;
                        string[] lines = System.IO.File.ReadAllLines(filen);
                        foreach(string line in lines)
                        {
                            formatter = line;
                            for(int i = 0; i < bannedChar.Length; i++)
                            {
                                if (formatter.Contains(bannedChar[i]))
                                {
                                    formatter = formatter.Replace(bannedChar[i], ' ');
                                }
                            }
                            if (!String.IsNullOrEmpty(formatter))
                            {
                                listBox1.Items.Add(formatter);
                                listBox1.SelectedIndex = 0;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            { 
                {
                    MessageBox.Show("Error: Could not read file from disk. Original Error: " + ex.Message);
                }
            }
        }

        private void saveToTextFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            System.IO.StreamWriter writer = new System.IO.StreamWriter(saveFileDialog1.OpenFile());
            for(int i = 0; i < listBox1.Items.Count; i++)
            {
                writer.WriteLine(listBox1.Items[i].ToString());
            }

            writer.Dispose();
            writer.Close();
        }

        private void mouseKeyEventProvider1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F12:
                    startBtn_Click(null, null);
                    return;
                case Keys.Enter:
                    addMsgBtn_Click(null, null);
                    return;
                case Keys.Delete:
                    button1_Click(null, null);
                    return;
                case Keys.Shift | Keys.Delete:
                    listBox1.Items.Clear();
                    return;
                default:
                    return;
            }
        }

        private void startTool_Popup(object sender, PopupEventArgs e)
        {

        }

        private void removeAllBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void alwaysOn_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
