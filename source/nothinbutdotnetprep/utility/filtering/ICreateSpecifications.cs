using System;

namespace nothinbutdotnetprep.utility.filtering
{
    public interface ICreateSpecifications<ItemToMatch, PropertyType>
    {
        IMatchAn<ItemToMatch> equal_to(PropertyType value_to_equal);
        IMatchAn<ItemToMatch> equal_to_any(params PropertyType[] possible_values);
        IMatchAn<ItemToMatch> not_equal_to(PropertyType value);
        //IMatchAn<ItemToMatch> create_from(IMatchAn<PropertyType> real_matcher);
    }
}