    Bridge.define("System.Lazy$1", function (T) { return {
        props: {
            Value: {
                get: function () {
                    throw new System.NotImplementedException();
                }
            },
            IsValueCreated: {
                get: function () {
                    throw new System.NotImplementedException();
                }
            }
        },
        ctors: {
            ctor: function () {
                System.Lazy$1(T).$ctor5.call(this, System.Threading.LazyThreadSafetyMode.ExecutionAndPublication);
            },
            $ctor2: function (valueFactory) {
                System.Lazy$1(T).$ctor4.call(this, valueFactory, System.Threading.LazyThreadSafetyMode.ExecutionAndPublication);
            },
            $ctor1: function (isThreadSafe) {
                System.Lazy$1(T).$ctor4.call(this, function () {
                    return Bridge.createInstance(T);
                }, isThreadSafe ? System.Threading.LazyThreadSafetyMode.ExecutionAndPublication : System.Threading.LazyThreadSafetyMode.None);
            },
            $ctor3: function (valueFactory, isThreadSafe) {
                System.Lazy$1(T).$ctor4.call(this, valueFactory, isThreadSafe ? System.Threading.LazyThreadSafetyMode.ExecutionAndPublication : System.Threading.LazyThreadSafetyMode.None);
            },
            $ctor5: function (mode) {
                System.Lazy$1(T).$ctor4.call(this, function () {
                    return Bridge.createInstance(T);
                }, mode);
            },
            $ctor4: function (valueFactory, mode) {
                this.$initialize();
            }
        },
        methods: {
            initValue: function () {
                throw new System.NotImplementedException();
            },
            toString: function () {
                throw new System.NotImplementedException();
            }
        }
    }; });
