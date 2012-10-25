﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DateInterval.cs" company="ORC">
//   MS-PL
// </copyright>
// <summary>
//   The date interval.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Orc.Entities
{
    using System;

    using Orc.Interface;

    /// <summary>
    /// The date interval.
    /// </summary>
    public class DateInterval : Interval<DateTime>, IDateInterval
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DateInterval"/> class.
        /// By Default the min point is inclusive and the max point is exclusive.
        /// </summary>
        /// <param name="minValue">
        /// Left most value (or Min).
        /// </param>
        /// <param name="maxValue">
        /// Right most value (or Max).
        /// </param>
        /// <param name="isMinInclusive">
        /// The left most point is inclusive.
        /// </param>
        /// <param name="isMaxInclusive">
        /// The right most point is inclusive.
        /// </param>
        public DateInterval(
            DateTime minValue, DateTime maxValue, bool isMinInclusive = true, bool isMaxInclusive = false)
            : base(minValue, maxValue, isMinInclusive, isMaxInclusive)
        {
            this.Duration = maxValue - minValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DateInterval"/> class.
        /// By Default the min point is inclusive and the max point is exclusive.
        /// </summary>
        /// <param name="minValue">
        /// Left most value (or Min).
        /// </param>
        /// <param name="duration">
        /// Interval duration
        /// </param>
        /// <param name="isMinInclusive">
        /// The left most point is inclusive.
        /// </param>
        /// <param name="isMaxInclusive">
        /// The right most point is inclusive.
        /// </param>
        public DateInterval(
            DateTime minValue, TimeSpan duration, bool isMinInclusive = true, bool isMaxInclusive = false)
            : base(minValue, minValue.Add(duration), isMinInclusive, isMaxInclusive)
        {
            this.Duration = duration;
        }

        /// <summary>
        /// Gets the duration.
        /// </summary>
        /// <value>
        /// The duration.
        /// </value>
        public TimeSpan Duration { get; private set; }

        // TODO: Need to implement IComparable<>
    }
}