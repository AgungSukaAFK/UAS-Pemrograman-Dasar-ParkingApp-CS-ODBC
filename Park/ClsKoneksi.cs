using Park;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Park

{
    internal class ClsKoneksi
    {
        public static OdbcCommand dml;
        public static OdbcDataReader dr;
        public static OdbcConnection koneksi;

        public void BukaKoneksi()
        {
            koneksi = new OdbcConnection("DSN=dbpendaftaran");
            koneksi.Open();
        }
    }
}

