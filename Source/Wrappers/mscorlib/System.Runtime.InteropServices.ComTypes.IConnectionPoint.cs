using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.InteropServices.ComTypes
{
    public static class __IConnectionPoint
    {
        public static IObservable<System.Guid> GetConnectionInterface(
            this IObservable<System.Runtime.InteropServices.ComTypes.IConnectionPoint> IConnectionPointValue)
        {
            return Observable.Select(IConnectionPointValue, (IConnectionPointValueLambda) =>
            {
                System.Guid pIIDOutput = default(System.Guid);
                IConnectionPointValueLambda.GetConnectionInterface(out pIIDOutput);
                return pIIDOutput;
            });
        }


        public static IObservable<System.Runtime.InteropServices.ComTypes.IConnectionPointContainer>
            GetConnectionPointContainer(
            this IObservable<System.Runtime.InteropServices.ComTypes.IConnectionPoint> IConnectionPointValue)
        {
            return Observable.Select(IConnectionPointValue, (IConnectionPointValueLambda) =>
            {
                System.Runtime.InteropServices.ComTypes.IConnectionPointContainer ppCPCOutput =
                    default(System.Runtime.InteropServices.ComTypes.IConnectionPointContainer);
                IConnectionPointValueLambda.GetConnectionPointContainer(out ppCPCOutput);
                return ppCPCOutput;
            });
        }


        public static IObservable<System.Int32> Advise(
            this IObservable<System.Runtime.InteropServices.ComTypes.IConnectionPoint> IConnectionPointValue,
            IObservable<System.Object> pUnkSink)
        {
            return Observable.Zip(IConnectionPointValue, pUnkSink, (IConnectionPointValueLambda, pUnkSinkLambda) =>
            {
                System.Int32 pdwCookieOutput = default(System.Int32);
                IConnectionPointValueLambda.Advise(pUnkSinkLambda, out pdwCookieOutput);
                return pdwCookieOutput;
            });
        }


        public static IObservable<System.Reactive.Unit> Unadvise(
            this IObservable<System.Runtime.InteropServices.ComTypes.IConnectionPoint> IConnectionPointValue,
            IObservable<System.Int32> dwCookie)
        {
            return ObservableExt.ZipExecute(IConnectionPointValue, dwCookie,
                (IConnectionPointValueLambda, dwCookieLambda) => IConnectionPointValueLambda.Unadvise(dwCookieLambda));
        }


        public static IObservable<System.Runtime.InteropServices.ComTypes.IEnumConnections> EnumConnections(
            this IObservable<System.Runtime.InteropServices.ComTypes.IConnectionPoint> IConnectionPointValue)
        {
            return Observable.Select(IConnectionPointValue, (IConnectionPointValueLambda) =>
            {
                System.Runtime.InteropServices.ComTypes.IEnumConnections ppEnumOutput =
                    default(System.Runtime.InteropServices.ComTypes.IEnumConnections);
                IConnectionPointValueLambda.EnumConnections(out ppEnumOutput);
                return ppEnumOutput;
            });
        }
    }
}