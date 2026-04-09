using System.Diagnostics.Eventing.Reader;
using static System.Windows.Forms.DataFormats;

namespace Sınav_Hesaplayıcı_Programı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hesapla_Click(object sender, EventArgs e)
        {
            try
            {
                int vizenotu = Convert.ToInt32(textVize.Text);
                int finalnotu = Convert.ToInt32(textFinal.Text);
                int sonuc = (vizenotu * 40 / 100) + (finalnotu * 60 / 100);

                if (vizenotu < 0 || vizenotu > 100 || finalnotu < 0 || finalnotu > 100)
                {
                    throw new ArithmeticException("Lütfen 0 ile 100 arasında bir not giriniz.");
                }

                if (finalnotu < 35)
                {
                    lblHarfNotu.Text = "Finalinizin 35 altında kalması sebebiyle dersten kaldınız.";
                    this.BackColor = Color.DarkRed;
                }
                else
                {
                    switch (sonuc)
                    {

                        case (>= 80):
                            lblHarfNotu.Text = "AA notu alarak dersi başarılıyla geçtiniz";
                            this.BackColor = Color.Green;
                            break;
                        case (>= 70):
                            lblHarfNotu.Text = "BA notu alarak dersi başarılıyla geçtiniz";
                            this.BackColor = Color.Green;
                            break;
                        case (>= 65):
                            lblHarfNotu.Text = "BB notu alarak dersi başarılıyla geçtiniz";
                            this.BackColor = Color.Green;
                            break;
                        case (>= 55):
                            lblHarfNotu.Text = "CB notu alarak dersi başarılıyla geçtiniz";
                            this.BackColor = Color.Green;
                            break;
                        case (>= 45):
                            lblHarfNotu.Text = "CC notu alarak dersi başarılıyla geçtiniz";
                            this.BackColor = Color.Green;
                            break;
                        case (>= 40):
                            lblHarfNotu.Text = "DC notu alarak sorumlu geçtiniz";
                            this.BackColor = Color.Gray;
                            break;
                        case (>= 35):
                            lblHarfNotu.Text = "DD notu alarak sorumlu geçtiniz";
                            this.BackColor = Color.Gray;
                            break;
                        case (< 35):
                            lblHarfNotu.Text = "FF notu alarak kaldınız";
                            this.BackColor = Color.DarkRed;
                            break;
                        default:
                            lblHarfNotu.Text = "Lütfen geçerli bir not giriniz";
                            this.BackColor = Color.White;
                            break;




                    }
                }
            }

            catch (FormatException exFormat)
            {
                MessageBox.Show("Lütfen geçerli bir not giriniz. Hata: " + exFormat.Message);
                this.BackColor = Color.White;
            }
            catch (OverflowException exOverFlow)
            {
                MessageBox.Show(exOverFlow.Message);
                MessageBox.Show(exOverFlow.ToString());
            }
            catch (ArithmeticException exArithmetic)
            {
                MessageBox.Show(exArithmetic.Message);
                this.BackColor = Color.White;
            }

           catch (Exception ex)
            {
                MessageBox.Show("Beklenmeyen bir hata oluştu: " + ex.Message);
                this.BackColor = Color.White;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
