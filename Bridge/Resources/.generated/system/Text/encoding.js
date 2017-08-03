    Bridge.define("System.Text.Encoding", {
        inherits: [System.ICloneable],
        statics: {
            props: {
                UTF8: {
                    get: function () {
                        throw new System.NotImplementedException();
                    }
                },
                UTF8UnmarkedUnsafe: {
                    get: function () {
                        throw new System.NotImplementedException();
                    }
                }
            }
        },
        alias: ["clone", "System$ICloneable$clone"],
        ctors: {
            ctor: function () {
                this.$initialize();
            }
        },
        methods: {
            getBytes$4: function (s, charIndex, charCount, bytes, byteIndex) {
                throw new System.NotImplementedException();
            },
            getBytes$2: function (s) {
                throw new System.NotImplementedException();
            },
            getBytes$1: function (chars, index, count) {
                throw new System.NotImplementedException();
            },
            getBytes: function (chars) {
                throw new System.NotImplementedException();
            },
            getString$1: function (bytes, index, count) {
                throw new System.NotImplementedException();
            },
            getString: function (bytes) {
                throw new System.NotImplementedException();
            },
            getDecoder: function () {
                throw new System.NotImplementedException();
            },
            clone: function () {
                throw new System.NotImplementedException();
            }
        }
    });
