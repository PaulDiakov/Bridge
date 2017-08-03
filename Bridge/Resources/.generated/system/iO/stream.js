    Bridge.define("System.IO.Stream", {
        inherits: [System.IDisposable],
        statics: {
            fields: {
                null: null
            },
            ctors: {
                init: function () {
                    Object.defineProperty(this, "null", {
                        get: function() {
                            return this._null$ === undefined ? (this._null$ = new System.IO.NullStream()) : this._null$;
                        },
                        set: function(v) {
                            this._null$ = v;
                        }
                    });
                }
            },
            methods: {
                synchronized: function (stream) {
                    return new System.IO.SynchronizedStream(stream);
                }
            }
        },
        props: {
            CanTimeout: {
                get: function () {
                    return Bridge.getDefaultValue(System.Boolean);
                }
            },
            ReadTimeout: 0,
            WriteTimeout: 0
        },
        alias: ["dispose", "System$IDisposable$dispose"],
        ctors: {
            ctor: function () {
                this.$initialize();
            }
        },
        methods: {
            dispose: function () { },
            dispose$1: function (disposing) { },
            close: function () { },
            readByte: function () {
                return Bridge.getDefaultValue(System.Int32);
            },
            writeByte: function (value) { },
            beginRead: function (buffer, offset, count, callback, state) {
                return null;
            },
            beginWrite: function (buffer, offset, count, callback, state) {
                return null;
            },
            endRead: function (asyncResult) {
                return Bridge.getDefaultValue(System.Int32);
            },
            endWrite: function (asyncResult) { },
            copyTo: function (destination) { },
            copyTo$1: function (destination, bufferSize) { }
        }
    });
