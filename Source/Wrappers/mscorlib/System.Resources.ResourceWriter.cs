using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Resources
{
    public static class __ResourceWriter
    {
        
        public static IObservable<System.Reactive.Unit> AddResource(this IObservable<System.Resources.ResourceWriter> ResourceWriterValue, IObservable<System.String> name, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(ResourceWriterValue, name, value, (ResourceWriterValueLambda, nameLambda, valueLambda) => ResourceWriterValueLambda.AddResource(nameLambda, valueLambda));
        }


        public static IObservable<System.Reactive.Unit> AddResource(this IObservable<System.Resources.ResourceWriter> ResourceWriterValue, IObservable<System.String> name, IObservable<System.Object> value)
        {
            return ObservableExt.ZipExecute(ResourceWriterValue, name, value, (ResourceWriterValueLambda, nameLambda, valueLambda) => ResourceWriterValueLambda.AddResource(nameLambda, valueLambda));
        }


        public static IObservable<System.Reactive.Unit> AddResource(this IObservable<System.Resources.ResourceWriter> ResourceWriterValue, IObservable<System.String> name, IObservable<System.IO.Stream> value)
        {
            return ObservableExt.ZipExecute(ResourceWriterValue, name, value, (ResourceWriterValueLambda, nameLambda, valueLambda) => ResourceWriterValueLambda.AddResource(nameLambda, valueLambda));
        }


        public static IObservable<System.Reactive.Unit> AddResource(this IObservable<System.Resources.ResourceWriter> ResourceWriterValue, IObservable<System.String> name, IObservable<System.IO.Stream> value, IObservable<System.Boolean> closeAfterWrite)
        {
            return ObservableExt.ZipExecute(ResourceWriterValue, name, value, closeAfterWrite, (ResourceWriterValueLambda, nameLambda, valueLambda, closeAfterWriteLambda) => ResourceWriterValueLambda.AddResource(nameLambda, valueLambda, closeAfterWriteLambda));
        }


        public static IObservable<System.Reactive.Unit> AddResource(this IObservable<System.Resources.ResourceWriter> ResourceWriterValue, IObservable<System.String> name, IObservable<System.Byte[]> value)
        {
            return ObservableExt.ZipExecute(ResourceWriterValue, name, value, (ResourceWriterValueLambda, nameLambda, valueLambda) => ResourceWriterValueLambda.AddResource(nameLambda, valueLambda));
        }


        public static IObservable<System.Reactive.Unit> AddResourceData(this IObservable<System.Resources.ResourceWriter> ResourceWriterValue, IObservable<System.String> name, IObservable<System.String> typeName, IObservable<System.Byte[]> serializedData)
        {
            return ObservableExt.ZipExecute(ResourceWriterValue, name, typeName, serializedData, (ResourceWriterValueLambda, nameLambda, typeNameLambda, serializedDataLambda) => ResourceWriterValueLambda.AddResourceData(nameLambda, typeNameLambda, serializedDataLambda));
        }


        public static IObservable<System.Reactive.Unit> Close(this IObservable<System.Resources.ResourceWriter> ResourceWriterValue)
        {
            return Observable.Do(ResourceWriterValue, (ResourceWriterValueLambda) => ResourceWriterValueLambda.Close()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> Dispose(this IObservable<System.Resources.ResourceWriter> ResourceWriterValue)
        {
            return Observable.Do(ResourceWriterValue, (ResourceWriterValueLambda) => ResourceWriterValueLambda.Dispose()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> Generate(this IObservable<System.Resources.ResourceWriter> ResourceWriterValue)
        {
            return Observable.Do(ResourceWriterValue, (ResourceWriterValueLambda) => ResourceWriterValueLambda.Generate()).ToUnit();
        }


        public static IObservable<System.Func<System.Type, System.String>> get_TypeNameConverter(this IObservable<System.Resources.ResourceWriter> ResourceWriterValue)
        {
            return Observable.Select(ResourceWriterValue, (ResourceWriterValueLambda) => ResourceWriterValueLambda.TypeNameConverter);
        }


        public static IObservable<System.Reactive.Unit> set_TypeNameConverter(this IObservable<System.Resources.ResourceWriter> ResourceWriterValue, IObservable<System.Func<System.Type, System.String>> value)
        {
            return ObservableExt.ZipExecute(ResourceWriterValue, value, (ResourceWriterValueLambda, valueLambda) => ResourceWriterValueLambda.TypeNameConverter = valueLambda);
        }

    }
}