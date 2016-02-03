using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection.Emit
{
    public static class __SignatureHelper
    {
        
        public static IObservable<System.Reflection.Emit.SignatureHelper> GetMethodSigHelper(IObservable<System.Reflection.Module> mod, IObservable<System.Type> returnType, IObservable<System.Type[]> parameterTypes)
        {
            return Observable.Zip(mod, returnType, parameterTypes, (modLambda, returnTypeLambda, parameterTypesLambda) => System.Reflection.Emit.SignatureHelper.GetMethodSigHelper(modLambda, returnTypeLambda, parameterTypesLambda));
        }


        public static IObservable<System.Reflection.Emit.SignatureHelper> GetMethodSigHelper(IObservable<System.Reflection.Module> mod, IObservable<System.Reflection.CallingConventions> callingConvention, IObservable<System.Type> returnType)
        {
            return Observable.Zip(mod, callingConvention, returnType, (modLambda, callingConventionLambda, returnTypeLambda) => System.Reflection.Emit.SignatureHelper.GetMethodSigHelper(modLambda, callingConventionLambda, returnTypeLambda));
        }


        public static IObservable<System.Reflection.Emit.SignatureHelper> GetMethodSigHelper(IObservable<System.Reflection.Module> mod, IObservable<System.Runtime.InteropServices.CallingConvention> unmanagedCallConv, IObservable<System.Type> returnType)
        {
            return Observable.Zip(mod, unmanagedCallConv, returnType, (modLambda, unmanagedCallConvLambda, returnTypeLambda) => System.Reflection.Emit.SignatureHelper.GetMethodSigHelper(modLambda, unmanagedCallConvLambda, returnTypeLambda));
        }


        public static IObservable<System.Reflection.Emit.SignatureHelper> GetLocalVarSigHelper()
        {
            return ObservableExt.Factory(() => System.Reflection.Emit.SignatureHelper.GetLocalVarSigHelper());
        }


        public static IObservable<System.Reflection.Emit.SignatureHelper> GetMethodSigHelper(IObservable<System.Reflection.CallingConventions> callingConvention, IObservable<System.Type> returnType)
        {
            return Observable.Zip(callingConvention, returnType, (callingConventionLambda, returnTypeLambda) => System.Reflection.Emit.SignatureHelper.GetMethodSigHelper(callingConventionLambda, returnTypeLambda));
        }


        public static IObservable<System.Reflection.Emit.SignatureHelper> GetMethodSigHelper(IObservable<System.Runtime.InteropServices.CallingConvention> unmanagedCallingConvention, IObservable<System.Type> returnType)
        {
            return Observable.Zip(unmanagedCallingConvention, returnType, (unmanagedCallingConventionLambda, returnTypeLambda) => System.Reflection.Emit.SignatureHelper.GetMethodSigHelper(unmanagedCallingConventionLambda, returnTypeLambda));
        }


        public static IObservable<System.Reflection.Emit.SignatureHelper> GetLocalVarSigHelper(IObservable<System.Reflection.Module> mod)
        {
            return Observable.Select(mod, (modLambda) => System.Reflection.Emit.SignatureHelper.GetLocalVarSigHelper(modLambda));
        }


        public static IObservable<System.Reflection.Emit.SignatureHelper> GetFieldSigHelper(IObservable<System.Reflection.Module> mod)
        {
            return Observable.Select(mod, (modLambda) => System.Reflection.Emit.SignatureHelper.GetFieldSigHelper(modLambda));
        }


        public static IObservable<System.Reflection.Emit.SignatureHelper> GetPropertySigHelper(IObservable<System.Reflection.Module> mod, IObservable<System.Type> returnType, IObservable<System.Type[]> parameterTypes)
        {
            return Observable.Zip(mod, returnType, parameterTypes, (modLambda, returnTypeLambda, parameterTypesLambda) => System.Reflection.Emit.SignatureHelper.GetPropertySigHelper(modLambda, returnTypeLambda, parameterTypesLambda));
        }


        public static IObservable<System.Reflection.Emit.SignatureHelper> GetPropertySigHelper(IObservable<System.Reflection.Module> mod, IObservable<System.Type> returnType, IObservable<System.Type[]> requiredReturnTypeCustomModifiers, IObservable<System.Type[]> optionalReturnTypeCustomModifiers, IObservable<System.Type[]> parameterTypes, IObservable<System.Type[][]> requiredParameterTypeCustomModifiers, IObservable<System.Type[][]> optionalParameterTypeCustomModifiers)
        {
            return Observable.Zip(mod, returnType, requiredReturnTypeCustomModifiers, optionalReturnTypeCustomModifiers, parameterTypes, requiredParameterTypeCustomModifiers, optionalParameterTypeCustomModifiers, (modLambda, returnTypeLambda, requiredReturnTypeCustomModifiersLambda, optionalReturnTypeCustomModifiersLambda, parameterTypesLambda, requiredParameterTypeCustomModifiersLambda, optionalParameterTypeCustomModifiersLambda) => System.Reflection.Emit.SignatureHelper.GetPropertySigHelper(modLambda, returnTypeLambda, requiredReturnTypeCustomModifiersLambda, optionalReturnTypeCustomModifiersLambda, parameterTypesLambda, requiredParameterTypeCustomModifiersLambda, optionalParameterTypeCustomModifiersLambda));
        }


        public static IObservable<System.Reflection.Emit.SignatureHelper> GetPropertySigHelper(IObservable<System.Reflection.Module> mod, IObservable<System.Reflection.CallingConventions> callingConvention, IObservable<System.Type> returnType, IObservable<System.Type[]> requiredReturnTypeCustomModifiers, IObservable<System.Type[]> optionalReturnTypeCustomModifiers, IObservable<System.Type[]> parameterTypes, IObservable<System.Type[][]> requiredParameterTypeCustomModifiers, IObservable<System.Type[][]> optionalParameterTypeCustomModifiers)
        {
            return Observable.Zip(mod, callingConvention, returnType, requiredReturnTypeCustomModifiers, optionalReturnTypeCustomModifiers, parameterTypes, requiredParameterTypeCustomModifiers, optionalParameterTypeCustomModifiers, (modLambda, callingConventionLambda, returnTypeLambda, requiredReturnTypeCustomModifiersLambda, optionalReturnTypeCustomModifiersLambda, parameterTypesLambda, requiredParameterTypeCustomModifiersLambda, optionalParameterTypeCustomModifiersLambda) => System.Reflection.Emit.SignatureHelper.GetPropertySigHelper(modLambda, callingConventionLambda, returnTypeLambda, requiredReturnTypeCustomModifiersLambda, optionalReturnTypeCustomModifiersLambda, parameterTypesLambda, requiredParameterTypeCustomModifiersLambda, optionalParameterTypeCustomModifiersLambda));
        }


        public static IObservable<System.Reactive.Unit> AddArgument(this IObservable<System.Reflection.Emit.SignatureHelper> SignatureHelperValue, IObservable<System.Type> clsArgument)
        {
            return ObservableExt.ZipExecute(SignatureHelperValue, clsArgument, (SignatureHelperValueLambda, clsArgumentLambda) => SignatureHelperValueLambda.AddArgument(clsArgumentLambda));
        }


        public static IObservable<System.Reactive.Unit> AddArgument(this IObservable<System.Reflection.Emit.SignatureHelper> SignatureHelperValue, IObservable<System.Type> argument, IObservable<System.Boolean> pinned)
        {
            return ObservableExt.ZipExecute(SignatureHelperValue, argument, pinned, (SignatureHelperValueLambda, argumentLambda, pinnedLambda) => SignatureHelperValueLambda.AddArgument(argumentLambda, pinnedLambda));
        }


        public static IObservable<System.Reactive.Unit> AddArguments(this IObservable<System.Reflection.Emit.SignatureHelper> SignatureHelperValue, IObservable<System.Type[]> arguments, IObservable<System.Type[][]> requiredCustomModifiers, IObservable<System.Type[][]> optionalCustomModifiers)
        {
            return ObservableExt.ZipExecute(SignatureHelperValue, arguments, requiredCustomModifiers, optionalCustomModifiers, (SignatureHelperValueLambda, argumentsLambda, requiredCustomModifiersLambda, optionalCustomModifiersLambda) => SignatureHelperValueLambda.AddArguments(argumentsLambda, requiredCustomModifiersLambda, optionalCustomModifiersLambda));
        }


        public static IObservable<System.Reactive.Unit> AddArgument(this IObservable<System.Reflection.Emit.SignatureHelper> SignatureHelperValue, IObservable<System.Type> argument, IObservable<System.Type[]> requiredCustomModifiers, IObservable<System.Type[]> optionalCustomModifiers)
        {
            return ObservableExt.ZipExecute(SignatureHelperValue, argument, requiredCustomModifiers, optionalCustomModifiers, (SignatureHelperValueLambda, argumentLambda, requiredCustomModifiersLambda, optionalCustomModifiersLambda) => SignatureHelperValueLambda.AddArgument(argumentLambda, requiredCustomModifiersLambda, optionalCustomModifiersLambda));
        }


        public static IObservable<System.Reactive.Unit> AddSentinel(this IObservable<System.Reflection.Emit.SignatureHelper> SignatureHelperValue)
        {
            return Observable.Do(SignatureHelperValue, (SignatureHelperValueLambda) => SignatureHelperValueLambda.AddSentinel()).ToUnit();
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.Reflection.Emit.SignatureHelper> SignatureHelperValue, IObservable<System.Object> obj)
        {
            return Observable.Zip(SignatureHelperValue, obj, (SignatureHelperValueLambda, objLambda) => SignatureHelperValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System.Reflection.Emit.SignatureHelper> SignatureHelperValue)
        {
            return Observable.Select(SignatureHelperValue, (SignatureHelperValueLambda) => SignatureHelperValueLambda.GetHashCode());
        }


        public static IObservable<System.Byte[]> GetSignature(this IObservable<System.Reflection.Emit.SignatureHelper> SignatureHelperValue)
        {
            return Observable.Select(SignatureHelperValue, (SignatureHelperValueLambda) => SignatureHelperValueLambda.GetSignature());
        }


        public static IObservable<System.String> ToString(this IObservable<System.Reflection.Emit.SignatureHelper> SignatureHelperValue)
        {
            return Observable.Select(SignatureHelperValue, (SignatureHelperValueLambda) => SignatureHelperValueLambda.ToString());
        }

    }
}