using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDD_Abstract_HamTruuTuong
{
    internal class SinhvienIT : Sinhvien
    {
        public double DiemJava;
        public double DiemCss;
        public override double getDiemTB()
        {
            return (2 * DiemJava + DiemCss)/3;
        }

    }
}

