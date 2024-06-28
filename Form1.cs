using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klass
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
          
        InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {  
            BtnHakem.Visible = false;
            pictureBoxAt1.Visible = false;
            pictureBoxAt2.Visible = false;
            pictureBoxAt3.Visible = false;
            pictureBoxAt4.Visible = false;
            pictureBoxat5.Visible = false;
            pictureBoxat6.Visible = false;
            pictureBox8.Visible = true;
            progressBar2.Visible = false;
            progressBar3.Visible = false;


        }   
        System.Media.SoundPlayer kosusesi = new System.Media.SoundPlayer();
        System.Media.SoundPlayer atsesii = new System.Media.SoundPlayer();
        System.Media.SoundPlayer düdüksesii = new System.Media.SoundPlayer();
        Thread th1, th2, th3;
        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form.CheckForIllegalCrossThreadCalls = false;           
            th1 = new Thread(new ThreadStart(Work1));
            th2 = new Thread(new ThreadStart(Work2));
            th3 = new Thread(new ThreadStart(Work3));
            th3.Start();
            th1.Start();
            th2.Start();
            pictureBoxAt1.Visible = true;
            pictureBoxAt2.Visible = true;
            pictureBoxAt3.Visible = true;
            pictureBoxAt4.Visible = true;
            pictureBoxat5.Visible = true;
            pictureBoxat6.Visible = true;
            pictureBoxatÖnyüzler.Visible = false;
            timer1.Interval = 1000;
            timer2.Interval = 1000;
            timer1.Enabled = true;
            btnbasla.Left += 40;
            lblbasla.Text = "Basla";
            pictureBox8.Left -= 100;
            pictureBox8.Visible = false;
         
        }
        int sayac=0;
        int a;
        Random rd = new Random();
        private void Work1()//düdüksesi
        {

            while (progressBar2.Value < 100)
            {
                if (progressBar2.Value > 100)
                {

                    break;

                }
                else
                {
                    time++;
                    progressBar2.Value += 50;
                    label1.Text = "%" + time + " Tamamlandı.Lütfen Bekleyin";
                     Thread.Sleep(100);

                }

            }

            düdüksesii.SoundLocation = "düdüksesi.wav";
            düdüksesii.Play();

        }
        private void Work3()//kosusesi
        {
            time++;

            while (progressBar3.Value < 100)
            {

                if (progressBar3.Value > 100)
                {

                    break;

                }
                else
                {

                    progressBar3.Value += 1;
                    label3.Text = "%" + time + " Tamamlandı.Lütfen Bekleyin";
                   // Thread.Sleep(90);
                }

            }
            kosusesi.SoundLocation = "kosusesi.wav";
            kosusesi.Play();
        }
        private void Work2()//at sesi
        {
            while (progressBar1.Value < 100)
            {

                if (progressBar1.Value > 100)
                {

                    break;

                }
                else
                {
                    time++;
                    progressBar1.Value += 1;
                    label1.Text = "%" + time + " Tamamlandı.Lütfen Bekleyin";
                   // Thread.Sleep(60);

                }

            }

            atsesii.SoundLocation = "atsesi.wav";
            atsesii.Play();

        }
       
        int time = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {

           
            lblbasla.Visible = false;
            btnbasla.Visible = false;
            a = a + 15;
            pictureBox7.Left += a;
            sayac++;
            label2.Text = sayac.ToString();
            pictureBoxAt1.Left += rd.Next(1, 100);
            pictureBoxAt2.Left += rd.Next(1, 100);
            pictureBoxAt3.Left += rd.Next(1, 100);
            pictureBoxAt4.Left += rd.Next(1, 100);
            pictureBoxat5.Left += rd.Next(1, 100);
            pictureBox7.Left += rd.Next(1, 100);
            pictureBoxat6.Left += rd.Next(1, 100);
            pictureBoxatÖnyüzler.Left += rd.Next(1, 100);
           
            if (sayac>2)
            {
                
                düdüksesii.Stop();
               
            }
            if (sayac >2 && sayac <= 9)
            {
           
                if (pictureBoxAt1.Left > pictureBoxAt2.Left && pictureBoxAt1.Left > pictureBoxAt3.Left && pictureBoxAt1.Left > pictureBoxAt4.Left && pictureBoxAt1.Left > pictureBoxat5.Left && pictureBoxAt1.Left > pictureBoxat6.Left)
                {
                    label3.Text = "Birinci At Yarışı Önde Götürüyor Sayın Seyirciler..";
                }
                if (pictureBoxAt2.Left > pictureBoxAt3.Left && pictureBoxAt2.Left > pictureBoxAt1.Left && pictureBoxAt2.Left > pictureBoxAt4.Left && pictureBoxAt2.Left > pictureBoxat5.Left && pictureBoxAt2.Left > pictureBoxat6.Left)
                {
                    label3.Text = "ikinci At Yarışı Önde Götürüyor Sayın Seyirciler..";
                }
                if (pictureBoxAt3.Left > pictureBoxAt2.Left && pictureBoxAt3.Left > pictureBoxAt1.Left && pictureBoxAt3.Left > pictureBoxAt4.Left && pictureBoxAt3.Left > pictureBoxat5.Left && pictureBoxAt3.Left > pictureBoxat6.Left)
                {
                    label3.Text = "Üçüncü At Geçti Öne Sayın Seyirciler..";
                }
                if (pictureBoxAt4.Left > pictureBoxAt1.Left && pictureBoxAt4.Left > pictureBoxAt2.Left && pictureBoxAt4.Left > pictureBoxAt3.Left && pictureBoxAt4.Left > pictureBoxat5.Left && pictureBoxAt4.Left > pictureBoxat6.Left)
                {
                    label3.Text = "Dördüncü At Önde Götürüyor.. ";
                }
                if (pictureBoxat5.Left > pictureBoxAt1.Left && pictureBoxat5.Left > pictureBoxAt2.Left && pictureBoxat5.Left > pictureBoxAt3.Left && pictureBoxat5.Left > pictureBoxAt4.Left && pictureBoxat5.Left > pictureBoxat6.Left)
                {
                    label3.Text = "beşinci at yarışı önde götürüyor sayın sayirciler";
                }
                if (pictureBoxat6.Left > pictureBoxAt1.Left && pictureBoxat6.Left > pictureBoxAt2.Left && pictureBoxat6.Left > pictureBoxAt3.Left && pictureBoxat6.Left > pictureBoxAt4.Left && pictureBoxat6.Left > pictureBoxat5.Left)
                {
                    label3.Text = "Altıncı at yarışı önde götürüyor sayın sayirciler";
                }

            }
            if (sayac>7&& sayac<=9)
            {
                if (pictureBoxAt1.Left > pictureBoxAt2.Left && pictureBoxAt1.Left > pictureBoxAt3.Left && pictureBoxAt1.Left > pictureBoxAt4.Left && pictureBoxAt1.Left > pictureBoxat5.Left && pictureBoxAt1.Left > pictureBoxat6.Left)
                {
                    label3.Text = "Birinci At Yarışı Önde Götürüyor Sayın Seyirciler..";
                }
                if (pictureBoxAt2.Left > pictureBoxAt3.Left && pictureBoxAt2.Left > pictureBoxAt1.Left && pictureBoxAt2.Left > pictureBoxAt4.Left && pictureBoxAt2.Left > pictureBoxat5.Left && pictureBoxAt2.Left > pictureBoxat6.Left)
                {
                    label3.Text = "ikinci At Yarışı Önde Götürüyor Sayın Seyirciler..";
                }
                if (pictureBoxAt3.Left > pictureBoxAt2.Left && pictureBoxAt3.Left > pictureBoxAt1.Left && pictureBoxAt3.Left > pictureBoxAt4.Left && pictureBoxAt3.Left > pictureBoxat5.Left && pictureBoxAt3.Left > pictureBoxat6.Left)
                {
                    label3.Text = "Üçüncü At Geçti Öne Sayın Seyirciler..";
                }
                if (pictureBoxAt4.Left > pictureBoxAt1.Left && pictureBoxAt4.Left > pictureBoxAt2.Left && pictureBoxAt4.Left > pictureBoxAt3.Left && pictureBoxAt4.Left > pictureBoxat5.Left && pictureBoxAt4.Left > pictureBoxat6.Left)
                {
                    label3.Text = "Dördüncü At Önde Götürüyor.. ";
                }
                if (pictureBoxat5.Left > pictureBoxAt1.Left && pictureBoxat5.Left > pictureBoxAt2.Left && pictureBoxat5.Left > pictureBoxAt3.Left && pictureBoxat5.Left > pictureBoxAt4.Left && pictureBoxat5.Left > pictureBoxat6.Left)
                {
                    label3.Text = "beşinci at yarışı önde götürüyor sayın sayirciler";
                }
                if (pictureBoxat6.Left > pictureBoxAt1.Left && pictureBoxat6.Left > pictureBoxAt2.Left && pictureBoxat6.Left > pictureBoxAt3.Left && pictureBoxat6.Left > pictureBoxAt4.Left && pictureBoxat6.Left > pictureBoxat5.Left)
                {
                    label3.Text = "Altıncı at yarışı önde götürüyor sayın sayirciler";
                }

            }
            if (sayac >10 && sayac <= 11)
            {
               
              //  kosusesi.Stop();
                //düdüksesii.Play();
            }
            if (sayac > 11 && sayac <=12)
            {
               // atsesii.Play();
            }
            if (sayac > 12 && sayac <=16 )
            {
                
                pictureBoxatÖnyüzler.Visible = true;
                pictureBoxAt1.Visible = false;
                pictureBoxAt2.Visible = false;
                pictureBoxAt3.Visible = false;
                pictureBoxAt4.Visible = false;
                pictureBoxat5.Visible = false;
                pictureBox7.Visible = false;
                pictureBoxat6.Visible = false;
             if (pictureBoxAt1.Left > pictureBoxAt2.Left && pictureBoxAt1.Left > pictureBoxAt3.Left && pictureBoxAt1.Left > pictureBoxAt4.Left && pictureBoxAt1.Left > pictureBoxat5.Left && pictureBoxAt1.Left > pictureBoxat6.Left)
                {
                    label3.Text = " Birinci At Yarışı Önde Götürüyor Sayın Seyirciler..";
                    lblbasla.Visible = false;

                }
              if (pictureBoxAt2.Left > pictureBoxAt3.Left && pictureBoxAt2.Left > pictureBoxAt1.Left && pictureBoxAt2.Left > pictureBoxAt4.Left && pictureBoxAt2.Left > pictureBoxat5.Left && pictureBoxAt2.Left > pictureBoxat6.Left)
                {
                    label3.Text = "ikinci  At Yarışı Önde Götürüyor Sayın Seyirciler..";
                    lblbasla.Visible = false;

                }
              if (pictureBoxAt3.Left > pictureBoxAt2.Left && pictureBoxAt3.Left > pictureBoxAt1.Left && pictureBoxAt3.Left > pictureBoxAt4.Left && pictureBoxAt3.Left > pictureBoxat5.Left && pictureBoxAt3.Left > pictureBoxat6.Left)
                {
                    label3.Text = "Üçüncü At Geçti Öne Sayın Seyirciler..";
                    lblbasla.Visible = false;

                }
              if (pictureBoxAt4.Left > pictureBoxAt1.Left && pictureBoxAt4.Left > pictureBoxAt2.Left && pictureBoxAt4.Left > pictureBoxAt3.Left && pictureBoxAt4.Left > pictureBoxat5.Left && pictureBoxAt4.Left > pictureBoxat6.Left)
                {
                    label3.Text = "Dördüncü At Önde Götürüyor.. ";
                    lblbasla.Visible = false;

                }
               if (pictureBoxat5.Left > pictureBoxAt1.Left && pictureBoxat5.Left > pictureBoxAt2.Left && pictureBoxat5.Left > pictureBoxAt3.Left && pictureBoxat5.Left > pictureBoxAt4.Left && pictureBoxat5.Left > pictureBoxat6.Left)
                {
                    label3.Text = "şimdi beşinci at yarışı önde götürüyor sayın sayirciler";
                    lblbasla.Visible = false;

                }
                if (pictureBoxat6.Left > pictureBoxAt1.Left && pictureBoxat6.Left > pictureBoxAt2.Left && pictureBoxat6.Left > pictureBoxAt3.Left && pictureBoxat6.Left > pictureBoxAt4.Left && pictureBoxat6.Left > pictureBoxat5.Left)
                {
                    label3.Text = "altıcı at yarışı önde götürüyor sayın sayirciler";
                    lblbasla.Visible = false;

                }
                if (pictureBoxAt1.Left > ClientSize.Width)
                {

                    atsesii.Stop();
                    timer1.Stop();
                    timer1.Enabled = false;
                    timer2.Enabled = true;
                    label3.Text = "Birinci at Kasırga kazandı bravo KASIRGA..";
                    BtnHakem.Visible = true;
                    BtnHakem.Text = "Kasırga kazandı";
                }
                if (pictureBoxAt2.Left > ClientSize.Width)
                {

                    atsesii.Stop();
                    timer1.Stop();
                    timer1.Enabled = false;
                    timer2.Enabled = true;
                    label3.Text = "İkinci Fırtına at kazandı bravo yarışı Fırtına kazandı..";
                    BtnHakem.Visible = true;
                    BtnHakem.Text = "Fırtına kazandı";
                }
                if (pictureBoxAt3.Left > ClientSize.Width)
                {

                    atsesii.Stop();
                    timer1.Stop();
                    timer1.Enabled = false;
                    timer2.Enabled = true;
                    label3.Text = "Üçüncü at Atılgan kazandı yarışı Atılgan kazandı..";
                    BtnHakem.Visible = true;
                    BtnHakem.Text = "Atılgan kazandı";
                }
                if (pictureBoxAt4.Left > ClientSize.Width)
                {

                    atsesii.Stop();
                    timer1.Stop();
                    timer1.Enabled = false;
                    timer2.Enabled = true;
                    label3.Text = "Dördüncü Efsane at kazandı bravo Efsane yarışı kazandı..";
                    BtnHakem.Visible = true;
                    BtnHakem.Text = "Efsane kazandı";

                }
                if (pictureBoxat5.Left > ClientSize.Width)
                {

                    atsesii.Stop();
                    timer1.Stop();
                    timer1.Enabled = false;
                    timer2.Enabled = true;
                    label3.Text = "Beşinci Karayel at kazandı BRAVO KARAYEL..";
                    BtnHakem.Text = "Karayel Kazandı";
                    BtnHakem.Visible = true;
                }
                if (pictureBoxat6.Left > ClientSize.Width)
                {

                    atsesii.Stop();
                    timer1.Stop();
                    timer1.Enabled = false;
                    timer2.Enabled = true;
                    label3.Text = "altıncı at kazandı BOLD PİLOT..";
                    BtnHakem.Text = "Karayel Kazandı";
                    BtnHakem.Visible = true;
                }
            }
            if (sayac >16)
            {
                pictureBoxatÖnyüzler.Height = 660;                
                pictureBoxatÖnyüzler.Width = 280;
            }
           
            if (sayac >19 && sayac < 30)
            {

                pictureBoxAt2.Width = 180;
                pictureBoxAt2.Height = 108;
                pictureBoxAt3.Width = 180;
                pictureBoxAt3.Height = 108;
                pictureBoxAt4.Width = 180;
                pictureBoxAt4.Height = 108;
                pictureBoxat5.Width = 180;
                pictureBoxat5.Height = 108;
                pictureBoxat6.Width = 180;
                pictureBoxat6.Height = 108;
                pictureBoxAt1.Visible = true;
                pictureBoxAt2.Visible = true;
                pictureBoxAt3.Visible = true;
                pictureBoxAt4.Visible = true;
                pictureBoxat5.Visible = true;
                pictureBox7.Visible = true;
                pictureBoxat6.Visible = true;
                pictureBoxatÖnyüzler.Visible = false;

                if (pictureBoxAt1.Left > pictureBoxAt2.Left && pictureBoxAt1.Left > pictureBoxAt3.Left && pictureBoxAt1.Left > pictureBoxAt4.Left && pictureBoxAt1.Left > pictureBoxat5.Left && pictureBoxAt1.Left > pictureBoxat6.Left)
                {
                    label3.Text = " Birinci At Yarışı Önde Götürüyor Sayın Seyirciler..";
                    lblbasla.Visible = false;
                }
                if (pictureBoxAt2.Left > pictureBoxAt3.Left && pictureBoxAt2.Left > pictureBoxAt1.Left && pictureBoxAt2.Left > pictureBoxAt4.Left && pictureBoxAt2.Left > pictureBoxat5.Left && pictureBoxAt2.Left > pictureBoxat6.Left)
                {
                    label3.Text = "ikinci  At Yarışı Önde Götürüyor Sayın Seyirciler..";
                    lblbasla.Visible = false;
                }
                if (pictureBoxAt3.Left > pictureBoxAt2.Left && pictureBoxAt3.Left > pictureBoxAt1.Left && pictureBoxAt3.Left > pictureBoxAt4.Left && pictureBoxAt3.Left > pictureBoxat5.Left && pictureBoxAt3.Left > pictureBoxat6.Left)
                {
                    label3.Text = "Üçüncü At Geçti Öne Sayın Seyirciler..";
                    lblbasla.Visible = false;
                }
                if (pictureBoxAt4.Left > pictureBoxAt1.Left && pictureBoxAt4.Left > pictureBoxAt2.Left && pictureBoxAt4.Left > pictureBoxAt3.Left && pictureBoxAt4.Left > pictureBoxat5.Left && pictureBoxAt4.Left > pictureBoxat6.Left)
                {
                    label3.Text = "Dördüncü At Önde Götürüyor.. ";
                    lblbasla.Visible = false;
                }
                if (pictureBoxat5.Left > pictureBoxAt1.Left && pictureBoxat5.Left > pictureBoxAt2.Left && pictureBoxat5.Left > pictureBoxAt3.Left && pictureBoxat5.Left > pictureBoxAt4.Left && pictureBoxat5.Left > pictureBoxat6.Left)
                {
                    label3.Text = "şimdi beşinci at yarışı önde götürüyor sayın sayirciler";
                    lblbasla.Visible = false;
                }
                if (pictureBoxat6.Left > pictureBoxAt1.Left && pictureBoxat6.Left > pictureBoxAt2.Left && pictureBoxat6.Left > pictureBoxAt3.Left && pictureBoxat6.Left > pictureBoxAt4.Left && pictureBoxat6.Left > pictureBoxat5.Left)
                {
                    label3.Text = "altıcı at yarışı önde götürüyor sayın sayirciler";
                    lblbasla.Visible = false;
                }

                if (pictureBoxAt1.Left > ClientSize.Width)
                {

                    atsesii.Stop();
                    timer1.Stop();
                    timer1.Enabled = false;
                    timer2.Enabled = true;
                    label3.Text = "Birinci at Kasırga kazandı bravo KASIRGA..";
                    BtnHakem.Visible = true;
                    BtnHakem.Text = "Kasırga kazandı";
                    timer1.Enabled = false;

                }
                if (pictureBoxAt2.Left > ClientSize.Width)
                {
                    atsesii.Stop();
                    timer1.Enabled = false;
                    timer2.Enabled = true;
                    label3.Text = "İkinci Fırtına at kazandı bravo yarışı Fırtına kazandı..";
                    BtnHakem.Visible = true;
                    BtnHakem.Text = "Fırtına kazandı";

                }
                if (pictureBoxAt3.Left > ClientSize.Width)
                {

                    atsesii.Stop();
                    timer1.Stop();
                    timer1.Enabled = false;
                    timer2.Enabled = true;
                    label3.Text = "Üçüncü at Atılgan kazandı yarışı Atılgan kazandı..";
                    BtnHakem.Visible = true;
                    BtnHakem.Text = "Atılgan kazandı";

                }
                if (pictureBoxAt4.Left > ClientSize.Width)
                {

                    atsesii.Stop();
                    atsesii.Stop();
                    timer1.Stop();
                    timer1.Enabled = false;
                    timer2.Enabled = true;
                    label3.Text = "Dördüncü Efsane at kazandı bravo Efsane yarışı kazandı..";
                    BtnHakem.Visible = true;
                    BtnHakem.Text = "Efsane kazandı";

                }
                if (pictureBoxat5.Left > ClientSize.Width)
                {

                    atsesii.Stop();
                    timer1.Stop();
                    timer1.Enabled = false;
                    timer2.Enabled = true;
                    label3.Text = "Beşinci Karayel at kazandı BRAVO KARAYEL..";
                    BtnHakem.Text = "Karayel Kazandı";
                    BtnHakem.Visible = true;

                }
                if (pictureBoxat6.Left > ClientSize.Width)
                {

                    ////atsesii.Stop();
                    timer1.Stop();
                    timer1.Enabled = false;
                    timer2.Enabled = true;
                    label3.Text = "Altıncı at kazandı BRAVO Bold Pilot..";
                    BtnHakem.Text = "Bold Pilot Kazandı";
                    BtnHakem.Visible = true;

                }
            }
        }

        private void progressBar3_Click(object sender, EventArgs e)
        {

        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Enabled = false;
      
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBoxAt1.Left += rd.Next(1, 100);
            pictureBoxAt2.Left += rd.Next(1, 100);
            pictureBoxAt3.Left += rd.Next(1, 100);
            pictureBoxAt4.Left += rd.Next(1, 100);
            pictureBoxat5.Left += rd.Next(1, 100);
            pictureBox7.Left += rd.Next(1, 100);
            pictureBoxat6.Left += rd.Next(1, 100);
        }

                             
    }
}