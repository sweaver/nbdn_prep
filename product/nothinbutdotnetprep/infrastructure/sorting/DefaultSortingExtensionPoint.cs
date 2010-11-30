using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nothinbutdotnetprep.infrastructure.filtering;

namespace nothinbutdotnetprep.infrastructure.sorting {
    public class DefaultSortingExtensionPoint<ItemToSort, PropertyType> : SortingExtensionPoint<ItemToSort, PropertyType>
    {
        private Func<ItemToSort, PropertyType> accessor;

        public DefaultSortingExtensionPoint(Func<ItemToSort, PropertyType> accessor)
        {
            this.accessor = accessor;
        }


        public Criteria<ItemToSort> create_criteria_using(Criteria<PropertyType> real_criteria)
        {
            return new PropertyCriteria<ItemToSort, PropertyType>(accessor, real_criteria);
        }
    }
}
