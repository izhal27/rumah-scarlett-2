using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RumahScarlett2.Domain.Models.Barang
{
    [Table("barang")]
    public class BarangModel : IBarangModel
    {
        [Browsable(false)]
        [Display(Name = "ID")]
        public int id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Nama barang harus diisi !!!")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Nama barang harus diantara 5 sampai 100 karakter !!!")]
        [Display(Name = "Nama")]
        public string nama { get; set; }

        [Browsable(false)]
        [Range(1, uint.MaxValue, ErrorMessage = "Tipe barang harus diisi !!!")]
        [Display(Name = "Tipe ID")]
        public int tipe_id { get; set; }

        [DisplayFormat(DataFormatString = "{0:N0}")]
        [DefaultValue(0)]
        [Display(Name = "Stok Akhir")]
        public int stok_akhir { get; set; }
        
        [DefaultValue("")]
        [StringLength(255, ErrorMessage = "Panjang maksimal keterangan 255 karakter !!!")]
        [Display(Name = "Keterangan")]
        public string keterangan { get; set; }
    }
}
