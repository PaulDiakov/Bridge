    Bridge.define("System.Collections.DictionaryEntry", {
        $kind: "struct",
        statics: {
            methods: {
                getDefaultValue: function () { return new System.Collections.DictionaryEntry(); }
            }
        },
        props: {
            Key: {
                get: function () {
                    throw new System.NotImplementedException();
                },
                set: function (value) {
                    throw new System.NotImplementedException();
                }
            },
            Value: {
                get: function () {
                    throw new System.NotImplementedException();
                },
                set: function (value) {
                    throw new System.NotImplementedException();
                }
            }
        },
        ctors: {
            $ctor1: function (key, value) {
                this.$initialize();
            },
            ctor: function () {
                this.$initialize();
            }
        },
        methods: {
            $clone: function (to) { return this; }
        }
    });
