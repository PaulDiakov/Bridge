    Bridge.define("System.StringComparer", {
        inherits: [System.Collections.Generic.IComparer$1(System.String),System.Collections.Generic.IEqualityComparer$1(System.String)],
        statics: {
            props: {
                CurrentCulture: {
                    get: function () {
                        throw new System.NotImplementedException();
                    }
                },
                CurrentCultureIgnoreCase: {
                    get: function () {
                        throw new System.NotImplementedException();
                    }
                },
                InvariantCulture: {
                    get: function () {
                        throw new System.NotImplementedException();
                    }
                },
                InvariantCultureIgnoreCase: {
                    get: function () {
                        throw new System.NotImplementedException();
                    }
                },
                Ordinal: {
                    get: function () {
                        throw new System.NotImplementedException();
                    }
                },
                OrdinalIgnoreCase: {
                    get: function () {
                        throw new System.NotImplementedException();
                    }
                }
            },
            methods: {
                create: function (culture, ignoreCase) {
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
            compare$1: function (x, y) {
                throw new System.NotImplementedException();
            },
            equals: function (x, y) {
                throw new System.NotImplementedException();
            },
            getHashCode: function (obj) {
                throw new System.NotImplementedException();
            }
        }
    });
