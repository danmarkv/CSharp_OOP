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
        private readonly List<IActivity> _activities;

        public WorkFlowEngine()
        {
            _activities = new List<IActivity>();
        }

        public void CurrentActivity(IActivity activity)
        {
            _activities.Add(activity);
        }
        public void Run()
        {
            foreach (var act in _activities)
                act.Execute();
        }
    }
}
