    Bridge.define("System.Reflection.InterfaceMapping", {
        $kind: "struct",
        statics: {
            methods: {
                getDefaultValue: function () { return new System.Reflection.InterfaceMapping(); }
            }
        },
        fields: {
            interfaceMethods: null,
            interfaceType: null,
            targetMethods: null,
            targetType: null
        },
        ctors: {
            ctor: function () {
                this.$initialize();
            }
        },
        methods: {
            getHashCode: function () {
                var h = Bridge.addHash([6990171024, this.interfaceMethods, this.interfaceType, this.targetMethods, this.targetType]);
                return h;
            },
            equals: function (o) {
                if (!Bridge.is(o, System.Reflection.InterfaceMapping)) {
                    return false;
                }
                return Bridge.equals(this.interfaceMethods, o.interfaceMethods) && Bridge.equals(this.interfaceType, o.interfaceType) && Bridge.equals(this.targetMethods, o.targetMethods) && Bridge.equals(this.targetType, o.targetType);
            },
            $clone: function (to) {
                var s = to || new System.Reflection.InterfaceMapping();
                s.interfaceMethods = this.interfaceMethods;
                s.interfaceType = this.interfaceType;
                s.targetMethods = this.targetMethods;
                s.targetType = this.targetType;
                return s;
            }
        }
    });
