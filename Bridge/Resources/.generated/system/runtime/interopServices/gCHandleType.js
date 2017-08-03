    Bridge.define("System.Runtime.InteropServices.GCHandleType", {
        $kind: "enum",
        statics: {
            fields: {
                Weak: 0,
                WeakTrackResurrection: 1,
                Normal: 2,
                Pinned: 3
            }
        }
    });
