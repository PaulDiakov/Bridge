    Bridge.define("System.IO.BinaryReader", {
        inherits: [System.IDisposable],
        props: {
            BaseStream: {
                get: function () {
                    throw new System.NotImplementedException();
                }
            }
        },
        alias: ["dispose", "System$IDisposable$dispose"],
        ctors: {
            ctor: function (input) {
                System.IO.BinaryReader.$ctor1.call(this, input, System.Text.Encoding.UTF8UnmarkedUnsafe);
            },
            $ctor1: function (input, encoding) {
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
            peekChar: function () {
                throw new System.NotImplementedException();
            },
            read: function () {
                throw new System.NotImplementedException();
            },
            read$1: function (buffer, index, count) {
                throw new System.NotImplementedException();
            },
            read$2: function (buffer, index, count) {
                throw new System.NotImplementedException();
            },
            readBoolean: function () {
                throw new System.NotImplementedException();
            },
            readByte: function () {
                throw new System.NotImplementedException();
            },
            readBytes: function (count) {
                throw new System.NotImplementedException();
            },
            readChar: function () {
                throw new System.NotImplementedException();
            },
            readChars: function (count) {
                throw new System.NotImplementedException();
            },
            readDecimal: function () {
                throw new System.NotImplementedException();
            },
            readDouble: function () {
                throw new System.NotImplementedException();
            },
            readInt16: function () {
                throw new System.NotImplementedException();
            },
            readInt32: function () {
                throw new System.NotImplementedException();
            },
            readInt64: function () {
                throw new System.NotImplementedException();
            },
            readSByte: function () {
                throw new System.NotImplementedException();
            },
            readString: function () {
                throw new System.NotImplementedException();
            },
            readSingle: function () {
                throw new System.NotImplementedException();
            },
            readUInt16: function () {
                throw new System.NotImplementedException();
            },
            readUInt32: function () {
                throw new System.NotImplementedException();
            },
            readUInt64: function () {
                throw new System.NotImplementedException();
            }
        }
    });
