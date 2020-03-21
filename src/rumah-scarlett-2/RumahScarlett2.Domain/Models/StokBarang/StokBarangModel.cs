using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RumahScarlett2.Domain.Models.StokBarang
{
    [Table("stok_barang")]
    public class StokBarangModel : IStokBarangModel
    {
        [Browsable(false)]
        [Display(Name = "ID")]
        public int id { get; set; }

        [Browsable(false)]
        [Range(1, uint.MaxValue, ErrorMessage = "Barang harus diisi !!!")]
        [Display(Name = "Barang ID")]
        public int barang_id { get; set; }

        [DisplayFormat(DataFormatString = "dd/MM/yyyy")]
        [Display(Name = "Tanggal")]
        public DateTime tanggal { get; set; }
        
        [DisplayFormat(DataFormatString = "{0:N0}")]
        [DefaultValue(0)]
        [Display(Name = "Stok Awal")]
        public int stok_awal { get; set; }
        
        [DisplayFormat(DataFormatString = "{0:N0}")]
        [DefaultValue(0)]
        [Display(Name = "Barang Masuk")]
        public int barang_masuk { get; set; }

        [DisplayFormat(DataFormatString = "{0:N0}")]
        [DefaultValue(0)]
        [Display(Name = "Barang Keluar")]
        public int barang_keluar { get; set; }

        [DisplayFormat(DataFormatString = "{0:N0}")]
        [DefaultValue(0)]
        [Display(Name = "Stok Akhir")]
        public int stok_akhir { get; set; }
    }
}
