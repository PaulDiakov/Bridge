    Bridge.define("System.Threading.Tasks.TaskScheduler", {
        statics: {
            props: {
                Default: {
                    get: function () {
                        throw new System.NotImplementedException();
                    }
                },
                Current: {
                    get: function () {
                        throw new System.NotImplementedException();
                    },
                    set: function (value) {
                        throw new System.NotImplementedException();
                    }
                }
            },
            methods: {
                fromCurrentSynchronizationContext: function () {
                    throw new System.NotImplementedException();
                },
                fireUnobservedEvent: function (task, e) {
                    throw new System.NotImplementedException();
                }
            }
        },
        props: {
            Id: {
                get: function () {
                    throw new System.NotImplementedException();
                }
            },
            MaximumConcurrencyLevel: {
                get: function () {
                    throw new System.NotImplementedException();
                }
            }
        },
        ctors: {
            ctor: function () {
                this.$initialize();
            }
        },
        methods: {
            tryDequeue: function (task) {
                throw new System.NotImplementedException();
            },
            tryExecuteTask: function (task) {
                throw new System.NotImplementedException();
            },
            runInline: function (task, taskWasPreviouslyQueued) {
                throw new System.NotImplementedException();
            }
        }
    });
