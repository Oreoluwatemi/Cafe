using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE5231_RNA_FinalProject_JoesCafe {
  class OrderItemAddon {
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public int AddonId { get; set; }
    public double UnitPrice { get; set; }
    public int Qty { get; set; }
  }
}
