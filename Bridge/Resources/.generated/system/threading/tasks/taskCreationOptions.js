    Bridge.define("System.Threading.Tasks.TaskCreationOptions", {
        $kind: "enum",
        statics: {
            fields: {
                None: 0,
                PreferFairness: 1,
                LongRunning: 2,
                AttachedToParent: 4,
                DenyChildAttach: 8,
                HideScheduler: 16
            }
        }
    });
