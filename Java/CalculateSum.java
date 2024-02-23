class CalculateSum
{
    public static void main(String args[])
    {
    int len = args.length;
    // System.out.println(Integer.toString(len));
    int result = 0;
    for(int i=0;i<(len-2);i++)
    {
        result = result + Integer.parseInt(args[i]);
    }
    System.out.println("The result of the addition of provided integer values is " + Integer.toString(result));
    System.out.println("The result of the concatenation of the two strings inputted by the user is shown below:-");
    System.out.println(args[len-2]+" "+args[len-1]);
    }
}
