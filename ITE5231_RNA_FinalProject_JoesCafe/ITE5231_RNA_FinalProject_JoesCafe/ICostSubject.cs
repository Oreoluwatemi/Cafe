using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE5231_RNA_FinalProject_JoesCafe {
  interface ICostSubject {
    void Register(IGrandTotalObserver observer);
    void Remove(IGrandTotalObserver observer);
    void Notify();
  }
}
