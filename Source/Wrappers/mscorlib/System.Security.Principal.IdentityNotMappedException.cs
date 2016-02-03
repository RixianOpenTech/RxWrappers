using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Principal
{
    public static class __IdentityNotMappedException
    {
        
        public static IObservable<System.Reactive.Unit> GetObjectData(this IObservable<System.Security.Principal.IdentityNotMappedException> IdentityNotMappedExceptionValue, IObservable<System.Runtime.Serialization.SerializationInfo> serializationInfo, IObservable<System.Runtime.Serialization.StreamingContext> streamingContext)
        {
            return ObservableExt.ZipExecute(IdentityNotMappedExceptionValue, serializationInfo, streamingContext, (IdentityNotMappedExceptionValueLambda, serializationInfoLambda, streamingContextLambda) => IdentityNotMappedExceptionValueLambda.GetObjectData(serializationInfoLambda, streamingContextLambda));
        }


        public static IObservable<System.Security.Principal.IdentityReferenceCollection> get_UnmappedIdentities(this IObservable<System.Security.Principal.IdentityNotMappedException> IdentityNotMappedExceptionValue)
        {
            return Observable.Select(IdentityNotMappedExceptionValue, (IdentityNotMappedExceptionValueLambda) => IdentityNotMappedExceptionValueLambda.UnmappedIdentities);
        }

    }
}