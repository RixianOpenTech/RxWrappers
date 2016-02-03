using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.IO
{
    public static class __FileNotFoundException
    {
        
        public static IObservable<System.String> ToString(this IObservable<System.IO.FileNotFoundException> FileNotFoundExceptionValue)
        {
            return Observable.Select(FileNotFoundExceptionValue, (FileNotFoundExceptionValueLambda) => FileNotFoundExceptionValueLambda.ToString());
        }


        public static IObservable<System.Reactive.Unit> GetObjectData(this IObservable<System.IO.FileNotFoundException> FileNotFoundExceptionValue, IObservable<System.Runtime.Serialization.SerializationInfo> info, IObservable<System.Runtime.Serialization.StreamingContext> context)
        {
            return ObservableExt.ZipExecute(FileNotFoundExceptionValue, info, context, (FileNotFoundExceptionValueLambda, infoLambda, contextLambda) => FileNotFoundExceptionValueLambda.GetObjectData(infoLambda, contextLambda));
        }


        public static IObservable<System.String> get_Message(this IObservable<System.IO.FileNotFoundException> FileNotFoundExceptionValue)
        {
            return Observable.Select(FileNotFoundExceptionValue, (FileNotFoundExceptionValueLambda) => FileNotFoundExceptionValueLambda.Message);
        }


        public static IObservable<System.String> get_FileName(this IObservable<System.IO.FileNotFoundException> FileNotFoundExceptionValue)
        {
            return Observable.Select(FileNotFoundExceptionValue, (FileNotFoundExceptionValueLambda) => FileNotFoundExceptionValueLambda.FileName);
        }


        public static IObservable<System.String> get_FusionLog(this IObservable<System.IO.FileNotFoundException> FileNotFoundExceptionValue)
        {
            return Observable.Select(FileNotFoundExceptionValue, (FileNotFoundExceptionValueLambda) => FileNotFoundExceptionValueLambda.FusionLog);
        }

    }
}