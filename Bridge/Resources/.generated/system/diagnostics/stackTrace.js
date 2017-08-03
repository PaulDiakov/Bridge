    Bridge.define("System.Diagnostics.StackTrace", {
        statics: {
            fields: {
                METHODS_TO_SKIP: 0
            },
            ctors: {
                init: function () {
                    Object.defineProperty(this, "METHODS_TO_SKIP", {
                        get: function() {
                            return this._METHODS_TO_SKIP$ === undefined ? (this._METHODS_TO_SKIP$ = 0) : this._METHODS_TO_SKIP$;
                        },
                        set: function(v) {
                            this._METHODS_TO_SKIP$ = v;
                        }
                    });
                }
            },
            methods: {
                getFullNameForStackTrace: function (sb, mi) {
                    throw new System.NotImplementedException();
                }
            }
        },
        props: {
            FrameCount: {
                get: function () {
                    throw new System.NotImplementedException();
                }
            }
        },
        ctors: {
            ctor: function () {
                this.$initialize();
            },
            $ctor1: function (fNeedFileInfo) {
                this.$initialize();
            },
            $ctor8: function (skipFrames) {
                this.$initialize();
            },
            $ctor9: function (skipFrames, fNeedFileInfo) {
                this.$initialize();
            },
            $ctor4: function (e) {
                System.Diagnostics.StackTrace.$ctor7.call(this, e, System.Diagnostics.StackTrace.METHODS_TO_SKIP, false);
            },
            $ctor5: function (e, fNeedFileInfo) {
                System.Diagnostics.StackTrace.$ctor7.call(this, e, System.Diagnostics.StackTrace.METHODS_TO_SKIP, fNeedFileInfo);
            },
            $ctor6: function (e, skipFrames) {
                System.Diagnostics.StackTrace.$ctor7.call(this, e, skipFrames, false);
            },
            $ctor7: function (e, skipFrames, fNeedFileInfo) {
                this.$initialize();
            },
            $ctor2: function (frame) {
                this.$initialize();
            },
            $ctor10: function (targetThread, needFileInfo) {
                this.$initialize();
            },
            $ctor3: function (frames) {
                this.$initialize();
            }
        },
        methods: {
            getFrame: function (index) {
                throw new System.NotImplementedException();
            },
            getFrames: function () {
                throw new System.NotImplementedException();
            },
            addFrames: function (sb) {
                throw new System.NotImplementedException();
            },
            toString: function () {
                throw new System.NotImplementedException();
            },
            toString$1: function (traceFormat) {
                throw new System.NotImplementedException();
            }
        }
    });
