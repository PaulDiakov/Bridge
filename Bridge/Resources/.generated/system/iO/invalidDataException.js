    Bridge.define("System.IO.InvalidDataException", {
        inherits: [System.SystemException],
        ctors: {
            ctor: function () {
                this.$initialize();
                System.SystemException.ctor.call(this, "Invalid data format.");
            },
            $ctor1: function (message) {
                this.$initialize();
                System.SystemException.ctor.call(this, message);
            },
            $ctor2: function (message, innerException) {
                this.$initialize();
                System.SystemException.ctor.call(this, message, innerException);
            }
        }
    });
