using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Principal
{
    public static class __IdentityReferenceCollection
    {
        public static IObservable<System.Reactive.Unit> CopyTo(
            this IObservable<System.Security.Principal.IdentityReferenceCollection> IdentityReferenceCollectionValue,
            IObservable<System.Security.Principal.IdentityReference[]> array, IObservable<System.Int32> offset)
        {
            return ObservableExt.ZipExecute(IdentityReferenceCollectionValue, array, offset,
                (IdentityReferenceCollectionValueLambda, arrayLambda, offsetLambda) =>
                    IdentityReferenceCollectionValueLambda.CopyTo(arrayLambda, offsetLambda));
        }


        public static IObservable<System.Reactive.Unit> Add(
            this IObservable<System.Security.Principal.IdentityReferenceCollection> IdentityReferenceCollectionValue,
            IObservable<System.Security.Principal.IdentityReference> identity)
        {
            return ObservableExt.ZipExecute(IdentityReferenceCollectionValue, identity,
                (IdentityReferenceCollectionValueLambda, identityLambda) =>
                    IdentityReferenceCollectionValueLambda.Add(identityLambda));
        }


        public static IObservable<System.Boolean> Remove(
            this IObservable<System.Security.Principal.IdentityReferenceCollection> IdentityReferenceCollectionValue,
            IObservable<System.Security.Principal.IdentityReference> identity)
        {
            return Observable.Zip(IdentityReferenceCollectionValue, identity,
                (IdentityReferenceCollectionValueLambda, identityLambda) =>
                    IdentityReferenceCollectionValueLambda.Remove(identityLambda));
        }


        public static IObservable<System.Reactive.Unit> Clear(
            this IObservable<System.Security.Principal.IdentityReferenceCollection> IdentityReferenceCollectionValue)
        {
            return
                Observable.Do(IdentityReferenceCollectionValue,
                    (IdentityReferenceCollectionValueLambda) => IdentityReferenceCollectionValueLambda.Clear()).ToUnit();
        }


        public static IObservable<System.Boolean> Contains(
            this IObservable<System.Security.Principal.IdentityReferenceCollection> IdentityReferenceCollectionValue,
            IObservable<System.Security.Principal.IdentityReference> identity)
        {
            return Observable.Zip(IdentityReferenceCollectionValue, identity,
                (IdentityReferenceCollectionValueLambda, identityLambda) =>
                    IdentityReferenceCollectionValueLambda.Contains(identityLambda));
        }


        public static IObservable<System.Collections.Generic.IEnumerator<System.Security.Principal.IdentityReference>>
            GetEnumerator(
            this IObservable<System.Security.Principal.IdentityReferenceCollection> IdentityReferenceCollectionValue)
        {
            return Observable.Select(IdentityReferenceCollectionValue,
                (IdentityReferenceCollectionValueLambda) => IdentityReferenceCollectionValueLambda.GetEnumerator());
        }


        public static IObservable<System.Security.Principal.IdentityReferenceCollection> Translate(
            this IObservable<System.Security.Principal.IdentityReferenceCollection> IdentityReferenceCollectionValue,
            IObservable<System.Type> targetType)
        {
            return Observable.Zip(IdentityReferenceCollectionValue, targetType,
                (IdentityReferenceCollectionValueLambda, targetTypeLambda) =>
                    IdentityReferenceCollectionValueLambda.Translate(targetTypeLambda));
        }


        public static IObservable<System.Security.Principal.IdentityReferenceCollection> Translate(
            this IObservable<System.Security.Principal.IdentityReferenceCollection> IdentityReferenceCollectionValue,
            IObservable<System.Type> targetType, IObservable<System.Boolean> forceSuccess)
        {
            return Observable.Zip(IdentityReferenceCollectionValue, targetType, forceSuccess,
                (IdentityReferenceCollectionValueLambda, targetTypeLambda, forceSuccessLambda) =>
                    IdentityReferenceCollectionValueLambda.Translate(targetTypeLambda, forceSuccessLambda));
        }


        public static IObservable<System.Int32> get_Count(
            this IObservable<System.Security.Principal.IdentityReferenceCollection> IdentityReferenceCollectionValue)
        {
            return Observable.Select(IdentityReferenceCollectionValue,
                (IdentityReferenceCollectionValueLambda) => IdentityReferenceCollectionValueLambda.Count);
        }


        public static IObservable<System.Boolean> get_IsReadOnly(
            this IObservable<System.Security.Principal.IdentityReferenceCollection> IdentityReferenceCollectionValue)
        {
            return Observable.Select(IdentityReferenceCollectionValue,
                (IdentityReferenceCollectionValueLambda) => IdentityReferenceCollectionValueLambda.IsReadOnly);
        }


        public static IObservable<System.Security.Principal.IdentityReference> get_Item(
            this IObservable<System.Security.Principal.IdentityReferenceCollection> IdentityReferenceCollectionValue,
            IObservable<System.Int32> index)
        {
            return Observable.Zip(IdentityReferenceCollectionValue, index,
                (IdentityReferenceCollectionValueLambda, indexLambda) =>
                    IdentityReferenceCollectionValueLambda[indexLambda]);
        }


        public static IObservable<System.Reactive.Unit> set_Item(
            this IObservable<System.Security.Principal.IdentityReferenceCollection> IdentityReferenceCollectionValue,
            IObservable<System.Int32> index, IObservable<System.Security.Principal.IdentityReference> value)
        {
            return ObservableExt.ZipExecute(IdentityReferenceCollectionValue, index, value,
                (IdentityReferenceCollectionValueLambda, indexLambda, valueLambda) =>
                    IdentityReferenceCollectionValueLambda[indexLambda] = valueLambda);
        }
    }
}