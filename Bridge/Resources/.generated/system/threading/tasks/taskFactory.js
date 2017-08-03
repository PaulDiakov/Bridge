    Bridge.define("System.Threading.Tasks.TaskFactory", {
        statics: {
            methods: {
                checkContinuationOptions: function (continuationOptions) { },
                checkContinueArguments: function (tasks, continuationAction, continuationOptions, scheduler) { }
            }
        },
        props: {
            Scheduler: {
                get: function () {
                    return null;
                }
            },
            ContinuationOptions: {
                get: function () {
                    return 0;
                }
            },
            CreationOptions: {
                get: function () {
                    return 0;
                }
            },
            CancellationToken: {
                get: function () {
                    return Bridge.getDefaultValue(System.Threading.CancellationToken);
                }
            }
        },
        ctors: {
            ctor: function () {
                System.Threading.Tasks.TaskFactory.$ctor2.call(this, System.Threading.CancellationToken.none, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskContinuationOptions.None, null);
            },
            $ctor1: function (cancellationToken) {
                System.Threading.Tasks.TaskFactory.$ctor2.call(this, cancellationToken, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskContinuationOptions.None, null);
            },
            $ctor4: function (scheduler) {
                System.Threading.Tasks.TaskFactory.$ctor2.call(this, System.Threading.CancellationToken.none, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskContinuationOptions.None, scheduler);
            },
            $ctor3: function (creationOptions, continuationOptions) {
                System.Threading.Tasks.TaskFactory.$ctor2.call(this, System.Threading.CancellationToken.none, creationOptions, continuationOptions, null);
            },
            $ctor2: function (cancellationToken, creationOptions, continuationOptions, scheduler) {
                this.$initialize();
            }
        },
        methods: {
            startNew: function (action) {
                return null;
            },
            startNew$1: function (action, cancellationToken) {
                return null;
            },
            startNew$3: function (action, creationOptions) {
                return null;
            },
            startNew$2: function (action, cancellationToken, creationOptions, scheduler) {
                return null;
            },
            startNew$4: function (action, state) {
                return null;
            },
            startNew$5: function (action, state, cancellationToken) {
                return null;
            },
            startNew$7: function (action, state, creationOptions) {
                return null;
            },
            startNew$6: function (action, state, cancellationToken, creationOptions, scheduler) {
                return null;
            },
            startNew$8: function (TResult, $function) {
                return null;
            },
            startNew$11: function (TResult, $function, creationOptions) {
                return null;
            },
            startNew$9: function (TResult, $function, cancellationToken) {
                return null;
            },
            startNew$10: function (TResult, $function, cancellationToken, creationOptions, scheduler) {
                return null;
            },
            startNew$12: function (TResult, $function, state) {
                return null;
            },
            startNew$13: function (TResult, $function, state, cancellationToken) {
                return null;
            },
            startNew$15: function (TResult, $function, state, creationOptions) {
                return null;
            },
            startNew$14: function (TResult, $function, state, cancellationToken, creationOptions, scheduler) {
                return null;
            },
            continueWhenAny: function (tasks, continuationAction) {
                return null;
            },
            continueWhenAny$1: function (tasks, continuationAction, cancellationToken) {
                return null;
            },
            continueWhenAny$3: function (tasks, continuationAction, continuationOptions) {
                return null;
            },
            continueWhenAny$2: function (tasks, continuationAction, cancellationToken, continuationOptions, scheduler) {
                return null;
            },
            continueWhenAny$4: function (TAntecedentResult, tasks, continuationAction) {
                return null;
            },
            continueWhenAny$5: function (TAntecedentResult, tasks, continuationAction, cancellationToken) {
                return null;
            },
            continueWhenAny$7: function (TAntecedentResult, tasks, continuationAction, continuationOptions) {
                return null;
            },
            continueWhenAny$6: function (TAntecedentResult, tasks, continuationAction, cancellationToken, continuationOptions, scheduler) {
                return null;
            },
            continueWhenAny$8: function (TResult, tasks, continuationFunction) {
                return null;
            },
            continueWhenAny$9: function (TResult, tasks, continuationFunction, cancellationToken) {
                return null;
            },
            continueWhenAny$11: function (TResult, tasks, continuationFunction, continuationOptions) {
                return null;
            },
            continueWhenAny$10: function (TResult, tasks, continuationFunction, cancellationToken, continuationOptions, scheduler) {
                return null;
            },
            continueWhenAny$12: function (TAntecedentResult, TResult, tasks, continuationFunction) {
                return null;
            },
            continueWhenAny$13: function (TAntecedentResult, TResult, tasks, continuationFunction, cancellationToken) {
                return null;
            },
            continueWhenAny$15: function (TAntecedentResult, TResult, tasks, continuationFunction, continuationOptions) {
                return null;
            },
            continueWhenAny$14: function (TAntecedentResult, TResult, tasks, continuationFunction, cancellationToken, continuationOptions, scheduler) {
                return null;
            },
            continueWhenAll: function (tasks, continuationAction) {
                return null;
            },
            continueWhenAll$1: function (tasks, continuationAction, cancellationToken) {
                return null;
            },
            continueWhenAll$3: function (tasks, continuationAction, continuationOptions) {
                return null;
            },
            continueWhenAll$2: function (tasks, continuationAction, cancellationToken, continuationOptions, scheduler) {
                return null;
            },
            continueWhenAll$4: function (TAntecedentResult, tasks, continuationAction) {
                return null;
            },
            continueWhenAll$5: function (TAntecedentResult, tasks, continuationAction, cancellationToken) {
                return null;
            },
            continueWhenAll$7: function (TAntecedentResult, tasks, continuationAction, continuationOptions) {
                return null;
            },
            continueWhenAll$6: function (TAntecedentResult, tasks, continuationAction, cancellationToken, continuationOptions, scheduler) {
                return null;
            },
            continueWhenAll$8: function (TResult, tasks, continuationFunction) {
                return null;
            },
            continueWhenAll$11: function (TResult, tasks, continuationFunction, continuationOptions) {
                return null;
            },
            continueWhenAll$9: function (TResult, tasks, continuationFunction, cancellationToken) {
                return null;
            },
            continueWhenAll$10: function (TResult, tasks, continuationFunction, cancellationToken, continuationOptions, scheduler) {
                return null;
            },
            continueWhenAll$12: function (TAntecedentResult, TResult, tasks, continuationFunction) {
                return null;
            },
            continueWhenAll$15: function (TAntecedentResult, TResult, tasks, continuationFunction, continuationOptions) {
                return null;
            },
            continueWhenAll$13: function (TAntecedentResult, TResult, tasks, continuationFunction, cancellationToken) {
                return null;
            },
            continueWhenAll$14: function (TAntecedentResult, TResult, tasks, continuationFunction, cancellationToken, continuationOptions, scheduler) {
                return null;
            },
            fromAsync$2: function (asyncResult, endMethod) {
                return null;
            },
            fromAsync$3: function (asyncResult, endMethod, creationOptions) {
                return null;
            },
            fromAsync$4: function (asyncResult, endMethod, creationOptions, scheduler) {
                return null;
            },
            fromAsync$13: function (TResult, asyncResult, endMethod) {
                return null;
            },
            fromAsync$14: function (TResult, asyncResult, endMethod, creationOptions) {
                return null;
            },
            fromAsync$15: function (TResult, asyncResult, endMethod, creationOptions, scheduler) {
                return null;
            },
            fromAsync: function (beginMethod, endMethod, state) {
                return null;
            },
            fromAsync$1: function (beginMethod, endMethod, state, creationOptions) {
                return null;
            },
            fromAsync$5: function (TArg1, beginMethod, endMethod, arg1, state) {
                return null;
            },
            fromAsync$6: function (TArg1, beginMethod, endMethod, arg1, state, creationOptions) {
                return null;
            },
            fromAsync$7: function (TArg1, TArg2, beginMethod, endMethod, arg1, arg2, state) {
                return null;
            },
            fromAsync$8: function (TArg1, TArg2, beginMethod, endMethod, arg1, arg2, state, creationOptions) {
                return null;
            },
            fromAsync$9: function (TArg1, TArg2, TArg3, beginMethod, endMethod, arg1, arg2, arg3, state) {
                return null;
            },
            fromAsync$10: function (TArg1, TArg2, TArg3, beginMethod, endMethod, arg1, arg2, arg3, state, creationOptions) {
                return null;
            },
            fromAsync$11: function (TResult, beginMethod, endMethod, state) {
                return null;
            },
            fromAsync$12: function (TResult, beginMethod, endMethod, state, creationOptions) {
                return null;
            },
            fromAsync$16: function (TArg1, TResult, beginMethod, endMethod, arg1, state) {
                return null;
            },
            fromAsync$17: function (TArg1, TResult, beginMethod, endMethod, arg1, state, creationOptions) {
                return null;
            },
            fromAsync$18: function (TArg1, TArg2, TResult, beginMethod, endMethod, arg1, arg2, state) {
                return null;
            },
            fromAsync$19: function (TArg1, TArg2, TResult, beginMethod, endMethod, arg1, arg2, state, creationOptions) {
                return null;
            },
            fromAsync$20: function (TArg1, TArg2, TArg3, TResult, beginMethod, endMethod, arg1, arg2, arg3, state) {
                return null;
            },
            fromAsync$21: function (TArg1, TArg2, TArg3, TResult, beginMethod, endMethod, arg1, arg2, arg3, state, creationOptions) {
                return null;
            },
            getScheduler: function () {
                return null;
            }
        }
    });
