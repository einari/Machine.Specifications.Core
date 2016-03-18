using System;
using System.Reflection;
using Machine.Specifications.Runner.Impl;

namespace Machine.Specifications.Runner.Core
{
    public class Listener : ISpecificationRunListener
    {
        public void OnAssemblyEnd(AssemblyInfo assembly)
        {
            //Console.WriteLine("Assembly End");
        }

        public void OnAssemblyStart(AssemblyInfo assembly)
        {
            //Console.WriteLine("Assembly Start");
        }

        public void OnContextEnd(ContextInfo context)
        {
        }

        public void OnContextStart(ContextInfo context)
        {
            Console.WriteLine($"{context.Name}");
            
        }

        public void OnFatalError(ExceptionResult exception)
        {
            Console.WriteLine("FATAL");
        }

        public void OnRunEnd()
        {
           // Console.WriteLine("Run End");
        }

        public void OnRunStart()
        {
            //Console.WriteLine("Run Start");
        }

        public void OnSpecificationEnd(SpecificationInfo specification, Result result)
        {
            //Console.WriteLine("Spec End");
            if( !result.Passed ) Console.WriteLine("    FAILED");
        }

        public void OnSpecificationStart(SpecificationInfo specification)
        {
            Console.WriteLine("  It "+specification.Name);
        }
    }


    public class when_doing_stuff
    {
        Establish context = () => {};
        
        
        Because of = () => {};
        
        It should_really_do_things = () => true.ShouldBeTrue();
        It should_also_do_other_things = () => true.ShouldBeFalse();
        
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var listener = new Listener();
            var options = RunOptions.Default;
            var specificationRunner = new DefaultRunner(listener, options);
            
            var assembly = Assembly.GetEntryAssembly();
            specificationRunner.RunAssembly(assembly);
           
        }
    }
}