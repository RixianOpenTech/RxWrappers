using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System.Runtime.Serialization
{
    public static class __SerializationInfo
    {
        
        public static IObservable<System.Reactive.Unit> SetType(this IObservable<System.Runtime.Serialization.SerializationInfo> SerializationInfoValue, IObservable<System.Type> type)
        {
            return ObservableExt.ZipExecute(SerializationInfoValue, type, (SerializationInfoValueLambda, typeLambda) => SerializationInfoValueLambda.SetType(typeLambda));
        }


        public static IObservable<System.Runtime.Serialization.SerializationInfoEnumerator> GetEnumerator(this IObservable<System.Runtime.Serialization.SerializationInfo> SerializationInfoValue)
        {
            return Observable.Select(SerializationInfoValue, (SerializationInfoValueLambda) => SerializationInfoValueLambda.GetEnumerator());
        }


        public static IObservable<System.Reactive.Unit> AddValue(this IObservable<System.Runtime.Serialization.SerializationInfo> SerializationInfoValue, IObservable<System.String> name, IObservable<System.Object> value, IObservable<System.Type> type)
        {
            return ObservableExt.ZipExecute(SerializationInfoValue, name, value, type, (SerializationInfoValueLambda, nameLambda, valueLambda, typeLambda) => SerializationInfoValueLambda.AddValue(nameLambda, valueLambda, typeLambda));
        }


        public static IObservable<System.Reactive.Unit> AddValue(this IObservable<System.Runtime.Serialization.SerializationInfo> SerializationInfoValue, IObservable<System.String> name, IObservable<System.Object> value)
        {
            return ObservableExt.ZipExecute(SerializationInfoValue, name, value, (SerializationInfoValueLambda, nameLambda, valueLambda) => SerializationInfoValueLambda.AddValue(nameLambda, valueLambda));
        }


        public static IObservable<System.Reactive.Unit> AddValue(this IObservable<System.Runtime.Serialization.SerializationInfo> SerializationInfoValue, IObservable<System.String> name, IObservable<System.Boolean> value)
        {
            return ObservableExt.ZipExecute(SerializationInfoValue, name, value, (SerializationInfoValueLambda, nameLambda, valueLambda) => SerializationInfoValueLambda.AddValue(nameLambda, valueLambda));
        }


        public static IObservable<System.Reactive.Unit> AddValue(this IObservable<System.Runtime.Serialization.SerializationInfo> SerializationInfoValue, IObservable<System.String> name, IObservable<System.Char> value)
        {
            return ObservableExt.ZipExecute(SerializationInfoValue, name, value, (SerializationInfoValueLambda, nameLambda, valueLambda) => SerializationInfoValueLambda.AddValue(nameLambda, valueLambda));
        }


        public static IObservable<System.Reactive.Unit> AddValue(this IObservable<System.Runtime.Serialization.SerializationInfo> SerializationInfoValue, IObservable<System.String> name, IObservable<System.SByte> value)
        {
            return ObservableExt.ZipExecute(SerializationInfoValue, name, value, (SerializationInfoValueLambda, nameLambda, valueLambda) => SerializationInfoValueLambda.AddValue(nameLambda, valueLambda));
        }


        public static IObservable<System.Reactive.Unit> AddValue(this IObservable<System.Runtime.Serialization.SerializationInfo> SerializationInfoValue, IObservable<System.String> name, IObservable<System.Byte> value)
        {
            return ObservableExt.ZipExecute(SerializationInfoValue, name, value, (SerializationInfoValueLambda, nameLambda, valueLambda) => SerializationInfoValueLambda.AddValue(nameLambda, valueLambda));
        }


        public static IObservable<System.Reactive.Unit> AddValue(this IObservable<System.Runtime.Serialization.SerializationInfo> SerializationInfoValue, IObservable<System.String> name, IObservable<System.Int16> value)
        {
            return ObservableExt.ZipExecute(SerializationInfoValue, name, value, (SerializationInfoValueLambda, nameLambda, valueLambda) => SerializationInfoValueLambda.AddValue(nameLambda, valueLambda));
        }


        public static IObservable<System.Reactive.Unit> AddValue(this IObservable<System.Runtime.Serialization.SerializationInfo> SerializationInfoValue, IObservable<System.String> name, IObservable<System.UInt16> value)
        {
            return ObservableExt.ZipExecute(SerializationInfoValue, name, value, (SerializationInfoValueLambda, nameLambda, valueLambda) => SerializationInfoValueLambda.AddValue(nameLambda, valueLambda));
        }


        public static IObservable<System.Reactive.Unit> AddValue(this IObservable<System.Runtime.Serialization.SerializationInfo> SerializationInfoValue, IObservable<System.String> name, IObservable<System.Int32> value)
        {
            return ObservableExt.ZipExecute(SerializationInfoValue, name, value, (SerializationInfoValueLambda, nameLambda, valueLambda) => SerializationInfoValueLambda.AddValue(nameLambda, valueLambda));
        }


        public static IObservable<System.Reactive.Unit> AddValue(this IObservable<System.Runtime.Serialization.SerializationInfo> SerializationInfoValue, IObservable<System.String> name, IObservable<System.UInt32> value)
        {
            return ObservableExt.ZipExecute(SerializationInfoValue, name, value, (SerializationInfoValueLambda, nameLambda, valueLambda) => SerializationInfoValueLambda.AddValue(nameLambda, valueLambda));
        }


        public static IObservable<System.Reactive.Unit> AddValue(this IObservable<System.Runtime.Serialization.SerializationInfo> SerializationInfoValue, IObservable<System.String> name, IObservable<System.Int64> value)
        {
            return ObservableExt.ZipExecute(SerializationInfoValue, name, value, (SerializationInfoValueLambda, nameLambda, valueLambda) => SerializationInfoValueLambda.AddValue(nameLambda, valueLambda));
        }


        public static IObservable<System.Reactive.Unit> AddValue(this IObservable<System.Runtime.Serialization.SerializationInfo> SerializationInfoValue, IObservable<System.String> name, IObservable<System.UInt64> value)
        {
            return ObservableExt.ZipExecute(SerializationInfoValue, name, value, (SerializationInfoValueLambda, nameLambda, valueLambda) => SerializationInfoValueLambda.AddValue(nameLambda, valueLambda));
        }


        public static IObservable<System.Reactive.Unit> AddValue(this IObservable<System.Runtime.Serialization.SerializationInfo> SerializationInfoValue, IObservable<System.String> name, IObservable<System.Single> value)
        {
            return ObservableExt.ZipExecute(SerializationInfoValue, name, value, (SerializationInfoValueLambda, nameLambda, valueLambda) => SerializationInfoValueLambda.AddValue(nameLambda, valueLambda));
        }


        public static IObservable<System.Reactive.Unit> AddValue(this IObservable<System.Runtime.Serialization.SerializationInfo> SerializationInfoValue, IObservable<System.String> name, IObservable<System.Double> value)
        {
            return ObservableExt.ZipExecute(SerializationInfoValue, name, value, (SerializationInfoValueLambda, nameLambda, valueLambda) => SerializationInfoValueLambda.AddValue(nameLambda, valueLambda));
        }


        public static IObservable<System.Reactive.Unit> AddValue(this IObservable<System.Runtime.Serialization.SerializationInfo> SerializationInfoValue, IObservable<System.String> name, IObservable<System.Decimal> value)
        {
            return ObservableExt.ZipExecute(SerializationInfoValue, name, value, (SerializationInfoValueLambda, nameLambda, valueLambda) => SerializationInfoValueLambda.AddValue(nameLambda, valueLambda));
        }


        public static IObservable<System.Reactive.Unit> AddValue(this IObservable<System.Runtime.Serialization.SerializationInfo> SerializationInfoValue, IObservable<System.String> name, IObservable<System.DateTime> value)
        {
            return ObservableExt.ZipExecute(SerializationInfoValue, name, value, (SerializationInfoValueLambda, nameLambda, valueLambda) => SerializationInfoValueLambda.AddValue(nameLambda, valueLambda));
        }


        public static IObservable<System.Object> GetValue(this IObservable<System.Runtime.Serialization.SerializationInfo> SerializationInfoValue, IObservable<System.String> name, IObservable<System.Type> type)
        {
            return Observable.Zip(SerializationInfoValue, name, type, (SerializationInfoValueLambda, nameLambda, typeLambda) => SerializationInfoValueLambda.GetValue(nameLambda, typeLambda));
        }


        public static IObservable<System.Boolean> GetBoolean(this IObservable<System.Runtime.Serialization.SerializationInfo> SerializationInfoValue, IObservable<System.String> name)
        {
            return Observable.Zip(SerializationInfoValue, name, (SerializationInfoValueLambda, nameLambda) => SerializationInfoValueLambda.GetBoolean(nameLambda));
        }


        public static IObservable<System.Char> GetChar(this IObservable<System.Runtime.Serialization.SerializationInfo> SerializationInfoValue, IObservable<System.String> name)
        {
            return Observable.Zip(SerializationInfoValue, name, (SerializationInfoValueLambda, nameLambda) => SerializationInfoValueLambda.GetChar(nameLambda));
        }


        public static IObservable<System.SByte> GetSByte(this IObservable<System.Runtime.Serialization.SerializationInfo> SerializationInfoValue, IObservable<System.String> name)
        {
            return Observable.Zip(SerializationInfoValue, name, (SerializationInfoValueLambda, nameLambda) => SerializationInfoValueLambda.GetSByte(nameLambda));
        }


        public static IObservable<System.Byte> GetByte(this IObservable<System.Runtime.Serialization.SerializationInfo> SerializationInfoValue, IObservable<System.String> name)
        {
            return Observable.Zip(SerializationInfoValue, name, (SerializationInfoValueLambda, nameLambda) => SerializationInfoValueLambda.GetByte(nameLambda));
        }


        public static IObservable<System.Int16> GetInt16(this IObservable<System.Runtime.Serialization.SerializationInfo> SerializationInfoValue, IObservable<System.String> name)
        {
            return Observable.Zip(SerializationInfoValue, name, (SerializationInfoValueLambda, nameLambda) => SerializationInfoValueLambda.GetInt16(nameLambda));
        }


        public static IObservable<System.UInt16> GetUInt16(this IObservable<System.Runtime.Serialization.SerializationInfo> SerializationInfoValue, IObservable<System.String> name)
        {
            return Observable.Zip(SerializationInfoValue, name, (SerializationInfoValueLambda, nameLambda) => SerializationInfoValueLambda.GetUInt16(nameLambda));
        }


        public static IObservable<System.Int32> GetInt32(this IObservable<System.Runtime.Serialization.SerializationInfo> SerializationInfoValue, IObservable<System.String> name)
        {
            return Observable.Zip(SerializationInfoValue, name, (SerializationInfoValueLambda, nameLambda) => SerializationInfoValueLambda.GetInt32(nameLambda));
        }


        public static IObservable<System.UInt32> GetUInt32(this IObservable<System.Runtime.Serialization.SerializationInfo> SerializationInfoValue, IObservable<System.String> name)
        {
            return Observable.Zip(SerializationInfoValue, name, (SerializationInfoValueLambda, nameLambda) => SerializationInfoValueLambda.GetUInt32(nameLambda));
        }


        public static IObservable<System.Int64> GetInt64(this IObservable<System.Runtime.Serialization.SerializationInfo> SerializationInfoValue, IObservable<System.String> name)
        {
            return Observable.Zip(SerializationInfoValue, name, (SerializationInfoValueLambda, nameLambda) => SerializationInfoValueLambda.GetInt64(nameLambda));
        }


        public static IObservable<System.UInt64> GetUInt64(this IObservable<System.Runtime.Serialization.SerializationInfo> SerializationInfoValue, IObservable<System.String> name)
        {
            return Observable.Zip(SerializationInfoValue, name, (SerializationInfoValueLambda, nameLambda) => SerializationInfoValueLambda.GetUInt64(nameLambda));
        }


        public static IObservable<System.Single> GetSingle(this IObservable<System.Runtime.Serialization.SerializationInfo> SerializationInfoValue, IObservable<System.String> name)
        {
            return Observable.Zip(SerializationInfoValue, name, (SerializationInfoValueLambda, nameLambda) => SerializationInfoValueLambda.GetSingle(nameLambda));
        }


        public static IObservable<System.Double> GetDouble(this IObservable<System.Runtime.Serialization.SerializationInfo> SerializationInfoValue, IObservable<System.String> name)
        {
            return Observable.Zip(SerializationInfoValue, name, (SerializationInfoValueLambda, nameLambda) => SerializationInfoValueLambda.GetDouble(nameLambda));
        }


        public static IObservable<System.Decimal> GetDecimal(this IObservable<System.Runtime.Serialization.SerializationInfo> SerializationInfoValue, IObservable<System.String> name)
        {
            return Observable.Zip(SerializationInfoValue, name, (SerializationInfoValueLambda, nameLambda) => SerializationInfoValueLambda.GetDecimal(nameLambda));
        }


        public static IObservable<System.DateTime> GetDateTime(this IObservable<System.Runtime.Serialization.SerializationInfo> SerializationInfoValue, IObservable<System.String> name)
        {
            return Observable.Zip(SerializationInfoValue, name, (SerializationInfoValueLambda, nameLambda) => SerializationInfoValueLambda.GetDateTime(nameLambda));
        }


        public static IObservable<System.String> GetString(this IObservable<System.Runtime.Serialization.SerializationInfo> SerializationInfoValue, IObservable<System.String> name)
        {
            return Observable.Zip(SerializationInfoValue, name, (SerializationInfoValueLambda, nameLambda) => SerializationInfoValueLambda.GetString(nameLambda));
        }


        public static IObservable<System.String> get_FullTypeName(this IObservable<System.Runtime.Serialization.SerializationInfo> SerializationInfoValue)
        {
            return Observable.Select(SerializationInfoValue, (SerializationInfoValueLambda) => SerializationInfoValueLambda.FullTypeName);
        }


        public static IObservable<System.String> get_AssemblyName(this IObservable<System.Runtime.Serialization.SerializationInfo> SerializationInfoValue)
        {
            return Observable.Select(SerializationInfoValue, (SerializationInfoValueLambda) => SerializationInfoValueLambda.AssemblyName);
        }


        public static IObservable<System.Int32> get_MemberCount(this IObservable<System.Runtime.Serialization.SerializationInfo> SerializationInfoValue)
        {
            return Observable.Select(SerializationInfoValue, (SerializationInfoValueLambda) => SerializationInfoValueLambda.MemberCount);
        }


        public static IObservable<System.Type> get_ObjectType(this IObservable<System.Runtime.Serialization.SerializationInfo> SerializationInfoValue)
        {
            return Observable.Select(SerializationInfoValue, (SerializationInfoValueLambda) => SerializationInfoValueLambda.ObjectType);
        }


        public static IObservable<System.Boolean> get_IsFullTypeNameSetExplicit(this IObservable<System.Runtime.Serialization.SerializationInfo> SerializationInfoValue)
        {
            return Observable.Select(SerializationInfoValue, (SerializationInfoValueLambda) => SerializationInfoValueLambda.IsFullTypeNameSetExplicit);
        }


        public static IObservable<System.Boolean> get_IsAssemblyNameSetExplicit(this IObservable<System.Runtime.Serialization.SerializationInfo> SerializationInfoValue)
        {
            return Observable.Select(SerializationInfoValue, (SerializationInfoValueLambda) => SerializationInfoValueLambda.IsAssemblyNameSetExplicit);
        }


        public static IObservable<System.Reactive.Unit> set_FullTypeName(this IObservable<System.Runtime.Serialization.SerializationInfo> SerializationInfoValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(SerializationInfoValue, value, (SerializationInfoValueLambda, valueLambda) => SerializationInfoValueLambda.FullTypeName = valueLambda);
        }


        public static IObservable<System.Reactive.Unit> set_AssemblyName(this IObservable<System.Runtime.Serialization.SerializationInfo> SerializationInfoValue, IObservable<System.String> value)
        {
            return ObservableExt.ZipExecute(SerializationInfoValue, value, (SerializationInfoValueLambda, valueLambda) => SerializationInfoValueLambda.AssemblyName = valueLambda);
        }

    }
}