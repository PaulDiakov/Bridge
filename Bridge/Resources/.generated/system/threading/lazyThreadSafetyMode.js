    Bridge.define("System.Threading.LazyThreadSafetyMode", {
        $kind: "enum",
        statics: {
            fields: {
                None: 0,
                PublicationOnly: 1,
                ExecutionAndPublication: 2
            }
        }
    });
