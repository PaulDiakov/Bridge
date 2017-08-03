    Bridge.define("System.Diagnostics.StackFrame", {
        statics: {
            fields: {
                OFFSET_UNKNOWN: 0
            },
            ctors: {
                init: function () {
                    Object.defineProperty(this, "OFFSET_UNKNOWN", {
                        get: function() {
                            return this._OFFSET_UNKNOWN$ === undefined ? (this._OFFSET_UNKNOWN$ = -1) : this._OFFSET_UNKNOWN$;
                        },
                        set: function(v) {
                            this._OFFSET_UNKNOWN$ = v;
                        }
                    });
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
            $ctor2: function (skipFrames) {
                this.$initialize();
            },
            $ctor3: function (skipFrames, fNeedFileInfo) {
                this.$initialize();
            },
            $ctor4: function (fileName, lineNumber) {
                this.$initialize();
            },
            $ctor5: function (fileName, lineNumber, colNumber) {
                this.$initialize();
            }
        },
        methods: {
            getFileLineNumber: function () {
                throw new System.NotImplementedException();
            },
            getFileColumnNumber: function () {
                throw new System.NotImplementedException();
            },
            getFileName: function () {
                throw new System.NotImplementedException();
            },
            getSecureFileName: function () {
                throw new System.NotImplementedException();
            },
            getILOffset: function () {
                throw new System.NotImplementedException();
            },
            getMethod: function () {
                throw new System.NotImplementedException();
            },
            getNativeOffset: function () {
                throw new System.NotImplementedException();
            },
            getMethodAddress: function () {
                throw new System.NotImplementedException();
            },
            getMethodIndex: function () {
                throw new System.NotImplementedException();
            },
            getInternalMethodName: function () {
                throw new System.NotImplementedException();
            },
            toString: function () {
                throw new System.NotImplementedException();
            }
        }
    });
