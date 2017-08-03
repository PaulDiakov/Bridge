    Bridge.define("System.Threading.Tasks.TaskScheduler.TaskSchedulerDebuggerView", {
        props: {
            ScheduledTasks: {
                get: function () {
                    throw new System.NotImplementedException();
                }
            }
        },
        ctors: {
            ctor: function (scheduler) {
                this.$initialize();
            }
        }
    });
