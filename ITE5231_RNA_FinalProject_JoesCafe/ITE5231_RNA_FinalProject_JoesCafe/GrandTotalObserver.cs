using System;
using System.Collections.Generic;

namespace ITE5231_RNA_FinalProject_JoesCafe {
  class GrandTotalObserver : IGrandTotalObserver {
    public void Update() {
      // Global.GetInstance().CustomerScreen.displayGrandTotalOrderAmount();
      displayGrandTotalOrderAmount();
    }

    void displayGrandTotalOrderAmount() {
      Dictionary<int, List<Item>>[] productsSelectedForOrder = Global.GetInstance().CustomerScreen.productsSelectedForOrder;

      FrmCustomerScreen.grandTotalOrderAmount = 0.00;
      for (int i = 0; i < productsSelectedForOrder.Length; i++) {
        Dictionary<int, List<Item>> orderAmountForProduct = productsSelectedForOrder[i];
        if (orderAmountForProduct != null) {
          foreach (KeyValuePair<int, List<Item>> entry in orderAmountForProduct) {
            List<Item> orderList = entry.Value;
            for (int j = 0; j < orderList.Count; j++) {
              Item orderedItem = orderList[j];
              FrmCustomerScreen.grandTotalOrderAmount += orderedItem.TotalPrice;
            }
          }
        }
      }

      Global.GetInstance().CustomerScreen.lblActualGrandTotalAmount.Text = FrmCustomerScreen.grandTotalOrderAmount.ToString("N2");
      if (FrmCustomerScreen.grandTotalOrderAmount > 0.00) {
        Global.GetInstance().CustomerScreen.btnConfirmOrder.Enabled = true;
      } else {
        Global.GetInstance().CustomerScreen.btnConfirmOrder.Enabled = false;
      }
    }
  }
}
