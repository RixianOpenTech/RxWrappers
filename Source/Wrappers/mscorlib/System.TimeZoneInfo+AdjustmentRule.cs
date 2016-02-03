using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using MS.Core;

namespace System
{
    public static class __AdjustmentRule
    {
        public static IObservable<System.Boolean> Equals(
            this IObservable<System.TimeZoneInfo.AdjustmentRule> AdjustmentRuleValue,
            IObservable<System.TimeZoneInfo.AdjustmentRule> other)
        {
            return Observable.Zip(AdjustmentRuleValue, other,
                (AdjustmentRuleValueLambda, otherLambda) => AdjustmentRuleValueLambda.Equals(otherLambda));
        }


        public static IObservable<System.Int32> GetHashCode(
            this IObservable<System.TimeZoneInfo.AdjustmentRule> AdjustmentRuleValue)
        {
            return Observable.Select(AdjustmentRuleValue,
                (AdjustmentRuleValueLambda) => AdjustmentRuleValueLambda.GetHashCode());
        }


        public static IObservable<System.TimeZoneInfo.AdjustmentRule> CreateAdjustmentRule(
            IObservable<System.DateTime> dateStart, IObservable<System.DateTime> dateEnd,
            IObservable<System.TimeSpan> daylightDelta,
            IObservable<System.TimeZoneInfo.TransitionTime> daylightTransitionStart,
            IObservable<System.TimeZoneInfo.TransitionTime> daylightTransitionEnd)
        {
            return Observable.Zip(dateStart, dateEnd, daylightDelta, daylightTransitionStart, daylightTransitionEnd,
                (dateStartLambda, dateEndLambda, daylightDeltaLambda, daylightTransitionStartLambda,
                    daylightTransitionEndLambda) =>
                    System.TimeZoneInfo.AdjustmentRule.CreateAdjustmentRule(dateStartLambda, dateEndLambda,
                        daylightDeltaLambda, daylightTransitionStartLambda, daylightTransitionEndLambda));
        }


        public static IObservable<System.DateTime> get_DateStart(
            this IObservable<System.TimeZoneInfo.AdjustmentRule> AdjustmentRuleValue)
        {
            return Observable.Select(AdjustmentRuleValue,
                (AdjustmentRuleValueLambda) => AdjustmentRuleValueLambda.DateStart);
        }


        public static IObservable<System.DateTime> get_DateEnd(
            this IObservable<System.TimeZoneInfo.AdjustmentRule> AdjustmentRuleValue)
        {
            return Observable.Select(AdjustmentRuleValue,
                (AdjustmentRuleValueLambda) => AdjustmentRuleValueLambda.DateEnd);
        }


        public static IObservable<System.TimeSpan> get_DaylightDelta(
            this IObservable<System.TimeZoneInfo.AdjustmentRule> AdjustmentRuleValue)
        {
            return Observable.Select(AdjustmentRuleValue,
                (AdjustmentRuleValueLambda) => AdjustmentRuleValueLambda.DaylightDelta);
        }


        public static IObservable<System.TimeZoneInfo.TransitionTime> get_DaylightTransitionStart(
            this IObservable<System.TimeZoneInfo.AdjustmentRule> AdjustmentRuleValue)
        {
            return Observable.Select(AdjustmentRuleValue,
                (AdjustmentRuleValueLambda) => AdjustmentRuleValueLambda.DaylightTransitionStart);
        }


        public static IObservable<System.TimeZoneInfo.TransitionTime> get_DaylightTransitionEnd(
            this IObservable<System.TimeZoneInfo.AdjustmentRule> AdjustmentRuleValue)
        {
            return Observable.Select(AdjustmentRuleValue,
                (AdjustmentRuleValueLambda) => AdjustmentRuleValueLambda.DaylightTransitionEnd);
        }
    }
}