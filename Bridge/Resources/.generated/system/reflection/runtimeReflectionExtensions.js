    Bridge.define("System.Reflection.RuntimeReflectionExtensions", {
        statics: {
            methods: {
                getRuntimeProperties: function (type) {
                    return null;
                },
                getRuntimeEvents: function (type) {
                    return null;
                },
                getRuntimeMethods: function (type) {
                    return null;
                },
                getRuntimeFields: function (type) {
                    return null;
                },
                getRuntimeProperty: function (type, name) {
                    return null;
                },
                getRuntimeEvent: function (type, name) {
                    return null;
                },
                getRuntimeMethod: function (type, name, parameters) {
                    return null;
                },
                getRuntimeField: function (type, name) {
                    return null;
                },
                getRuntimeBaseDefinition: function (method) {
                    return null;
                },
                getRuntimeInterfaceMap: function (typeInfo, interfaceType) {
                    return Bridge.getDefaultValue(System.Reflection.InterfaceMapping);
                },
                getMethodInfo: function (del) {
                    return null;
                }
            }
        }
    });
