namespace String_to_Integer__atoi_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s = MyAtoi("123  456");
            Console.WriteLine(s);
        }

        public static int MyAtoi(string s)
        {


            string result = "";

            if (s.Length >= 0 && s.Length <= 200)
            {

               s= s.TrimStart(' ');

                if (string.IsNullOrWhiteSpace(s))
                    return 0;   
                
                if (char.IsLetter(s[0]) || s[0]=='.')
                    return 0;

                for (int i= 0; i< s.Length;i++)
                {

                    if (char.IsWhiteSpace(s[i]))
                    {

                        if (char.IsLetter(s[++i]) || char.IsWhiteSpace(s[i]))
                            break;
                        

                       return 0;
                    }

                    if (char.IsLetter(s[i]) || s[i] == '.')
                            break;

                    int j =  i ;

                    if (result.Count() >= 1 && (s[i] == '-' || s[i] == '+') )
                    {
                        if ((result[--j] == '-' || result[j] == '+'))
                            return 0;

                        break;
                    }


                    result += s[i];

                    if (result.Contains("-") && result.IndexOf("-", 0) != 0)
                        return 0;

                }
            }

            try
            {
              
                    return (result == "+" || result == "-") ? 0 :  int.Parse(result);
                
            }
            catch (OverflowException e)
            {
            var overflow=  double.Parse(result);

                return overflow >= int.MaxValue ? int.MaxValue : overflow <= int.MinValue ? int.MinValue : -1;

            }



        }
    }
}