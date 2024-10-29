namespace NUnitDemonstration
{
    public static class Triangle
    {
        public static string ValidTriangle(int firstAngle, int secondAngle, int thirdAngle)
        {
            
            // Check if the sum of the angles is equal to 180
            if ((firstAngle + secondAngle + thirdAngle) == 180)
            {
                return "The triangle is valid.";
            }
            else
            {
                return "The triangle is not valid.";
            }
        }
    }
}
