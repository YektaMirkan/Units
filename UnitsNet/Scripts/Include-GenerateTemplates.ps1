<#
.SYNOPSIS
Returns the Obsolete attribute if ObsoleteText has been defined on the JSON input - otherwise returns empty string
It is up to the consumer to wrap any padding/new lines in order to keep to correct indentation formats
#>
function GetObsoleteAttribute($quantity)
{
    if ($quantity.ObsoleteText)
    {
        return  "[System.Obsolete(""$($quantity.ObsoleteText)"")]";
    }
    return "";
}