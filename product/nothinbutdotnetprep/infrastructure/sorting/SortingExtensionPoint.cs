using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nothinbutdotnetprep.infrastructure.filtering;

namespace nothinbutdotnetprep.infrastructure.sorting {
    public interface SortingExtensionPoint<ItemToSort, PropertyType>
    {
        Criteria<ItemToSort> create_criteria_using(Criteria<PropertyType> real_criteria);
    }
}
