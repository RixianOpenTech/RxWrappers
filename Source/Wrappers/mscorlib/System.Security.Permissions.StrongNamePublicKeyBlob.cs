using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Permissions
{
    public static class __StrongNamePublicKeyBlob
    {
        
        public static IObservable<System.Boolean> Equals(this IObservable<System.Security.Permissions.StrongNamePublicKeyBlob> StrongNamePublicKeyBlobValue, IObservable<System.Object> obj)
        {
            return Observable.Zip(StrongNamePublicKeyBlobValue, obj, (StrongNamePublicKeyBlobValueLambda, objLambda) => StrongNamePublicKeyBlobValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System.Security.Permissions.StrongNamePublicKeyBlob> StrongNamePublicKeyBlobValue)
        {
            return Observable.Select(StrongNamePublicKeyBlobValue, (StrongNamePublicKeyBlobValueLambda) => StrongNamePublicKeyBlobValueLambda.GetHashCode());
        }


        public static IObservable<System.String> ToString(this IObservable<System.Security.Permissions.StrongNamePublicKeyBlob> StrongNamePublicKeyBlobValue)
        {
            return Observable.Select(StrongNamePublicKeyBlobValue, (StrongNamePublicKeyBlobValueLambda) => StrongNamePublicKeyBlobValueLambda.ToString());
        }

    }
}