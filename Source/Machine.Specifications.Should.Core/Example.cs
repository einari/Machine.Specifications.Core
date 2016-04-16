using System;

namespace Machine.Specifications.Should
{
    public class my_context
    {
        Establish context = () => Console.WriteLine("Context");

    }

    public class when_doing_stuff : my_context
    {
        Establish context = () => Console.WriteLine("More specific context");

        Because of = () => { };

        It should_really_do_things = () => true.ShouldBeTrue();
        It should_also_do_other_things = () => true.ShouldBeFalse();

    }    
}