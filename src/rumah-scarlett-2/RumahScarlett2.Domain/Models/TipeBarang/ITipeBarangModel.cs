using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RumahScarlett2.Domain.Models.TipeBarang
{
    public interface ITipeBarangModel
    {
        int id { get; set; }
        string nama { get; set; }
        string keterangan { get; set; }
    }
}
