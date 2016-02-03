using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Security.Cryptography
{
    public static class __RandomNumberGenerator
    {
        
        public static IObservable<System.Security.Cryptography.RandomNumberGenerator> Create()
        {
            return ObservableExt.Factory(() => System.Security.Cryptography.RandomNumberGenerator.Create());
        }


        public static IObservable<System.Security.Cryptography.RandomNumberGenerator> Create(IObservable<System.String> rngName)
        {
            return Observable.Select(rngName, (rngNameLambda) => System.Security.Cryptography.RandomNumberGenerator.Create(rngNameLambda));
        }


        public static IObservable<System.Reactive.Unit> Dispose(this IObservable<System.Security.Cryptography.RandomNumberGenerator> RandomNumberGeneratorValue)
        {
            return Observable.Do(RandomNumberGeneratorValue, (RandomNumberGeneratorValueLambda) => RandomNumberGeneratorValueLambda.Dispose()).ToUnit();
        }


        public static IObservable<System.Reactive.Unit> GetBytes(this IObservable<System.Security.Cryptography.RandomNumberGenerator> RandomNumberGeneratorValue, IObservable<System.Byte[]> data)
        {
            return ObservableExt.ZipExecute(RandomNumberGeneratorValue, data, (RandomNumberGeneratorValueLambda, dataLambda) => RandomNumberGeneratorValueLambda.GetBytes(dataLambda));
        }


        public static IObservable<System.Reactive.Unit> GetBytes(this IObservable<System.Security.Cryptography.RandomNumberGenerator> RandomNumberGeneratorValue, IObservable<System.Byte[]> data, IObservable<System.Int32> offset, IObservable<System.Int32> count)
        {
            return ObservableExt.ZipExecute(RandomNumberGeneratorValue, data, offset, count, (RandomNumberGeneratorValueLambda, dataLambda, offsetLambda, countLambda) => RandomNumberGeneratorValueLambda.GetBytes(dataLambda, offsetLambda, countLambda));
        }


        public static IObservable<System.Reactive.Unit> GetNonZeroBytes(this IObservable<System.Security.Cryptography.RandomNumberGenerator> RandomNumberGeneratorValue, IObservable<System.Byte[]> data)
        {
            return ObservableExt.ZipExecute(RandomNumberGeneratorValue, data, (RandomNumberGeneratorValueLambda, dataLambda) => RandomNumberGeneratorValueLambda.GetNonZeroBytes(dataLambda));
        }

    }
}