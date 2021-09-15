using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITE5231_RNA_FinalProject_JoesCafe {
  class BeverageDisplayRecordFactory : AbstractBeverageDisplayRecordFactory {
    private BeverageDisplayRecordFactory() { } // Private constructor
    private BeveragePanelPrototype prototype = new BeveragePanelPrototype(); // Prototype

    private static BeverageDisplayRecordFactory instance = null;

    public static AbstractBeverageDisplayRecordFactory GetInstance() {
      if (instance == null) {
        instance = new BeverageDisplayRecordFactory();
      }

      return instance;
    }

    override public BeveragePanelPrototype GetBeverageDisplayRecord() { // Factory Method
      // Deep-clone - We create a new instance of this (well staged) prototype object and return it
      return (BeveragePanelPrototype)prototype.Clone(); // Clone a prototype and return to the caller of factory method
    }
  }
}
