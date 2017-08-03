    Bridge.define("System.GCNotificationStatus", {
        $kind: "enum",
        statics: {
            fields: {
                Succeeded: 0,
                Failed: 1,
                Canceled: 2,
                Timeout: 3,
                NotApplicable: 4
            }
        }
    });
