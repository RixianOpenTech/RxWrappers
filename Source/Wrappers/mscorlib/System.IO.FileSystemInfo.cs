using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.IO
{
    public static class __FileSystemInfo
    {
        public static IObservable<System.Reactive.Unit> Delete(
            this IObservable<System.IO.FileSystemInfo> FileSystemInfoValue)
        {
            return
                Observable.Do(FileSystemInfoValue, (FileSystemInfoValueLambda) => FileSystemInfoValueLambda.Delete())
                    .ToUnit();
        }


        public static IObservable<System.Reactive.Unit> Refresh(
            this IObservable<System.IO.FileSystemInfo> FileSystemInfoValue)
        {
            return
                Observable.Do(FileSystemInfoValue, (FileSystemInfoValueLambda) => FileSystemInfoValueLambda.Refresh())
                    .ToUnit();
        }


        public static IObservable<System.Reactive.Unit> GetObjectData(
            this IObservable<System.IO.FileSystemInfo> FileSystemInfoValue,
            IObservable<System.Runtime.Serialization.SerializationInfo> info,
            IObservable<System.Runtime.Serialization.StreamingContext> context)
        {
            return ObservableExt.ZipExecute(FileSystemInfoValue, info, context,
                (FileSystemInfoValueLambda, infoLambda, contextLambda) =>
                    FileSystemInfoValueLambda.GetObjectData(infoLambda, contextLambda));
        }


        public static IObservable<System.String> get_FullName(
            this IObservable<System.IO.FileSystemInfo> FileSystemInfoValue)
        {
            return Observable.Select(FileSystemInfoValue,
                (FileSystemInfoValueLambda) => FileSystemInfoValueLambda.FullName);
        }


        public static IObservable<System.String> get_Extension(
            this IObservable<System.IO.FileSystemInfo> FileSystemInfoValue)
        {
            return Observable.Select(FileSystemInfoValue,
                (FileSystemInfoValueLambda) => FileSystemInfoValueLambda.Extension);
        }


        public static IObservable<System.String> get_Name(this IObservable<System.IO.FileSystemInfo> FileSystemInfoValue)
        {
            return Observable.Select(FileSystemInfoValue, (FileSystemInfoValueLambda) => FileSystemInfoValueLambda.Name);
        }


        public static IObservable<System.Boolean> get_Exists(
            this IObservable<System.IO.FileSystemInfo> FileSystemInfoValue)
        {
            return Observable.Select(FileSystemInfoValue,
                (FileSystemInfoValueLambda) => FileSystemInfoValueLambda.Exists);
        }


        public static IObservable<System.DateTime> get_CreationTime(
            this IObservable<System.IO.FileSystemInfo> FileSystemInfoValue)
        {
            return Observable.Select(FileSystemInfoValue,
                (FileSystemInfoValueLambda) => FileSystemInfoValueLambda.CreationTime);
        }


        public static IObservable<System.DateTime> get_CreationTimeUtc(
            this IObservable<System.IO.FileSystemInfo> FileSystemInfoValue)
        {
            return Observable.Select(FileSystemInfoValue,
                (FileSystemInfoValueLambda) => FileSystemInfoValueLambda.CreationTimeUtc);
        }


        public static IObservable<System.DateTime> get_LastAccessTime(
            this IObservable<System.IO.FileSystemInfo> FileSystemInfoValue)
        {
            return Observable.Select(FileSystemInfoValue,
                (FileSystemInfoValueLambda) => FileSystemInfoValueLambda.LastAccessTime);
        }


        public static IObservable<System.DateTime> get_LastAccessTimeUtc(
            this IObservable<System.IO.FileSystemInfo> FileSystemInfoValue)
        {
            return Observable.Select(FileSystemInfoValue,
                (FileSystemInfoValueLambda) => FileSystemInfoValueLambda.LastAccessTimeUtc);
        }


        public static IObservable<System.DateTime> get_LastWriteTime(
            this IObservable<System.IO.FileSystemInfo> FileSystemInfoValue)
        {
            return Observable.Select(FileSystemInfoValue,
                (FileSystemInfoValueLambda) => FileSystemInfoValueLambda.LastWriteTime);
        }


        public static IObservable<System.DateTime> get_LastWriteTimeUtc(
            this IObservable<System.IO.FileSystemInfo> FileSystemInfoValue)
        {
            return Observable.Select(FileSystemInfoValue,
                (FileSystemInfoValueLambda) => FileSystemInfoValueLambda.LastWriteTimeUtc);
        }


        public static IObservable<System.IO.FileAttributes> get_Attributes(
            this IObservable<System.IO.FileSystemInfo> FileSystemInfoValue)
        {
            return Observable.Select(FileSystemInfoValue,
                (FileSystemInfoValueLambda) => FileSystemInfoValueLambda.Attributes);
        }


        public static IObservable<System.Reactive.Unit> set_CreationTime(
            this IObservable<System.IO.FileSystemInfo> FileSystemInfoValue, IObservable<System.DateTime> value)
        {
            return ObservableExt.ZipExecute(FileSystemInfoValue, value,
                (FileSystemInfoValueLambda, valueLambda) => FileSystemInfoValueLambda.CreationTime = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_CreationTimeUtc(
            this IObservable<System.IO.FileSystemInfo> FileSystemInfoValue, IObservable<System.DateTime> value)
        {
            return ObservableExt.ZipExecute(FileSystemInfoValue, value,
                (FileSystemInfoValueLambda, valueLambda) => FileSystemInfoValueLambda.CreationTimeUtc = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_LastAccessTime(
            this IObservable<System.IO.FileSystemInfo> FileSystemInfoValue, IObservable<System.DateTime> value)
        {
            return ObservableExt.ZipExecute(FileSystemInfoValue, value,
                (FileSystemInfoValueLambda, valueLambda) => FileSystemInfoValueLambda.LastAccessTime = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_LastAccessTimeUtc(
            this IObservable<System.IO.FileSystemInfo> FileSystemInfoValue, IObservable<System.DateTime> value)
        {
            return ObservableExt.ZipExecute(FileSystemInfoValue, value,
                (FileSystemInfoValueLambda, valueLambda) => FileSystemInfoValueLambda.LastAccessTimeUtc = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_LastWriteTime(
            this IObservable<System.IO.FileSystemInfo> FileSystemInfoValue, IObservable<System.DateTime> value)
        {
            return ObservableExt.ZipExecute(FileSystemInfoValue, value,
                (FileSystemInfoValueLambda, valueLambda) => FileSystemInfoValueLambda.LastWriteTime = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_LastWriteTimeUtc(
            this IObservable<System.IO.FileSystemInfo> FileSystemInfoValue, IObservable<System.DateTime> value)
        {
            return ObservableExt.ZipExecute(FileSystemInfoValue, value,
                (FileSystemInfoValueLambda, valueLambda) => FileSystemInfoValueLambda.LastWriteTimeUtc = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_Attributes(
            this IObservable<System.IO.FileSystemInfo> FileSystemInfoValue, IObservable<System.IO.FileAttributes> value)
        {
            return ObservableExt.ZipExecute(FileSystemInfoValue, value,
                (FileSystemInfoValueLambda, valueLambda) => FileSystemInfoValueLambda.Attributes = valueLambda);
        }
    }
}