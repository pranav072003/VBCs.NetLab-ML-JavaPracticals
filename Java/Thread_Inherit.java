// Experiment 3 Multithreading:- Creating child thread by inheriting Thread Class

class MyThread_Inherit extends Thread
{
    MyThread_Inherit()
    {
        super("Demo inherited child thread");
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
                System.out.println("Child thread executing: " + i);
                Thread.sleep(501);
            }
        }
        catch(InterruptedException e)
        {
            
        }
        finally
        {
            System.out.println("Exiting the child thread execution...");
        }
    }
}

class Thread_Inherit
{
    public static void main(String[] args)
    {
        Thread current_Thread = Thread.currentThread();
        current_Thread.setName("Parent Thread");
        current_Thread.setPriority(Thread.NORM_PRIORITY + 4);
        
        MyThread_Inherit ob = new MyThread_Inherit(); 
    
        System.out.println("Current thread: " + Thread.currentThread());
            
        try{
            for(int n=10;n>0;n--)
            {
                System.out.println("Currently running iteration is: " + n);
                ob.join();
            }
        }
        catch(InterruptedException e)
        {
            System.out.println("Exception caught due to sleeping thread getting interrupted by another alive thread");
        }
    }
}