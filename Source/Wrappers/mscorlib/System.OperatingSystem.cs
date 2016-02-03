using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __OperatingSystem
    {
        public static IObservable<System.Reactive.Unit> GetObjectData(
            this IObservable<System.OperatingSystem> OperatingSystemValue,
            IObservable<System.Runtime.Serialization.SerializationInfo> info,
            IObservable<System.Runtime.Serialization.StreamingContext> context)
        {
            return ObservableExt.ZipExecute(OperatingSystemValue, info, context,
                (OperatingSystemValueLambda, infoLambda, contextLambda) =>
                    OperatingSystemValueLambda.GetObjectData(infoLambda, contextLambda));
        }


        public static IObservable<System.Object> Clone(this IObservable<System.OperatingSystem> OperatingSystemValue)
        {
            return Observable.Select(OperatingSystemValue,
                (OperatingSystemValueLambda) => OperatingSystemValueLambda.Clone());
        }


        public static IObservable<System.String> ToString(this IObservable<System.OperatingSystem> OperatingSystemValue)
        {
            return Observable.Select(OperatingSystemValue,
                (OperatingSystemValueLambda) => OperatingSystemValueLambda.ToString());
        }


        public static IObservable<System.PlatformID> get_Platform(
            this IObservable<System.OperatingSystem> OperatingSystemValue)
        {
            return Observable.Select(OperatingSystemValue,
                (OperatingSystemValueLambda) => OperatingSystemValueLambda.Platform);
        }


        public static IObservable<System.String> get_ServicePack(
            this IObservable<System.OperatingSystem> OperatingSystemValue)
        {
            return Observable.Select(OperatingSystemValue,
                (OperatingSystemValueLambda) => OperatingSystemValueLambda.ServicePack);
        }


        public static IObservable<System.Version> get_Version(
            this IObservable<System.OperatingSystem> OperatingSystemValue)
        {
            return Observable.Select(OperatingSystemValue,
                (OperatingSystemValueLambda) => OperatingSystemValueLambda.Version);
        }


        public static IObservable<System.String> get_VersionString(
            this IObservable<System.OperatingSystem> OperatingSystemValue)
        {
            return Observable.Select(OperatingSystemValue,
                (OperatingSystemValueLambda) => OperatingSystemValueLambda.VersionString);
        }
    }
}