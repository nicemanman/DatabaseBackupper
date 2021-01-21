namespace DomainModel.Components.CronBox
{
    public enum CronExpressionType
    {
        EveryNSeconds,
        EveryNMinutes,
        EveryNHours,
        EveryDayAt,
        EveryNDaysAt,
        EveryWeekDayAt,
        EverySpecificDayAt,
        EverySpecificDayEveryNMonthAt,
        EverySpecificSeqWeekDayEveryNMonthAt,
        EverySpecificDayOfMonthAt,
        EverySpecificSeqWeekDayOfMonthAt,
    }
}
