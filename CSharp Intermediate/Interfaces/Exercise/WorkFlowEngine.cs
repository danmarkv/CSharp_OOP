using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate.Interfaces.Exercise
{
    public interface IActivity
    {
        void Execute();
    }
    
    public interface IWorkflow
    {
        void Add(IActivity activity);
        void Remove(IActivity activity);
        IEnumerable<IActivity> GetActivity();
    }

    public class Workflow : IWorkflow
    {
        private readonly List<IActivity> _activities;

        public Workflow()
        {
            _activities = new List<IActivity>();
        }

        public void Add(IActivity activity)
        {
            _activities.Add(activity);
        }

        public void Remove(IActivity activity)
        {
            _activities.Remove(activity);
        }

        public IEnumerable<IActivity> GetActivity()
        {
            return _activities;
        }
    }

    public class UploadToCloudStorage : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Uploading video to cloud...");
        }
    }

    public class WebServiceVideoEnconder : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Encoder is ready.");
        }
    }

    public class NotifyOwner : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Notify owner that video has started processing...");
        }
    }
    public class WorkFlowEngine
    {
        
        public void Run(IWorkflow workflow)
        {
            foreach (var activity in workflow.GetActivity())
                activity.Execute();
        }
    }
}
