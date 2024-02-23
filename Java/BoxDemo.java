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
    
    b1.length = 5.16489D;
    b1.width = 1.46875D;
    b1.height = 5.12365D;
    
    b2.length = 8.164523D;
    b2.width = 4.6423D;
    b2.height = 4.2316D;
    
    double volume1 = b1.length*b1.width*b1.height;
    double volume2 = b2.length*b2.width*b2.height;
    System.out.println("Volume of box 1 is " + Double.toString(volume1) + " volume of box 2 is " + Double.toString(volume2));   
    }
}
