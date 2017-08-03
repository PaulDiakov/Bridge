    Bridge.define("System.Runtime.InteropServices.StructLayoutAttribute", {
        inherits: [System.Attribute],
        fields: {
            pack: 0,
            size: 0
        },
        props: {
            Value: {
                get: function () {
                    return 0;
                }
            }
        },
        ctors: {
            ctor: function (layoutKind) {
                this.$initialize();
                System.Attribute.ctor.call(this);
                return;
            },
            $ctor1: function (layoutKind) {
                this.$initialize();
                System.Attribute.ctor.call(this);
                return;
            }
        }
    });
