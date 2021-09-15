namespace ITE5231_RNA_FinalProject_JoesCafe {
  class AddonIterator : IIterator<Addon> {
    int CurrPosition;

    private AddonCollection addons;

    public AddonIterator(AddonCollection addons) {
      this.addons = addons;
      CurrPosition = 0;
    }

    public bool MoveNext() {
      CurrPosition++;
      if ((CurrPosition > 0) && (CurrPosition < addons.Count)) {
        return true;
      } else {
        return false;
      }
    }

    public Addon Current() {
      return addons.GetItem(CurrPosition);
    }
  }
}
