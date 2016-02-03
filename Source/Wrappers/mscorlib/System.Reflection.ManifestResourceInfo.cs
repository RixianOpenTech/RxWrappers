using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection
{
    public static class __ManifestResourceInfo
    {
        
        public static IObservable<System.Reflection.Assembly> get_ReferencedAssembly(this IObservable<System.Reflection.ManifestResourceInfo> ManifestResourceInfoValue)
        {
            return Observable.Select(ManifestResourceInfoValue, (ManifestResourceInfoValueLambda) => ManifestResourceInfoValueLambda.ReferencedAssembly);
        }


        public static IObservable<System.String> get_FileName(this IObservable<System.Reflection.ManifestResourceInfo> ManifestResourceInfoValue)
        {
            return Observable.Select(ManifestResourceInfoValue, (ManifestResourceInfoValueLambda) => ManifestResourceInfoValueLambda.FileName);
        }


        public static IObservable<System.Reflection.ResourceLocation> get_ResourceLocation(this IObservable<System.Reflection.ManifestResourceInfo> ManifestResourceInfoValue)
        {
            return Observable.Select(ManifestResourceInfoValue, (ManifestResourceInfoValueLambda) => ManifestResourceInfoValueLambda.ResourceLocation);
        }

    }
}