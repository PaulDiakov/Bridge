    Bridge.define("System.IO.TextReader", {
        inherits: [System.IDisposable],
        statics: {
            fields: {
                null: null
            },
            ctors: {
                init: function () {
                    Object.defineProperty(this, "null", {
                        get: function() {
                            return this._null$ === undefined ? (this._null$ = new System.IO.TextReader.NullTextReader()) : this._null$;
                        },
                        set: function(v) {
                            this._null$ = v;
                        }
                    });
                }
            },
            methods: {
                synchronized: function (reader) {
                    throw new System.NotImplementedException();
                }
            }
        },
        alias: ["dispose", "System$IDisposable$dispose"],
        ctors: {
            ctor: function () {
                this.$initialize();
            }
        },
        methods: {
            close: function () {
                throw new System.NotImplementedException();
            },
            dispose: function () {
                throw new System.NotImplementedException();
            },
            peek: function () {
                throw new System.NotImplementedException();
            },
            read: function () {
                throw new System.NotImplementedException();
            },
            read$1: function (buffer, index, count) {
                throw new System.NotImplementedException();
            },
            readBlock: function (buffer, index, count) {
                throw new System.NotImplementedException();
            },
            readLine: function () {
                throw new System.NotImplementedException();
            },
            readToEnd: function () {
                throw new System.NotImplementedException();
            }
        }
    });
