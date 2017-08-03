    Bridge.define("System.Threading.EventWaitHandle", {
        inherits: [System.Threading.WaitHandle],
        statics: {
            methods: {
                isManualReset: function (mode) {
                    throw new System.NotImplementedException();
                },
                openExisting: function (name) {
                    throw new System.NotImplementedException();
                },
                openExisting$1: function (name, rights) {
                    throw new System.NotImplementedException();
                }
            }
        },
        ctors: {
            ctor: function (initialState, mode) {
                this.$initialize();
                System.Threading.WaitHandle.ctor.call(this);
            },
            $ctor1: function (initialState, mode, name) {
                this.$initialize();
                System.Threading.WaitHandle.ctor.call(this);
            },
            $ctor2: function (initialState, mode, name, createdNew) {
                this.$initialize();
                System.Threading.WaitHandle.ctor.call(this);
                throw new System.NotImplementedException();
            },
            $ctor3: function (initialState, mode, name, createdNew, eventSecurity) {
                this.$initialize();
                System.Threading.WaitHandle.ctor.call(this);
                throw new System.NotImplementedException();
            }
        },
        methods: {
            getAccessControl: function () {
                throw new System.NotImplementedException();
            },
            reset: function () {
                throw new System.NotImplementedException();
            },
            set: function () {
                throw new System.NotImplementedException();
            },
            setAccessControl: function (eventSecurity) {
                throw new System.NotImplementedException();
            }
        }
    });
