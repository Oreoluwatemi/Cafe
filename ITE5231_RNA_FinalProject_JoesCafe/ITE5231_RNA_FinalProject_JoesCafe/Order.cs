using System;
using System.Collections.Generic;

namespace ITE5231_RNA_FinalProject_JoesCafe {
  // We want to compare Order objects just based on Id.
  // Since we are using them in Sorted Dictionary - For FIFO (Queue) Serving Order algorithm

  class Order : IComparable<Order> {
    public int Id { get; set; }
    public int UserId { get; set; }
    public DateTime OrderDate { get; set; }
    public DateTime DeliveryDate { get; set; }
    public double OrderAmount { get; set; }

    public int CompareTo(Order other) {
      return Id - other.Id;
    }

    public bool Equals(Order other) {
      if (other == null) return false;
      if (this.Id == other.Id) return true;

      return false;
    }

    public override bool Equals(Object obj) {
      if (obj == null)
        return false;

      Order orderObj = obj as Order;
      if (orderObj == null) return false;
      else return Equals(orderObj);
    }

    public override int GetHashCode() {
      return this.Id.GetHashCode();
    }
  }
}
