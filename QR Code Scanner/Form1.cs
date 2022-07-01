using System.IO;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Aztec;

namespace QR_Code_Scanner
{
    public partial class QRCode : Form
    {
        public QRCode()
        {
            InitializeComponent();
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;

        private void QRCode_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                CameraBox.Items.Add(filterInfo.Name);
            CameraBox.SelectedIndex = 0;
        }

        private void strbtn_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[CameraBox.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();
        }
        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            ScannerBox.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void QRCode_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (captureDevice.IsRunning)
            {
                captureDevice.SignalToStop();
                captureDevice.WaitForStop();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ScannerBox.Image != null)
            {
                BarcodeReader Reader = new BarcodeReader();
                Result result = Reader.Decode((Bitmap)ScannerBox.Image);
                if (result != null)
                {
                    DecodeBox.Text = result.ToString();
                    timer1.Stop();
                      if (captureDevice.IsRunning)
            {
                captureDevice.SignalToStop();
                captureDevice.WaitForStop();
            }
                }
            }
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            StreamWriter Form;

            Form = File.CreateText(@"C:\Users\user\Documents\Contact Tracing\Contacts.txt");
            Form.WriteLine(DecodeBox.Text);
            Form.Close();
            this.Close();
        }
    }
}