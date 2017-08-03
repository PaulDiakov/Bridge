    Bridge.define("System.IO.FileNotFoundException", {
        inherits: [System.IO.IOException],
        props: {
            FileName: {
                get: function () {
                    throw new System.NotImplementedException();
                }
            },
            FusionLog: {
                get: function () {
                    throw new System.NotImplementedException();
                }
            },
            Message: {
                get: function () {
                    throw new System.NotImplementedException();
                }
            }
        },
        ctors: {
            ctor: function () {
                this.$initialize();
                System.IO.IOException.$ctor1.call(this, "Unable to find the specified file.");
            },
            $ctor1: function (message) {
                this.$initialize();
                System.IO.IOException.$ctor1.call(this, message);
            },
            $ctor2: function (message, innerException) {
                this.$initialize();
                System.IO.IOException.$ctor2.call(this, message, innerException);
            },
            $ctor3: function (message, fileName) {
                this.$initialize();
                System.IO.IOException.$ctor1.call(this, message);
            },
            $ctor4: function (message, fileName, innerException) {
                this.$initialize();
                System.IO.IOException.$ctor2.call(this, message, innerException);
            }
        },
        methods: {
            toString: function () {
                throw new System.NotImplementedException();
            }
        }
    });
