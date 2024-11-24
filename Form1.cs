using System;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Threading;
using System.Windows.Forms;

namespace SerialProMon
{
    public partial class Form1 : Form
    {
        bool hexmode = false;
        private bool showTimestamp = true;
        public Form1()
        {
            InitializeComponent();

            // Initialize a new ContextMenuStrip
            ContextMenuStrip contextMenu = new ContextMenuStrip();

            // Add menu items
            ToolStripMenuItem copyItem = new ToolStripMenuItem("Copy");
            ToolStripMenuItem pasteItem = new ToolStripMenuItem("Paste");
            ToolStripMenuItem cutItem = new ToolStripMenuItem("Cut");
            ToolStripMenuItem clearItem = new ToolStripMenuItem("Clear");

            // Add event handlers for menu items
            copyItem.Click += (s, e) => richTextBox1.Copy();
            pasteItem.Click += (s, e) => richTextBox1.Paste();
            cutItem.Click += (s, e) => richTextBox1.Cut();
            clearItem.Click += (s, e) => richTextBox1.Clear();

            // Add menu items to the context menu
            contextMenu.Items.AddRange(new ToolStripItem[] { copyItem, pasteItem, cutItem, clearItem });

            // Assign the context menu to the RichTextBox
            richTextBox1.ContextMenuStrip = contextMenu;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Enabled = false;
            cbbComPort.Items.Clear();
            cbbBaudRate.SelectedIndex = 7;
            cbbDatasize.SelectedIndex = 1;
            cbbStopBits.SelectedIndex = 1;
            cbbParity.SelectedIndex = 0;
            cbbHandshake.SelectedIndex = 0;

            using (var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE Caption like '%(COM%'"))
            {
                if (SerialPort.GetPortNames().Length > 0)
                {
                    cbbComPort.DropDown += new EventHandler(cbbComPort_DropDown);
                    var portnames = SerialPort.GetPortNames();
                    var ports = searcher.Get().Cast<ManagementBaseObject>().ToList().Select(p => p["Caption"].ToString());

                    var portList = portnames.Select(n => n + " - " + ports.FirstOrDefault(s => s.Contains(n))).ToList();
                    portList.Sort((x, y) =>
                    {
                        int numX = ExtractNumber(x);
                        int numY = ExtractNumber(y);
                        return numX.CompareTo(numY);
                    });

                    foreach (string s in portList)
                    {
                        cbbComPort.Items.Add(s);
                    }

                    cbbComPort.SelectedIndex = 0;
                }
                else
                {
                    btnConnect.Enabled = false;
                }
                  
            }

            if (serialPort1.IsOpen == true)
            {
                btnConnect.Text = "Disconnect";
                toolStripStatusLabel2.Text = "Connection status: Connected";
                toolStripStatusLabel2.ForeColor = Color.Blue;

                grbCMD.Enabled = true;
                richTextBox1.Enabled = true;
                cbxDTR.Enabled = true;
                cbxRTS.Enabled = true;
            }
            else
            {
                btnConnect.Text = "Connect";
                toolStripStatusLabel2.Text = "Connection status: Disconnected";
                toolStripStatusLabel2.ForeColor = Color.Red;

                grbCMD.Enabled = false;
                richTextBox1.Enabled = false;
                cbxDTR.Enabled = false;
                cbxRTS.Enabled = false;
            }

            cbShowTimestamp.Checked = true;
        }

        // Method to extract the number after "COM"
        static int ExtractNumber(string str)
        {
            // Find the position of "COM" and extract the number part
            string numberPart = str.Substring(3).Split(' ')[0];
            return int.Parse(numberPart);
        }

        private void cbbComPort_DropDown(object sender, EventArgs e)
        {
            ComboBox senderComboBox = (ComboBox)sender;

            int maxWidth = senderComboBox.DropDownWidth;
            Font font = senderComboBox.Font;

            // Measure the width of each item using TextRenderer
            foreach (object item in senderComboBox.Items)
            {
                Size textSize = TextRenderer.MeasureText(item.ToString(), font);
                int itemWidth = textSize.Width;

                // Update the width if the item is wider than the current maxWidth
                if (itemWidth > maxWidth)
                {
                    maxWidth = itemWidth;
                }
            }

            // Set the new dropdown width
            senderComboBox.DropDownWidth = maxWidth;
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (btnConnect.Text == "Connect")
            {
                if (cbbComPort.Items.Count > 0)
                {
                    if (cbbComPort.SelectedItem.ToString() != "")
                    {
                        if (serialPort1.IsOpen == false)
                        {
                            try
                            {
                                serialPort1.Close();
                                serialPort1.PortName = cbbComPort.SelectedItem.ToString().Split('-')[0].Trim();
                                serialPort1.BaudRate = int.Parse(cbbBaudRate.SelectedItem.ToString());
                                serialPort1.DataBits = int.Parse(cbbDatasize.SelectedItem.ToString());
                                if (cbbBaudRate.SelectedItem.ToString() == "none")
                                {
                                    serialPort1.Parity = Parity.None;
                                }
                                else if (cbbBaudRate.SelectedItem.ToString() == "even")
                                {
                                    serialPort1.Parity = Parity.Even;
                                }
                                else if (cbbBaudRate.SelectedItem.ToString() == "odd")
                                {
                                    serialPort1.Parity = Parity.Odd;
                                }
                                else if (cbbBaudRate.SelectedItem.ToString() == "mark")
                                {
                                    serialPort1.Parity = Parity.Mark;
                                }
                                else if (cbbBaudRate.SelectedItem.ToString() == "space")
                                {
                                    serialPort1.Parity = Parity.Space;
                                }
                                else
                                {
                                    serialPort1.Parity = Parity.None;
                                }
                                if (cbbHandshake.SelectedItem.ToString() == "OFF")
                                {
                                    serialPort1.Handshake = Handshake.None;
                                }
                                else if (cbbHandshake.SelectedItem.ToString() == "RTS")
                                {
                                    serialPort1.Handshake = Handshake.RequestToSend;
                                }
                                else if (cbbHandshake.SelectedItem.ToString() == "Xon/Xoff")
                                {
                                    serialPort1.Handshake = Handshake.XOnXOff;
                                }
                                else if (cbbHandshake.SelectedItem.ToString() == "RTS+Xon/Xoff")
                                {
                                    serialPort1.Handshake = Handshake.RequestToSendXOnXOff;
                                }
                                else
                                {
                                    serialPort1.Handshake = Handshake.None;
                                }
                                if (cbbStopBits.SelectedItem.ToString() == "None")
                                {
                                    serialPort1.StopBits = StopBits.None;
                                }
                                else if (cbbStopBits.SelectedItem.ToString() == "1")
                                {
                                    serialPort1.StopBits = StopBits.One;
                                }
                                else if (cbbStopBits.SelectedItem.ToString() == "1.5")
                                {
                                    serialPort1.StopBits = StopBits.OnePointFive;
                                }
                                else if (cbbStopBits.SelectedItem.ToString() == "2")
                                {
                                    serialPort1.StopBits = StopBits.Two;
                                }
                                else
                                {
                                    serialPort1.StopBits = StopBits.None;
                                }
                                serialPort1.ReadTimeout = 4000;
                                serialPort1.WriteTimeout = 6000;
                                serialPort1.Open();
                            }
                            catch
                            {
                            }

                            if (serialPort1.IsOpen == true)
                            {
                                btnConnect.Text = "Disconnect";
                                grbConfig.Enabled = false;

                                toolStripStatusLabel2.Text = "Connection status: Connected";
                                toolStripStatusLabel2.ForeColor = Color.Blue;

                                grbCMD.Enabled = true;
                                richTextBox1.Enabled = true;
                                cbxDTR.Enabled = true;
                                cbxRTS.Enabled = true;
                            }
                            else
                            {
                                toolStripStatusLabel2.Text = "Connection status: Disconnected";
                                toolStripStatusLabel2.ForeColor = Color.Red;

                                grbCMD.Enabled = false;
                                richTextBox1.Enabled = false;
                                cbxDTR.Enabled = false;
                                cbxRTS.Enabled = false;
                            }
                        }
                        else
                        {
                            toolStripStatusLabel2.Text = "Cannot connect to COM port";
                            toolStripStatusLabel2.ForeColor = Color.Red;

                            grbCMD.Enabled = false;
                            richTextBox1.Enabled = false;
                            cbxDTR.Enabled = false;
                            cbxRTS.Enabled = false;
                        }
                    }
                    else
                    {
                        toolStripStatusLabel2.Text = "COM port not selected";
                        toolStripStatusLabel2.ForeColor = Color.Red;

                        grbCMD.Enabled = false;
                        richTextBox1.Enabled = false;
                        cbxDTR.Enabled = false;
                        cbxRTS.Enabled = false;
                    }
                }
                else
                {
                    toolStripStatusLabel2.Text = "COM port not selected";
                    toolStripStatusLabel2.ForeColor = Color.Red;
                    cbbComPort.Items.Clear();

                    if (SerialPort.GetPortNames().Length > 0)
                    {
                        foreach (string s in SerialPort.GetPortNames())
                        {
                            cbbComPort.Items.Add(s);
                        }
                        cbbComPort.SelectedIndex = 0;
                    }

                    grbCMD.Enabled = false;
                    richTextBox1.Enabled = false;
                    cbxDTR.Enabled = false;
                    cbxRTS.Enabled = false;
                }

            }
            else
            {
                try
                {
                    serialPort1.Close();
                    btnConnect.Text = "Connect";

                    grbConfig.Enabled = true;

                    grbCMD.Enabled = false;
                    richTextBox1.Enabled = false;
                    cbxDTR.Enabled = false;
                    cbxRTS.Enabled = false;
                }
                catch (Exception ex)
                {
                    ex.Message.ToString();
                }

                if (serialPort1.IsOpen == true)
                {
                    toolStripStatusLabel2.Text = "Connection status: Connected";
                    toolStripStatusLabel2.ForeColor = Color.Blue;

                    grbCMD.Enabled = true;
                    richTextBox1.Enabled = true;
                    cbxDTR.Enabled = true;
                    cbxRTS.Enabled = true;
                }
                else
                {
                    toolStripStatusLabel2.Text = "Connection status: Disconnected";
                    toolStripStatusLabel2.ForeColor = Color.Red;

                    grbCMD.Enabled = false;
                    richTextBox1.Enabled = false;
                    cbxDTR.Enabled = false;
                    cbxRTS.Enabled = false;
                }
            }
        }
        private void UpdateRichTextBoxText(string newText)
        {
            if (richTextBox1.InvokeRequired)
            {
                richTextBox1.Invoke(new Action<string>(UpdateRichTextBoxText), newText);
            }
            else
            {
                string[] lines = newText.Split(new[] { '\n' }, StringSplitOptions.None);
                foreach (string line in lines)
                {
                    string timestamp = showTimestamp ? DateTime.Now.ToString("HH:mm:ss") : "";
                    if (!string.IsNullOrEmpty(timestamp))
                    {
                        timestamp = $"[{timestamp}] ";
                    }
                    richTextBox1.SelectionColor = Color.DarkMagenta;
                    richTextBox1.AppendText($"{timestamp}{line}\n"); 
                }
            }
            richTextBox1.ScrollToCaret();
        }

        private void UpdateRichTextBoxText_SEND(string newText)
        {
            if (richTextBox1.InvokeRequired)
            {
                richTextBox1.Invoke(new Action<string>(UpdateRichTextBoxText_SEND), newText);
            }
            else
            {
                string[] lines = newText.Split(new[] { '\n' }, StringSplitOptions.None);
                foreach (string line in lines)
                {
                    string timestamp = showTimestamp ? DateTime.Now.ToString("HH:mm:ss") : "";
                    if (!string.IsNullOrEmpty(timestamp))
                    {
                        timestamp = $"[{timestamp}] ";
                    }
                    richTextBox1.SelectionColor = Color.Green;
                    richTextBox1.AppendText($"{timestamp}{line}\n");
                }
            }
            richTextBox1.ScrollToCaret();
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                Thread.Sleep(50);
                int byteavail = serialPort1.BytesToRead;
                byte[] data = new byte[byteavail];
                serialPort1.Read(data, 0, byteavail);
                UpdateRichTextBoxText(System.Text.Encoding.Default.GetString(data));
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                serialPort1.Write(textBox1.Text);
                UpdateRichTextBoxText_SEND(textBox1.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                serialPort1.Write(textBox2.Text);
                UpdateRichTextBoxText_SEND(textBox2.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                serialPort1.WriteLine(textBox3.Text);
                UpdateRichTextBoxText_SEND(textBox3.Text);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                serialPort1.WriteLine(textBox4.Text);
                UpdateRichTextBoxText_SEND(textBox4.Text);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox5.Text != "")
            {
                serialPort1.WriteLine(textBox5.Text);
                UpdateRichTextBoxText_SEND(textBox5.Text);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox6.Text != "")
            {
                serialPort1.WriteLine(textBox6.Text);
                UpdateRichTextBoxText_SEND(textBox6.Text);
            }
        }

        private void cbxDTR_CheckedChanged(object sender, EventArgs e)
        {
            serialPort1.DtrEnable = cbxDTR.Checked;
        }

        private void cbxRTS_CheckedChanged(object sender, EventArgs e)
        {
            serialPort1.RtsEnable = cbxRTS.Checked;
        }

        private void cbbComPort_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbbBaudRate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxHexmode_CheckedChanged(object sender, EventArgs e)
        {
            hexmode = cbxHexmode.Checked;
            richTextBox1.Text = hexmode.ToString();
        }

        private void cbShowTimestamp_CheckedChanged(object sender, EventArgs e)
        {
            showTimestamp = cbShowTimestamp.Checked;
        }
    }
}
