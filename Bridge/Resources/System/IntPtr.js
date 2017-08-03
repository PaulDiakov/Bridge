Bridge.define("System.IntPtr", {
    $kind: "struct",
    statics: {
        fields: {
            zero: null
        },
        props: {
            Size: {
                get: function () {
                    throw new System.NotImplementedException();
                }
            }
        },
        ctors: {
            init: function () {
                this.zero = new System.IntPtr();
            }
        },
        methods: {
            add: function (pointer, offset) {
                throw new System.NotImplementedException();
            },
            subtract: function (pointer, offset) {
                throw new System.NotImplementedException();
            },
            op_Equality: function (value1, value2) {
                throw new System.NotImplementedException();
            },
            op_Inequality: function (value1, value2) {
                throw new System.NotImplementedException();
            },
            op_Explicit$2: function (value) {
                throw new System.NotImplementedException();
            },
            op_Explicit$3: function (value) {
                throw new System.NotImplementedException();
            },
            op_Explicit$4: function (value) {
                throw new System.NotImplementedException();
            },
            op_Explicit: function (value) {
                throw new System.NotImplementedException();
            },
            op_Explicit$1: function (value) {
                throw new System.NotImplementedException();
            },
            op_Explicit$5: function (value) {
                throw new System.NotImplementedException();
            },
            op_Addition: function (pointer, offset) {
                throw new System.NotImplementedException();
            },
            op_Subtraction: function (pointer, offset) {
                throw new System.NotImplementedException();
            },
            getDefaultValue: function () { return new System.IntPtr(); }
        }
    },
    fields: {
        pointer: null
    },
    ctors: {
        $ctor1: function (value) {
            this.$initialize();
            this.pointer = new System.JsPtr.ctor(value);
        },
        $ctor2: function (value) {
            this.$initialize();
            this.pointer = new System.JsPtr.$ctor1(value);
        },
        $ctor3: function (value) {
            this.$initialize();
            this.pointer = value;
        },
        ctor: function (value) {
            this.$initialize();
            this.pointer = value;
        }
    },
    methods: {
        equals: function (obj) {
            throw new System.NotImplementedException();
        },
        getHashCode: function () {
            throw new System.NotImplementedException();
        },
        toInt32: function () {
            throw new System.NotImplementedException();
        },
        toInt64: function () {
            throw new System.NotImplementedException();
        },
        toPointer: function () {
            return this.pointer;
        },
        toString: function () {
            throw new System.NotImplementedException();
        },
        toString$1: function (format) {
            throw new System.NotImplementedException();
        },
        isNull: function () {
            throw new System.NotImplementedException();
        },
        $clone: function (to) {
            var s = to || new System.IntPtr();
            s.pointer = this.pointer;
            return s;
        }
    }
});
