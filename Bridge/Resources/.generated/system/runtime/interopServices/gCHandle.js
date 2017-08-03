    Bridge.define("System.Runtime.InteropServices.GCHandle", {
        $kind: "struct",
        statics: {
            methods: {
                alloc: function (value) {
                    throw new System.NotImplementedException();
                },
                alloc$1: function (value, type) {
                    throw new System.NotImplementedException();
                },
                fromIntPtr: function (value) {
                    throw new System.NotImplementedException();
                },
                toIntPtr: function (value) {
                    throw new System.NotImplementedException();
                },
                op_Explicit: function (value) {
                    throw new System.NotImplementedException();
                },
                op_Explicit$1: function (value) {
                    throw new System.NotImplementedException();
                },
                op_Equality: function (a, b) {
                    throw new System.NotImplementedException();
                },
                op_Inequality: function (a, b) {
                    throw new System.NotImplementedException();
                },
                getDefaultValue: function () { return new System.Runtime.InteropServices.GCHandle(); }
            }
        },
        props: {
            IsAllocated: {
                get: function () {
                    throw new System.NotImplementedException();
                }
            },
            Target: {
                get: function () {
                    throw new System.NotImplementedException();
                },
                set: function (value) {
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
            addrOfPinnedObject: function () {
                throw new System.NotImplementedException();
            },
            free: function () {
                throw new System.NotImplementedException();
            },
            equals: function (o) {
                throw new System.NotImplementedException();
            },
            getHashCode: function () {
                throw new System.NotImplementedException();
            },
            $clone: function (to) { return this; }
        }
    });
