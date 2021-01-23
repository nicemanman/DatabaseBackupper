using System;
using static DomainModel.Enums;

namespace DomainModel.Components.CronBox
{
    public class CronExpressionManager
    {
        private readonly DaysOfWeek _days;
        private readonly Months _month;
        private readonly int _interval;
        private readonly int _dayNumber;
        private readonly int _startHour;
        private readonly int _startMinute;

        private readonly CronExpressionType _expressionType;
        private string _cronString;

        public CronExpressionType ExpressionType
        {
            get { return _expressionType; }
        }

        private void BuildCronExpression()
        {
            switch (ExpressionType)
            {
               
                case CronExpressionType.EveryNMinutes:
                    _cronString = string.Format("0 0/{0} * 1/1 * ? *", _interval);
                    break;
                case CronExpressionType.EveryNHours:
                    _cronString = string.Format("0 0 0/{0} 1/1 * ? *", _interval);
                    break;
                
                case CronExpressionType.EveryDayAt:
                    _cronString = string.Format("0 {0} {1} 1/{2} * ? *", _startMinute, _startHour, _interval);
                    break;
                
                case CronExpressionType.EverySpecificDayAt:
                    _cronString = string.Format("0 {0} {1} ? * {2} *", _startMinute, _startHour, CronConverter.ToCronRepresentation(_days));
                    break;
                
                
                default:
                    throw new ArgumentException();
            }
        }

        protected CronExpressionManager(int interval, CronExpressionType expressionType)
        {
            _interval = interval;
            _expressionType = expressionType;

            BuildCronExpression();
        }

        protected CronExpressionManager(int startHour, int startMinute, CronExpressionType expressionType)
        {
            _startHour = startHour;
            _startMinute = startMinute;
            _expressionType = expressionType;

            BuildCronExpression();
        }

        protected CronExpressionManager(int interval, int startHour, int startMinute, CronExpressionType expressionType)
        {
            _interval = interval;
            _startHour = startHour;
            _startMinute = startMinute;
            _expressionType = expressionType;

            BuildCronExpression();
        }

        protected CronExpressionManager(DaysOfWeek days, int startHour, int startMinute, CronExpressionType expressionType)
        {
            _days = days;
            _startHour = startHour;
            _startMinute = startMinute;
            _expressionType = expressionType;

            BuildCronExpression();
        }

        protected CronExpressionManager(int dayNumber, int interval, int startHour, int startMinute, CronExpressionType expressionType)
        {
            _dayNumber = dayNumber;
            _interval = interval;
            _startHour = startHour;
            _startMinute = startMinute;
            _expressionType = expressionType;

            BuildCronExpression();
        }

        protected CronExpressionManager(DaySeqNumber dayNumber, DaysOfWeek days, int monthInverval, int startHour, int startMinute, CronExpressionType expressionType)
        {
            _dayNumber = (int)dayNumber;
            _days = days;
            _interval = monthInverval;
            _startHour = startHour;
            _startMinute = startMinute;
            _expressionType = expressionType;

            BuildCronExpression();
        }

        protected CronExpressionManager(Months month, int dayNumber, int startHour, int startMinute, CronExpressionType expressionType)
        {
            _month = month;
            _dayNumber = dayNumber;
            _startHour = startHour;
            _startMinute = startMinute;
            _expressionType = expressionType;

            BuildCronExpression();
        }

        protected CronExpressionManager(DaySeqNumber dayNumber, DaysOfWeek days, Months month, int startHour, int startMinute, CronExpressionType expressionType)
        {
            _dayNumber = (int)dayNumber;
            _days = days;
            _month = month;
            _startHour = startHour;
            _startMinute = startMinute;
            _expressionType = expressionType;

            BuildCronExpression();
        }

        


        /// <summary>
        /// Create new CronExpression instance, which occurs every *minutesInteval* minutes
        /// </summary>
        /// <param name="minutesInteval">Interval in minutes</param>
        /// <returns>New CronExpression instance</returns>
        public static CronExpressionManager EveryNMinutes(int minutesInteval)
        {
            var ce = new CronExpressionManager(minutesInteval, CronExpressionType.EveryNMinutes);
            return ce;
        }

        /// <summary>
        /// Create new CronExpression instance, which occurs every *hoursInterval* hours
        /// </summary>
        /// <param name="hoursInterval">Interval in hours</param>
        /// <returns>New CronExpression instance</returns>
        public static CronExpressionManager EveryNHours(int hoursInterval)
        {
            var ce = new CronExpressionManager(hoursInterval, CronExpressionType.EveryNHours);
            return ce;
        }

        /// <summary>
        /// Create new CronExpression instance, which occurs every day at specified hours
        /// </summary>
        /// <param name="hour">Hour, when occurence will happen</param>
        /// <param name="minute">Minute, when occurence will happen</param>
        /// <returns>New CronExpression instance</returns>
        public static CronExpressionManager EveryDayAt(int hour, int minute)
        {
            var ce = new CronExpressionManager(1, hour, minute, CronExpressionType.EveryDayAt);
            return ce;
        }

       

        

        /// <summary>
        /// Create new CronExpression instance, which occurs on specified days at specified hours
        /// </summary>
        /// <param name="hour">Hour, when occurence will happen</param>
        /// <param name="minute">Minute, when occurence will happen</param>
        /// <param name="days">Days, when occurence will happen</param>
        /// <returns>New CronExpression instance</returns>
        public static CronExpressionManager EverySpecificWeekDayAt(int hour, int minute, DaysOfWeek days)
        {
            var ce = new CronExpressionManager(days, hour, minute, CronExpressionType.EverySpecificDayAt);
            return ce;
        }

        public override string ToString()
        {
            return _cronString;
        }

        public static implicit operator string(CronExpressionManager expression)
        {
            return expression.ToString();
        }
    }
}
