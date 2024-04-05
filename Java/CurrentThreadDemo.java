// Experiment 1 Multithreading:- Demonstration of currentThread() method in Thread class

class CurrentThreadDemo
{
    public static void main(String[] args)
    {
        Thread t = Thread.currentThread();
    
        System.out.println("Current thread: " + t);
    
        // set name of current thread
        t.setName("My Thread");
        
        System.out.println("New thread: " + t);
            
        try{
            for(int n=10;n>0;n--)
            {
                System.out.println("Currently running iteration is: " + n);
                Thread.sleep(500);
            }
        }
        catch(InterruptedException e)
        {
            System.out.println("Exception caught due to sleeping thread getting interrupted by another alive thread");
        }
    }
}