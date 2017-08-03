    Bridge.define("System.Threading.SynchronizationContext", {
        statics: {
            props: {
                Current: {
                    get: function () {
                        throw new System.NotImplementedException();
                    }
                }
            },
            methods: {
                setSynchronizationContext: function (syncContext) {
                    throw new System.NotImplementedException();
                },
                waitHelper: function (waitHandles, waitAll, millisecondsTimeout) {
                    throw new System.NotImplementedException();
                }
            }
        },
        ctors: {
            ctor: function () {
                this.$initialize();
            },
            $ctor1: function (context) {
                this.$initialize();
            }
        },
        methods: {
            createCopy: function () {
                throw new System.NotImplementedException();
            },
            isWaitNotificationRequired: function () {
                throw new System.NotImplementedException();
            },
            operationCompleted: function () {
                throw new System.NotImplementedException();
            },
            operationStarted: function () {
                throw new System.NotImplementedException();
            },
            post: function (d, state) {
                throw new System.NotImplementedException();
            },
            send: function (d, state) {
                throw new System.NotImplementedException();
            },
            setWaitNotificationRequired: function () {
                throw new System.NotImplementedException();
            },
            wait: function (waitHandles, waitAll, millisecondsTimeout) {
                throw new System.NotImplementedException();
            }
        }
    });
