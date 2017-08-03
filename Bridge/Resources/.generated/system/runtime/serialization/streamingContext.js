    Bridge.define("System.Runtime.Serialization.StreamingContext", {
        $kind: "struct",
        statics: {
            methods: {
                getDefaultValue: function () { return new System.Runtime.Serialization.StreamingContext(); }
            }
        },
        methods: {
            $clone: function (to) { return this; }
        }
    });
