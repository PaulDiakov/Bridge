Bridge.define("System.Runtime.InteropServices.Marshal", {
    statics: {
        methods: {
            allocHGlobal$1: function (cb) { //from IntPtr
                throw new System.NotImplementedException();
            },
            allocHGlobal: function (cb) {
                return new System.IntPtr.$ctor1(cb);
            },
            freeHGlobal: function (hglobal) {
                //delete IntPtr, free buffer
                throw new System.NotImplementedException();
            },
            ptrToStringAnsi: function (ptr) {
                throw new System.NotImplementedException();
            },
            ptrToStringAnsi$1: function (ptr, len) {
                throw new System.NotImplementedException();
            },
            ptrToStructure$1: function (ptr, structure) {
                throw new System.NotImplementedException();
            },
            ptrToStructure: function (ptr, structureType) {
                throw new System.NotImplementedException();
            },
            sizeOf: function (structure) {
                throw new System.NotImplementedException();
            },
            sizeOf$1: function (t) {
                throw new System.NotImplementedException();
            },
            copy: function (source, startIndex, destination, length) {
                throw new System.NotImplementedException();
            },
            copy$1: function (source, startIndex, destination, length) {
                throw new System.NotImplementedException();
            },
            copy$3: function (source, startIndex, destination, length) {
                throw new System.NotImplementedException();
            },
            copy$4: function (source, startIndex, destination, length) {
                throw new System.NotImplementedException();
            },
            copy$5: function (source, startIndex, destination, length) {
                throw new System.NotImplementedException();
            },
            copy$15: function (source, startIndex, destination, length) {
                throw new System.NotImplementedException();
            },
            copy$2: function (source, startIndex, destination, length) {
                throw new System.NotImplementedException();
            },
            copy$14: function (source, startIndex, destination, length) {
                throw new System.NotImplementedException();
            },
            copy$6: function (source, destination, startIndex, length) {
                throw new System.NotImplementedException();
            },
            copy$7: function (source, destination, startIndex, length) {
                throw new System.NotImplementedException();
            },
            copy$9: function (source, destination, startIndex, length) {
                throw new System.NotImplementedException();
            },
            copy$10: function (source, destination, startIndex, length) {
                throw new System.NotImplementedException();
            },
            copy$11: function (source, destination, startIndex, length) {
                throw new System.NotImplementedException();
            },
            copy$13: function (source, destination, startIndex, length) {
                throw new System.NotImplementedException();
            },
            copy$8: function (source, destination, startIndex, length) {
                throw new System.NotImplementedException();
            },
            copy$12: function (source, destination, startIndex, length) {
                throw new System.NotImplementedException();
            }
        }
    }
});
