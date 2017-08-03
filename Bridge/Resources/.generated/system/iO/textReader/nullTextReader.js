    Bridge.define("System.IO.TextReader.NullTextReader", {
        inherits: [System.IO.TextReader],
        methods: {
            readLine: function () {
                throw new System.NotImplementedException();
            },
            readToEnd: function () {
                throw new System.NotImplementedException();
            }
        }
    });
