using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RumahScarlett2.Domain.Models.TipeBarang
{
    [Table("tipe_barang")]
    public class TipeBarangModel : ITipeBarangModel
    {
        [Browsable(false)]
        [Display(Name = "ID")]
        public int id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Nama tipe harus diisi !!!")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Nama tipe harus diantara 3 sampai 100 karakter !!!")]
        [Display(Name = "Nama")]
        public string nama { get; set; }

        [DefaultValue("")]
        [StringLength(255, ErrorMessage = "Panjang maksimal keterangan 255 karakter !!!")]
        [Display(Name = "Keterangan")]
        public string keterangan { get; set; }
    }
}
