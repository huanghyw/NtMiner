﻿using System;

namespace NTMiner {
    public static class DateTimeExtensions {
        public static bool IsInTime(this DateTime time) {
            return Math.Abs((DateTime.Now - time).TotalSeconds) < 100;
        }

        public static ulong ToUlong(this DateTime time) {
            return Timestamp.GetTimestamp(time);
        }
    }
}
