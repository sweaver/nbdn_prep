using System;

namespace nothinbutdotnetprep.infrastructure.sorting
{
    public class Sort<ItemToSort>
    {
        public static DefaultSortingExtensionPoint<ItemToSort, PropertyType> on<PropertyType>(Func<ItemToSort, PropertyType> property_accessor)
        {
            return new DefaultSortingExtensionPoint<ItemToSort, PropertyType>(property_accessor);
        }
    }
}