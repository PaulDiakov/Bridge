    Bridge.define("System.IO.Path", {
        statics: {
            fields: {
                invalidPathChars: null,
                altDirectorySeparatorChar: 0,
                directorySeparatorChar: 0,
                pathSeparator: 0,
                directorySeparatorStr: null,
                volumeSeparatorChar: 0,
                pathSeparatorChars: null
            },
            props: {
                DirectorySeparatorCharAsString: {
                    get: function () {
                        throw new System.NotImplementedException();
                    }
                }
            },
            methods: {
                changeExtension: function (path, extension) {
                    throw new System.NotImplementedException();
                },
                combine: function (path1, path2) {
                    throw new System.NotImplementedException();
                },
                combine$3: function (paths) {
                    if (paths === void 0) { paths = []; }
                    throw new System.NotImplementedException();
                },
                combine$1: function (path1, path2, path3) {
                    throw new System.NotImplementedException();
                },
                combine$2: function (path1, path2, path3, path4) {
                    throw new System.NotImplementedException();
                },
                cleanPath: function (s) {
                    throw new System.NotImplementedException();
                },
                getDirectoryName: function (path) {
                    throw new System.NotImplementedException();
                },
                getExtension: function (path) {
                    throw new System.NotImplementedException();
                },
                getFileName: function (path) {
                    throw new System.NotImplementedException();
                },
                getFileNameWithoutExtension: function (path) {
                    throw new System.NotImplementedException();
                },
                getFullPath: function (path) {
                    throw new System.NotImplementedException();
                },
                getFullPathInternal: function (path) {
                    throw new System.NotImplementedException();
                },
                getFullPathName: function (path) {
                    throw new System.NotImplementedException();
                },
                windowsDriveAdjustment: function (path) {
                    throw new System.NotImplementedException();
                },
                insecureGetFullPath: function (path) {
                    throw new System.NotImplementedException();
                },
                isDirectorySeparator: function (c) {
                    throw new System.NotImplementedException();
                },
                getPathRoot: function (path) {
                    throw new System.NotImplementedException();
                },
                getTempFileName: function () {
                    throw new System.NotImplementedException();
                },
                getTempPath: function () {
                    throw new System.NotImplementedException();
                },
                hasExtension: function (path) {
                    throw new System.NotImplementedException();
                },
                isPathRooted: function (path) {
                    throw new System.NotImplementedException();
                },
                getInvalidFileNameChars: function () {
                    throw new System.NotImplementedException();
                },
                getInvalidPathChars: function () {
                    throw new System.NotImplementedException();
                },
                getRandomFileName: function () {
                    throw new System.NotImplementedException();
                },
                validate: function (path) {
                    throw new System.NotImplementedException();
                },
                validate$1: function (path, parameterName) {
                    throw new System.NotImplementedException();
                }
            }
        }
    });
