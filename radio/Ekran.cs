using System.Net.Http.Headers;
using NAudio.Wave;

namespace radio
{
    public partial class Ekran : Form
    {
        //deyiþkenler ayarlanýr biri çalma iþlemi diyeri veriyi okumak için kullanýlýr
        private WaveOutEvent wçýktý;
        private MediaFoundationReader mokuyucu;
        //eski url yi tutar
        private String esurl = "a";
        //önceden basýlýp basýlmadýðýna bakar
        private Boolean basýldý = false;
        public Ekran()
        {
            InitializeComponent();
        }

        //butona basma durumunda olacaklar
        private void s_s_Click(object sender, EventArgs e)
        {
            
            String urll = url.Text;
            try
            {
                if (!basýldý)
                {
                    if (esurl.Equals(urll))
                    {
                        //çalmaya baþlatýr
                        wçýktý.Play();
                    }
                    else
                    {
                        //yeni bir urele gelirse onu yükler
                        mokuyucu = new MediaFoundationReader(urll);
                        wçýktý = new WaveOutEvent();
                        wçýktý.Init(mokuyucu);
                        wçýktý.Play();
                    }
                    basýldý = true;
                }
                else
                {
                    //durdurma iþlemi
                    wçýktý.Stop();
                    basýldý = false;
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"bir hata var :\n {ex.Message}","hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
        private void kapat(object sender,FormClosingEventArgs e) 
        {
                wçýktý?.Stop();
                wçýktý?.Dispose();
                mokuyucu?.Dispose();
            
        }
    }
}
