    Bridge.define("System.IO.SynchronizedStream", {
        inherits: [System.IO.Stream],
        props: {
            CanRead: {
                get: function () {
                    return Bridge.getDefaultValue(System.Boolean);
                }
            },
            CanSeek: {
                get: function () {
                    return Bridge.getDefaultValue(System.Boolean);
                }
            },
            CanWrite: {
                get: function () {
                    return Bridge.getDefaultValue(System.Boolean);
                }
            },
            Length: {
                get: function () {
                    return Bridge.getDefaultValue(System.Int64);
                }
            },
            Position: {
                get: function () {
                    return Bridge.getDefaultValue(System.Int64);
                },
                set: function (value) { }
            }
        },
        ctors: {
            ctor: function (source) {
                this.$initialize();
                System.IO.Stream.ctor.call(this);
            }
        },
        methods: {
            flush: function () { },
            read: function (buffer, offset, count) {
                return Bridge.getDefaultValue(System.Int32);
            },
            readByte: function () {
                return Bridge.getDefaultValue(System.Int32);
            },
            seek: function (offset, origin) {
                return Bridge.getDefaultValue(System.Int64);
            },
            setLength: function (value) { },
            write: function (buffer, offset, count) { },
            writeByte: function (value) { }
        }
    });
