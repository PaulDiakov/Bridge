    Bridge.define("System.Reflection.AssemblyName", {
        props: {
            Name: {
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
            },
            $ctor1: function (assemblyName) {
                this.$initialize();
            }
        }
    });
