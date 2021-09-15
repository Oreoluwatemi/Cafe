using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE5231_RNA_FinalProject_JoesCafe {
  class AddonCollection : IAggregate<Addon> {
    private List<Addon> Addons;

    public AddonCollection() {
      Addons = new List<Addon>();
    }

    public int Count {
      get { return Addons.Count; }
    }

    public void Remove(Addon addon) {
      Addons.Remove(addon);
    }

    public void Add(Addon addon) {
      Addons.Add(addon);
    }

    public Addon GetItem(int index) {
      return Addons[index];
    }

    public Addon this[int key] {
      get => Addons[key];
      set => Addons[key] = value;
    }

    public List<Addon> ToList() {
      return Addons;
    }

    IIterator<Addon> IAggregate<Addon>.CreateIterator() {
      return new AddonIterator(this);

    }
  }
}
