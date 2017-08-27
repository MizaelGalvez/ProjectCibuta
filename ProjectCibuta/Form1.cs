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
using AForge.Imaging;
using System.IO;
using System.Drawing.Imaging;
using AForge.Imaging.Filters;
using System.Runtime.InteropServices;
using System.Threading;
using AForge;

namespace MT_project
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection Dispositivos;

        private ScreenCaptureStream FuentedeVideo1, FuentedeVideo2, FuentedeVideo3, FuentedeVideo4, FuentedeVideo5;

        private int bucleCAM1, bucleCAM2, bucleCAM3, bucleCAM4, bucleCAM5;

        int posicion1, posicion2, posicion3, posicion4;
        int intercalar = 1;

        int PrimerCuadro = 0;
        int SegundoCuadro = 0;

        int intercalarBinaria =1;
        int estrategia_aplicada_A = 460;
        int estrategia_aplicada_B = 560;

        int resolucionAPLICADA = 1470;

        int resolucionA = 1470; int estrategiaA_ = 550; int estrategiaA = 460;
        
        int ResolucionB = 1810; int estrategiaB_ = 680; int estrategiaB = 560;

        int VentanaNueva = 460;


        double sensibilidadUSADA = 00.002;

        double sensibilidadA = 00.01;
        double sensibilidadB = 00.0001;

        int horaA = 7;
        int horaB = 10;
        int horaC = 3;
        int horaD = 5;
        int minutoA = 30;
        int minutoB = 15;

        int horaA_ = 7;
        int horaB_ = 10;
        int horaC_ = 3;
        int horaD_ = 5;
        int minutoA_ = 30;
        int minutoB_ = 15;

        MotionDetector Detector1, Detector2, Detector3, Detector4, Detector5;

        float NiveldeDeteccion1, NiveldeDeteccion2, NiveldeDeteccion3, NiveldeDeteccion4, NiveldeDeteccion5;
        
        int full1 = 0;
        int pantallacompleta = 100;
        private Rectangle screenArea;

        








        ////////////////////////////////////////importacion de click derecho////////////////////////////////////////////////


        [DllImport("user32.dll")]
        private static extern void mouse_event(UInt32 dwFlags, UInt32 dx, UInt32 dy, UInt32 dwData, IntPtr dwExtraInfo);

        private const UInt32 MouseEventleftDown = 0x0002;
        private const UInt32 MouseEventleftUp = 0x0004;


        public static void EnviarClick(UInt32 posX, UInt32 posY)
        {
            mouse_event(MouseEventleftDown, posX, posY, 0, new System.IntPtr());
            mouse_event(MouseEventleftUp, posX, posY, 0, new System.IntPtr());
        }

        
        ////////////////////////////////////////////////////////////////////////////////////////


        public Form1()
        {
            InitializeComponent();
            
            
            Detector1 = new MotionDetector(new TwoFramesDifferenceDetector());
            Detector2 = new MotionDetector(new TwoFramesDifferenceDetector());
            Detector3 = new MotionDetector(new TwoFramesDifferenceDetector());
            Detector4 = new MotionDetector(new TwoFramesDifferenceDetector());
            Detector5 = new MotionDetector(new TwoFramesDifferenceDetector());
            bucleCAM1 = 0; bucleCAM2 = 0; bucleCAM3 = 0; bucleCAM4 = 0; bucleCAM5 = 0;

            //Estrategia.Text = "Tendencia";
            Estrategia.BackColor = Color.Blue;
            Horario.Text = "CON HORARIO";
            cambioResolucion.Text = "Resolucion 1470";

        }



        //////////////////////////////////ASIGNAR Detector de movimiento a cada Camara/////////////////////////////////////////




        



        ////////////////////////////////////////////////////////primeras 2 vetanas a la izquierda//////////////////////////////////////////////////////////////////
        


        private void videoSourcePlayer1_NewFrame_1(object sender, ref Bitmap image)
        {
            EuclideanColorFiltering F_verde_D = new EuclideanColorFiltering(); //TENDENCIA 1/1
            // set center colol and radius
            F_verde_D.CenterColor = new RGB(127, 0, 255);
            F_verde_D.Radius = 100;
            // apply the filter
            //F_verde_D.ApplyInPlace(image);
            //NiveldeDeteccion1 = Detector1.ProcessFrame(image);


            // create filter
            EuclideanColorFiltering filter = new EuclideanColorFiltering();
            // set center colol and radius
            filter.CenterColor = new RGB(255, 255, 255);
            filter.Radius = 200;
            // apply the filter
            filter.ApplyInPlace(image);


            BlobCounter blobCounter = new BlobCounter();
            blobCounter.MinWidth = 8;                    // set minimum size of
            blobCounter.MinHeight = 1;                   // objects we look for
            blobCounter.FilterBlobs = true;               // filter blobs by size
            blobCounter.ObjectsOrder = ObjectsOrder.Area; // order found object by size

            // grayscaling
            Bitmap grayImage = (image);
            // locate blobs 
            blobCounter.ProcessImage(image);
            Rectangle[] rects = blobCounter.GetObjectsRectangles();
            // draw rectangle around the biggest blob
            if (rects.Length > 0)
            {
                Rectangle objectRect = rects[0];
                Graphics g = Graphics.FromImage(image);

                using (Pen pen = new Pen(Color.FromArgb(255, 255, 255), 7))
                {
                    g.DrawRectangle(pen, objectRect);

                }

                PrimerCuadro = 1;

                g.Dispose();
            }
            else
            {
                PrimerCuadro = 0;
            }
            




        }

        private void videoSourcePlayer4_NewFrame(object sender, ref Bitmap image)
        {
            EuclideanColorFiltering F_rojo = new EuclideanColorFiltering(); //TENDENCIA 1/2
            // set center colol and radius
            F_rojo.CenterColor = new RGB(127, 0, 255);
            F_rojo.Radius = 100;
            // apply the filter
            //F_rojo.ApplyInPlace(image);
            //NiveldeDeteccion3 = Detector3.ProcessFrame(image);



            // create filter
            EuclideanColorFiltering filter = new EuclideanColorFiltering();
            // set center colol and radius
            filter.CenterColor = new RGB(255, 255, 255);
            filter.Radius = 200;
            // apply the filter
            filter.ApplyInPlace(image);


            BlobCounter blobCounter = new BlobCounter();
            blobCounter.MinWidth = 8;                    // set minimum size of
            blobCounter.MinHeight = 1;                   // objects we look for
            blobCounter.FilterBlobs = true;               // filter blobs by size
            blobCounter.ObjectsOrder = ObjectsOrder.Area; // order found object by size

            // grayscaling
            Bitmap grayImage = (image);
            // locate blobs 
            blobCounter.ProcessImage(image);
            Rectangle[] rects = blobCounter.GetObjectsRectangles();
            // draw rectangle around the biggest blob
            if (rects.Length > 0)
            {
                Rectangle objectRect = rects[0];
                Graphics g = Graphics.FromImage(image);

                using (Pen pen = new Pen(Color.FromArgb(255, 255, 255), 7))
                {
                    g.DrawRectangle(pen, objectRect);

                }

                SegundoCuadro = 1;

                g.Dispose();
            }
            else
            {
                SegundoCuadro = 0;
            }





        }

        ////////////////////////////////////////////////////////////SEGUNDA DOS VENTANAS A LA DERECHA//////////////////////////////////////////////////////////////


        private void videoSourcePlayer3_NewFrame(object sender, ref Bitmap image)
        {
            EuclideanColorFiltering F_verde_up = new EuclideanColorFiltering(); //TENDENCIA 1/1
            // set center colol and radius
            F_verde_up.CenterColor = new RGB(127, 0, 255);
            F_verde_up.Radius = 100;
            //apply the filter
            F_verde_up.ApplyInPlace(image);
            NiveldeDeteccion2 = Detector2.ProcessFrame(image);
        }

        private void videoSourcePlayer5_NewFrame(object sender, ref Bitmap image)
        {


            EuclideanColorFiltering F_verde = new EuclideanColorFiltering(); //TENDENCIA 1/1
            // set center colol and radius
            F_verde.CenterColor = new RGB(127, 0, 255);
            F_verde.Radius = 100;
            //apply the filter
            F_verde.ApplyInPlace(image);
            NiveldeDeteccion5 = Detector5.ProcessFrame(image);

        }

        //////////////////////////////////////////////////////////////nueva Ventana////////////////////////////////////////////////////////////

        private void videoSourcePlayer2_NewFrame_1(object sender, ref Bitmap image)
        {


            EuclideanColorFiltering F_naranja = new EuclideanColorFiltering(); //NUEVA VENTANA
            // set center colol and radius
            F_naranja.CenterColor = new RGB(255, 153, 51);
            F_naranja.Radius = 100;
            // apply the filter
            F_naranja.ApplyInPlace(image);
            NiveldeDeteccion4 = Detector4.ProcessFrame(image);


            /*

            // create filter
            EuclideanColorFiltering filter = new EuclideanColorFiltering();
            // set center colol and radius
            filter.CenterColor = new RGB(127, 0, 255);
            filter.Radius = 200;
            // apply the filter
            filter.ApplyInPlace(image);


            BlobCounter blobCounter = new BlobCounter();
            blobCounter.MinWidth = 8;                    // set minimum size of
            blobCounter.MinHeight = 1;                   // objects we look for
            blobCounter.FilterBlobs = true;               // filter blobs by size
            blobCounter.ObjectsOrder = ObjectsOrder.Area; // order found object by size

            // grayscaling
            Bitmap grayImage = (image);
            // locate blobs 
            blobCounter.ProcessImage(image);
            Rectangle[] rects = blobCounter.GetObjectsRectangles();
            // draw rectangle around the biggest blob
            if (rects.Length > 0)
            {
                Rectangle objectRect = rects[0];
                Graphics g = Graphics.FromImage(image);

                using (Pen pen = new Pen(Color.FromArgb(255, 255, 255), 7))
                {
                    g.DrawRectangle(pen, objectRect);

                }
                if (intercalar == 2)
                {
                    if ((objectRect.Y > 150 && objectRect.Y < 250))
                    {
                        rebote();
                        R_T = 0;

                    }
                    else
                    {
                        tendencia();
                        R_T = 1;
                    }
                }


                g.Dispose();
            }

                */


        }

       

        ////////////////////////////////////////////////////////////////////////////

        private void cambioResolucion_Click(object sender, EventArgs e)
        {
            if (intercalarBinaria == 0)
            {
                resolucionAPLICADA = resolucionA;
                estrategia_aplicada_A = estrategiaA;
                estrategia_aplicada_B = estrategiaB;
                VentanaNueva = estrategiaA;
                cambioResolucion.Text = "Resolucion 1470";

                intercalarBinaria = 1;

            }
            else
            {
                resolucionAPLICADA = ResolucionB;
                estrategia_aplicada_A = estrategiaA_;
                estrategia_aplicada_B = estrategiaB_;
                VentanaNueva = estrategiaA_;
                cambioResolucion.Text = "Resolucion 1810";

                intercalarBinaria = 0;
            }
        }

        ///////////////////////////////////////////////////////////////////////////



        //////////////////////////////////////////////////////priemras DOS////////////////////////////////////////////////////////////////////


        private void DeteccionMovimiento(object sender, EventArgs e)
        {
            if (NiveldeDeteccion1 > sensibilidadB)
            {
               
                //HacerClickConHora(1);
                //Thread.Sleep(2000);

            }
            else
            {
                pictureBox1.BackColor = System.Drawing.Color.DarkGray;
            }




            if (NiveldeDeteccion3 > sensibilidadB)
            {
               
                //HacerClickConHora(2);
                //Thread.Sleep(2000);


            }
            else
            {
                pictureBox4.BackColor = System.Drawing.Color.DarkGray;
            }



            /////////////////////////////////////////////////////segundas DOS////////////////////////////////////////////////////////////////////





            if (NiveldeDeteccion2 > sensibilidadUSADA)
            {
                if (PrimerCuadro == 1 && SegundoCuadro == 0)
                {
                    HacerClickConHora(3);
                    Thread.Sleep(2000);
                }
                if (PrimerCuadro == 0 && SegundoCuadro == 1)
                {
                    HacerClickConHora(3);
                    Thread.Sleep(2000);
                }
                
                

                

            }
            else
            {
                pictureBox2.BackColor = System.Drawing.Color.DarkGray;
            }


            if (NiveldeDeteccion5 > sensibilidadUSADA)
            {
                if (PrimerCuadro ==1 && SegundoCuadro == 0)
                {
                    HacerClickConHora(4);
                    Thread.Sleep(2000);
                }
                if (PrimerCuadro == 0 && SegundoCuadro == 1)
                {
                    HacerClickConHora(4);
                    Thread.Sleep(2000);
                }
                


            }
            else
            {
               // pictureBox4.BackColor = System.Drawing.Color.DarkGray;
            }


            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            if (NiveldeDeteccion4 > 00.0001)
            {
                pictureBox3.BackColor = System.Drawing.Color.Red; // de nueva ventana


                Cursor.Position = new System.Drawing.Point(850, 5);// original en Y 550
                HacerClickConHora(5);

                SendKeys.Send("^w");

                Cursor.Position = new System.Drawing.Point(resolucionAPLICADA, VentanaNueva);// original en Y 550
                HacerClickConHora(5);

                Thread.Sleep(2000);
            }
            else
            {
                pictureBox3.BackColor = System.Drawing.Color.DarkGray;
            }




        }


        //////////////////////////////////////////////////////////////////////////

        private void Home_Click(object sender, EventArgs e)
        {
            Estrategia.Enabled = true;

            Horario.Enabled = true;

            Estrategia.BackColor = Color.Lime;

            Rectangle screenArea = Rectangle.Empty;

            screenArea = new Rectangle(1758, 500, 150, 150); //NUEVA VENTANA

            FuentedeVideo2 = new ScreenCaptureStream(screenArea);

            videoSourcePlayer2.VideoSource = FuentedeVideo2;
            videoSourcePlayer2.Start();

            // ////////////////////////////////////////////////////////////////////////////////////////////////////

            Rectangle screenArea2 = Rectangle.Empty; //Linea Superior

            screenArea2 = new Rectangle(850, 430, 125, 65); // si funciona la deteccion y el PUT anterior de 785  y menos 10

            FuentedeVideo1 = new ScreenCaptureStream(screenArea2);

            videoSourcePlayer1.VideoSource = FuentedeVideo1;
            videoSourcePlayer1.Start();

            Rectangle screenArea4 = Rectangle.Empty;  // linea Roja, 

            screenArea4 = new Rectangle(1100, 430, 125, 65); //si Funciona el PUSH antes 982 menos 10

            FuentedeVideo4 = new ScreenCaptureStream(screenArea4);

            videoSourcePlayer4.VideoSource = FuentedeVideo4;
            videoSourcePlayer4.Start();

            // ////////////////////////////////////////////////////////////////////////////////////////////////////

            Rectangle screenArea3 = Rectangle.Empty;

            screenArea3 = new Rectangle(1200, 899, 150, 10); //COORDENADAS TENDENCIA SEGUNDA COLUMNA SEGUNDA RENGLON

            FuentedeVideo3 = new ScreenCaptureStream(screenArea3);

            videoSourcePlayer3.VideoSource = FuentedeVideo3;
            videoSourcePlayer3.Start();


            Rectangle screenArea5 = Rectangle.Empty; //COORDENADAS TENDENCIA SEGUNDA COLUMNA PRIMER RENGLON

            screenArea5 = new Rectangle(1200, 780, 150, 10);

            FuentedeVideo5 = new ScreenCaptureStream(screenArea5);

            videoSourcePlayer5.VideoSource = FuentedeVideo5;
            videoSourcePlayer5.Start();
        }
        
        private void DesvincularTodo_Click(object sender, EventArgs e)
        {
            Estrategia.BackColor = Color.Black;

            videoSourcePlayer1.SignalToStop();
            videoSourcePlayer2.SignalToStop();
            videoSourcePlayer3.SignalToStop();
            videoSourcePlayer4.SignalToStop();
            videoSourcePlayer5.SignalToStop();
            Estrategia.Enabled = true;
            Estrategia.BackColor = SystemColors.Control;
            Estrategia.Enabled = false;

            Horario.Enabled = true;
            Horario.BackColor = Color.DarkOrange;
            Horario.Enabled = false;



        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            videoSourcePlayer1.SignalToStop();
            videoSourcePlayer2.SignalToStop();
            videoSourcePlayer3.SignalToStop();
            videoSourcePlayer4.SignalToStop();
            videoSourcePlayer5.SignalToStop();

        }
        



        //////////////////////////////////ANIMACIONES y ACTUALIZAR DATOS METODOS//////////////////////////////////////////

            

        public delegate void ControlStringConsumer(Control control, int text);  // defines a delegate type

        public void Refrescar(Control control, int text)
        {
            control.Invoke(new ControlStringConsumer(RegrescarGUI), new object[] { control, text });  // invoking another method
        }

        public void RegrescarGUI(Control control, int text)
        {
            if (text == 1)
            {
            this.videoSourcePlayer1.SignalToStop();
            this.videoSourcePlayer4.SignalToStop();      // the "functional part", acceptable only on the main thread

            }
            if (text == 2)
            {
                videoSourcePlayer1.VideoSource = FuentedeVideo1;
                videoSourcePlayer1.Start();
            }
            if (text == 3)
            {
                videoSourcePlayer4.VideoSource = FuentedeVideo4;
                videoSourcePlayer4.Start();
            }
        }

        //////////////////////////////BOTONES//////////////////////////////////////////////

            


        private void button3_Click(object sender, EventArgs e)
        {
            

            if (intercalar == 0)
            {
                 horaA = 0;
                 horaB = 24;
                 horaC = 0;
                 horaD = 24;
                 minutoA = 0;
                 minutoB = 60;

                Horario.Text = "SIN HORARIO";

                intercalar = 1;

            }
            else
            {
                horaA = horaA_;
                horaB = horaB_;
                horaC = horaC_;
                horaD = horaD_;
                minutoA = minutoA_;
                minutoB = minutoB_;

                Horario.Text = "CON HORARIO";

                intercalar = 0;
            }


        }


        

        ////////////////////////////////////////////////////////////////////////////

        public void HacerClickConHora(int cuadro)
        {
            int a = DateTime.Now.Hour;
            int b = DateTime.Now.Minute;
            
            if (((a >= horaA && a <= horaB)    ||    (a >= horaC && a <= horaD)))
            {
                if ((a == horaA && b >=minutoA)  ||  (a != horaA && a != horaB)   ||    (a == horaB && b <= minutoB))
                {



                    switch (cuadro)
                    {
                        case 1:
                            if (intercalarBinaria == 1)
                            {
                                resolucionAPLICADA = resolucionA;
                                estrategia_aplicada_A = estrategiaB;
                                estrategia_aplicada_B = estrategiaA;

                                cambioResolucion.Text = "Resolucion 1470";


                            }
                            else
                            {
                                resolucionAPLICADA = ResolucionB;
                                estrategia_aplicada_A = estrategiaB_;
                                estrategia_aplicada_B = estrategiaA_;

                                cambioResolucion.Text = "Resolucion 1810";

                            }

                            button2.Text = "Rebote a la Baja";//estrategia_aplicada_A.ToString();

                            
                            Cursor.Position = new System.Drawing.Point(resolucionAPLICADA, estrategia_aplicada_A);

                            EnviarClick(0, 0);
                            break;

                        case 2:
                            if (intercalarBinaria == 1)
                            {
                                resolucionAPLICADA = resolucionA;
                                estrategia_aplicada_A = estrategiaB;
                                estrategia_aplicada_B = estrategiaA;

                                cambioResolucion.Text = "Resolucion 1470";


                            }
                            else
                            {
                                resolucionAPLICADA = ResolucionB;
                                estrategia_aplicada_A = estrategiaB_;
                                estrategia_aplicada_B = estrategiaA_;

                                cambioResolucion.Text = "Resolucion 1810";

                            }

                            button2.Text = button2.Text = "Rebote a la Alta";//estrategia_aplicada_A.ToString();

                            Cursor.Position = new System.Drawing.Point(resolucionAPLICADA, estrategia_aplicada_B);

                            EnviarClick(0, 0);
                            break;

                        case 3:
                            if (intercalarBinaria == 1)
                            {
                                resolucionAPLICADA = resolucionA;
                                estrategia_aplicada_A = estrategiaA;
                                estrategia_aplicada_B = estrategiaB;

                                cambioResolucion.Text = "Resolucion 1470";


                            }
                            else
                            {
                                resolucionAPLICADA = ResolucionB;
                                estrategia_aplicada_A = estrategiaA_;
                                estrategia_aplicada_B = estrategiaB_;

                                cambioResolucion.Text = "Resolucion 1810";

                            }

                            button2.Text = "Tendencia a la ALTA";//estrategia_aplicada_A.ToString();
                            Cursor.Position = new System.Drawing.Point(resolucionAPLICADA, estrategia_aplicada_B);

                            EnviarClick(0, 0);

                            break;

                        case 4:
                            if (intercalarBinaria == 1)
                            {
                                resolucionAPLICADA = resolucionA;
                                estrategia_aplicada_A = estrategiaA;
                                estrategia_aplicada_B = estrategiaB;

                                cambioResolucion.Text = "Resolucion 1470";


                            }
                            else
                            {
                                resolucionAPLICADA = ResolucionB;
                                estrategia_aplicada_A = estrategiaA_;
                                estrategia_aplicada_B = estrategiaB_;

                                cambioResolucion.Text = "Resolucion 1810";

                            }

                            button2.Text = "Tendencia a la BAJA";//estrategia_aplicada_A.ToString();

                            Cursor.Position = new System.Drawing.Point(resolucionAPLICADA, estrategia_aplicada_A);

                            EnviarClick(0, 0);

                            break;

                        case 5:
                            EnviarClick(0, 0);
                            break;


                        default:
                            break;
                    }





                    
                }
                else
                {
                }

            }
            else
            {
            }

        }

        //////////////////////////TODO/////////////////////////////
        //
        //
        // Realizar una Captura de pantalla cada bez que se detecte movimiento y se Guarde Por Camara
        //
        // Hacer una captura de cada Frame Para Hacer Streaming, para minimisar recursos adjuntar los cuatro capturas en una sola imagen si es Posible, para solo enviar a Stremear una sola imagen y  no cuadtro.
        //
        // hacer un Login, para tener los Usuarios, que podrian ser Clientes.
        //
        ///////////////////////////////////////////////////////////



    

    }
}