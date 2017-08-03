    Bridge.define("System.WeakReference$1", function (T) { return {
        ctors: {
            ctor: function (target) {
                this.$initialize();
            }
        },
        methods: {
            setTarget: function (target) {
                throw new System.NotImplementedException();
            },
            tryGetTarget: function (target) {
                throw new System.NotImplementedException();
            }
        }
    }; });

    Bridge.define("System.WeakReference", {
        inherits: [System.Runtime.Serialization.ISerializable],
        props: {
            IsAlive: {
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
            },
            TrackResurrection: {
                get: function () {
                    throw new System.NotImplementedException();
                }
            }
        },
        alias: ["getObjectData", "System$Runtime$Serialization$ISerializable$getObjectData"],
        ctors: {
            ctor: function (target) {
                System.WeakReference.$ctor1.call(this, target, false);
            },
            $ctor1: function (target, trackResurrection) {
                this.$initialize();
            },
            $ctor2: function (info, context) {
                this.$initialize();
            }
        },
        methods: {
            getObjectData: function (info, context) {
                throw new System.NotImplementedException();
            }
        }
    });
