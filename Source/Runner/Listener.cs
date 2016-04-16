using System;

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
            Console.WriteLine("\n");
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
            if (!result.Passed) Console.WriteLine("    FAILED");
            foreach( var supplement in result.Supplements ) 
            {
                Console.WriteLine($"    Supplement : {supplement.Key} - {supplement.Value}");
            }
        }

        public void OnSpecificationStart(SpecificationInfo specification)
        {
            Console.WriteLine("  It " + specification.Name);
        }
    }
}