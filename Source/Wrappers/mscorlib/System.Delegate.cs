using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __Delegate
    {
        
        public static IObservable<System.Object> DynamicInvoke(this IObservable<System.Delegate> DelegateValue, IObservable<System.Object[]> args)
        {
            return Observable.Zip(DelegateValue, args, (DelegateValueLambda, argsLambda) => DelegateValueLambda.DynamicInvoke(argsLambda));
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.Delegate> DelegateValue, IObservable<System.Object> obj)
        {
            return Observable.Zip(DelegateValue, obj, (DelegateValueLambda, objLambda) => DelegateValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System.Delegate> DelegateValue)
        {
            return Observable.Select(DelegateValue, (DelegateValueLambda) => DelegateValueLambda.GetHashCode());
        }


        public static IObservable<System.Delegate> Combine(IObservable<System.Delegate> a, IObservable<System.Delegate> b)
        {
            return Observable.Zip(a, b, (aLambda, bLambda) => System.Delegate.Combine(aLambda, bLambda));
        }


        public static IObservable<System.Delegate> Combine(IObservable<System.Delegate[]> delegates)
        {
            return Observable.Select(delegates, (delegatesLambda) => System.Delegate.Combine(delegatesLambda));
        }


        public static IObservable<System.Delegate[]> GetInvocationList(this IObservable<System.Delegate> DelegateValue)
        {
            return Observable.Select(DelegateValue, (DelegateValueLambda) => DelegateValueLambda.GetInvocationList());
        }


        public static IObservable<System.Delegate> Remove(IObservable<System.Delegate> source, IObservable<System.Delegate> value)
        {
            return Observable.Zip(source, value, (sourceLambda, valueLambda) => System.Delegate.Remove(sourceLambda, valueLambda));
        }


        public static IObservable<System.Delegate> RemoveAll(IObservable<System.Delegate> source, IObservable<System.Delegate> value)
        {
            return Observable.Zip(source, value, (sourceLambda, valueLambda) => System.Delegate.RemoveAll(sourceLambda, valueLambda));
        }


        public static IObservable<System.Object> Clone(this IObservable<System.Delegate> DelegateValue)
        {
            return Observable.Select(DelegateValue, (DelegateValueLambda) => DelegateValueLambda.Clone());
        }


        public static IObservable<System.Delegate> CreateDelegate(IObservable<System.Type> type, IObservable<System.Object> target, IObservable<System.String> method)
        {
            return Observable.Zip(type, target, method, (typeLambda, targetLambda, methodLambda) => System.Delegate.CreateDelegate(typeLambda, targetLambda, methodLambda));
        }


        public static IObservable<System.Delegate> CreateDelegate(IObservable<System.Type> type, IObservable<System.Object> target, IObservable<System.String> method, IObservable<System.Boolean> ignoreCase)
        {
            return Observable.Zip(type, target, method, ignoreCase, (typeLambda, targetLambda, methodLambda, ignoreCaseLambda) => System.Delegate.CreateDelegate(typeLambda, targetLambda, methodLambda, ignoreCaseLambda));
        }


        public static IObservable<System.Delegate> CreateDelegate(IObservable<System.Type> type, IObservable<System.Object> target, IObservable<System.String> method, IObservable<System.Boolean> ignoreCase, IObservable<System.Boolean> throwOnBindFailure)
        {
            return Observable.Zip(type, target, method, ignoreCase, throwOnBindFailure, (typeLambda, targetLambda, methodLambda, ignoreCaseLambda, throwOnBindFailureLambda) => System.Delegate.CreateDelegate(typeLambda, targetLambda, methodLambda, ignoreCaseLambda, throwOnBindFailureLambda));
        }


        public static IObservable<System.Delegate> CreateDelegate(IObservable<System.Type> type, IObservable<System.Type> target, IObservable<System.String> method)
        {
            return Observable.Zip(type, target, method, (typeLambda, targetLambda, methodLambda) => System.Delegate.CreateDelegate(typeLambda, targetLambda, methodLambda));
        }


        public static IObservable<System.Delegate> CreateDelegate(IObservable<System.Type> type, IObservable<System.Type> target, IObservable<System.String> method, IObservable<System.Boolean> ignoreCase)
        {
            return Observable.Zip(type, target, method, ignoreCase, (typeLambda, targetLambda, methodLambda, ignoreCaseLambda) => System.Delegate.CreateDelegate(typeLambda, targetLambda, methodLambda, ignoreCaseLambda));
        }


        public static IObservable<System.Delegate> CreateDelegate(IObservable<System.Type> type, IObservable<System.Type> target, IObservable<System.String> method, IObservable<System.Boolean> ignoreCase, IObservable<System.Boolean> throwOnBindFailure)
        {
            return Observable.Zip(type, target, method, ignoreCase, throwOnBindFailure, (typeLambda, targetLambda, methodLambda, ignoreCaseLambda, throwOnBindFailureLambda) => System.Delegate.CreateDelegate(typeLambda, targetLambda, methodLambda, ignoreCaseLambda, throwOnBindFailureLambda));
        }


        public static IObservable<System.Delegate> CreateDelegate(IObservable<System.Type> type, IObservable<System.Reflection.MethodInfo> method, IObservable<System.Boolean> throwOnBindFailure)
        {
            return Observable.Zip(type, method, throwOnBindFailure, (typeLambda, methodLambda, throwOnBindFailureLambda) => System.Delegate.CreateDelegate(typeLambda, methodLambda, throwOnBindFailureLambda));
        }


        public static IObservable<System.Delegate> CreateDelegate(IObservable<System.Type> type, IObservable<System.Object> firstArgument, IObservable<System.Reflection.MethodInfo> method)
        {
            return Observable.Zip(type, firstArgument, method, (typeLambda, firstArgumentLambda, methodLambda) => System.Delegate.CreateDelegate(typeLambda, firstArgumentLambda, methodLambda));
        }


        public static IObservable<System.Delegate> CreateDelegate(IObservable<System.Type> type, IObservable<System.Object> firstArgument, IObservable<System.Reflection.MethodInfo> method, IObservable<System.Boolean> throwOnBindFailure)
        {
            return Observable.Zip(type, firstArgument, method, throwOnBindFailure, (typeLambda, firstArgumentLambda, methodLambda, throwOnBindFailureLambda) => System.Delegate.CreateDelegate(typeLambda, firstArgumentLambda, methodLambda, throwOnBindFailureLambda));
        }


        public static IObservable<System.Reactive.Unit> GetObjectData(this IObservable<System.Delegate> DelegateValue, IObservable<System.Runtime.Serialization.SerializationInfo> info, IObservable<System.Runtime.Serialization.StreamingContext> context)
        {
            return ObservableExt.ZipExecute(DelegateValue, info, context, (DelegateValueLambda, infoLambda, contextLambda) => DelegateValueLambda.GetObjectData(infoLambda, contextLambda));
        }


        public static IObservable<System.Delegate> CreateDelegate(IObservable<System.Type> type, IObservable<System.Reflection.MethodInfo> method)
        {
            return Observable.Zip(type, method, (typeLambda, methodLambda) => System.Delegate.CreateDelegate(typeLambda, methodLambda));
        }


        public static IObservable<System.Reflection.MethodInfo> get_Method(this IObservable<System.Delegate> DelegateValue)
        {
            return Observable.Select(DelegateValue, (DelegateValueLambda) => DelegateValueLambda.Method);
        }


        public static IObservable<System.Object> get_Target(this IObservable<System.Delegate> DelegateValue)
        {
            return Observable.Select(DelegateValue, (DelegateValueLambda) => DelegateValueLambda.Target);
        }

    }
}