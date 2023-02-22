namespace HashTest;

public static class ExtensionMethods
{
    public static string GenerateQueryStringForSignature(this object obj) {
        var properties = from p in obj.GetType().GetProperties().ToList()
            where p.GetValue(obj, null) != null && !string.Equals(p.Name, "Api_Key", StringComparison.OrdinalIgnoreCase)
                                                && !string.Equals(p.Name, "Signature", StringComparison.OrdinalIgnoreCase) 
                                                && !string.Equals(p.Name, "Product_Description", StringComparison.OrdinalIgnoreCase)
            select p.Name.ToUpperInvariant() + "=" + p.GetValue(obj, null);

        var list = properties.ToList();
        list.Sort();
        return string.Join("&", list.ToArray()) + "&";
    }
}