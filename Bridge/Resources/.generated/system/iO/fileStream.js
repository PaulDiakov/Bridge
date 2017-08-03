    Bridge.define("System.IO.FileStream", {
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
        methods: {
            flush: function () {
                throw new System.NotImplementedException();
            },
            read: function (buffer, offset, count) {
                throw new System.NotImplementedException();
            },
            seek: function (offset, origin) {
                throw new System.NotImplementedException();
            },
            setLength: function (value) {
                throw new System.NotImplementedException();
            },
            write: function (buffer, offset, count) {
                throw new System.NotImplementedException();
            }
        }
    });
