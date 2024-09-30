using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDD_Abstract_HamTruuTuong
{
    internal class SinhvienBizz : Sinhvien
    {
        public double DiemkeToan;
        public double DiemmaKeting;
        public double DiembanHang;
        public override double getDiemTB()
        {
            return (DiemkeToan + DiemmaKeting + DiembanHang)/3;
        }

    }
}
