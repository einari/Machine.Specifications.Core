using System;


namespace Machine.Specifications
{
  public class SpecificationUsageException : Exception
  {
    //
    // For guidelines regarding the creation of new exception types, see
    //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/cpgenref/html/cpconerrorraisinghandlingguidelines.asp
    // and
    //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/dncscol/html/csharp07192001.asp
    //

    public SpecificationUsageException()
    {
    }

    public SpecificationUsageException(string message) : base(message)
    {
    }

    public SpecificationUsageException(string message, Exception inner) : base(message, inner)
    {
    }

  }

  public class SpecificationException : Exception
  {
      //
      // For guidelines regarding the creation of new exception types, see
      //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/cpgenref/html/cpconerrorraisinghandlingguidelines.asp
      // and
      //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/dncscol/html/csharp07192001.asp
      //

      public SpecificationException()
      {
      }

      public SpecificationException(string message)
          : base(message)
      {
      }

      public SpecificationException(string message, Exception inner)
          : base(message, inner)
      {
      }
  }
}