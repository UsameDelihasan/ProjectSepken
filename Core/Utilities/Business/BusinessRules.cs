using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {

        public IResult Run(params IResult[] results)
        {
            foreach (var item in results)
            {
                if (!item.Success )
                {
                    return item;
                }
            }

            return null;    
        }
    }
}
