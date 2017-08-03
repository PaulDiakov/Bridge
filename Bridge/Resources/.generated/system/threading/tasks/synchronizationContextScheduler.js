    Bridge.define("System.Threading.Tasks.SynchronizationContextScheduler", {
        inherits: [System.Threading.Tasks.TaskScheduler],
        props: {
            MaximumConcurrencyLevel: {
                get: function () {
                    throw new System.NotImplementedException();
                }
            }
        },
        ctors: {
            ctor: function (ctx) {
                this.$initialize();
                System.Threading.Tasks.TaskScheduler.ctor.call(this);
            }
        },
        methods: {
            queueTask: function (task) { },
            taskLaunchWrapper: function (obj) { },
            getScheduledTasks: function () {
                throw new System.NotImplementedException();
            },
            tryDequeue: function (task) {
                throw new System.NotImplementedException();
            },
            tryExecuteTaskInline: function (task, taskWasPreviouslyQueued) {
                throw new System.NotImplementedException();
            }
        }
    });
