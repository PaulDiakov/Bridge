    Bridge.define("System.IO.DirectoryInfo", {
        inherits: [System.IO.FileSystemInfo],
        props: {
            Exists: {
                get: function () {
                    throw new System.NotImplementedException();
                }
            },
            Name: {
                get: function () {
                    throw new System.NotImplementedException();
                }
            },
            Parent: {
                get: function () {
                    throw new System.NotImplementedException();
                }
            },
            Root: {
                get: function () {
                    throw new System.NotImplementedException();
                }
            }
        },
        ctors: {
            ctor: function (path) {
                System.IO.DirectoryInfo.$ctor1.call(this, path, false);
            },
            $ctor1: function (path, simpleOriginalPath) {
                this.$initialize();
                System.IO.FileSystemInfo.ctor.call(this);
            }
        },
        methods: {
            create: function () {
                throw new System.NotImplementedException();
            },
            createSubdirectory: function (path) {
                throw new System.NotImplementedException();
            },
            getFiles: function () {
                throw new System.NotImplementedException();
            },
            getFiles$1: function (searchPattern) {
                throw new System.NotImplementedException();
            },
            getDirectories: function () {
                throw new System.NotImplementedException();
            },
            getDirectories$1: function (searchPattern) {
                throw new System.NotImplementedException();
            },
            getFileSystemInfos: function () {
                throw new System.NotImplementedException();
            },
            delete: function () {
                throw new System.NotImplementedException();
            },
            delete$1: function (recursive) {
                throw new System.NotImplementedException();
            },
            moveTo: function (destDirName) {
                throw new System.NotImplementedException();
            },
            toString: function () {
                throw new System.NotImplementedException();
            }
        }
    });
