    Bridge.define("System.Collections.Generic.LinkedList$1.Enumerator", function (T) { return {
        inherits: [System.Collections.Generic.IEnumerator$1(T),System.IDisposable,System.Collections.IEnumerator,System.Runtime.Serialization.ISerializable,System.Runtime.Serialization.IDeserializationCallback],
        $kind: "struct",
        statics: {
            fields: {
                VersionKey: null,
                IndexKey: null,
                ListKey: null
            },
            ctors: {
                init: function () {
                    Object.defineProperty(this, "VersionKey", {
                        get: function() {
                            return this._VersionKey$ === undefined ? (this._VersionKey$ = "version") : this._VersionKey$;
                        },
                        set: function(v) {
                            this._VersionKey$ = v;
                        }
                    });
                    Object.defineProperty(this, "IndexKey", {
                        get: function() {
                            return this._IndexKey$ === undefined ? (this._IndexKey$ = "index") : this._IndexKey$;
                        },
                        set: function(v) {
                            this._IndexKey$ = v;
                        }
                    });
                    Object.defineProperty(this, "ListKey", {
                        get: function() {
                            return this._ListKey$ === undefined ? (this._ListKey$ = "list") : this._ListKey$;
                        },
                        set: function(v) {
                            this._ListKey$ = v;
                        }
                    });
                }
            },
            methods: {
                getDefaultValue: function () { return new (System.Collections.Generic.LinkedList$1.Enumerator(T))(); }
            }
        },
        props: {
            Current: {
                get: function () {
                    throw new System.NotImplementedException();
                }
            },
            System$Collections$IEnumerator$Current: {
                get: function () {
                    throw new System.NotImplementedException();
                }
            }
        },
        alias: [
            "Current", ["System$Collections$Generic$IEnumerator$1$" + Bridge.getTypeAlias(T) + "$Current$1", "System$Collections$Generic$IEnumerator$1$Current$1"],
            "moveNext", "System$Collections$IEnumerator$moveNext",
            "dispose", "System$IDisposable$dispose"
        ],
        ctors: {
            ctor: function () {
                this.$initialize();
            }
        },
        methods: {
            moveNext: function () {
                throw new System.NotImplementedException();
            },
            System$Collections$IEnumerator$reset: function () {
                throw new System.NotImplementedException();
            },
            dispose: function () {
                throw new System.NotImplementedException();
            },
            System$Runtime$Serialization$ISerializable$getObjectData: function (info, context) {
                throw new System.NotImplementedException();
            },
            System$Runtime$Serialization$IDeserializationCallback$onDeserialization: function (sender) {
                throw new System.NotImplementedException();
            },
            $clone: function (to) { return this; }
        }
    }; });
