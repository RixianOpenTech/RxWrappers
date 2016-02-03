using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.IO
{
    public static class __Path
    {
        
        public static IObservable<System.String> ChangeExtension(IObservable<System.String> path, IObservable<System.String> extension)
        {
            return Observable.Zip(path, extension, (pathLambda, extensionLambda) => System.IO.Path.ChangeExtension(pathLambda, extensionLambda));
        }


        public static IObservable<System.String> GetDirectoryName(IObservable<System.String> path)
        {
            return Observable.Select(path, (pathLambda) => System.IO.Path.GetDirectoryName(pathLambda));
        }


        public static IObservable<System.Char[]> GetInvalidPathChars()
        {
            return ObservableExt.Factory(() => System.IO.Path.GetInvalidPathChars());
        }


        public static IObservable<System.Char[]> GetInvalidFileNameChars()
        {
            return ObservableExt.Factory(() => System.IO.Path.GetInvalidFileNameChars());
        }


        public static IObservable<System.String> GetExtension(IObservable<System.String> path)
        {
            return Observable.Select(path, (pathLambda) => System.IO.Path.GetExtension(pathLambda));
        }


        public static IObservable<System.String> GetFullPath(IObservable<System.String> path)
        {
            return Observable.Select(path, (pathLambda) => System.IO.Path.GetFullPath(pathLambda));
        }


        public static IObservable<System.String> GetFileName(IObservable<System.String> path)
        {
            return Observable.Select(path, (pathLambda) => System.IO.Path.GetFileName(pathLambda));
        }


        public static IObservable<System.String> GetFileNameWithoutExtension(IObservable<System.String> path)
        {
            return Observable.Select(path, (pathLambda) => System.IO.Path.GetFileNameWithoutExtension(pathLambda));
        }


        public static IObservable<System.String> GetPathRoot(IObservable<System.String> path)
        {
            return Observable.Select(path, (pathLambda) => System.IO.Path.GetPathRoot(pathLambda));
        }


        public static IObservable<System.String> GetTempPath()
        {
            return ObservableExt.Factory(() => System.IO.Path.GetTempPath());
        }


        public static IObservable<System.String> GetRandomFileName()
        {
            return ObservableExt.Factory(() => System.IO.Path.GetRandomFileName());
        }


        public static IObservable<System.String> GetTempFileName()
        {
            return ObservableExt.Factory(() => System.IO.Path.GetTempFileName());
        }


        public static IObservable<System.Boolean> HasExtension(IObservable<System.String> path)
        {
            return Observable.Select(path, (pathLambda) => System.IO.Path.HasExtension(pathLambda));
        }


        public static IObservable<System.Boolean> IsPathRooted(IObservable<System.String> path)
        {
            return Observable.Select(path, (pathLambda) => System.IO.Path.IsPathRooted(pathLambda));
        }


        public static IObservable<System.String> Combine(IObservable<System.String> path1, IObservable<System.String> path2)
        {
            return Observable.Zip(path1, path2, (path1Lambda, path2Lambda) => System.IO.Path.Combine(path1Lambda, path2Lambda));
        }


        public static IObservable<System.String> Combine(IObservable<System.String> path1, IObservable<System.String> path2, IObservable<System.String> path3)
        {
            return Observable.Zip(path1, path2, path3, (path1Lambda, path2Lambda, path3Lambda) => System.IO.Path.Combine(path1Lambda, path2Lambda, path3Lambda));
        }


        public static IObservable<System.String> Combine(IObservable<System.String> path1, IObservable<System.String> path2, IObservable<System.String> path3, IObservable<System.String> path4)
        {
            return Observable.Zip(path1, path2, path3, path4, (path1Lambda, path2Lambda, path3Lambda, path4Lambda) => System.IO.Path.Combine(path1Lambda, path2Lambda, path3Lambda, path4Lambda));
        }


        public static IObservable<System.String> Combine(IObservable<System.String[]> paths)
        {
            return Observable.Select(paths, (pathsLambda) => System.IO.Path.Combine(pathsLambda));
        }

    }
}