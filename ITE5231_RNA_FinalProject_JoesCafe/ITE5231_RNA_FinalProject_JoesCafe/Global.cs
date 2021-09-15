namespace ITE5231_RNA_FinalProject_JoesCafe {
  public class Global {
    private FrmRegisterNewCustomer registerNewCustomerForm = new FrmRegisterNewCustomer();
    private FrmCustomerScreen customerScreen = new FrmCustomerScreen();
    private FrmChefScreen chefScreen = new FrmChefScreen();
    private FrmJoesCafeMain mainForm = new FrmJoesCafeMain();

    private static Global instance = null;

    public static Global GetInstance() {
      if (instance == null) {
        instance = new Global();
      }

      return instance;
    }

    public FrmRegisterNewCustomer RegisterNewCustomerForm {
      get { return registerNewCustomerForm; }
    }

    public FrmCustomerScreen CustomerScreen {
      get { return customerScreen; }
    }

    public FrmChefScreen ChefScreen {
      get { return chefScreen; }
    }

    public FrmJoesCafeMain MainForm {
      get { return mainForm; }
    }
  }
}
