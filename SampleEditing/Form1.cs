using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleEditing
{
    public partial class Form1 : Form
    {
        private string starting;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFire_Click(object sender, EventArgs e)
        {
            var duration = CalculateDurationInSeconds(txtStart.Text, txtEnd.Text);
            starting = txtStart.Text;
            MediaHandler _mhandler = new MediaHandler();
            string RootPath = @"D:\MediaFiles";
            // set required parameters
            _mhandler.FFMPEGPath = @"C:\Users\M1039139\Downloads\ffmpeg-20171212-0e52602-win64-shared\ffmpeg-20171212-0e52602-win64-shared\bin\ffmpeg.exe";
            _mhandler.InputPath = RootPath;
            _mhandler.OutputPath = RootPath;
            // set other parameters
            _mhandler.FileName = "Nikon.mp4";
            _mhandler.OutputFileName = txtFileName.Text; // required
            _mhandler.OutputExtension = ".mp4"; // required
            _mhandler.Width = 320;
            _mhandler.Height = 240;
            // set paremters related to output video type. it is different for 3gp video, mp4 video, avi video etc.
            //_mhandler.TargetFileType = "pal-vcd";
            // split video parameters
            //int length_of_video = Int32.Parse(txtStart.Text); // in seconds;
            //int total_clips = Int32.Parse(txtEnd.Text);Star
            //VideoInfo info = _mhandler.Split_Video(20);

            VideoInfo info = _mhandler.Split_Video(duration, 1, starting);
            if (info.ErrorCode > 0)
            {
                Console.WriteLine("Error occured: Error Code: " + info.ErrorCode + "<br />Error Message: " + info.ErrorMessage);
                return;
            }
        }

        private int CalculateDurationInSeconds(string startTime, string endTime)
        {
            //TimeSpan duration = DateTime.Parse(endTime).Subtract(DateTime.Parse(startTime));
            double duration = double.Parse(endTime) - (double.Parse(startTime));
            return (int)duration;
            //return (int)double.Parse(duration.TotalSeconds.ToString());
        }
    }
}
