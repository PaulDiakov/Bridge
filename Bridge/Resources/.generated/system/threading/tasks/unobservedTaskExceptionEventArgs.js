    Bridge.define("System.Threading.Tasks.UnobservedTaskExceptionEventArgs", {
        props: {
            Exception: {
                get: function () {
                    throw new System.NotImplementedException();
                }
            },
            Observed: {
                get: function () {
                    throw new System.NotImplementedException();
                }
            }
        },
        ctors: {
            ctor: function (exception) {
                this.$initialize();
            }
        },
        methods: {
            setObserved: function () {
                throw new System.NotImplementedException();
            }
        }
    });
