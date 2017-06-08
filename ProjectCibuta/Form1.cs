using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Vision.Motion;


namespace ProjectCibuta
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection Dispositivos;
        private VideoCaptureDevice FuentedeVideo;
        MotionDetector Detector;
        float NiveldeDeteccion;
        int full1 = 0;
        int pantallacompleta = 100;








        public Form1()
        {
            InitializeComponent();

            Detector = new MotionDetector(new TwoFramesDifferenceDetector());

            float NiveldeDeteccion;

            Dispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo x in Dispositivos)
            {
                Selector1.Items.Add(x.Name);
            }
            
        }
        
        private void vincular_Click(object sender, EventArgs e)
        {

            FuentedeVideo = new VideoCaptureDevice(Dispositivos[Selector1.SelectedIndex].MonikerString);

            videoSourcePlayer1.VideoSource = FuentedeVideo;
            videoSourcePlayer1.Start();
        }
        
        private void desvincular_Click(object sender, EventArgs e)
        {
            videoSourcePlayer1.SignalToStop();
        }
        
        private void videoSourcePlayer1_NewFrame(object sender, ref Bitmap image)
        {
            NiveldeDeteccion = Detector.ProcessFrame(image);
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //detectorplayer1.Text = String.Format("{0:00.0000}", NiveldeDeteccion);
            if (NiveldeDeteccion > 00.0100)
            {
                pictureBox1.BackColor = System.Drawing.Color.Red;
            }
            else {
                pictureBox1.BackColor = System.Drawing.Color.DarkGray;
            }
        }
        
        private void IntercalarPantallas(int camara)
        {

            int ciclo = 0;

            TableLayoutRowStyleCollection stylesRow = this.layouttodascamaras.RowStyles;

            foreach (RowStyle style in stylesRow)
            {


                switch (camara)
                {

                    case 1:
                        
                    case 2:

                    case 3:

                    case 4:


                    default:
                        break;
                }





                switch (full1)
                {

                    case 0:

                        if (style.SizeType == SizeType.Percent)
                        {
                            style.Height = pantallacompleta;

                        }
                        pantallacompleta = 0;

                        break;
                    case 1:

                        if (style.SizeType == SizeType.Percent)
                        {
                            style.Height = pantallacompleta;

                        }
                        pantallacompleta = 50;


                        break;
                    default:
                        break;
                }

                


            }



            switch (full1) { case 0: pantallacompleta = 100; break; case 1: pantallacompleta = 50; break; default: break; }

            TableLayoutColumnStyleCollection stylesColum = this.layouttodascamaras.ColumnStyles;

            foreach (ColumnStyle style in stylesColum)
            {



                switch (full1)
                {

                    case 0:

                        if (style.SizeType == SizeType.Percent)
                        {
                            style.Width = pantallacompleta;

                        }
                        pantallacompleta = 0;

                        break;
                    case 1:

                        if (style.SizeType == SizeType.Percent)
                        {
                            style.Width = pantallacompleta;

                        }
                        pantallacompleta = 50;


                        break;
                    default:
                        break;
                }

            }


            switch (full1) { case 0: full1 = 1; pantallacompleta = 50; ; break; case 1: full1 = 0; pantallacompleta = 100; break; default: break; }





        }

        
        ////////////////////////////////////////////////////////////////////////////
        

        private void Completa1_Click(object sender, EventArgs e)
        {
            int camara = 1;
            IntercalarPantallas(camara);
        }




    }
    
    
}
