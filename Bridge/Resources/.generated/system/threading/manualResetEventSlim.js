    Bridge.define("System.Threading.ManualResetEventSlim", {
        inherits: [System.IDisposable],
        statics: {
            methods: {
                checkTimeout: function (timeout) {
                    throw new System.NotImplementedException();
                }
            }
        },
        props: {
            IsSet: {
                get: function () {
                    throw new System.NotImplementedException();
                }
            },
            SpinCount: {
                get: function () {
                    throw new System.NotImplementedException();
                }
            },
            WaitHandle: {
                get: function () {
                    throw new System.NotImplementedException();
                }
            }
        },
        alias: ["dispose", "System$IDisposable$dispose"],
        ctors: {
            ctor: function () {
                System.Threading.ManualResetEventSlim.$ctor2.call(this, false, 10);
            },
            $ctor1: function (initialState) {
                System.Threading.ManualResetEventSlim.$ctor2.call(this, initialState, 10);
            },
            $ctor2: function (initialState, spinCount) {
                this.$initialize();
            }
        },
        methods: {
            reset: function () {
                throw new System.NotImplementedException();
            },
            set: function () {
                throw new System.NotImplementedException();
            },
            wait$4: function () {
                throw new System.NotImplementedException();
            },
            wait: function (millisecondsTimeout) {
                throw new System.NotImplementedException();
            },
            wait$2: function (timeout) {
                throw new System.NotImplementedException();
            },
            wait$5: function (cancellationToken) {
                throw new System.NotImplementedException();
            },
            wait$1: function (millisecondsTimeout, cancellationToken) {
                throw new System.NotImplementedException();
            },
            wait$3: function (timeout, cancellationToken) {
                throw new System.NotImplementedException();
            },
            dispose: function () {
                throw new System.NotImplementedException();
            },
            dispose$1: function (disposing) {
                throw new System.NotImplementedException();
            }
        }
    });
