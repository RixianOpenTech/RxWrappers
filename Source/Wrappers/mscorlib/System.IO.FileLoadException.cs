using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.IO
{
    public static class __FileLoadException
    {
        public static IObservable<System.String> ToString(
            this IObservable<System.IO.FileLoadException> FileLoadExceptionValue)
        {
            return Observable.Select(FileLoadExceptionValue,
                (FileLoadExceptionValueLambda) => FileLoadExceptionValueLambda.ToString());
        }


        public static IObservable<System.Reactive.Unit> GetObjectData(
            this IObservable<System.IO.FileLoadException> FileLoadExceptionValue,
            IObservable<System.Runtime.Serialization.SerializationInfo> info,
            IObservable<System.Runtime.Serialization.StreamingContext> context)
        {
            return ObservableExt.ZipExecute(FileLoadExceptionValue, info, context,
                (FileLoadExceptionValueLambda, infoLambda, contextLambda) =>
                    FileLoadExceptionValueLambda.GetObjectData(infoLambda, contextLambda));
        }


        public static IObservable<System.String> get_Message(
            this IObservable<System.IO.FileLoadException> FileLoadExceptionValue)
        {
            return Observable.Select(FileLoadExceptionValue,
                (FileLoadExceptionValueLambda) => FileLoadExceptionValueLambda.Message);
        }


        public static IObservable<System.String> get_FileName(
            this IObservable<System.IO.FileLoadException> FileLoadExceptionValue)
        {
            return Observable.Select(FileLoadExceptionValue,
                (FileLoadExceptionValueLambda) => FileLoadExceptionValueLambda.FileName);
        }


        public static IObservable<System.String> get_FusionLog(
            this IObservable<System.IO.FileLoadException> FileLoadExceptionValue)
        {
            return Observable.Select(FileLoadExceptionValue,
                (FileLoadExceptionValueLambda) => FileLoadExceptionValueLambda.FusionLog);
        }
    }
}