using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Resources
{
    public static class __ResourceSet
    {
        public static IObservable<System.Reactive.Unit> Close(
            this IObservable<System.Resources.ResourceSet> ResourceSetValue)
        {
            return Observable.Do(ResourceSetValue, (ResourceSetValueLambda) => ResourceSetValueLambda.Close()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> Dispose(
            this IObservable<System.Resources.ResourceSet> ResourceSetValue)
        {
            return
                Observable.Do(ResourceSetValue, (ResourceSetValueLambda) => ResourceSetValueLambda.Dispose()).ToUnit();
        }


        public static IObservable<System.Type> GetDefaultReader(
            this IObservable<System.Resources.ResourceSet> ResourceSetValue)
        {
            return Observable.Select(ResourceSetValue,
                (ResourceSetValueLambda) => ResourceSetValueLambda.GetDefaultReader());
        }


        public static IObservable<System.Type> GetDefaultWriter(
            this IObservable<System.Resources.ResourceSet> ResourceSetValue)
        {
            return Observable.Select(ResourceSetValue,
                (ResourceSetValueLambda) => ResourceSetValueLambda.GetDefaultWriter());
        }


        public static IObservable<System.Collections.IDictionaryEnumerator> GetEnumerator(
            this IObservable<System.Resources.ResourceSet> ResourceSetValue)
        {
            return Observable.Select(ResourceSetValue,
                (ResourceSetValueLambda) => ResourceSetValueLambda.GetEnumerator());
        }


        public static IObservable<System.String> GetString(
            this IObservable<System.Resources.ResourceSet> ResourceSetValue, IObservable<System.String> name)
        {
            return Observable.Zip(ResourceSetValue, name,
                (ResourceSetValueLambda, nameLambda) => ResourceSetValueLambda.GetString(nameLambda));
        }


        public static IObservable<System.String> GetString(
            this IObservable<System.Resources.ResourceSet> ResourceSetValue, IObservable<System.String> name,
            IObservable<System.Boolean> ignoreCase)
        {
            return Observable.Zip(ResourceSetValue, name, ignoreCase,
                (ResourceSetValueLambda, nameLambda, ignoreCaseLambda) =>
                    ResourceSetValueLambda.GetString(nameLambda, ignoreCaseLambda));
        }


        public static IObservable<System.Object> GetObject(
            this IObservable<System.Resources.ResourceSet> ResourceSetValue, IObservable<System.String> name)
        {
            return Observable.Zip(ResourceSetValue, name,
                (ResourceSetValueLambda, nameLambda) => ResourceSetValueLambda.GetObject(nameLambda));
        }


        public static IObservable<System.Object> GetObject(
            this IObservable<System.Resources.ResourceSet> ResourceSetValue, IObservable<System.String> name,
            IObservable<System.Boolean> ignoreCase)
        {
            return Observable.Zip(ResourceSetValue, name, ignoreCase,
                (ResourceSetValueLambda, nameLambda, ignoreCaseLambda) =>
                    ResourceSetValueLambda.GetObject(nameLambda, ignoreCaseLambda));
        }
    }
}