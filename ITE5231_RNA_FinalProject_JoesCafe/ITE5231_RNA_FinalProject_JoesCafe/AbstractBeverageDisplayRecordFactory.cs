namespace ITE5231_RNA_FinalProject_JoesCafe {
  abstract class AbstractBeverageDisplayRecordFactory {
    public static BeverageDisplayRecordFactory GetInstance() {
      return null;
    }

    abstract public BeveragePanelPrototype GetBeverageDisplayRecord();
  }
}
