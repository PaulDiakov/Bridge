using Bridge;

namespace System.Threading.Tasks
{
    sealed class SynchronizationContextScheduler : TaskScheduler
    {
        public SynchronizationContextScheduler(SynchronizationContext ctx)
        {
        }

        protected internal override void QueueTask(Task task)
        {
        }

        void TaskLaunchWrapper(object obj)
        {
        }

        protected override Collections.Generic.IEnumerable<Task> GetScheduledTasks()
        {
            throw new NotImplementedException();
        }

        protected internal override bool TryDequeue(Task task)
        {
            throw new NotImplementedException();
        }

        protected override bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued)
        {
            throw new NotImplementedException();
        }

        public override int MaximumConcurrencyLevel
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}