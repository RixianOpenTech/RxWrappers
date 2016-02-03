using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Diagnostics.CodeAnalysis
{
    public static class __SuppressMessageAttribute
    {
        public static IObservable<System.String> get_Category(
            this IObservable<System.Diagnostics.CodeAnalysis.SuppressMessageAttribute> SuppressMessageAttributeValue)
        {
            return Observable.Select(SuppressMessageAttributeValue,
                (SuppressMessageAttributeValueLambda) => SuppressMessageAttributeValueLambda.Category);
        }


        public static IObservable<System.String> get_CheckId(
            this IObservable<System.Diagnostics.CodeAnalysis.SuppressMessageAttribute> SuppressMessageAttributeValue)
        {
            return Observable.Select(SuppressMessageAttributeValue,
                (SuppressMessageAttributeValueLambda) => SuppressMessageAttributeValueLambda.CheckId);
        }


        public static IObservable<System.String> get_Scope(
            this IObservable<System.Diagnostics.CodeAnalysis.SuppressMessageAttribute> SuppressMessageAttributeValue)
        {
            return Observable.Select(SuppressMessageAttributeValue,
                (SuppressMessageAttributeValueLambda) => SuppressMessageAttributeValueLambda.Scope);
        }


        public static IObservable<System.String> get_Target(
            this IObservable<System.Diagnostics.CodeAnalysis.SuppressMessageAttribute> SuppressMessageAttributeValue)
        {
            return Observable.Select(SuppressMessageAttributeValue,
                (SuppressMessageAttributeValueLambda) => SuppressMessageAttributeValueLambda.Target);
        }


        public static IObservable<System.String> get_MessageId(
            this IObservable<System.Diagnostics.CodeAnalysis.SuppressMessageAttribute> SuppressMessageAttributeValue)
        {
            return Observable.Select(SuppressMessageAttributeValue,
                (SuppressMessageAttributeValueLambda) => SuppressMessageAttributeValueLambda.MessageId);
        }


        public static IObservable<System.String> get_Justification(
            this IObservable<System.Diagnostics.CodeAnalysis.SuppressMessageAttribute> SuppressMessageAttributeValue)
        {
            return Observable.Select(SuppressMessageAttributeValue,
                (SuppressMessageAttributeValueLambda) => SuppressMessageAttributeValueLambda.Justification);
        }


        public static IObservable<System.Reactive.Unit> set_Scope(
            this IObservable<System.Diagnostics.CodeAnalysis.SuppressMessageAttribute> SuppressMessageAttributeValue,
            IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(SuppressMessageAttributeValue, value,
                (SuppressMessageAttributeValueLambda, valueLambda) =>
                    SuppressMessageAttributeValueLambda.Scope = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Target(
            this IObservable<System.Diagnostics.CodeAnalysis.SuppressMessageAttribute> SuppressMessageAttributeValue,
            IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(SuppressMessageAttributeValue, value,
                (SuppressMessageAttributeValueLambda, valueLambda) =>
                    SuppressMessageAttributeValueLambda.Target = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_MessageId(
            this IObservable<System.Diagnostics.CodeAnalysis.SuppressMessageAttribute> SuppressMessageAttributeValue,
            IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(SuppressMessageAttributeValue, value,
                (SuppressMessageAttributeValueLambda, valueLambda) =>
                    SuppressMessageAttributeValueLambda.MessageId = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Justification(
            this IObservable<System.Diagnostics.CodeAnalysis.SuppressMessageAttribute> SuppressMessageAttributeValue,
            IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(SuppressMessageAttributeValue, value,
                (SuppressMessageAttributeValueLambda, valueLambda) =>
                    SuppressMessageAttributeValueLambda.Justification = valueLambda);
        }
    }
}