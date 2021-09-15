using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace ITE5231_RNA_FinalProject_JoesCafe {
  class Product {

    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public string ImageType { get; set; }
    public Bitmap ProductImage { get; set; }
  }
}
