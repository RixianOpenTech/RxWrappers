using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Collections
{
    public static class __StructuralComparisons
    {
        public static IObservable<System.Collections.IComparer> get_StructuralComparer()
        {
            return ObservableExt.Factory(() => System.Collections.StructuralComparisons.StructuralComparer);
        }


        public static IObservable<System.Collections.IEqualityComparer> get_StructuralEqualityComparer()
        {
            return ObservableExt.Factory(() => System.Collections.StructuralComparisons.StructuralEqualityComparer);
        }
    }
}