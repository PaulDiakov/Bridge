    Bridge.define("System.IO.MemoryStream", {
        inherits: [System.IO.Stream],
        props: {
            CanRead: {
                get: function () {
                    throw new System.NotImplementedException();
                }
            },
            CanSeek: {
                get: function () {
                    throw new System.NotImplementedException();
                }
            },
            CanWrite: {
                get: function () {
                    throw new System.NotImplementedException();
                }
            },
            Capacity: {
                get: function () {
                    throw new System.NotImplementedException();
                },
                set: function (value) {
                    throw new System.NotImplementedException();
                }
            },
            Length: {
                get: function () {
                    throw new System.NotImplementedException();
                }
            },
            Position: {
                get: function () {
                    throw new System.NotImplementedException();
                },
                set: function (value) {
                    throw new System.NotImplementedException();
                }
            }
        },
        ctors: {
            ctor: function () {
                System.IO.MemoryStream.$ctor6.call(this, 0);
            },
            $ctor6: function (capacity) {
                this.$initialize();
                System.IO.Stream.ctor.call(this);
            },
            $ctor1: function (buffer) {
                this.$initialize();
                System.IO.Stream.ctor.call(this);
            },
            $ctor2: function (buffer, writable) {
                this.$initialize();
                System.IO.Stream.ctor.call(this);
            },
            $ctor3: function (buffer, index, count) {
                this.$initialize();
                System.IO.Stream.ctor.call(this);
            },
            $ctor4: function (buffer, index, count, writable) {
                this.$initialize();
                System.IO.Stream.ctor.call(this);
            },
            $ctor5: function (buffer, index, count, writable, publiclyVisible) {
                this.$initialize();
                System.IO.Stream.ctor.call(this);
            }
        },
        methods: {
            dispose$1: function (disposing) {
                throw new System.NotImplementedException();
            },
            flush: function () {
                throw new System.NotImplementedException();
            },
            getBuffer: function () {
                throw new System.NotImplementedException();
            },
            getByteArray: function () {
                throw new System.NotImplementedException();
            },
            read: function (buffer, offset, count) {
                throw new System.NotImplementedException();
            },
            readByte: function () {
                throw new System.NotImplementedException();
            },
            seek: function (offset, loc) {
                throw new System.NotImplementedException();
            },
            setLength: function (value) {
                throw new System.NotImplementedException();
            },
            toArray: function () {
                throw new System.NotImplementedException();
            },
            write: function (buffer, offset, count) {
                throw new System.NotImplementedException();
            },
            writeByte: function (value) {
                throw new System.NotImplementedException();
            },
            writeTo: function (stream) {
                throw new System.NotImplementedException();
            }
        }
    });
