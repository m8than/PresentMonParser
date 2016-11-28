using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentMonParser
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = ofd.FileName;
            }
        }
        class frameData
        {
            public string ProcessName;
            public int ProcessID;
            public float TimeInSeconds;
            public float MsBetweenPresents;
            public float MsBetweenDisplayChange;
            public float MsInPresentAPI; //probably not gonna use but good to store
            public float MsUntilRenderComplete;
            public float MsUntilDisplayed; //total time to render and output on screen
        }
        //frame/display timing rating
        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (txtFileName.Text == "")
                return;
            string[] lines = File.ReadAllLines(txtFileName.Text);
            List<frameData> frames = new List<frameData>();

            for (int i = 1; i < lines.Length; i++)
            {
                frameData curFrame = new frameData();
                string line = lines[i];
                string[] info = line.Split(',');

                curFrame.ProcessName = info[0];
                curFrame.ProcessID = int.Parse(info[1]);
                curFrame.TimeInSeconds = float.Parse(info[9]);
                curFrame.MsBetweenPresents = float.Parse(info[10]);
                curFrame.MsBetweenDisplayChange = float.Parse(info[11]);
                curFrame.MsInPresentAPI = float.Parse(info[12]);
                curFrame.MsUntilRenderComplete = float.Parse(info[13]);
                curFrame.MsUntilDisplayed = float.Parse(info[14]);

                frames.Add(curFrame);
            }

            int TotalFrames = frames.Count();
            int TimeInSeconds = (int)frames[TotalFrames - 1].TimeInSeconds;
            int AverageFPS = (int)(TotalFrames/TimeInSeconds);

            int AvgMinimumFPS = int.MaxValue;
            int AvgMaximumFPS = 0;

            int curSeconds = 0;
            int curFrameCount = 0;
            

            //count through every frame
            foreach(frameData a in frames)
            {
                //on every second count the frames in the previous seconds and update avgminimum and avgmaximum if necessary

                //curFrameCount = FPS
                if ((int)a.TimeInSeconds > curSeconds)
                {
                    if (curFrameCount > AvgMaximumFPS)
                        AvgMaximumFPS = curFrameCount;
                    if (curFrameCount < AvgMinimumFPS)
                        AvgMinimumFPS = curFrameCount;

                    curFrameCount = 0;
                    curSeconds = (int)a.TimeInSeconds;
                }
                curFrameCount++;
            }
            
            /* Calculate minimum and maximum based on framerate (needs 1000+ seconds of benchmark)
            List<int> FPSorder = new List<int>();
            FPSorder = FPS.OrderByDescending(a => a).ToList();

            int onepercent = FPSorder.Count() / 100;
            int pointonepercent = FPSorder.Count() / 1000;

            int onelow = (int)Math.Round(FPSorder.Take(onepercent).Average());
            int pointonelow = (int)Math.Round(FPSorder.Take(pointonepercent).Average());
            */
            

            /* Calculate minimum and maximum based on frametimes using linq */
            int MinimumFPS = (int)Math.Round(1000 / frames.Max(c => c.MsBetweenPresents)); //based on maximum frametime
            int MaximumFPS = (int)Math.Round(1000 / frames.Min(c => c.MsBetweenPresents)); //based on minimum frametime


            /* Calculate 1% low and 0.1% low based on frametimes using linq */
            List<frameData> frameTimeOrder = new List<frameData>();
            frameTimeOrder = frames.OrderByDescending(i => i.MsBetweenPresents).ToList();

            int onepercent = frameTimeOrder.Count() / 100;
            int pointonepercent = frameTimeOrder.Count() / 1000;

            int onelow = (int)Math.Round(1000/frameTimeOrder.Take(onepercent).Average(i=>i.MsBetweenPresents));
            int pointonelow = (int)Math.Round(1000/frameTimeOrder.Take(pointonepercent).Average(i => i.MsBetweenPresents));

            /* Calculate 1% low and 0.1% low based on frametimes
            List<frameData> frameTimeOrder = new List<frameData>();
            frameTimeOrder = frames.OrderByDescending(i => i.MsBetweenPresents).ToList();

            float totalFrameTimes = 0;
            int frameCount = frameTimeOrder.Count() / 100;

            for (int i=0;i<frameCount;i++)
            {
                totalFrameTimes += frameTimeOrder[i].MsBetweenPresents;
            }

            int onelow = (int)Math.Round(1000 / totalFrameTimes * frameCount);

            totalFrameTimes = 0;
            frameCount = frameTimeOrder.Count() / 1000;

            for (int i = 0; i < frameCount; i++)
            {
                totalFrameTimes += frameTimeOrder[i].MsBetweenPresents;
            }

            int pointonelow = (int)Math.Round(1000 / totalFrameTimes * frameCount);
            */

            lblAverage.Text = AverageFPS.ToString();
            lblMinimum.Text = AvgMinimumFPS.ToString();
            lblMaximum.Text = AvgMaximumFPS.ToString(); 
            lbl1Low.Text = onelow.ToString();
            lbl01Low.Text = pointonelow.ToString(); 
             
            lines = null;
        }
    }
}
