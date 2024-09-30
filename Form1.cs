namespace HDD_Abstract_HamTruuTuong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_IT_Click(object sender, EventArgs e)
        {
            SinhvienIT sinhvienIT = new SinhvienIT();
            sinhvienIT.DiemJava = double.Parse(txt_Java.Text);
            sinhvienIT.DiemCss = double.Parse(txt_Css.Text);
            MessageBox.Show(sinhvienIT.getDiemTB().ToString() + " " + sinhvienIT.xepLoai());
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            SinhvienBizz sinhvienBizz = new SinhvienBizz();
            sinhvienBizz.DiemkeToan = double.Parse(txt_KT.Text);
            sinhvienBizz.DiemmaKeting = double.Parse(txt_MKTing.Text);
            sinhvienBizz.DiembanHang = double.Parse(txt_Bhang.Text);
            MessageBox.Show(sinhvienBizz.getDiemTB().ToString() +" "+ sinhvienBizz.xepLoai());
        }
    }
}
