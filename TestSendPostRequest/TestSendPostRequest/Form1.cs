using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace TestSendPostRequest
{
    public partial class Form1 : Form
    {

        private int fileCounter = 0;
        private byte[] fileContentBody = null;

        delegate void UpdateFileCounterCallback();
        public void UpdateFileCounter()
        {
            try
            {
                if (this.fileCounterL.InvokeRequired)
                {
                    UpdateFileCounterCallback d = new UpdateFileCounterCallback(UpdateFileCounter);
                    this.Invoke(d, new object[] { });
                }
                else
                {
                    fileCounter++;
                    this.fileCounterL.Text = fileCounter.ToString();

                    if (fileCounter > 50000)
                    {
                        stopB_Action();
                    }
                }
            }
            catch (Exception ex)
            {
                AddMessage("-----------> UpdateFileCounter: " + ex.Message);
            }
        }

        public void IsAllowToCloaseAllThreads()
        {
            try
            {
                fileCounter++;
                if (fileCounter > 500)
                {
                    stopB_Action();
                }
            }
            catch (Exception ex)
            {
                AddMessage("-----------> IsAllowToCloaseAllThreads: " + ex.Message);
            }
        }




        public Form1()
        {
            InitializeComponent();
        }





        #region Timer



        private List<NamedTimer> timerLst = null;
        bool isStart = false;



        private void startB_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(urlTB.Text))
                {
                    MessageBox.Show("Enter url");
                    return;
                }

                if (string.IsNullOrEmpty(fileTB.Text))
                {
                    MessageBox.Show("choise file");
                    return;
                }

                ClearMessage();
                fileContentBody = GetFileContent();

                StartTimer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void stopB_Click(object sender, EventArgs e)
        {
            stopB_Action();
        }

        private void stopB_Action()
        {
            try
            {
                StopTimer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        private int GetCountOfPostRequestTB()
        {
            try
            {
                if (postRequestTB.Text.Trim().Length == 0)
                    postRequestTB.Text = "100";

                return int.Parse(postRequestTB.Text);
            }
            catch (Exception ex)
            {
            }

            return 1;
        }

        private int GetMiliseconds()
        {
            try
            {
                if(milisecondsTB.Text.Trim().Length == 0)
                    milisecondsTB.Text = "100";

                return int.Parse(milisecondsTB.Text);
            }
            catch(Exception ex)
            {
            }

            return 100;
        }

        private void StartTimer()
        {
  
            ClearMessage();


            StringBuilder sb = new StringBuilder();

            isStart = true;
            timerLst = new List<NamedTimer>();
            for (int i = 0; i < 1 ; i++)
            {
                // Create a timer with a two second interval.
                NamedTimer aTimer = new NamedTimer("TIMER_" + i);

                aTimer.Interval = GetMiliseconds();// (1000 * 1); //1 sec
                aTimer.Elapsed += OnTimedEvent;
                aTimer.AutoReset = !AutoResetCB.Checked; //aTimer.AutoReset = true;
                // aTimer.Enabled = true;
                aTimer.Start();


                sb.Append("\r\n <<<<<<<<<<<<<<<<        START TIMER(" + i + ") ");

                timerLst.Add(aTimer);
            }

            AddMessage(sb.ToString());
        }


        private void StopTimer()
        {
            isStart = false;

            ClearMessage();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < timerLst.Count; i++)
            {
                try
                {
                    // System.Timers.Timer aTimer = timerLst[i];
                    NamedTimer aTimer = timerLst[i];

                    //aTimer.Enabled = false;
                    aTimer.Stop();
                    aTimer.Dispose();
                    aTimer = null;

                    sb.Append("\r\n >>>>>>>>>>>>>>>>>>>      STOP TIMER(" + i + ") ");
                }
                catch (Exception ex)
                {
                    sb.Append("\r\n -----------> ERROR STOP TIMER(" + i + "): " + ex.Message);
                }
            }

            AddMessage(sb.ToString());


        }



        private async void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            try
            {
                NamedTimer timer = source as NamedTimer;
                //   AddMessage("------- (" + timer.name + ") Loop  -------");

                if (isStart == false)
                    return;


                for (int i = 0; i < GetCountOfPostRequestTB(); i++)
                {
                    await SendPostRequest(i);
                }
            }
            catch (Exception ex)
            {
                AddMessage("Error (OnTimedEvent): " + ex.Message);
            }
        }

        #endregion


        private byte[] GetNewRecorderID(int index)
        {
            List<byte> lst = new List<byte>();

            try
            {                
                string source = BaseRecorderIDTB.Text;
                string nubmer = NumberRecorderIDTB.Text;
                int num = int.Parse(nubmer);
                num = num + index;
                
                string recoredId = source + num;



                for (int i = 0; i < recoredId.Length; i++)
                {
                    lst.Add((byte)recoredId[i]);
                }
            }
            catch (Exception ex)
            {
                AddMessage("Error (GetNewRecorderID): " + ex.Message);
            }

            return lst.ToArray();
        }

        private byte[] GetPayloadForDevice(int index)
        {
            List<byte> lst = new List<byte>();

            try
            {
                byte[] newRecorederID_Arr = GetNewRecorderID(index);

                for (int i = 0; i < fileContentBody.Length; i++)
                {
                    if(i>=2 && i < 14)
                    {
                        lst.AddRange(newRecorederID_Arr); 

                        i += newRecorederID_Arr.Length;
                    }

                    lst.Add(fileContentBody[i]);
                }
            }
            catch (Exception ex)
            {
                AddMessage("Error (GetPayloadForDevice): " + ex.Message);
            }

            return lst.ToArray();
        }

        private async Task SendPostRequest(int index)
        {
            try
            {                  
                byte[] post_request_body = GetPayloadForDevice(index);

                Stream res = await SendPostRequest(urlTB.Text, post_request_body, index);
                if (res != null)
                {
                    AddMessage("Device ("+index+") Answer <--- OK ");
                }
                else
                {
                    AddMessage("Device (" + index + ") Answer <--- ERROR ");
                }
            }
            catch (Exception ex)
            {
                AddMessage("Error (SendPostRequest): " + ex.Message);
            }
        }















        #region Message Trace


        delegate void AddMessageCallback(string text);
        private void AddMessage(string text)
        {
            if (this.resTB.InvokeRequired)
            {
                AddMessageCallback d = new AddMessageCallback(AddMessage);
                this.Invoke(d, new object[] { text });
            }
            else
            {

                string txt = this.resTB.Text;

                this.resTB.Text = "\r\n  " + DateTime.Now.ToString("dd.MM.yyyy hh:mm:ss.fffff") + " : " + text + txt;

                // AppLog.AddToLog(text);
            }
        }


        delegate void ClearMessageCallback();
        private void ClearMessage()
        {
            if (this.resTB.InvokeRequired)
            {
                ClearMessageCallback d = new ClearMessageCallback(ClearMessage);
                this.Invoke(d);
            }
            else
            {
                this.resTB.Text = "";
            }
        }


        #endregion
















        private async Task button1_Action()
        {
            try
            {
                System.IO.Stream res = await SendPostRequest(urlTB.Text, fileContentBody);
                if (res != null)
                {
                    // UpdateFileCounter();
                    IsAllowToCloaseAllThreads();
                }
            }
            catch (Exception ex)
            {
                AddMessage("Error (button1_Action): " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var dlg = new System.Windows.Forms.OpenFileDialog();
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fileTB.Text = dlg.FileName;
            }
        }
    
        private byte[] GetFileContent()
        {

            try
            {
                if (String.IsNullOrEmpty(fileTB.Text))
                    return null;

                string file = fileTB.Text;

                byte[] array = File.ReadAllBytes(file);
                return array;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error (GetFileContent): " + ex.Message);
            }

           return null;
        }


        private async Task<System.IO.Stream> SendPostRequest(string actionUrl, /*string paramString, Stream paramFileStream,*/ byte[] paramFileBytes,int index = 0)
        {
            try
            {


              //  HttpContent stringContent = new StringContent(paramString);
             //   HttpContent fileStreamContent = new StreamContent(paramFileStream);
                HttpContent bytesContent = new ByteArrayContent(paramFileBytes);


                using (var client = new HttpClient())
                {
                    using (var formData = new MultipartFormDataContent())
                    {
                        //formData.Add(stringContent, "param1", "param1");
                       // formData.Add(fileStreamContent, "file1", "file1");
                        formData.Add(bytesContent, "file2", "file2");


                        AddMessage("Device (" + index + ") Send ---> OK ");

                        var response = await client.PostAsync(actionUrl, formData);
                        if (!response.IsSuccessStatusCode)
                        {
                            return null;
                        }

                        return await response.Content.ReadAsStreamAsync();
                    }
                }

            }
            catch (Exception ex)
            {
                AddMessage("Error (SendPostRequest): " + ex.Message);
            }

            return null;
        }

     




    }
}
