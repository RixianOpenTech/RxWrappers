using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Resources
{
    public static class __ResourceReader
    {
        
        public static IObservable<System.Reactive.Unit> Close(this IObservable<System.Resources.ResourceReader> ResourceReaderValue)
        {
            return Observable.Do(ResourceReaderValue, (ResourceReaderValueLambda) => ResourceReaderValueLambda.Close()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> Dispose(this IObservable<System.Resources.ResourceReader> ResourceReaderValue)
        {
            return Observable.Do(ResourceReaderValue, (ResourceReaderValueLambda) => ResourceReaderValueLambda.Dispose()).ToUnit();
        }


        public static IObservable<System.Collections.IDictionaryEnumerator> GetEnumerator(this IObservable<System.Resources.ResourceReader> ResourceReaderValue)
        {
            return Observable.Select(ResourceReaderValue, (ResourceReaderValueLambda) => ResourceReaderValueLambda.GetEnumerator());
        }


        public static IObservable<Tuple<System.String, System.Byte[]>> GetResourceData(this IObservable<System.Resources.ResourceReader> ResourceReaderValue, IObservable<System.String> resourceName)
        {
            return Observable.Zip(ResourceReaderValue, resourceName, (ResourceReaderValueLambda, resourceNameLambda) => {
System.String resourceTypeOutput = default(System.String);
System.Byte[] resourceDataOutput = default(System.Byte[]);
ResourceReaderValueLambda.GetResourceData(resourceNameLambda, out resourceTypeOutput, out resourceDataOutput);
return Tuple.Create(resourceTypeOutput, resourceDataOutput);
});
        }

    }
}