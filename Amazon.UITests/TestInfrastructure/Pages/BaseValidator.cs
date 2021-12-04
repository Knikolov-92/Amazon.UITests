using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.UITests.TestInfrastructure.Pages
{
    public class BaseValidator<TElementMap> where TElementMap : BaseElements, new()
    {
        protected TElementMap Elements => new TElementMap();
    }
}
