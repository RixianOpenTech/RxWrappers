using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Serialization.Formatters
{
    public static class __IFieldInfo
    {
        public static IObservable<System.String[]> get_FieldNames(
            this IObservable<System.Runtime.Serialization.Formatters.IFieldInfo> IFieldInfoValue)
        {
            return Observable.Select(IFieldInfoValue, (IFieldInfoValueLambda) => IFieldInfoValueLambda.FieldNames);
        }


        public static IObservable<System.Type[]> get_FieldTypes(
            this IObservable<System.Runtime.Serialization.Formatters.IFieldInfo> IFieldInfoValue)
        {
            return Observable.Select(IFieldInfoValue, (IFieldInfoValueLambda) => IFieldInfoValueLambda.FieldTypes);
        }


        public static IObservable<System.Reactive.Unit> set_FieldNames(
            this IObservable<System.Runtime.Serialization.Formatters.IFieldInfo> IFieldInfoValue,
            IObservable<System.String[]> value)
        {
            return ObservableExt.ZipExecute(IFieldInfoValue, value,
                (IFieldInfoValueLambda, valueLambda) => IFieldInfoValueLambda.FieldNames = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_FieldTypes(
            this IObservable<System.Runtime.Serialization.Formatters.IFieldInfo> IFieldInfoValue,
            IObservable<System.Type[]> value)
        {
            return ObservableExt.ZipExecute(IFieldInfoValue, value,
                (IFieldInfoValueLambda, valueLambda) => IFieldInfoValueLambda.FieldTypes = valueLambda);
        }
    }
}