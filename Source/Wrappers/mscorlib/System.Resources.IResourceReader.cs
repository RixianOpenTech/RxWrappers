using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Resources
{
    public static class __IResourceReader
    {
        
        public static IObservable<System.Reactive.Unit> Close(this IObservable<System.Resources.IResourceReader> IResourceReaderValue)
        {
            return Observable.Do(IResourceReaderValue, (IResourceReaderValueLambda) => IResourceReaderValueLambda.Close()).ToUnit();
        }


        public static IObservable<System.Collections.IDictionaryEnumerator> GetEnumerator(this IObservable<System.Resources.IResourceReader> IResourceReaderValue)
        {
            return Observable.Select(IResourceReaderValue, (IResourceReaderValueLambda) => IResourceReaderValueLambda.GetEnumerator());
        }

    }
}