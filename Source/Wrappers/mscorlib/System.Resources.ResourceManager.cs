using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Resources
{
    public static class __ResourceManager
    {
        
        public static IObservable<System.Reactive.Unit> ReleaseAllResources(this IObservable<System.Resources.ResourceManager> ResourceManagerValue)
        {
            return Observable.Do(ResourceManagerValue, (ResourceManagerValueLambda) => ResourceManagerValueLambda.ReleaseAllResources()).ToUnit();
        }


        public static IObservable<System.Resources.ResourceManager> CreateFileBasedResourceManager(IObservable<System.String> baseName, IObservable<System.String> resourceDir, IObservable<System.Type> usingResourceSet)
        {
            return Observable.Zip(baseName, resourceDir, usingResourceSet, (baseNameLambda, resourceDirLambda, usingResourceSetLambda) => System.Resources.ResourceManager.CreateFileBasedResourceManager(baseNameLambda, resourceDirLambda, usingResourceSetLambda));
        }


        public static IObservable<System.Resources.ResourceSet> GetResourceSet(this IObservable<System.Resources.ResourceManager> ResourceManagerValue, IObservable<System.Globalization.CultureInfo> culture, IObservable<System.Boolean> createIfNotExists, IObservable<System.Boolean> tryParents)
        {
            return Observable.Zip(ResourceManagerValue, culture, createIfNotExists, tryParents, (ResourceManagerValueLambda, cultureLambda, createIfNotExistsLambda, tryParentsLambda) => ResourceManagerValueLambda.GetResourceSet(cultureLambda, createIfNotExistsLambda, tryParentsLambda));
        }


        public static IObservable<System.String> GetString(this IObservable<System.Resources.ResourceManager> ResourceManagerValue, IObservable<System.String> name)
        {
            return Observable.Zip(ResourceManagerValue, name, (ResourceManagerValueLambda, nameLambda) => ResourceManagerValueLambda.GetString(nameLambda));
        }


        public static IObservable<System.String> GetString(this IObservable<System.Resources.ResourceManager> ResourceManagerValue, IObservable<System.String> name, IObservable<System.Globalization.CultureInfo> culture)
        {
            return Observable.Zip(ResourceManagerValue, name, culture, (ResourceManagerValueLambda, nameLambda, cultureLambda) => ResourceManagerValueLambda.GetString(nameLambda, cultureLambda));
        }


        public static IObservable<System.Object> GetObject(this IObservable<System.Resources.ResourceManager> ResourceManagerValue, IObservable<System.String> name)
        {
            return Observable.Zip(ResourceManagerValue, name, (ResourceManagerValueLambda, nameLambda) => ResourceManagerValueLambda.GetObject(nameLambda));
        }


        public static IObservable<System.Object> GetObject(this IObservable<System.Resources.ResourceManager> ResourceManagerValue, IObservable<System.String> name, IObservable<System.Globalization.CultureInfo> culture)
        {
            return Observable.Zip(ResourceManagerValue, name, culture, (ResourceManagerValueLambda, nameLambda, cultureLambda) => ResourceManagerValueLambda.GetObject(nameLambda, cultureLambda));
        }


        public static IObservable<System.IO.UnmanagedMemoryStream> GetStream(this IObservable<System.Resources.ResourceManager> ResourceManagerValue, IObservable<System.String> name)
        {
            return Observable.Zip(ResourceManagerValue, name, (ResourceManagerValueLambda, nameLambda) => ResourceManagerValueLambda.GetStream(nameLambda));
        }


        public static IObservable<System.IO.UnmanagedMemoryStream> GetStream(this IObservable<System.Resources.ResourceManager> ResourceManagerValue, IObservable<System.String> name, IObservable<System.Globalization.CultureInfo> culture)
        {
            return Observable.Zip(ResourceManagerValue, name, culture, (ResourceManagerValueLambda, nameLambda, cultureLambda) => ResourceManagerValueLambda.GetStream(nameLambda, cultureLambda));
        }


        public static IObservable<System.String> get_BaseName(this IObservable<System.Resources.ResourceManager> ResourceManagerValue)
        {
            return Observable.Select(ResourceManagerValue, (ResourceManagerValueLambda) => ResourceManagerValueLambda.BaseName);
        }


        public static IObservable<System.Boolean> get_IgnoreCase(this IObservable<System.Resources.ResourceManager> ResourceManagerValue)
        {
            return Observable.Select(ResourceManagerValue, (ResourceManagerValueLambda) => ResourceManagerValueLambda.IgnoreCase);
        }


        public static IObservable<System.Type> get_ResourceSetType(this IObservable<System.Resources.ResourceManager> ResourceManagerValue)
        {
            return Observable.Select(ResourceManagerValue, (ResourceManagerValueLambda) => ResourceManagerValueLambda.ResourceSetType);
        }


        public static IObservable<System.Reactive.Unit> set_IgnoreCase(this IObservable<System.Resources.ResourceManager> ResourceManagerValue, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(ResourceManagerValue, value, (ResourceManagerValueLambda, valueLambda) => ResourceManagerValueLambda.IgnoreCase = valueLambda);
        }

    }
}