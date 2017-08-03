    Bridge.define("System.Collections.Generic.Dictionary$2", function (TKey, TValue) { return {
        inherits: [System.Collections.Generic.IDictionary$2(TKey,TValue),System.Collections.IDictionary,System.Collections.Generic.IReadOnlyDictionary$2(TKey,TValue),System.Collections.Generic.IReadOnlyCollection$1(System.Collections.Generic.KeyValuePair$2(TKey,TValue)),System.Object],
        props: {
            comparer: null,
            count: 0,
            Keys: {
                get: function () {
                    return new (System.Collections.Generic.Dictionary$2.KeyCollection(TKey,TValue))(this);
                }
            },
            System$Collections$IDictionary$Values: null,
            System$Collections$IDictionary$Keys: null
        },
        alias: [
            "count", "System$Collections$Generic$IReadOnlyCollection$1$System$Collections$Generic$KeyValuePair$2$" + Bridge.getTypeAlias(TKey) + "$" + Bridge.getTypeAlias(TValue) + "$Count",
            "count", "System$Collections$ICollection$Count",
            "count", "System$Collections$Generic$ICollection$1$System$Collections$Generic$KeyValuePair$2$" + Bridge.getTypeAlias(TKey) + "$" + Bridge.getTypeAlias(TValue) + "$Count",
            "System$Collections$Generic$IDictionary$2$Keys", "System$Collections$Generic$IDictionary$2$" + Bridge.getTypeAlias(TKey) + "$" + Bridge.getTypeAlias(TValue) + "$Keys",
            "System$Collections$Generic$IReadOnlyDictionary$2$Keys", "System$Collections$Generic$IReadOnlyDictionary$2$" + Bridge.getTypeAlias(TKey) + "$" + Bridge.getTypeAlias(TValue) + "$Keys",
            "Values", "System$Collections$Generic$IDictionary$2$" + Bridge.getTypeAlias(TKey) + "$" + Bridge.getTypeAlias(TValue) + "$Values",
            "System$Collections$Generic$IReadOnlyDictionary$2$Values", "System$Collections$Generic$IReadOnlyDictionary$2$" + Bridge.getTypeAlias(TKey) + "$" + Bridge.getTypeAlias(TValue) + "$Values",
            "get", "System$Collections$Generic$IReadOnlyDictionary$2$" + Bridge.getTypeAlias(TKey) + "$" + Bridge.getTypeAlias(TValue) + "$getItem",
            "set", "System$Collections$Generic$IReadOnlyDictionary$2$" + Bridge.getTypeAlias(TKey) + "$" + Bridge.getTypeAlias(TValue) + "$setItem",
            "get", "System$Collections$Generic$IDictionary$2$" + Bridge.getTypeAlias(TKey) + "$" + Bridge.getTypeAlias(TValue) + "$getItem",
            "set", "System$Collections$Generic$IDictionary$2$" + Bridge.getTypeAlias(TKey) + "$" + Bridge.getTypeAlias(TValue) + "$setItem",
            "add", "System$Collections$Generic$IDictionary$2$" + Bridge.getTypeAlias(TKey) + "$" + Bridge.getTypeAlias(TValue) + "$add",
            "clear", "System$Collections$Generic$ICollection$1$System$Collections$Generic$KeyValuePair$2$" + Bridge.getTypeAlias(TKey) + "$" + Bridge.getTypeAlias(TValue) + "$clear",
            "containsKey", "System$Collections$Generic$IReadOnlyDictionary$2$" + Bridge.getTypeAlias(TKey) + "$" + Bridge.getTypeAlias(TValue) + "$containsKey",
            "containsKey", "System$Collections$Generic$IDictionary$2$" + Bridge.getTypeAlias(TKey) + "$" + Bridge.getTypeAlias(TValue) + "$containsKey",
            "getEnumerator", ["System$Collections$Generic$IEnumerable$1$System$Collections$Generic$KeyValuePair$2$" + Bridge.getTypeAlias(TKey) + "$" + Bridge.getTypeAlias(TValue) + "$getEnumerator", "System$Collections$Generic$IEnumerable$1$getEnumerator"],
            "remove", "System$Collections$Generic$IDictionary$2$" + Bridge.getTypeAlias(TKey) + "$" + Bridge.getTypeAlias(TValue) + "$remove",
            "tryGetValue", "System$Collections$Generic$IReadOnlyDictionary$2$" + Bridge.getTypeAlias(TKey) + "$" + Bridge.getTypeAlias(TValue) + "$tryGetValue",
            "tryGetValue", "System$Collections$Generic$IDictionary$2$" + Bridge.getTypeAlias(TKey) + "$" + Bridge.getTypeAlias(TValue) + "$tryGetValue",
            "IsReadOnly", "System$Collections$IDictionary$IsReadOnly",
            "IsReadOnly", "System$Collections$Generic$ICollection$1$System$Collections$Generic$KeyValuePair$2$" + Bridge.getTypeAlias(TKey) + "$" + Bridge.getTypeAlias(TValue) + "$IsReadOnly",
            "System$Collections$Generic$ICollection$1$add", "System$Collections$Generic$ICollection$1$System$Collections$Generic$KeyValuePair$2$" + Bridge.getTypeAlias(TKey) + "$" + Bridge.getTypeAlias(TValue) + "$add",
            "System$Collections$Generic$ICollection$1$copyTo", "System$Collections$Generic$ICollection$1$System$Collections$Generic$KeyValuePair$2$" + Bridge.getTypeAlias(TKey) + "$" + Bridge.getTypeAlias(TValue) + "$copyTo",
            "System$Collections$Generic$ICollection$1$contains", "System$Collections$Generic$ICollection$1$System$Collections$Generic$KeyValuePair$2$" + Bridge.getTypeAlias(TKey) + "$" + Bridge.getTypeAlias(TValue) + "$contains",
            "System$Collections$Generic$ICollection$1$remove", "System$Collections$Generic$ICollection$1$System$Collections$Generic$KeyValuePair$2$" + Bridge.getTypeAlias(TKey) + "$" + Bridge.getTypeAlias(TValue) + "$remove"
        ],
        methods: {
            get: function (key) null,
            set: function (key, value) null,
            get: function (key) null,
            set: function (key, value) null
        }
    }; });
