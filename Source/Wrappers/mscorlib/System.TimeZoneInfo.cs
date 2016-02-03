using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __TimeZoneInfo
    {
        public static IObservable<System.TimeZoneInfo.AdjustmentRule[]> GetAdjustmentRules(
            this IObservable<System.TimeZoneInfo> TimeZoneInfoValue)
        {
            return Observable.Select(TimeZoneInfoValue,
                (TimeZoneInfoValueLambda) => TimeZoneInfoValueLambda.GetAdjustmentRules());
        }


        public static IObservable<System.TimeSpan[]> GetAmbiguousTimeOffsets(
            this IObservable<System.TimeZoneInfo> TimeZoneInfoValue, IObservable<System.DateTimeOffset> dateTimeOffset)
        {
            return Observable.Zip(TimeZoneInfoValue, dateTimeOffset,
                (TimeZoneInfoValueLambda, dateTimeOffsetLambda) =>
                    TimeZoneInfoValueLambda.GetAmbiguousTimeOffsets(dateTimeOffsetLambda));
        }


        public static IObservable<System.TimeSpan[]> GetAmbiguousTimeOffsets(
            this IObservable<System.TimeZoneInfo> TimeZoneInfoValue, IObservable<System.DateTime> dateTime)
        {
            return Observable.Zip(TimeZoneInfoValue, dateTime,
                (TimeZoneInfoValueLambda, dateTimeLambda) =>
                    TimeZoneInfoValueLambda.GetAmbiguousTimeOffsets(dateTimeLambda));
        }


        public static IObservable<System.TimeSpan> GetUtcOffset(this IObservable<System.TimeZoneInfo> TimeZoneInfoValue,
            IObservable<System.DateTimeOffset> dateTimeOffset)
        {
            return Observable.Zip(TimeZoneInfoValue, dateTimeOffset,
                (TimeZoneInfoValueLambda, dateTimeOffsetLambda) =>
                    TimeZoneInfoValueLambda.GetUtcOffset(dateTimeOffsetLambda));
        }


        public static IObservable<System.TimeSpan> GetUtcOffset(this IObservable<System.TimeZoneInfo> TimeZoneInfoValue,
            IObservable<System.DateTime> dateTime)
        {
            return Observable.Zip(TimeZoneInfoValue, dateTime,
                (TimeZoneInfoValueLambda, dateTimeLambda) => TimeZoneInfoValueLambda.GetUtcOffset(dateTimeLambda));
        }


        public static IObservable<System.Boolean> IsAmbiguousTime(
            this IObservable<System.TimeZoneInfo> TimeZoneInfoValue, IObservable<System.DateTimeOffset> dateTimeOffset)
        {
            return Observable.Zip(TimeZoneInfoValue, dateTimeOffset,
                (TimeZoneInfoValueLambda, dateTimeOffsetLambda) =>
                    TimeZoneInfoValueLambda.IsAmbiguousTime(dateTimeOffsetLambda));
        }


        public static IObservable<System.Boolean> IsAmbiguousTime(
            this IObservable<System.TimeZoneInfo> TimeZoneInfoValue, IObservable<System.DateTime> dateTime)
        {
            return Observable.Zip(TimeZoneInfoValue, dateTime,
                (TimeZoneInfoValueLambda, dateTimeLambda) => TimeZoneInfoValueLambda.IsAmbiguousTime(dateTimeLambda));
        }


        public static IObservable<System.Boolean> IsDaylightSavingTime(
            this IObservable<System.TimeZoneInfo> TimeZoneInfoValue, IObservable<System.DateTimeOffset> dateTimeOffset)
        {
            return Observable.Zip(TimeZoneInfoValue, dateTimeOffset,
                (TimeZoneInfoValueLambda, dateTimeOffsetLambda) =>
                    TimeZoneInfoValueLambda.IsDaylightSavingTime(dateTimeOffsetLambda));
        }


        public static IObservable<System.Boolean> IsDaylightSavingTime(
            this IObservable<System.TimeZoneInfo> TimeZoneInfoValue, IObservable<System.DateTime> dateTime)
        {
            return Observable.Zip(TimeZoneInfoValue, dateTime,
                (TimeZoneInfoValueLambda, dateTimeLambda) =>
                    TimeZoneInfoValueLambda.IsDaylightSavingTime(dateTimeLambda));
        }


        public static IObservable<System.Boolean> IsInvalidTime(this IObservable<System.TimeZoneInfo> TimeZoneInfoValue,
            IObservable<System.DateTime> dateTime)
        {
            return Observable.Zip(TimeZoneInfoValue, dateTime,
                (TimeZoneInfoValueLambda, dateTimeLambda) => TimeZoneInfoValueLambda.IsInvalidTime(dateTimeLambda));
        }


        public static IObservable<System.Reactive.Unit> ClearCachedData()
        {
            return ObservableExt.Factory(() => System.TimeZoneInfo.ClearCachedData());
        }


        public static IObservable<System.DateTimeOffset> ConvertTimeBySystemTimeZoneId(
            IObservable<System.DateTimeOffset> dateTimeOffset, IObservable<System.String> destinationTimeZoneId)
        {
            return Observable.Zip(dateTimeOffset, destinationTimeZoneId,
                (dateTimeOffsetLambda, destinationTimeZoneIdLambda) =>
                    System.TimeZoneInfo.ConvertTimeBySystemTimeZoneId(dateTimeOffsetLambda, destinationTimeZoneIdLambda));
        }


        public static IObservable<System.DateTime> ConvertTimeBySystemTimeZoneId(IObservable<System.DateTime> dateTime,
            IObservable<System.String> destinationTimeZoneId)
        {
            return Observable.Zip(dateTime, destinationTimeZoneId,
                (dateTimeLambda, destinationTimeZoneIdLambda) =>
                    System.TimeZoneInfo.ConvertTimeBySystemTimeZoneId(dateTimeLambda, destinationTimeZoneIdLambda));
        }


        public static IObservable<System.DateTime> ConvertTimeBySystemTimeZoneId(IObservable<System.DateTime> dateTime,
            IObservable<System.String> sourceTimeZoneId, IObservable<System.String> destinationTimeZoneId)
        {
            return Observable.Zip(dateTime, sourceTimeZoneId, destinationTimeZoneId,
                (dateTimeLambda, sourceTimeZoneIdLambda, destinationTimeZoneIdLambda) =>
                    System.TimeZoneInfo.ConvertTimeBySystemTimeZoneId(dateTimeLambda, sourceTimeZoneIdLambda,
                        destinationTimeZoneIdLambda));
        }


        public static IObservable<System.DateTimeOffset> ConvertTime(IObservable<System.DateTimeOffset> dateTimeOffset,
            IObservable<System.TimeZoneInfo> destinationTimeZone)
        {
            return Observable.Zip(dateTimeOffset, destinationTimeZone,
                (dateTimeOffsetLambda, destinationTimeZoneLambda) =>
                    System.TimeZoneInfo.ConvertTime(dateTimeOffsetLambda, destinationTimeZoneLambda));
        }


        public static IObservable<System.DateTime> ConvertTime(IObservable<System.DateTime> dateTime,
            IObservable<System.TimeZoneInfo> destinationTimeZone)
        {
            return Observable.Zip(dateTime, destinationTimeZone,
                (dateTimeLambda, destinationTimeZoneLambda) =>
                    System.TimeZoneInfo.ConvertTime(dateTimeLambda, destinationTimeZoneLambda));
        }


        public static IObservable<System.DateTime> ConvertTime(IObservable<System.DateTime> dateTime,
            IObservable<System.TimeZoneInfo> sourceTimeZone, IObservable<System.TimeZoneInfo> destinationTimeZone)
        {
            return Observable.Zip(dateTime, sourceTimeZone, destinationTimeZone,
                (dateTimeLambda, sourceTimeZoneLambda, destinationTimeZoneLambda) =>
                    System.TimeZoneInfo.ConvertTime(dateTimeLambda, sourceTimeZoneLambda, destinationTimeZoneLambda));
        }


        public static IObservable<System.DateTime> ConvertTimeFromUtc(IObservable<System.DateTime> dateTime,
            IObservable<System.TimeZoneInfo> destinationTimeZone)
        {
            return Observable.Zip(dateTime, destinationTimeZone,
                (dateTimeLambda, destinationTimeZoneLambda) =>
                    System.TimeZoneInfo.ConvertTimeFromUtc(dateTimeLambda, destinationTimeZoneLambda));
        }


        public static IObservable<System.DateTime> ConvertTimeToUtc(IObservable<System.DateTime> dateTime)
        {
            return Observable.Select(dateTime, (dateTimeLambda) => System.TimeZoneInfo.ConvertTimeToUtc(dateTimeLambda));
        }


        public static IObservable<System.DateTime> ConvertTimeToUtc(IObservable<System.DateTime> dateTime,
            IObservable<System.TimeZoneInfo> sourceTimeZone)
        {
            return Observable.Zip(dateTime, sourceTimeZone,
                (dateTimeLambda, sourceTimeZoneLambda) =>
                    System.TimeZoneInfo.ConvertTimeToUtc(dateTimeLambda, sourceTimeZoneLambda));
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.TimeZoneInfo> TimeZoneInfoValue,
            IObservable<System.TimeZoneInfo> other)
        {
            return Observable.Zip(TimeZoneInfoValue, other,
                (TimeZoneInfoValueLambda, otherLambda) => TimeZoneInfoValueLambda.Equals(otherLambda));
        }


        public static IObservable<System.Boolean> Equals(this IObservable<System.TimeZoneInfo> TimeZoneInfoValue,
            IObservable<System.Object> obj)
        {
            return Observable.Zip(TimeZoneInfoValue, obj,
                (TimeZoneInfoValueLambda, objLambda) => TimeZoneInfoValueLambda.Equals(objLambda));
        }


        public static IObservable<System.TimeZoneInfo> FromSerializedString(IObservable<System.String> source)
        {
            return Observable.Select(source, (sourceLambda) => System.TimeZoneInfo.FromSerializedString(sourceLambda));
        }


        public static IObservable<System.Int32> GetHashCode(this IObservable<System.TimeZoneInfo> TimeZoneInfoValue)
        {
            return Observable.Select(TimeZoneInfoValue,
                (TimeZoneInfoValueLambda) => TimeZoneInfoValueLambda.GetHashCode());
        }


        public static IObservable<System.Collections.ObjectModel.ReadOnlyCollection<System.TimeZoneInfo>>
            GetSystemTimeZones()
        {
            return ObservableExt.Factory(() => System.TimeZoneInfo.GetSystemTimeZones());
        }


        public static IObservable<System.Boolean> HasSameRules(this IObservable<System.TimeZoneInfo> TimeZoneInfoValue,
            IObservable<System.TimeZoneInfo> other)
        {
            return Observable.Zip(TimeZoneInfoValue, other,
                (TimeZoneInfoValueLambda, otherLambda) => TimeZoneInfoValueLambda.HasSameRules(otherLambda));
        }


        public static IObservable<System.String> ToSerializedString(
            this IObservable<System.TimeZoneInfo> TimeZoneInfoValue)
        {
            return Observable.Select(TimeZoneInfoValue,
                (TimeZoneInfoValueLambda) => TimeZoneInfoValueLambda.ToSerializedString());
        }


        public static IObservable<System.String> ToString(this IObservable<System.TimeZoneInfo> TimeZoneInfoValue)
        {
            return Observable.Select(TimeZoneInfoValue, (TimeZoneInfoValueLambda) => TimeZoneInfoValueLambda.ToString());
        }


        public static IObservable<System.TimeZoneInfo> CreateCustomTimeZone(IObservable<System.String> id,
            IObservable<System.TimeSpan> baseUtcOffset, IObservable<System.String> displayName,
            IObservable<System.String> standardDisplayName)
        {
            return Observable.Zip(id, baseUtcOffset, displayName, standardDisplayName,
                (idLambda, baseUtcOffsetLambda, displayNameLambda, standardDisplayNameLambda) =>
                    System.TimeZoneInfo.CreateCustomTimeZone(idLambda, baseUtcOffsetLambda, displayNameLambda,
                        standardDisplayNameLambda));
        }


        public static IObservable<System.TimeZoneInfo> CreateCustomTimeZone(IObservable<System.String> id,
            IObservable<System.TimeSpan> baseUtcOffset, IObservable<System.String> displayName,
            IObservable<System.String> standardDisplayName, IObservable<System.String> daylightDisplayName,
            IObservable<System.TimeZoneInfo.AdjustmentRule[]> adjustmentRules)
        {
            return Observable.Zip(id, baseUtcOffset, displayName, standardDisplayName, daylightDisplayName,
                adjustmentRules,
                (idLambda, baseUtcOffsetLambda, displayNameLambda, standardDisplayNameLambda, daylightDisplayNameLambda,
                    adjustmentRulesLambda) =>
                    System.TimeZoneInfo.CreateCustomTimeZone(idLambda, baseUtcOffsetLambda, displayNameLambda,
                        standardDisplayNameLambda, daylightDisplayNameLambda, adjustmentRulesLambda));
        }


        public static IObservable<System.TimeZoneInfo> CreateCustomTimeZone(IObservable<System.String> id,
            IObservable<System.TimeSpan> baseUtcOffset, IObservable<System.String> displayName,
            IObservable<System.String> standardDisplayName, IObservable<System.String> daylightDisplayName,
            IObservable<System.TimeZoneInfo.AdjustmentRule[]> adjustmentRules,
            IObservable<System.Boolean> disableDaylightSavingTime)
        {
            return Observable.Zip(id, baseUtcOffset, displayName, standardDisplayName, daylightDisplayName,
                adjustmentRules, disableDaylightSavingTime,
                (idLambda, baseUtcOffsetLambda, displayNameLambda, standardDisplayNameLambda, daylightDisplayNameLambda,
                    adjustmentRulesLambda, disableDaylightSavingTimeLambda) =>
                    System.TimeZoneInfo.CreateCustomTimeZone(idLambda, baseUtcOffsetLambda, displayNameLambda,
                        standardDisplayNameLambda, daylightDisplayNameLambda, adjustmentRulesLambda,
                        disableDaylightSavingTimeLambda));
        }


        public static IObservable<System.TimeZoneInfo> FindSystemTimeZoneById(IObservable<System.String> id)
        {
            return Observable.Select(id, (idLambda) => System.TimeZoneInfo.FindSystemTimeZoneById(idLambda));
        }


        public static IObservable<System.String> get_Id(this IObservable<System.TimeZoneInfo> TimeZoneInfoValue)
        {
            return Observable.Select(TimeZoneInfoValue, (TimeZoneInfoValueLambda) => TimeZoneInfoValueLambda.Id);
        }


        public static IObservable<System.String> get_DisplayName(this IObservable<System.TimeZoneInfo> TimeZoneInfoValue)
        {
            return Observable.Select(TimeZoneInfoValue, (TimeZoneInfoValueLambda) => TimeZoneInfoValueLambda.DisplayName);
        }


        public static IObservable<System.String> get_StandardName(
            this IObservable<System.TimeZoneInfo> TimeZoneInfoValue)
        {
            return Observable.Select(TimeZoneInfoValue,
                (TimeZoneInfoValueLambda) => TimeZoneInfoValueLambda.StandardName);
        }


        public static IObservable<System.String> get_DaylightName(
            this IObservable<System.TimeZoneInfo> TimeZoneInfoValue)
        {
            return Observable.Select(TimeZoneInfoValue,
                (TimeZoneInfoValueLambda) => TimeZoneInfoValueLambda.DaylightName);
        }


        public static IObservable<System.TimeSpan> get_BaseUtcOffset(
            this IObservable<System.TimeZoneInfo> TimeZoneInfoValue)
        {
            return Observable.Select(TimeZoneInfoValue,
                (TimeZoneInfoValueLambda) => TimeZoneInfoValueLambda.BaseUtcOffset);
        }


        public static IObservable<System.Boolean> get_SupportsDaylightSavingTime(
            this IObservable<System.TimeZoneInfo> TimeZoneInfoValue)
        {
            return Observable.Select(TimeZoneInfoValue,
                (TimeZoneInfoValueLambda) => TimeZoneInfoValueLambda.SupportsDaylightSavingTime);
        }


        public static IObservable<System.TimeZoneInfo> get_Local()
        {
            return ObservableExt.Factory(() => System.TimeZoneInfo.Local);
        }


        public static IObservable<System.TimeZoneInfo> get_Utc()
        {
            return ObservableExt.Factory(() => System.TimeZoneInfo.Utc);
        }
    }
}