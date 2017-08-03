    Bridge.define("System.Threading.WaitHandle", {
        inherits: [System.IDisposable],
        statics: {
            fields: {
                WaitTimeout: 0
            },
            ctors: {
                init: function () {
                    Object.defineProperty(this, "WaitTimeout", {
                        get: function() {
                            return this._WaitTimeout$ === undefined ? (this._WaitTimeout$ = 258) : this._WaitTimeout$;
                        },
                        set: function(v) {
                            this._WaitTimeout$ = v;
                        }
                    });
                }
            },
            methods: {
                waitAll: function (waitHandles) {
                    throw new System.NotImplementedException();
                },
                waitAll$2: function (waitHandles, millisecondsTimeout, exitContext) {
                    throw new System.NotImplementedException();
                },
                waitAll$4: function (waitHandles, timeout, exitContext) {
                    throw new System.NotImplementedException();
                },
                waitAll$1: function (waitHandles, millisecondsTimeout) {
                    throw new System.NotImplementedException();
                },
                waitAll$3: function (waitHandles, timeout) {
                    throw new System.NotImplementedException();
                },
                waitAny: function (waitHandles) {
                    throw new System.NotImplementedException();
                },
                waitAny$2: function (waitHandles, millisecondsTimeout, exitContext) {
                    throw new System.NotImplementedException();
                },
                waitAny$3: function (waitHandles, timeout) {
                    throw new System.NotImplementedException();
                },
                waitAny$1: function (waitHandles, millisecondsTimeout) {
                    throw new System.NotImplementedException();
                },
                waitAny$4: function (waitHandles, timeout, exitContext) {
                    throw new System.NotImplementedException();
                },
                signalAndWait: function (toSignal, toWaitOn) {
                    throw new System.NotImplementedException();
                },
                signalAndWait$1: function (toSignal, toWaitOn, millisecondsTimeout, exitContext) {
                    throw new System.NotImplementedException();
                },
                signalAndWait$2: function (toSignal, toWaitOn, timeout, exitContext) {
                    throw new System.NotImplementedException();
                }
            }
        },
        alias: ["dispose", "System$IDisposable$dispose"],
        ctors: {
            ctor: function () {
                this.$initialize();
            }
        },
        methods: {
            close: function () {
                throw new System.NotImplementedException();
            },
            handle: function () {
                throw new System.NotImplementedException();
            },
            waitOne: function () {
                throw new System.NotImplementedException();
            },
            waitOne$2: function (millisecondsTimeout, exitContext) {
                throw new System.NotImplementedException();
            },
            waitOne$1: function (millisecondsTimeout) {
                throw new System.NotImplementedException();
            },
            waitOne$3: function (timeout) {
                throw new System.NotImplementedException();
            },
            waitOne$4: function (timeout, exitContext) {
                throw new System.NotImplementedException();
            },
            checkDisposed: function () {
                throw new System.NotImplementedException();
            },
            dispose: function () {
                throw new System.NotImplementedException();
            }
        }
    });
