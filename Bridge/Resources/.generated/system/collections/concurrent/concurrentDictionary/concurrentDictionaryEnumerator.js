    Bridge.define("System.Collections.Concurrent.ConcurrentDictionary$2.ConcurrentDictionaryEnumerator", function (TKey, TValue) { return {
        inherits: [System.Collections.IDictionaryEnumerator],
        props: {
            Current: {
                get: function () {
                    throw new System.NotImplementedException();
                }
            },
            Entry: {
                get: function () {
                    throw new System.NotImplementedException();
                }
            },
            Key: {
                get: function () {
                    throw new System.NotImplementedException();
                }
            },
            Value: {
                get: function () {
                    throw new System.NotImplementedException();
                }
            }
        },
        alias: [
            "moveNext", "System$Collections$IEnumerator$moveNext",
            "reset", "System$Collections$IEnumerator$reset",
            "Current", "System$Collections$IEnumerator$Current",
            "Entry", "System$Collections$IDictionaryEnumerator$Entry",
            "Key", "System$Collections$IDictionaryEnumerator$Key",
            "Value", "System$Collections$IDictionaryEnumerator$Value"
        ],
        ctors: {
            ctor: function (internalEnum) {
                this.$initialize();
            }
        },
        methods: {
            moveNext: function () {
                throw new System.NotImplementedException();
            },
            reset: function () {
                throw new System.NotImplementedException();
            }
        }
    }; });
