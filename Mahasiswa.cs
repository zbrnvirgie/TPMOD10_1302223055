using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMOD10_1302223055
{
    public class Mahasiswa
    {
        public int Id { get; set; }
        private String? nama { get; set; }
        private String? nim { get; set; }

        public String? Nama
        {
            get { return nama; }
            set { nama = value; }
        }

        public String? Nim
        {
            get { return nim; }
            set { nim = value; }
        }
    }
}
