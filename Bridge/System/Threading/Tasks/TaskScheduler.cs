using Bridge;
using System.Collections.Generic;

namespace System.Threading.Tasks
{
    public abstract class TaskScheduler
	{
		sealed class TaskSchedulerDebuggerView
		{
			public TaskSchedulerDebuggerView (TaskScheduler scheduler)
			{
			}

			public IEnumerable<Task> ScheduledTasks {
				get {
                    throw new NotImplementedException();
                }
			}
		}
        
		protected TaskScheduler ()
		{
		}
		
		public static TaskScheduler FromCurrentSynchronizationContext ()
		{
            throw new NotImplementedException();
        }
		
		public static TaskScheduler Default  {
			get {
                throw new NotImplementedException();
            }
		}
		
		public static TaskScheduler Current  {
			get {
                throw new NotImplementedException();
            }
			internal set {
                throw new NotImplementedException();
            }
		}
		
		public int Id {
			get {
                throw new NotImplementedException();
            }
		}
		
		public virtual int MaximumConcurrencyLevel {
			get {
                throw new NotImplementedException();
            }
		}

		protected abstract IEnumerable<Task> GetScheduledTasks ();
		protected internal abstract void QueueTask (Task task);

		protected internal virtual bool TryDequeue (Task task)
		{
            throw new NotImplementedException();
        }

		internal protected bool TryExecuteTask (Task task)
		{
            throw new NotImplementedException();
        }

		protected abstract bool TryExecuteTaskInline (Task task, bool taskWasPreviouslyQueued);

		internal bool RunInline (Task task, bool taskWasPreviouslyQueued)
		{
            throw new NotImplementedException();
        }

		internal static UnobservedTaskExceptionEventArgs FireUnobservedEvent (Task task, AggregateException e)
		{
            throw new NotImplementedException();
        }
	}
}