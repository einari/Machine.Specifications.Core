using System;

namespace Machine.Specifications.Model
{
    public enum SpecificationResult
    {
        Failed,
        Passed,
        NotImplemented,
    }

    public class SpecificationVerificationResult
    {
        readonly SpecificationResult _result;

        public bool Passed
        {
            get { return _result == SpecificationResult.Passed; }
        }

        public Exception Exception { get; private set; }

        public SpecificationResult Result
        {
            get { return _result; }
        }

        public SpecificationVerificationResult(Exception exception)
        {
            _result = SpecificationResult.Failed;
            this.Exception = exception;
        }

        public SpecificationVerificationResult()
        {
            _result = SpecificationResult.Passed;
        }

        public SpecificationVerificationResult(SpecificationResult result)
        {
            this._result = result;
        }
    }
}