    Bridge.define("System.IO.IOException", {
        inherits: [System.SystemException],
        ctors: {
            ctor: function () {
                this.$initialize();
                System.SystemException.ctor.call(this, "I/O Error");
            },
            $ctor1: function (message) {
                this.$initialize();
                System.SystemException.ctor.call(this, message);
            },
            $ctor2: function (message, innerException) {
                this.$initialize();
                System.SystemException.ctor.call(this, message, innerException);
            },
            $ctor3: function (message, hresult) {
                this.$initialize();
                System.SystemException.ctor.call(this, message);
            }
        }
    });
