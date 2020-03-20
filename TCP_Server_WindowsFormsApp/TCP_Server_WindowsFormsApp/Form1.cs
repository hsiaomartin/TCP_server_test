using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
namespace TCP_Server_WindowsFormsApp
{
    public partial class Form1 : Form
    {
        private delegate void ShowTD(String Str);
        private delegate void ShowListbox(String Str,Boolean bl);
        private ShowTD ShowTextDele;
        private ChatServer CS = new ChatServer();
        Thread time_tick;
        Boolean myDebug = false;
        private Thread refreshClientList;
        enum textBox_select {IP_box,chat_box }
        // private ChatClient CC = new ChatClient();
        public Form1()
        {
            //CheckForIllegalCrossThreadCalls = false;
            CS.Start(this);

            try
            {
               // CC.Start();
                InitializeComponent();
                IP_textBox.Text = CS.getIP();
                Port_textBox.Text = "8250";
                ShowTextDele = new ShowTD(ShowText);
                time_tick = new Thread(show_time);
                time_tick.Start();

               // refreshClientList = new Thread(refreshRichBox);
               // refreshClientList.Start();

            }
            catch
            {
                ShowText("連線錯誤!");
            }
            
        }


        public void refreshRichBox(string userInfo,Boolean userExist)
        {


            if (this.InvokeRequired)
            {

                this.BeginInvoke(new ShowListbox(refreshRichBox), userInfo, userExist);
                return;
            }
            else
            {
                if (userExist)
                    IP_listBox.Items.Add(userInfo);
                else
                    IP_listBox.Items.Remove(userInfo);
            }

            //while (true)
            //{
            //List<User> userList = CS.getUsers();
            //string IPList = "";
            //foreach (User Q in userList)
            //{
            //    IPList += Q.Sock.RemoteEndPoint.ToString() + "\r\n";
            //}
            //if (myDebug)
            //    CS.serverSend("Hi\r\n");
            //ShowText(IPList);
            //Thread.Sleep(1000);
            //}



        }
        public void ShowText(String str)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(ShowTextDele, str);
                return;
            }



            try
            {
                content.AppendText(str + "\r\n");
                content.SelectionStart = content.Text.Length;
                content.ScrollToCaret();
            }
            catch(Exception e) {
                MessageBox.Show("伺服器已中止!\r\n"+e);
                this.Close();
                Environment.Exit(Environment.ExitCode);
            }

        }

        private void send_btn_Click(object sender, EventArgs e)
        {
            CS.serverSend("Server :" + input.Text);
            input.Text = "";
        }

        private void send_btn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (input.Text.Length == 0) return;
             //   CC.Send(myname.Text + ":" + input.Text);
                input.Text = "";
            }
        }

        private void show_time() {
            while (true)
            {
                
                CS.serverSend("Time " + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
               // CC.Send("Time "+ DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
                Thread.Sleep(1000);
                time_toolStripStatusLabel.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");

            }
                
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            time_tick.Abort();
           // refreshClientList.Abort();
            // CS.Stop();
            // MessageBox.Show("伺服器已中止!\r\n" + e);
            //this.Close();
            //Environment.Exit(Environment.ExitCode);
            //serialPort1.Close();
        }


    }
}
