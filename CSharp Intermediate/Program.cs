﻿using System;
using System.IO;
using System.Collections;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Amazon;
using CSharpIntermediate.Associate_Between_Classes;
using CSharpIntermediate.Associate_Between_Classes.Composition;
using CSharpIntermediate.Classes;
using CSharpIntermediate.Classes_Exercises;
using CSharpIntermediate.Inheritance;
using CSharpIntermediate.Interfaces;
using CSharpIntermediate.Polymorphism;
using CSharpIntermediate.Polymorphism.Exercises;
using CSharpIntermediate.Interfaces.Exercise;


namespace CSharpIntermediate
{
    
    class Program
    {

        static void Main()
        {
            var workflow = new Workflow();
            workflow.Add(new UploadToCloudStorage());
            workflow.Add(new NotifyOwner());

            var workflowEngine = new WorkFlowEngine();
            workflowEngine.Run(workflow);

        }
    }
}
