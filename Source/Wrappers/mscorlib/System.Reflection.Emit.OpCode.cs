using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Reflection.Emit
{
    public static class __OpCode
    {
        public static IObservable<System.Boolean> Equals(this IObservable<System.Reflection.Emit.OpCode> OpCodeValue,
            IObservable<System.Object> obj)
        {
            return Observable.Zip(OpCodeValue, obj,
                (OpCodeValueLambda, objLambda) => OpCodeValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.Reflection.Emit.OpCode> OpCodeValue,
            IObservable<System.Reflection.Emit.OpCode> obj)
        {
            return Observable.Zip(OpCodeValue, obj,
                (OpCodeValueLambda, objLambda) => OpCodeValueLambda.Equals(objLambda));
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System.Reflection.Emit.OpCode> OpCodeValue)
        {
            return Observable.Select(OpCodeValue, (OpCodeValueLambda) => OpCodeValueLambda.GetHashCode());
        }


        public static IObservable<System.String> ToString(this IObservable<System.Reflection.Emit.OpCode> OpCodeValue)
        {
            return Observable.Select(OpCodeValue, (OpCodeValueLambda) => OpCodeValueLambda.ToString());
        }


        public static IObservable<System.Reflection.Emit.OperandType> get_OperandType(
            this IObservable<System.Reflection.Emit.OpCode> OpCodeValue)
        {
            return Observable.Select(OpCodeValue, (OpCodeValueLambda) => OpCodeValueLambda.OperandType);
        }


        public static IObservable<System.Reflection.Emit.FlowControl> get_FlowControl(
            this IObservable<System.Reflection.Emit.OpCode> OpCodeValue)
        {
            return Observable.Select(OpCodeValue, (OpCodeValueLambda) => OpCodeValueLambda.FlowControl);
        }


        public static IObservable<System.Reflection.Emit.OpCodeType> get_OpCodeType(
            this IObservable<System.Reflection.Emit.OpCode> OpCodeValue)
        {
            return Observable.Select(OpCodeValue, (OpCodeValueLambda) => OpCodeValueLambda.OpCodeType);
        }


        public static IObservable<System.Reflection.Emit.StackBehaviour> get_StackBehaviourPop(
            this IObservable<System.Reflection.Emit.OpCode> OpCodeValue)
        {
            return Observable.Select(OpCodeValue, (OpCodeValueLambda) => OpCodeValueLambda.StackBehaviourPop);
        }


        public static IObservable<System.Reflection.Emit.StackBehaviour> get_StackBehaviourPush(
            this IObservable<System.Reflection.Emit.OpCode> OpCodeValue)
        {
            return Observable.Select(OpCodeValue, (OpCodeValueLambda) => OpCodeValueLambda.StackBehaviourPush);
        }


        public static IObservable<System.Int32> get_Size(this IObservable<System.Reflection.Emit.OpCode> OpCodeValue)
        {
            return Observable.Select(OpCodeValue, (OpCodeValueLambda) => OpCodeValueLambda.Size);
        }


        public static IObservable<System.Int16> get_Value(this IObservable<System.Reflection.Emit.OpCode> OpCodeValue)
        {
            return Observable.Select(OpCodeValue, (OpCodeValueLambda) => OpCodeValueLambda.Value);
        }


        public static IObservable<System.String> get_Name(this IObservable<System.Reflection.Emit.OpCode> OpCodeValue)
        {
            return Observable.Select(OpCodeValue, (OpCodeValueLambda) => OpCodeValueLambda.Name);
        }
    }
}