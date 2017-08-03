    Bridge.define("System.Threading.AutoResetEvent", {
        inherits: [System.Threading.EventWaitHandle],
        ctors: {
            ctor: function (initialState) {
                this.$initialize();
                System.Threading.EventWaitHandle.ctor.call(this, initialState, System.Threading.EventResetMode.AutoReset);
            }
        }
    });
