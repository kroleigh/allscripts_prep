using System;

namespace nothinbutdotnetprep.utility.filtering
{
    public class Where<ItemToMatch>
    {
        //public static ComparableCriteriaFactory<ItemToMatch, PropertyType> has_an<PropertyType>(
        //    Func<ItemToMatch, PropertyType> property_accessor)
        //    where PropertyType : IComparable<PropertyType>

        //{
        //    return new ComparableCriteriaFactory<ItemToMatch, PropertyType>(has_a(property_accessor));
        //}

      public static ICreateSpecifications<ItemToMatch, PropertyType> has_a<PropertyType>(Func<ItemToMatch, PropertyType> property_accessor)
      {
        return new CriteriaFactory<ItemToMatch, PropertyType>(property_accessor);
      }

    }

  
}