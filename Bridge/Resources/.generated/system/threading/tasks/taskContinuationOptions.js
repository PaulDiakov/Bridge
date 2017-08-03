    Bridge.define("System.Threading.Tasks.TaskContinuationOptions", {
        $kind: "enum",
        statics: {
            fields: {
                None: 0,
                PreferFairness: 1,
                LongRunning: 2,
                AttachedToParent: 4,
                DenyChildAttach: 8,
                HideScheduler: 16,
                LazyCancellation: 32,
                NotOnRanToCompletion: 65536,
                NotOnFaulted: 131072,
                NotOnCanceled: 262144,
                OnlyOnRanToCompletion: 393216,
                OnlyOnFaulted: 327680,
                OnlyOnCanceled: 196608,
                ExecuteSynchronously: 524288
            }
        }
    });
