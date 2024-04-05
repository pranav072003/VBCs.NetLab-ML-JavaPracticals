// Experiment 4 Multithreading:- Creating multiple child threads by inheriting Thread Class

class MyThread_Inherit extends Thread
{
    String threadname;
    
    MyThread_Inherit(String name)
    {
        super("Demo inherited child thread");
        threadname = name;
        System.out.println("Child thread: " + this);
        this.setName("Child Thread Inherited");
        this.setPriority(5);
        start();
    }
    
    public void run()
    {
        // override the run() method of the Thread Class
        try
        {
            for(int i=5;i>0;i--)
            {
                System.out.println("Child thread " + threadname + " executing: " + i);
                Thread.sleep(501);
            }
        }
        catch(InterruptedException e)
        {
            
        }
        finally
        {
            System.out.println("Exiting the child thread " + threadname + " execution...");
        }
    }
}

class Multiple_Child_Threads
{
    public static void main(String[] args)
    {
        Thread current_Thread = Thread.currentThread();
        current_Thread.setName("Parent Thread");
        current_Thread.setPriority(Thread.NORM_PRIORITY + 4);
        
        MyThread_Inherit ob_one = new MyThread_Inherit("one"); 
        MyThread_Inherit ob_two = new MyThread_Inherit("two");
        MyThread_Inherit ob_three = new MyThread_Inherit("three");
    
        System.out.println("Current thread: " + Thread.currentThread());
        
        System.out.println("Thread one is alive: " + ob_one.isAlive());
        System.out.println("Thread two is alive: " + ob_two.isAlive());
        System.out.println("Thread three is alive: " + ob_three.isAlive());
            
        try{
            for(int n=10;n>0;n--)
            {
                System.out.println("Currently running iteration is: " + n);
                ob_one.join();
                ob_two.join();
                ob_three.join();
            }
            // ob_one.start(); // gives IllegalThreadStateException runtime error as a thread cannot be restarted once terminated
        }
        catch(InterruptedException e)
        {
            System.out.println("Exception caught due to sleeping thread getting interrupted by another alive thread");
        }
        finally{
            System.out.println("Exiting the main thread....");
            // confirming that the threads have terminated or not
            System.out.println("Thread one is alive: " + ob_one.isAlive());
            System.out.println("Thread two is alive: " + ob_two.isAlive());
            System.out.println("Thread three is alive: " + ob_three.isAlive());
        }
    }
}