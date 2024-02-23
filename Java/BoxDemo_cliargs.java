class Box 
{
    double length;
    double width;
    double height;
}

class BoxDemo
{
    public static void main(String args[])
    {
    Box b1 = new Box();
    Box b2 = new Box();
    int len = args.length;
    // System.out.println(Integer.toString(len));
    
    b1.length = Double.parseDouble(args[0]);
    b1.width = Double.parseDouble(args[1]);
    b1.height = Double.parseDouble(args[2]);
    
    b2.length = Double.parseDouble(args[3]);
    b2.width = Double.parseDouble(args[4]);
    b2.height = Double.parseDouble(args[5]);
    
    double volume1 = b1.length*b1.width*b1.height;
    double volume2 = b2.length*b2.width*b2.height;
    System.out.println("Volume of box 1 is " + Double.toString(volume1) + " volume of box 2 is " + Double.toString(volume2));   
    }
}
