    Bridge.define("System.Collections.Concurrent.ConcurrentDictionary$2", function (TKey, TValue) { return {
        inherits: [System.Collections.Generic.IDictionary$2(TKey,TValue),System.Collections.Generic.ICollection$1(System.Collections.Generic.KeyValuePair$2(TKey,TValue)),System.Collections.Generic.IEnumerable$1(System.Collections.Generic.KeyValuePair$2(TKey,TValue)),System.Collections.IDictionary,System.Collections.ICollection,System.Collections.IEnumerable],
        statics: {
            methods: {
                make: function (U, V, key, value) {
                    throw new System.NotImplementedException();
                }
            }
        },
        props: {
            Count: {
                get: function () {
                    throw new System.NotImplementedException();
                }
            },
            IsEmpty: {
                get: function () {
                    throw new System.NotImplementedException();
                }
            },
            System$Collections$Generic$ICollection$1$IsReadOnly: {
                get: function () {
                    throw new System.NotImplementedException();
                }
            },
            System$Collections$IDictionary$IsReadOnly: {
                get: function () {
                    throw new System.NotImplementedException();
                }
            },
            Keys: {
                get: function () {
                    throw new System.NotImplementedException();
                }
            },
            Values: {
                get: function () {
                    throw new System.NotImplementedException();
                }
            },
            System$Collections$IDictionary$Keys: {
                get: function () {
                    throw new System.NotImplementedException();
                }
            },
            System$Collections$IDictionary$Values: {
                get: function () {
                    throw new System.NotImplementedException();
                }
            }
        },
        alias: [
            "System$Collections$Generic$IDictionary$2$add", "System$Collections$Generic$IDictionary$2$" + Bridge.getTypeAlias(TKey) + "$" + Bridge.getTypeAlias(TValue) + "$add",
            "System$Collections$Generic$ICollection$1$add", "System$Collections$Generic$ICollection$1$System$Collections$Generic$KeyValuePair$2$" + Bridge.getTypeAlias(TKey) + "$" + Bridge.getTypeAlias(TValue) + "$add",
            "tryGetValue", "System$Collections$Generic$IDictionary$2$" + Bridge.getTypeAlias(TKey) + "$" + Bridge.getTypeAlias(TValue) + "$tryGetValue",
            "getItem", "System$Collections$Generic$IDictionary$2$" + Bridge.getTypeAlias(TKey) + "$" + Bridge.getTypeAlias(TValue) + "$getItem",
            "setItem", "System$Collections$Generic$IDictionary$2$" + Bridge.getTypeAlias(TKey) + "$" + Bridge.getTypeAlias(TValue) + "$setItem",
            "System$Collections$Generic$IDictionary$2$remove", "System$Collections$Generic$IDictionary$2$" + Bridge.getTypeAlias(TKey) + "$" + Bridge.getTypeAlias(TValue) + "$remove",
            "System$Collections$Generic$ICollection$1$remove", "System$Collections$Generic$ICollection$1$System$Collections$Generic$KeyValuePair$2$" + Bridge.getTypeAlias(TKey) + "$" + Bridge.getTypeAlias(TValue) + "$remove",
            "containsKey", "System$Collections$Generic$IDictionary$2$" + Bridge.getTypeAlias(TKey) + "$" + Bridge.getTypeAlias(TValue) + "$containsKey",
            "System$Collections$Generic$ICollection$1$contains", "System$Collections$Generic$ICollection$1$System$Collections$Generic$KeyValuePair$2$" + Bridge.getTypeAlias(TKey) + "$" + Bridge.getTypeAlias(TValue) + "$contains",
            "clear", "System$Collections$Generic$ICollection$1$System$Collections$Generic$KeyValuePair$2$" + Bridge.getTypeAlias(TKey) + "$" + Bridge.getTypeAlias(TValue) + "$clear",
            "Count", "System$Collections$ICollection$Count",
            "Count", "System$Collections$Generic$ICollection$1$System$Collections$Generic$KeyValuePair$2$" + Bridge.getTypeAlias(TKey) + "$" + Bridge.getTypeAlias(TValue) + "$Count",
            "System$Collections$Generic$ICollection$1$IsReadOnly", "System$Collections$Generic$ICollection$1$System$Collections$Generic$KeyValuePair$2$" + Bridge.getTypeAlias(TKey) + "$" + Bridge.getTypeAlias(TValue) + "$IsReadOnly",
            "Keys", "System$Collections$Generic$IDictionary$2$" + Bridge.getTypeAlias(TKey) + "$" + Bridge.getTypeAlias(TValue) + "$Keys",
            "Values", "System$Collections$Generic$IDictionary$2$" + Bridge.getTypeAlias(TKey) + "$" + Bridge.getTypeAlias(TValue) + "$Values",
            "System$Collections$Generic$ICollection$1$copyTo", "System$Collections$Generic$ICollection$1$System$Collections$Generic$KeyValuePair$2$" + Bridge.getTypeAlias(TKey) + "$" + Bridge.getTypeAlias(TValue) + "$copyTo",
            "getEnumerator", ["System$Collections$Generic$IEnumerable$1$System$Collections$Generic$KeyValuePair$2$" + Bridge.getTypeAlias(TKey) + "$" + Bridge.getTypeAlias(TValue) + "$getEnumerator", "System$Collections$Generic$IEnumerable$1$getEnumerator"],
            "containsKey$1", "System$Collections$IDictionary$containsKey",
            "remove", "System$Collections$IDictionary$remove"
        ],
        ctors: {
            ctor: function () {
                System.Collections.Concurrent.ConcurrentDictionary$2(TKey,TValue).$ctor3.call(this, System.Collections.Generic.EqualityComparer$1(TKey).def);
            },
            $ctor1: function (collection) {
                System.Collections.Concurrent.ConcurrentDictionary$2(TKey,TValue).$ctor2.call(this, collection, System.Collections.Generic.EqualityComparer$1(TKey).def);
            },
            $ctor3: function (comparer) {
                this.$initialize();
            },
            $ctor2: function (collection, comparer) {
                System.Collections.Concurrent.ConcurrentDictionary$2(TKey,TValue).$ctor3.call(this, comparer);
            },
            $ctor5: function (concurrencyLevel, capacity) {
                System.Collections.Concurrent.ConcurrentDictionary$2(TKey,TValue).$ctor3.call(this, System.Collections.Generic.EqualityComparer$1(TKey).def);
            },
            $ctor4: function (concurrencyLevel, collection, comparer) {
                System.Collections.Concurrent.ConcurrentDictionary$2(TKey,TValue).$ctor2.call(this, collection, comparer);
            },
            $ctor6: function (concurrencyLevel, capacity, comparer) {
                System.Collections.Concurrent.ConcurrentDictionary$2(TKey,TValue).$ctor3.call(this, comparer);
            }
        },
        methods: {
            getItem: function (key) {
                throw new System.NotImplementedException();
            },
            setItem: function (key, value) {
                throw new System.NotImplementedException();
            },
            getItem: function (key) {
                throw new System.NotImplementedException();
            },
            setItem: function (key, value) {
                throw new System.NotImplementedException();
            },
            checkKey: function (key) {
                throw new System.NotImplementedException();
            },
            add: function (key, value) {
                throw new System.NotImplementedException();
            },
            System$Collections$Generic$IDictionary$2$add: function (key, value) {
                throw new System.NotImplementedException();
            },
            System$Collections$Generic$ICollection$1$add: function (pair) {
                throw new System.NotImplementedException();
            },
            System$Collections$IDictionary$add: function (key, value) {
                throw new System.NotImplementedException();
            },
            tryAdd: function (key, value) {
                throw new System.NotImplementedException();
            },
            addOrUpdate$1: function (key, addValueFactory, updateValueFactory) {
                throw new System.NotImplementedException();
            },
            addOrUpdate: function (key, addValue, updateValueFactory) {
                throw new System.NotImplementedException();
            },
            addOrUpdate$2: function (key, addValue, updateValue) {
                throw new System.NotImplementedException();
            },
            getValue: function (key) {
                throw new System.NotImplementedException();
            },
            tryGetValue: function (key, value) {
                throw new System.NotImplementedException();
            },
            tryUpdate: function (key, newValue, comparisonValue) {
                throw new System.NotImplementedException();
            },
            getOrAdd$1: function (key, valueFactory) {
                throw new System.NotImplementedException();
            },
            getOrAdd: function (key, value) {
                throw new System.NotImplementedException();
            },
            tryRemove: function (key, value) {
                throw new System.NotImplementedException();
            },
            remove$1: function (key) {
                throw new System.NotImplementedException();
            },
            System$Collections$Generic$IDictionary$2$remove: function (key) {
                throw new System.NotImplementedException();
            },
            System$Collections$Generic$ICollection$1$remove: function (pair) {
                throw new System.NotImplementedException();
            },
            remove: function (key) {
                throw new System.NotImplementedException();
            },
            containsKey: function (key) {
                throw new System.NotImplementedException();
            },
            containsKey$1: function (key) {
                throw new System.NotImplementedException();
            },
            System$Collections$Generic$ICollection$1$contains: function (pair) {
                throw new System.NotImplementedException();
            },
            toArray: function () {
                throw new System.NotImplementedException();
            },
            clear: function () {
                throw new System.NotImplementedException();
            },
            getPart: function (T, extractor) {
                throw new System.NotImplementedException();
            },
            System$Collections$ICollection$copyTo: function (array, startIndex) {
                throw new System.NotImplementedException();
            },
            copyTo: function (array, startIndex) {
                throw new System.NotImplementedException();
            },
            System$Collections$Generic$ICollection$1$copyTo: function (array, startIndex) {
                throw new System.NotImplementedException();
            },
            copyTo$1: function (array, startIndex, num) {
                throw new System.NotImplementedException();
            },
            getEnumerator: function () {
                throw new System.NotImplementedException();
            },
            System$Collections$IEnumerable$getEnumerator: function () {
                throw new System.NotImplementedException();
            },
            getEnumeratorInternal: function () {
                throw new System.NotImplementedException();
            },
            hash: function (key) {
                throw new System.NotImplementedException();
            }
        }
    }; });
