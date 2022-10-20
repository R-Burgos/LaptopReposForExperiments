namespace CodeWars_Worksheet
{
    internal class Program
    {

        public static string GetDrinkByProfession(string p)
        {
            switch (p)
            {
                case "jabroni":
                    string d1 = "Patron Tequila";
                    return d1;
                case "school counselor":
                    string d2 = "Anything with Alcohol";
                    return d2;
                case "programmer":
                    string d3 = "Hipster Craft Beer";
                    return d3;
                case "bike gang member":
                    string d4 = "Moonshine";
                    return d4;
                case "politician":
                    string d5 = "Your tax dollars";
                    return d5;
                case "rapper":
                    string d6 = "Cristal";
                    return d6;
                default:
                    string d7 = "Beer";
                    return d7;

            }
            
        }


        static void Main(string[] args)
        {
            string profession = Console.ReadLine().ToLower();
            Console.WriteLine (GetDrinkByProfession(profession));
            
        }      
    }
}