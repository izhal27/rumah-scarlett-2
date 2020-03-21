using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RumahScarlett2.Domain.Models.Barang
{
    public interface IBarangModel
    {
        int id { get; set; }
        string nama { get; set; }
        int tipe_id { get; set; }
        int stok_akhir { get; set; }
        string keterangan { get; set; }
    }
}
