using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace Newtonsoft.Json.Serialization
{
    public static class __IReferenceResolver
    {
        
        public static IObservable<System.Object> ResolveReference(this IObservable<Newtonsoft.Json.Serialization.IReferenceResolver> IReferenceResolverValue, IObservable<System.Object> context, IObservable<System.String> reference)
        {
            return Observable.Zip(IReferenceResolverValue, context, reference, (IReferenceResolverValueLambda, contextLambda, referenceLambda) => IReferenceResolverValueLambda.ResolveReference(contextLambda, referenceLambda));
        }


        public static IObservable<System.String> GetReference(this IObservable<Newtonsoft.Json.Serialization.IReferenceResolver> IReferenceResolverValue, IObservable<System.Object> context, IObservable<System.Object> value)
        {
            return Observable.Zip(IReferenceResolverValue, context, value, (IReferenceResolverValueLambda, contextLambda, valueLambda) => IReferenceResolverValueLambda.GetReference(contextLambda, valueLambda));
        }


        public static IObservable<System.Boolean> IsReferenced(this IObservable<Newtonsoft.Json.Serialization.IReferenceResolver> IReferenceResolverValue, IObservable<System.Object> context, IObservable<System.Object> value)
        {
            return Observable.Zip(IReferenceResolverValue, context, value, (IReferenceResolverValueLambda, contextLambda, valueLambda) => IReferenceResolverValueLambda.IsReferenced(contextLambda, valueLambda));
        }


        public static IObservable<System.Reactive.Unit> AddReference(this IObservable<Newtonsoft.Json.Serialization.IReferenceResolver> IReferenceResolverValue, IObservable<System.Object> context, IObservable<System.String> reference, IObservable<System.Object> value)
        {
            return ObservableExt.ZipExecute(IReferenceResolverValue, context, reference, value, (IReferenceResolverValueLambda, contextLambda, referenceLambda, valueLambda) => IReferenceResolverValueLambda.AddReference(contextLambda, referenceLambda, valueLambda));
        }

    }
}