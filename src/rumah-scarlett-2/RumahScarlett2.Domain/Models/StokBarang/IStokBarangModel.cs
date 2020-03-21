using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RumahScarlett2.Domain.Models.StokBarang
{
    public interface IStokBarangModel
    {
        int id { get; set; }
        int barang_id { get; set; }
        DateTime tanggal { get; set; }
        int stok_awal { get; set; }
        int barang_masuk { get; set; }
        int barang_keluar { get; set; }
        int stok_akhir { get; set; }
    }
}
