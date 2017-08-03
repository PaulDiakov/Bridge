    Bridge.define("System.Runtime.Serialization.SerializationException", {
        inherits: [System.SystemException],
        ctors: {
            ctor: function () {
                this.$initialize();
                System.SystemException.ctor.call(this, "An error occurred during (de)serialization");
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
