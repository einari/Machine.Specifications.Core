using System;
using System.IO;
using System.Reflection;
using Machine.Specifications.Runner.Impl;

namespace Machine.Specifications.Runner.Core
{
    public class my_context
    {
        Establish context = () => {};
    }

    public class when_doing_stuff : my_context
    {
        static int[] some_integers = new[] {1,2,3};
        
        Establish context = () => {};

        Because of = () => { };

        It should_really_do_things = () => true.ShouldBeTrue();
        It should_also_do_other_things = () => true.ShouldBeFalse();
        
        It should_only_contain_the_expected_integers = () => some_integers.ShouldContainOnly(new[] {1,2,3});
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var currentDirectory = Directory.GetCurrentDirectory();
            var projectName = currentDirectory.Substring(currentDirectory.LastIndexOf(Path.DirectorySeparatorChar) + 1);

            Console.WriteLine($"Running specs for '{projectName}'");

            var assemblyName = new AssemblyName(projectName);

            try
            {
                var assembly = Assembly.Load(assemblyName);
                Console.WriteLine($"  Loaded Assembly : {assembly.FullName}");

                AssemblyRunner.Run(assembly);
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error - {ex.Message}");
            }
        }


        #region Things I'm thinking about - Braindump

        //Directory.SetCurrentDirectory("/Users/einari/Projects/Machine.Specifications.Core/Source/Runner/bin/debug/dnxcore50/osx.10.11-x64/");
        //Directory.SetCurrentDirectory("/Users/einari/Projects/Machine.Specifications.Core/Source/Runner/");
        //var assemblyName = new AssemblyName("Machine.Specifications.Should.Core");

        //AssemblyLoadContext.Default.LoadFromAssemblyName(assemblyName);

        //Console.WriteLine($"App Dir : {AppContext.BaseDirectory}");
        //Microsoft.Extensions.DependencyModel.DependencyContext;

        //System.Runtime.Loader.AssemblyLoadContext c;
        //Console.WriteLine("Main");
        //var libraryManager = CallContextServiceLocator.Locator.ServiceProvider.GetService(typeof(ILibraryManager)) as LibraryManager;

        /*
        var assembly = Assembly.GetEntryAssembly();


        var path = Directory.GetCurrentDirectory();
        var watcher = new FileSystemWatcher(path, "*.cs");
        watcher.IncludeSubdirectories = true;
        watcher.EnableRaisingEvents = true;
        watcher.Changed += (s, e) => Console.WriteLine($"Changed : {e.FullPath}");
        watcher.Deleted += (s, e) => Console.WriteLine($"Deleted : {e.FullPath}");
        watcher.Created += (s, e) => Console.WriteLine($"Created : {e.FullPath}");
        watcher.Renamed += (s, e) => Console.WriteLine($"Renamed : {e.OldFullPath} -> {e.FullPath}");

        Console.ReadKey();
        */

        #endregion
    }
}