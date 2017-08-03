    Bridge.define("System.GC", {
        statics: {
            props: {
                MaxGeneration: 0
            },
            methods: {
                collect: function () {
                    throw new System.NotImplementedException();
                },
                collect$1: function (generation) {
                    throw new System.NotImplementedException();
                },
                collect$2: function (generation, mode) {
                    throw new System.NotImplementedException();
                },
                collect$3: function (generation, mode, blocking) {
                    throw new System.NotImplementedException();
                },
                getGeneration: function (wo) {
                    throw new System.NotImplementedException();
                },
                addMemoryPressure: function (bytesAllocated) {
                    throw new System.NotImplementedException();
                },
                removeMemoryPressure: function (bytesAllocated) {
                    throw new System.NotImplementedException();
                },
                waitForFullGCApproach: function () {
                    throw new System.NotImplementedException();
                },
                waitForFullGCApproach$1: function (millisecondsTimeout) {
                    throw new System.NotImplementedException();
                },
                waitForFullGCComplete: function () {
                    throw new System.NotImplementedException();
                },
                waitForFullGCComplete$1: function (millisecondsTimeout) {
                    throw new System.NotImplementedException();
                },
                registerForFullGCNotification: function (maxGenerationThreshold, largeObjectHeapThreshold) {
                    throw new System.NotImplementedException();
                },
                cancelFullGCNotification: function () {
                    throw new System.NotImplementedException();
                }
            }
        }
    });
