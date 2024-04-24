public class ValidateNumbers {
    public static void main(String[] args)
    {
        String[] input = {"100", "10.2", "5.hello", "100hello"};

        for (String str : input)
        {
            try
            {
                int intValue = Integer.parseInt(str);
                System.out.println(str + " is a valid integer.");
            } 
            catch (NumberFormatException e1)
            {
                try
                {
                    double doubleValue = Double.parseDouble(str);
                    System.out.println(str + " is a valid double.");
                } 
                catch (NumberFormatException e2)
                {
                    System.out.println(str + " is not a valid number.");
                }
            }
        }
    }
}