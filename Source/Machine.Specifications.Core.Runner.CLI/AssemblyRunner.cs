using System;
using System.IO;
using System.Reflection;
using Machine.Specifications.Runner.Impl;

namespace Machine.Specifications.Runner.Core
{
    public class AssemblyRunner
    {
        public static void Run(Assembly assembly)
        {
            var listener = new Listener();
            var options = RunOptions.Default;
            var specificationRunner = new DefaultRunner(listener, options);

            specificationRunner.RunAssembly(assembly);
        }
            
    }
}
