namespace ITE5231_RNA_FinalProject_JoesCafe {
  class Item {
    public int ProductId { get; set; }
    public int AddonId { get; set; }
    public string Type { get; set; }
    public string Name { get; set; }
    public int Qty { get; set; }
    public double UnitPrice { get; set; }
    public double TotalPrice {
      get { return Qty * UnitPrice; }
    }
  }
}
