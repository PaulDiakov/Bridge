Bridge.define("System.JsPtr", {
    statics: {
        methods: {
            cast: function (value, type) 
            {
                var pointer = value.toPointer().copy();

                //cast only if buffer is typed array
                return pointer.toTypedView(pointer.type == 'source' ? 'source' : type);
            },
            getPointer: function (source, offset)
            {
                var pointer;

                if (source.isJsPtr)
                {
                    pointer = new System.JsPtr.$ctor2(source.buffer);
                    pointer.offset = source.offset + offset || 0;

                    return pointer.toTypedView(source.type);
                }

                pointer = new System.JsPtr.$ctor2(source);
                pointer.offset = offset || 0;

                return pointer.toSourceView();
            },
            toFixed: function (source)
            {
                return source.isJsPtr ? source : System.JsPtr.getPointer(source);
            }
        }
    },
    fields: {
        isJsPtr: null,
        buffer: null,
        current: null,
        offset: null,
        type: null,
        view: null
    },
    ctors: {
        ctor: function (value) { // from int
            this.$initialize();
            this.isJsPtr = true;
            this.buffer = new ArrayBuffer(value);
            this.current = 0;
            this.offset = 0;
        },
        $ctor1: function (value) { // from long
            this.$initialize();
            this.isJsPtr = true;
            this.buffer = new ArrayBuffer(value);
            this.current = 0;
            this.offset = 0;
        },
        $ctor2: function (value) { // from "pointer" (another ArrayBuffer or js array)
            this.$initialize();
            this.isJsPtr = true;
            this.buffer = value;
            this.current = 0;
            this.offset = 0;
        }
    },
    methods: {
        toPointer: function()
        {
            return this;
        },

        toTypedView: function (type)
        {
            this.type = type;

            switch(this.type)
            {
            case System.Single:
                return this.toFloat32View();

            case System.Int32:
                return this.toInt32View();

            case System.Byte:
                return this.toUint8Array();

            default:
                this.type = 'source';
                return this.toSourceView();
            }
        },
        
        toFloat32View: function()
        {
            this.view = new Float32Array(this.buffer);

            return this;
        },

        toInt32View: function()
        {
            this.view = new Int32Array(this.buffer);

            return this;
        },

        toUint8Array: function()
        {
            this.view = new Uint8Array(this.buffer);

            return this;
        },

        toSourceView: function()
        {
            this.view = this.buffer;

            return this;
        },

        getElement: function(index)
        {
            return this.view[index + this.offset];
        },

        setElement: function(index, value)
        {
            this.view[index + this.offset] = value;
        },

        get: function()
        {
            return this.view[this.current + this.offset];
        },

        set: function(value)
        {
            this.view[this.current + this.offset] = value;
        },

        add: function(value)
        {
            this.view[this.current + this.offset] += value;
        },

        sub: function(value)
        {
            this.view[this.current + this.offset] -= value;
        },

        addOffset: function (value, createNew) 
        {
            var ptr = createNew ? this.copy() : this;
            
            ptr.current += value;

            return ptr;
        },
        
        subOffset: function (value, createNew) 
        {
            return addOffset(-value, createNew);
        },

        copy: function ()
        {
            var ptr = new System.JsPtr.$ctor2(this.buffer);
            ptr.current = this.current;
            ptr.offset = this.offset;
            ptr.type = this.type;
            ptr.view = this.view;

            return ptr;
        }
    }
});
