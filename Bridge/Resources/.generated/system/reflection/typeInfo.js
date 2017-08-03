    Bridge.define("System.Reflection.TypeInfo", {
        inherits: [Function,System.Reflection.IReflectableType],
        ctors: {
            ctor: function () {
                this.$initialize();
            }
        },
        methods: {
            System$Reflection$IReflectableType$getTypeInfo: function () {
                throw new System.NotImplementedException();
            }
        }
    });
