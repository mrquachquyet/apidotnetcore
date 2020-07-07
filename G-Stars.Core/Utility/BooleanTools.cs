
namespace VNCDCL.Core.Utility
{
    public static class BooleanTools
    {
        public static bool? ConvertToBoolean(string value)
        {
            bool isBoolean;
            if (!string.IsNullOrEmpty(value))
            {
                if (bool.TryParse(value, out isBoolean))
                    return bool.Parse(value);
            }
            return null;
        }
    }
}
