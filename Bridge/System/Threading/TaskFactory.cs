namespace System.Threading.Tasks
{
    public class TaskFactory
    {
        public TaskFactory()
            : this(CancellationToken.None, TaskCreationOptions.None, TaskContinuationOptions.None, null)
        {
        }

        public TaskFactory(CancellationToken cancellationToken)
            : this(cancellationToken, TaskCreationOptions.None, TaskContinuationOptions.None, null)
        {
        }

        public TaskFactory(TaskScheduler scheduler)
            : this(CancellationToken.None, TaskCreationOptions.None, TaskContinuationOptions.None, scheduler)
        {
        }

        public TaskFactory(TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions)
            : this(CancellationToken.None, creationOptions, continuationOptions, null)
        {
        }

        public TaskFactory(CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions,
                            TaskScheduler scheduler)
        {
        }

        public TaskScheduler Scheduler
        {
            get
            {
                return default(TaskScheduler);
            }
        }

        public TaskContinuationOptions ContinuationOptions
        {
            get
            {
                return default(TaskContinuationOptions);
            }
        }

        public TaskCreationOptions CreationOptions
        {
            get
            {
                return default(TaskCreationOptions);
            }
        }

        public CancellationToken CancellationToken
        {
            get
            {
                return default(CancellationToken);
            }
        }

        internal static void CheckContinuationOptions(TaskContinuationOptions continuationOptions)
        {
        }

        public Task StartNew(Action action)
        {
            return default(Task);
        }

        public Task StartNew(Action action, CancellationToken cancellationToken)
        {
            return default(Task);
        }

        public Task StartNew(Action action, TaskCreationOptions creationOptions)
        {
            return default(Task);
        }

        public Task StartNew(Action action, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
        {
            return default(Task);
        }

        public Task StartNew(Action<object> action, object state)
        {
            return default(Task);
        }

        public Task StartNew(Action<object> action, object state, CancellationToken cancellationToken)
        {
            return default(Task);
        }

        public Task StartNew(Action<object> action, object state, TaskCreationOptions creationOptions)
        {
            return default(Task);
        }

        public Task StartNew(Action<object> action, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions,
                              TaskScheduler scheduler)
        {
            return default(Task);
        }
        
        public Task<TResult> StartNew<TResult>(Func<TResult> function)
        {
            return default(Task<TResult>);
        }

        public Task<TResult> StartNew<TResult>(Func<TResult> function, TaskCreationOptions creationOptions)
        {
            return default(Task<TResult>);
        }

        public Task<TResult> StartNew<TResult>(Func<TResult> function, CancellationToken cancellationToken)
        {
            return default(Task<TResult>);
        }

        public Task<TResult> StartNew<TResult>(Func<TResult> function,
                                                CancellationToken cancellationToken,
                                                TaskCreationOptions creationOptions,
                                                TaskScheduler scheduler)
        {
            return default(Task<TResult>);
        }

        public Task<TResult> StartNew<TResult>(Func<object, TResult> function, object state)
        {
            return default(Task<TResult>);
        }

        public Task<TResult> StartNew<TResult>(Func<object, TResult> function, object state, CancellationToken cancellationToken)
        {
            return default(Task<TResult>);
        }

        public Task<TResult> StartNew<TResult>(Func<object, TResult> function, object state, TaskCreationOptions creationOptions)
        {
            return default(Task<TResult>);
        }

        public Task<TResult> StartNew<TResult>(Func<object, TResult> function, object state,
                                                CancellationToken cancellationToken,
                                                TaskCreationOptions creationOptions,
                                                TaskScheduler scheduler)
        {
            return default(Task<TResult>);
        }
        
        public Task ContinueWhenAny(Task[] tasks, Action<Task> continuationAction)
        {
            return default(Task);
        }

        public Task ContinueWhenAny(Task[] tasks, Action<Task> continuationAction, CancellationToken cancellationToken)
        {
            return default(Task);
        }

        public Task ContinueWhenAny(Task[] tasks, Action<Task> continuationAction, TaskContinuationOptions continuationOptions)
        {
            return default(Task);
        }

        public Task ContinueWhenAny(Task[] tasks, Action<Task> continuationAction, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
        {
            return default(Task);
        }

        public Task ContinueWhenAny<TAntecedentResult>(Task<TAntecedentResult>[] tasks,
                                                        Action<Task<TAntecedentResult>> continuationAction)
        {
            return default(Task);
        }

        public Task ContinueWhenAny<TAntecedentResult>(Task<TAntecedentResult>[] tasks,
                                                        Action<Task<TAntecedentResult>> continuationAction,
                                                        CancellationToken cancellationToken)
        {
            return default(Task);
        }

        public Task ContinueWhenAny<TAntecedentResult>(Task<TAntecedentResult>[] tasks,
                                                        Action<Task<TAntecedentResult>> continuationAction,
                                                        TaskContinuationOptions continuationOptions)
        {
            return default(Task);
        }

        public Task ContinueWhenAny<TAntecedentResult>(Task<TAntecedentResult>[] tasks,
                                                        Action<Task<TAntecedentResult>> continuationAction,
                                                        CancellationToken cancellationToken,
                                                        TaskContinuationOptions continuationOptions,
                                                        TaskScheduler scheduler)
        {
            return default(Task);
        }

        public Task<TResult> ContinueWhenAny<TResult>(Task[] tasks, Func<Task, TResult> continuationFunction)
        {
            return default(Task<TResult>);
        }

        public Task<TResult> ContinueWhenAny<TResult>(Task[] tasks,
                                                       Func<Task, TResult> continuationFunction,
                                                       CancellationToken cancellationToken)
        {
            return default(Task<TResult>);
        }

        public Task<TResult> ContinueWhenAny<TResult>(Task[] tasks,
                                                       Func<Task, TResult> continuationFunction,
                                                       TaskContinuationOptions continuationOptions)
        {
            return default(Task<TResult>);
        }

        public Task<TResult> ContinueWhenAny<TResult>(Task[] tasks,
                                                       Func<Task, TResult> continuationFunction,
                                                       CancellationToken cancellationToken,
                                                       TaskContinuationOptions continuationOptions,
                                                       TaskScheduler scheduler)
        {
            return default(Task<TResult>);
        }

        public Task<TResult> ContinueWhenAny<TAntecedentResult, TResult>(Task<TAntecedentResult>[] tasks,
                                                                          Func<Task<TAntecedentResult>, TResult> continuationFunction)
        {
            return default(Task<TResult>);
        }

        public Task<TResult> ContinueWhenAny<TAntecedentResult, TResult>(Task<TAntecedentResult>[] tasks,
                                                                          Func<Task<TAntecedentResult>, TResult> continuationFunction,
                                                                          CancellationToken cancellationToken)
        {
            return default(Task<TResult>);
        }

        public Task<TResult> ContinueWhenAny<TAntecedentResult, TResult>(Task<TAntecedentResult>[] tasks,
                                                                          Func<Task<TAntecedentResult>, TResult> continuationFunction,
                                                                          TaskContinuationOptions continuationOptions)
        {
            return default(Task<TResult>);
        }

        public Task<TResult> ContinueWhenAny<TAntecedentResult, TResult>(Task<TAntecedentResult>[] tasks,
                                                                          Func<Task<TAntecedentResult>, TResult> continuationFunction,
                                                                          CancellationToken cancellationToken,
                                                                          TaskContinuationOptions continuationOptions,
                                                                          TaskScheduler scheduler)
        {
            return default(Task<TResult>);
        }

        public Task ContinueWhenAll(Task[] tasks, Action<Task[]> continuationAction)
        {
            return default(Task);
        }

        public Task ContinueWhenAll(Task[] tasks, Action<Task[]> continuationAction, CancellationToken cancellationToken)
        {
            return default(Task);
        }

        public Task ContinueWhenAll(Task[] tasks, Action<Task[]> continuationAction,
                                     TaskContinuationOptions continuationOptions)
        {
            return default(Task);
        }

        public Task ContinueWhenAll(Task[] tasks, Action<Task[]> continuationAction, CancellationToken cancellationToken,
                                     TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
        {
            return default(Task);
        }

        public Task ContinueWhenAll<TAntecedentResult>(Task<TAntecedentResult>[] tasks,
                                                        Action<Task<TAntecedentResult>[]> continuationAction)
        {
            return default(Task);
        }

        public Task ContinueWhenAll<TAntecedentResult>(Task<TAntecedentResult>[] tasks,
                                                        Action<Task<TAntecedentResult>[]> continuationAction, CancellationToken cancellationToken)
        {
            return default(Task);
        }

        public Task ContinueWhenAll<TAntecedentResult>(Task<TAntecedentResult>[] tasks, Action<Task<TAntecedentResult>[]> continuationAction,
                                                        TaskContinuationOptions continuationOptions)
        {
            return default(Task);
        }

        public Task ContinueWhenAll<TAntecedentResult>(Task<TAntecedentResult>[] tasks,
                                                        Action<Task<TAntecedentResult>[]> continuationAction,
                                                        CancellationToken cancellationToken, TaskContinuationOptions continuationOptions,
                                                        TaskScheduler scheduler)
        {
            return default(Task);
        }

        public Task<TResult> ContinueWhenAll<TResult>(Task[] tasks, Func<Task[], TResult> continuationFunction)
        {
            return default(Task<TResult>);
        }

        public Task<TResult> ContinueWhenAll<TResult>(Task[] tasks, Func<Task[], TResult> continuationFunction,
                                                       TaskContinuationOptions continuationOptions)
        {
            return default(Task<TResult>);
        }

        public Task<TResult> ContinueWhenAll<TResult>(Task[] tasks, Func<Task[], TResult> continuationFunction,
                                                       CancellationToken cancellationToken)
        {
            return default(Task<TResult>);
        }

        public Task<TResult> ContinueWhenAll<TResult>(Task[] tasks, Func<Task[], TResult> continuationFunction,
                                                       CancellationToken cancellationToken,
                                                       TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
        {
            return default(Task<TResult>);
        }

        public Task<TResult> ContinueWhenAll<TAntecedentResult, TResult>(Task<TAntecedentResult>[] tasks,
                                                                          Func<Task<TAntecedentResult>[], TResult> continuationFunction)
        {
            return default(Task<TResult>);
        }

        public Task<TResult> ContinueWhenAll<TAntecedentResult, TResult>(Task<TAntecedentResult>[] tasks,
                                                                          Func<Task<TAntecedentResult>[], TResult> continuationFunction,
                                                                          TaskContinuationOptions continuationOptions)
        {
            return default(Task<TResult>);
        }

        public Task<TResult> ContinueWhenAll<TAntecedentResult, TResult>(Task<TAntecedentResult>[] tasks,
                                                                          Func<Task<TAntecedentResult>[], TResult> continuationFunction,
                                                                          CancellationToken cancellationToken)
        {
            return default(Task<TResult>);
        }

        public Task<TResult> ContinueWhenAll<TAntecedentResult, TResult>(Task<TAntecedentResult>[] tasks,
                                                                          Func<Task<TAntecedentResult>[], TResult> continuationFunction,
                                                                          CancellationToken cancellationToken,
                                                                          TaskContinuationOptions continuationOptions,
                                                                          TaskScheduler scheduler)
        {
            return default(Task<TResult>);
        }
        
        public Task FromAsync(IAsyncResult asyncResult, Action<IAsyncResult> endMethod)
        {
            return default(Task);
        }

        public Task FromAsync(IAsyncResult asyncResult, Action<IAsyncResult> endMethod, TaskCreationOptions creationOptions)
        {
            return default(Task);
        }

        public Task FromAsync(IAsyncResult asyncResult, Action<IAsyncResult> endMethod, TaskCreationOptions creationOptions, TaskScheduler scheduler)
        {
            return default(Task);
        }

        public Task<TResult> FromAsync<TResult>(IAsyncResult asyncResult, Func<IAsyncResult, TResult> endMethod)
        {
            return default(Task<TResult>);
        }

        public Task<TResult> FromAsync<TResult>(IAsyncResult asyncResult, Func<IAsyncResult, TResult> endMethod, TaskCreationOptions creationOptions)
        {
            return default(Task<TResult>);
        }

        public Task<TResult> FromAsync<TResult>(IAsyncResult asyncResult, Func<IAsyncResult, TResult> endMethod, TaskCreationOptions creationOptions, TaskScheduler scheduler)
        {
            return default(Task<TResult>);
        }
        
        public Task FromAsync(Func<AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, object state)
        {
            return default(Task);
        }

        public Task FromAsync(Func<AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod,
                               object state, TaskCreationOptions creationOptions)
        {
            return default(Task);
        }

        public Task FromAsync<TArg1>(Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod,
                                      TArg1 arg1, object state)
        {
            return default(Task);
        }

        public Task FromAsync<TArg1>(Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod,
                                      TArg1 arg1, object state, TaskCreationOptions creationOptions)
        {
            return default(Task);
        }

        public Task FromAsync<TArg1, TArg2>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod,
                                             Action<IAsyncResult> endMethod,
                                             TArg1 arg1, TArg2 arg2, object state)
        {
            return default(Task);
        }

        public Task FromAsync<TArg1, TArg2>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod,
                                             Action<IAsyncResult> endMethod,
                                             TArg1 arg1, TArg2 arg2, object state, TaskCreationOptions creationOptions)
        {
            return default(Task);
        }

        public Task FromAsync<TArg1, TArg2, TArg3>(Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod,
                                                    TArg1 arg1, TArg2 arg2, TArg3 arg3, object state)
        {
            return default(Task);
        }

        public Task FromAsync<TArg1, TArg2, TArg3>(Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod,
                                                    TArg1 arg1, TArg2 arg2, TArg3 arg3, object state, TaskCreationOptions creationOptions)
        {
            return default(Task);
        }

        public Task<TResult> FromAsync<TResult>(Func<AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod,
                                                 object state)
        {
            return default(Task<TResult>);
        }

        public Task<TResult> FromAsync<TResult>(Func<AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod,
                                                 object state, TaskCreationOptions creationOptions)
        {
            return default(Task<TResult>);
        }

        public Task<TResult> FromAsync<TArg1, TResult>(Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod,
                                                        TArg1 arg1, object state)
        {
            return default(Task<TResult>);
        }

        public Task<TResult> FromAsync<TArg1, TResult>(Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod,
                                                        TArg1 arg1, object state, TaskCreationOptions creationOptions)
        {
            return default(Task<TResult>);
        }

        public Task<TResult> FromAsync<TArg1, TArg2, TResult>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod,
                                                               Func<IAsyncResult, TResult> endMethod,
                                                               TArg1 arg1, TArg2 arg2, object state)
        {
            return default(Task<TResult>);
        }

        public Task<TResult> FromAsync<TArg1, TArg2, TResult>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod,
                                                               TArg1 arg1, TArg2 arg2, object state, TaskCreationOptions creationOptions)
        {
            return default(Task<TResult>);
        }

        public Task<TResult> FromAsync<TArg1, TArg2, TArg3, TResult>(Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod,
                                                                      TArg1 arg1, TArg2 arg2, TArg3 arg3, object state)
        {
            return default(Task<TResult>);
        }

        public Task<TResult> FromAsync<TArg1, TArg2, TArg3, TResult>(Func<TArg1, TArg2, TArg3, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod,
                                                                      TArg1 arg1, TArg2 arg2, TArg3 arg3, object state, TaskCreationOptions creationOptions)
        {
            return default(Task<TResult>);
        }
        
        TaskScheduler GetScheduler()
        {
            return default(TaskScheduler);
        }

        static void CheckContinueArguments(Task[] tasks, object continuationAction, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
        {
        }
    }
}