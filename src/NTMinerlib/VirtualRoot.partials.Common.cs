﻿using NTMiner.MinerClient;
using System;

namespace NTMiner {
    public static partial class VirtualRoot {
        public static readonly bool IsGEWin10 = Environment.OSVersion.Version >= new Version(6, 2);
        public static readonly bool IsLTWin10 = Environment.OSVersion.Version < new Version(6, 2);

        public static void WorkerEvent(WorkerEventChannel channel, string content) {
            Happened(new WorkerEvent(channel, content));
        }
    }
}
