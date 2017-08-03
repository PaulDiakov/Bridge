    Bridge.define("System.Collections.Generic.Dictionary$2.KeyCollection", function (TKey, TValue) { return {
        inherits: [System.Collections.Generic.ICollection$1(TKey),System.Collections.Generic.IEnumerable$1(TKey),System.Collections.ICollection,System.Collections.IEnumerable],
        props: {
            Count: {
                get: function () {
                    return Bridge.getDefaultValue(System.Int32);
                }
            },
            System$Collections$Generic$ICollection$1$IsReadOnly: {
                get: function () {
                    return true;
                }
            }
        },
        alias: [
            "copyTo", "System$Collections$Generic$ICollection$1$" + Bridge.getTypeAlias(TKey) + "$copyTo",
            "System$Collections$Generic$ICollection$1$add", "System$Collections$Generic$ICollection$1$" + Bridge.getTypeAlias(TKey) + "$add",
            "System$Collections$Generic$ICollection$1$clear", "System$Collections$Generic$ICollection$1$" + Bridge.getTypeAlias(TKey) + "$clear",
            "System$Collections$Generic$ICollection$1$contains", "System$Collections$Generic$ICollection$1$" + Bridge.getTypeAlias(TKey) + "$contains",
            "System$Collections$Generic$ICollection$1$remove", "System$Collections$Generic$ICollection$1$" + Bridge.getTypeAlias(TKey) + "$remove",
            "System$Collections$Generic$IEnumerable$1$getEnumerator", "System$Collections$Generic$IEnumerable$1$" + Bridge.getTypeAlias(TKey) + "$getEnumerator",
            "Count", "System$Collections$ICollection$Count",
            "Count", "System$Collections$Generic$ICollection$1$" + Bridge.getTypeAlias(TKey) + "$Count",
            "System$Collections$Generic$ICollection$1$IsReadOnly", "System$Collections$Generic$ICollection$1$" + Bridge.getTypeAlias(TKey) + "$IsReadOnly"
        ],
        ctors: {
            ctor: function (dictionary) {
                this.$initialize();
            }
        },
        methods: {
            copyTo: function (array, index) { },
            System$Collections$ICollection$copyTo: function (array, index) { },
            getEnumerator: function () {
                return Bridge.getDefaultValue(System.Collections.Generic.Dictionary$2.KeyCollection.Enumerator(TKey,TValue));
            },
            System$Collections$Generic$IEnumerable$1$getEnumerator: function () {
                return null;
            },
            System$Collections$IEnumerable$getEnumerator: function () {
                return null;
            },
            System$Collections$Generic$ICollection$1$add: function (item) { },
            System$Collections$Generic$ICollection$1$clear: function () { },
            System$Collections$Generic$ICollection$1$contains: function (item) {
                return Bridge.getDefaultValue(System.Boolean);
            },
            System$Collections$Generic$ICollection$1$remove: function (item) {
                return Bridge.getDefaultValue(System.Boolean);
            }
        }
    }; });
