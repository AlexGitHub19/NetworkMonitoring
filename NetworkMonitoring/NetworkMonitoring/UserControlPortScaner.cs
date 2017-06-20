using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkMonitoring
{
    public partial class UserControlPortScaner : UserControl
    {
        MainFrom instance;
        string ip;
        public UserControlPortScaner(string Ip, MainFrom Instance)
        {
            
            instance = Instance;
            InitializeComponent();
            ip = Ip;
            listBoxResult.Text = String.Empty;
            metroLabelIp.Text = ip;
            mButtonStart.BackColor = System.Drawing.ColorTranslator.FromHtml(GetColor.GetColorHex(instance.metroStyleManager1.Style.ToString()));
            listBoxResult.ForeColor = System.Drawing.ColorTranslator.FromHtml(GetColor.GetColorHex(instance.metroStyleManager1.Style.ToString()));
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            // Заносим в переменную StartPort стартовый номер порта из компонента NumericUpDown
            int StartPort = Convert.ToInt32(numericUpDownStart.Value);
            // Заносим в переменную EndPort конечный номер порта из компонента 
            int EndPort = Convert.ToInt32(numericUpDownEnd.Value);

            for (int CurrPort = StartPort; CurrPort <= EndPort; CurrPort++)
            {
                //Инициализируем новый экземпляр класса 
                System.Net.Sockets.TcpClient TcpScan = new System.Net.Sockets.TcpClient();
                try
                {
                    //Выполняем подключение клиента к указанному порту заданного узла.
                    TcpScan.Connect(ip, CurrPort);
                    //Если подключение выполнено успешно то выводим в listBox1
                    PortOpen(CurrPort);
                }
                catch
                {
                    //Если возникло исключение то порт закрыт
                    PortClose(CurrPort);
                }
                //Переводим курсор на последнюю строку списка
                selectedIndex();
            }

        }

        public void selectedIndex()
        {
            try
            {
                if (InvokeRequired)
                    BeginInvoke(new MethodInvoker(delegate
                    {
                        listBoxResult.SelectedIndex = listBoxResult.Items.Count - 1;                      
                    }));
                else
                {
                    listBoxResult.SelectedIndex = listBoxResult.Items.Count - 1;
                }
            }
            catch (Exception) { }
        }

        public void PortOpen(int port)
        {
            try
            {
                if (InvokeRequired)
                    BeginInvoke(new MethodInvoker(delegate
                    {
                        listBoxResult.Items.Add("Port " + port + " is OPENED");
                    }));
                else
                {
                    listBoxResult.Items.Add("Port " + port + " is closed");
                }
            }
            catch (Exception) { }
        }

        public void PortClose(int port)
        {
            try
            {
                if (InvokeRequired)
                    BeginInvoke(new MethodInvoker(delegate
                    {                      
                        listBoxResult.Items.Add("Port " + port + " is closed");
                    }));
                else
                {
                    listBoxResult.Items.Add("Port " + port + " is closed");
                }
            }
            catch (Exception) { }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            mButtonStart.Enabled = true;
        }

        private void mButtonStart_Click(object sender, EventArgs e)
        {
            listBoxResult.Items.Clear();
            //Блокируем кнопку, для предотвращения повторного запуска
            //процесса, при уже запущенном процессе
            listBoxResult.Enabled = false;
            backgroundWorker1.RunWorkerAsync();
        }

        private void listBoxResult_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();

            bool isItemSelected = ((e.State & DrawItemState.Selected) == DrawItemState.Selected);
            int itemIndex = e.Index;
            if (itemIndex >= 0 && itemIndex < listBoxResult.Items.Count)
            {
                Graphics g = e.Graphics;

                // Background Color
                SolidBrush backgroundColorBrush = new SolidBrush((isItemSelected) ? System.Drawing.ColorTranslator.FromHtml(GetColor.GetColorHex(instance.metroStyleManager1.Style.ToString())) : Color.White);
                g.FillRectangle(backgroundColorBrush, e.Bounds);

                // Set text color
                string itemText = listBoxResult.Items[itemIndex].ToString();

                SolidBrush itemTextColorBrush = (isItemSelected) ? new SolidBrush(Color.White) : new SolidBrush(Color.Black);
                g.DrawString(itemText, e.Font, itemTextColorBrush, listBoxResult.GetItemRectangle(itemIndex).Location);

                // Clean up
                backgroundColorBrush.Dispose();
                itemTextColorBrush.Dispose();
            }

            e.DrawFocusRectangle();
        }
    }
}
