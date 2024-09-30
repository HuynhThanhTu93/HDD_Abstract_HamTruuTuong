using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDD_Abstract_HamTruuTuong
{
    abstract internal class Sinhvien
    {
        public string hoTen;
        abstract public double getDiemTB();
        public virtual string xepLoai()
        {
            if (getDiemTB() > 5 && getDiemTB() < 7)
            {
                return "Khá";
            }
            else if (getDiemTB() > 7)
            {
                return "Gioi";
            }
            else
            {
                {
                    return "Yeu";
                }

            }return "Kem";

        }
      
    }
}
