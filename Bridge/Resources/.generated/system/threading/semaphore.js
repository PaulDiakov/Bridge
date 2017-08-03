    Bridge.define("System.Threading.Semaphore", {
        inherits: [System.Threading.WaitHandle],
        statics: {
            methods: {
                openExisting: function (name) {
                    throw new System.NotImplementedException();
                }
            }
        },
        ctors: {
            $ctor2: function (handle) {
                this.$initialize();
                System.Threading.WaitHandle.ctor.call(this);
            },
            ctor: function (initialCount, maximumCount) {
                System.Threading.Semaphore.$ctor1.call(this, initialCount, maximumCount, null);
            },
            $ctor1: function (initialCount, maximumCount, name) {
                this.$initialize();
                System.Threading.WaitHandle.ctor.call(this);
            }
        },
        methods: {
            release: function () {
                throw new System.NotImplementedException();
            },
            release$1: function (releaseCount) {
                throw new System.NotImplementedException();
            }
        }
    });
