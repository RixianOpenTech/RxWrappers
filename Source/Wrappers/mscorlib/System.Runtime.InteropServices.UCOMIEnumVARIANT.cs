using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices
{
    public static class __UCOMIEnumVARIANT
    {
        
        public static IObservable<System.Int32> Next(this IObservable<System.Runtime.InteropServices.UCOMIEnumVARIANT> UCOMIEnumVARIANTValue, IObservable<System.Int32> celt, IObservable<System.Int32> rgvar, IObservable<System.Int32> pceltFetched)
        {
            return Observable.Zip(UCOMIEnumVARIANTValue, celt, rgvar, pceltFetched, (UCOMIEnumVARIANTValueLambda, celtLambda, rgvarLambda, pceltFetchedLambda) => UCOMIEnumVARIANTValueLambda.Next(celtLambda, rgvarLambda, pceltFetchedLambda));
        }


        public static IObservable<System.Int32> Skip(this IObservable<System.Runtime.InteropServices.UCOMIEnumVARIANT> UCOMIEnumVARIANTValue, IObservable<System.Int32> celt)
        {
            return Observable.Zip(UCOMIEnumVARIANTValue, celt, (UCOMIEnumVARIANTValueLambda, celtLambda) => UCOMIEnumVARIANTValueLambda.Skip(celtLambda));
        }


        public static IObservable<System.Int32> Reset(this IObservable<System.Runtime.InteropServices.UCOMIEnumVARIANT> UCOMIEnumVARIANTValue)
        {
            return Observable.Select(UCOMIEnumVARIANTValue, (UCOMIEnumVARIANTValueLambda) => UCOMIEnumVARIANTValueLambda.Reset());
        }


        public static IObservable<System.Reactive.Unit> Clone(this IObservable<System.Runtime.InteropServices.UCOMIEnumVARIANT> UCOMIEnumVARIANTValue, IObservable<System.Int32> ppenum)
        {
            return ObservableExt.ZipExecute(UCOMIEnumVARIANTValue, ppenum, (UCOMIEnumVARIANTValueLambda, ppenumLambda) => UCOMIEnumVARIANTValueLambda.Clone(ppenumLambda));
        }

    }
}