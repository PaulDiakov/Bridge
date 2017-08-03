    Bridge.define("System.Collections.Generic.Dictionary$2.KeyCollection.Enumerator", function (TKey, TValue) { return {
        inherits: [System.Collections.Generic.IEnumerator$1(TKey),System.IDisposable,System.Collections.IEnumerator],
        $kind: "struct",
        statics: {
            methods: {
                getDefaultValue: function () { return new (System.Collections.Generic.Dictionary$2.KeyCollection.Enumerator(TKey,TValue))(); }
            }
        },
        props: {
            Current: {
                get: function () {
                    return Bridge.getDefaultValue(TKey);
                }
            },
            System$Collections$IEnumerator$Current: {
                get: function () {
                    return null;
                }
            }
        },
        alias: [
            "dispose", "System$IDisposable$dispose",
            "moveNext", "System$Collections$IEnumerator$moveNext",
            "Current", ["System$Collections$Generic$IEnumerator$1$" + Bridge.getTypeAlias(TKey) + "$Current$1", "System$Collections$Generic$IEnumerator$1$Current$1"]
        ],
        ctors: {
            $ctor1: function (host) {
                this.$initialize();
            },
            ctor: function () {
                this.$initialize();
            }
        },
        methods: {
            dispose: function () { },
            moveNext: function () {
                return Bridge.getDefaultValue(System.Boolean);
            },
            System$Collections$IEnumerator$reset: function () { },
            $clone: function (to) { return this; }
        }
    }; });
