using System.Net.Http.Headers;
using NAudio.Wave;

namespace radio
{
    public partial class Ekran : Form
    {
        //deyi�kenler ayarlan�r biri �alma i�lemi diyeri veriyi okumak i�in kullan�l�r
        private WaveOutEvent w��kt�;
        private MediaFoundationReader mokuyucu;
        //eski url yi tutar
        private String esurl = "a";
        //�nceden bas�l�p bas�lmad���na bakar
        private Boolean bas�ld� = false;
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
                if (!bas�ld�)
                {
                    if (esurl.Equals(urll))
                    {
                        //�almaya ba�lat�r
                        w��kt�.Play();
                    }
                    else
                    {
                        //yeni bir urele gelirse onu y�kler
                        mokuyucu = new MediaFoundationReader(urll);
                        w��kt� = new WaveOutEvent();
                        w��kt�.Init(mokuyucu);
                        w��kt�.Play();
                    }
                    bas�ld� = true;
                }
                else
                {
                    //durdurma i�lemi
                    w��kt�.Stop();
                    bas�ld� = false;
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"bir hata var :\n {ex.Message}","hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
        private void kapat(object sender,FormClosingEventArgs e) 
        {
                w��kt�?.Stop();
                w��kt�?.Dispose();
                mokuyucu?.Dispose();
            
        }
    }
}
