    Bridge.define("System.Threading.ReaderWriterLockSlim", {
        inherits: [System.IDisposable],
        props: {
            IsReadLockHeld: {
                get: function () {
                    throw new System.NotImplementedException();
                }
            },
            IsUpgradeableReadLockHeld: {
                get: function () {
                    throw new System.NotImplementedException();
                }
            },
            IsWriteLockHeld: {
                get: function () {
                    throw new System.NotImplementedException();
                }
            },
            RecursionPolicy: {
                get: function () {
                    throw new System.NotImplementedException();
                }
            },
            CurrentReadCount: {
                get: function () {
                    throw new System.NotImplementedException();
                }
            },
            RecursiveReadCount: {
                get: function () {
                    throw new System.NotImplementedException();
                }
            },
            RecursiveUpgradeCount: {
                get: function () {
                    throw new System.NotImplementedException();
                }
            },
            RecursiveWriteCount: {
                get: function () {
                    throw new System.NotImplementedException();
                }
            },
            WaitingReadCount: {
                get: function () {
                    throw new System.NotImplementedException();
                }
            },
            WaitingUpgradeCount: {
                get: function () {
                    throw new System.NotImplementedException();
                }
            },
            WaitingWriteCount: {
                get: function () {
                    throw new System.NotImplementedException();
                }
            }
        },
        alias: ["dispose", "System$IDisposable$dispose"],
        ctors: {
            ctor: function () {
                System.Threading.ReaderWriterLockSlim.$ctor1.call(this, System.Threading.LockRecursionPolicy.NoRecursion);
            },
            $ctor1: function (recursionPolicy) {
                this.$initialize();
            }
        },
        methods: {
            enterReadLock: function () {
                throw new System.NotImplementedException();
            },
            tryEnterReadLock$1: function (timeout) {
                throw new System.NotImplementedException();
            },
            tryEnterReadLock: function (millisecondsTimeout) {
                throw new System.NotImplementedException();
            },
            enterWriteLock: function () {
                throw new System.NotImplementedException();
            },
            tryEnterWriteLock$1: function (timeout) {
                throw new System.NotImplementedException();
            },
            tryEnterWriteLock: function (millisecondsTimeout) {
                throw new System.NotImplementedException();
            },
            enterUpgradeableReadLock: function () {
                throw new System.NotImplementedException();
            },
            tryEnterUpgradeableReadLock$1: function (timeout) {
                throw new System.NotImplementedException();
            },
            tryEnterUpgradeableReadLock: function (millisecondsTimeout) {
                throw new System.NotImplementedException();
            },
            exitReadLock: function () {
                throw new System.NotImplementedException();
            },
            exitWriteLock: function () {
                throw new System.NotImplementedException();
            },
            exitUpgradeableReadLock: function () {
                throw new System.NotImplementedException();
            },
            dispose: function () {
                throw new System.NotImplementedException();
            }
        }
    });
