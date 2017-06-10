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
using AForge.Video.FFMPEG;



namespace ProjectCibuta
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection Dispositivos;

        private VideoCaptureDevice FuentedeVideo1, FuentedeVideo2, FuentedeVideo3, FuentedeVideo4;

        MotionDetector Detector1, Detector2, Detector3, Detector4;

        float NiveldeDeteccion1, NiveldeDeteccion2, NiveldeDeteccion3, NiveldeDeteccion4;
        
        int full1 = 0;
        int pantallacompleta = 100;

        
        public Form1()
        {
            InitializeComponent();

            ActualizarSelectorCamaras();
            
            Detector1 = new MotionDetector(new TwoFramesDifferenceDetector());
            Detector2 = new MotionDetector(new TwoFramesDifferenceDetector());
            Detector3 = new MotionDetector(new TwoFramesDifferenceDetector());
            Detector4 = new MotionDetector(new TwoFramesDifferenceDetector());

        }

        //////////////////////////////////ASIGNAR Detector de movimiento a cada Camara/////////////////////////////////////////


        private void videoSourcePlayer1_NewFrame(object sender, ref Bitmap image)
        {
            NiveldeDeteccion1 = Detector1.ProcessFrame(image);
        }

        private void videoSourcePlayer2_NewFrame_1(object sender, ref Bitmap image)
        {
            NiveldeDeteccion2 = Detector2.ProcessFrame(image);
        }
        
        private void videoSourcePlayer3_NewFrame_1(object sender, ref Bitmap image)
        {
            NiveldeDeteccion4 = Detector4.ProcessFrame(image);
        }
        
        private void videoSourcePlayer4_NewFrame_1(object sender, ref Bitmap image)
        {
            NiveldeDeteccion3 = Detector3.ProcessFrame(image);
        }

        ////////////////////////////////////////////////////////////////////////////

            
        private void DeteccionMovimiento(object sender, EventArgs e)
        {
            if (NiveldeDeteccion1 > 00.0030)
            {
                pictureBox1.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                pictureBox1.BackColor = System.Drawing.Color.DarkGray;
            }

            if (NiveldeDeteccion2 > 00.0030)
            {
                pictureBox2.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                pictureBox2.BackColor = System.Drawing.Color.DarkGray;
            }


            if (NiveldeDeteccion3 > 00.0030)
            {
                pictureBox4.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                pictureBox4.BackColor = System.Drawing.Color.DarkGray;
            }


            if (NiveldeDeteccion4 > 00.0030)
            {
                pictureBox3.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                pictureBox3.BackColor = System.Drawing.Color.DarkGray;
            }

        }

        
        //////////////////////////////////Botones para Vincular y Desvincular Camaras//////////////////////////////////////////


        private void Vincular1_Click(object sender, EventArgs e)
        {

            FuentedeVideo1 = new VideoCaptureDevice(Dispositivos[Selector1.SelectedIndex].MonikerString);

            videoSourcePlayer1.VideoSource = FuentedeVideo1;
            videoSourcePlayer1.Start();
        }
        private void Desvincular1_Click(object sender, EventArgs e)
        {
            videoSourcePlayer1.SignalToStop();
        }

        private void Vincular2_Click(object sender, EventArgs e)
        {
            FuentedeVideo2 = new VideoCaptureDevice(Dispositivos[Selector2.SelectedIndex].MonikerString);

            videoSourcePlayer2.VideoSource = FuentedeVideo2;
            videoSourcePlayer2.Start();
        }
        private void Desvincular2_Click(object sender, EventArgs e)
        {
            videoSourcePlayer2.SignalToStop();
        }

        private void Vinculae3_Click(object sender, EventArgs e)
        {
            FuentedeVideo3 = new VideoCaptureDevice(Dispositivos[Selector3.SelectedIndex].MonikerString);

            videoSourcePlayer4.VideoSource = FuentedeVideo3;
            videoSourcePlayer4.Start();
        }
        private void Desvincular3_Click(object sender, EventArgs e)
        {
            videoSourcePlayer4.SignalToStop();
        }

        private void Vincular4_Click(object sender, EventArgs e)
        {
            FuentedeVideo4 = new VideoCaptureDevice(Dispositivos[Selector4.SelectedIndex].MonikerString);

            videoSourcePlayer3.VideoSource = FuentedeVideo4;
            videoSourcePlayer3.Start();
        }
        private void Desvincular4_Click(object sender, EventArgs e)
        {
            videoSourcePlayer3.SignalToStop();
        }
        

        //////////////////////////////////ANIMACIONES y ACTUALIZAR DATOS METODOS//////////////////////////////////////////


        private void IntercalarPantallas(int camara)
        {

            
                switch (full1)
                {

                    case 0:


                        switch (camara)
                        {

                            case 1:
                                this.layouttodascamaras.RowStyles[0].Height = 100;
                                this.layouttodascamaras.ColumnStyles[0].Width = 100;
                                this.layouttodascamaras.RowStyles[1].Height = 0;
                                this.layouttodascamaras.ColumnStyles[1].Width = 0;
                            break;

                            case 2:
                                this.layouttodascamaras.RowStyles[0].Height = 100;
                                this.layouttodascamaras.ColumnStyles[1].Width = 100;
                                this.layouttodascamaras.RowStyles[1].Height = 0;
                                this.layouttodascamaras.ColumnStyles[0].Width = 0;
                            break;

                            case 3:
                                this.layouttodascamaras.RowStyles[1].Height = 100;
                                this.layouttodascamaras.ColumnStyles[0].Width = 100;
                                this.layouttodascamaras.RowStyles[0].Height = 0;
                                this.layouttodascamaras.ColumnStyles[1].Width = 0;
                            break;
                            case 4:
                                this.layouttodascamaras.RowStyles[1].Height = 100;
                                this.layouttodascamaras.ColumnStyles[1].Width = 100;
                                this.layouttodascamaras.RowStyles[0].Height = 0;
                                this.layouttodascamaras.ColumnStyles[0].Width = 0;
                            break;

                            default:
                                break;
                        }

                    
                    break;

                    case 1:
                        switch (camara)
                        {

                            default:
                            this.layouttodascamaras.RowStyles[0].Height = 50;
                            this.layouttodascamaras.ColumnStyles[0].Width = 50;
                            this.layouttodascamaras.RowStyles[1].Height = 50;
                            this.layouttodascamaras.ColumnStyles[1].Width = 50;
                            break;
                        }
                    
                    break;

                    default:
                        break;
                }
            


            switch (full1) { case 0: full1 = 1; break; case 1: full1 = 0;break; default: break; }

            
        }

        private void ActualizarSelectorCamaras() {

            Dispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo x in Dispositivos)
            {
                Selector1.Items.Add(x.Name);
                Selector2.Items.Add(x.Name);
                Selector3.Items.Add(x.Name);
                Selector4.Items.Add(x.Name);
            }

        }
        
        private void VideosGuardados_Click(object sender, EventArgs e)
        {
            this.layoutnavegacion.ColumnStyles[0].Width = 20;
            this.layoutnavegacion.ColumnStyles[1].Width = 0;
            this.layoutnavegacion.ColumnStyles[2].Width = 80;
        }
        
        private void Home_Click(object sender, EventArgs e)
        {
            this.layoutnavegacion.ColumnStyles[0].Width = 20;
            this.layoutnavegacion.ColumnStyles[1].Width = 80;
            this.layoutnavegacion.ColumnStyles[2].Width = 0;
        }


        /////////////////////////////Pantallas al 100% de visualizacion///////////////////////////////////////////////


        private void Completa1_Click(object sender, EventArgs e)
        {
            int camara = 1;
            IntercalarPantallas(camara);
        }

        private void Completa2_Click(object sender, EventArgs e)
        {
            int camara = 2;
            IntercalarPantallas(camara);
        }

        private void Completa3_Click(object sender, EventArgs e)
        {
            int camara = 3;
            IntercalarPantallas(camara);
        }

        private void Completa4_Click(object sender, EventArgs e)
        {
            int camara = 4;
            IntercalarPantallas(camara);
        }

        
        ////////////////////////////////////////////////////////////////////////////





    }


}
