// Experiment 2 Multithreading:- Creating child thread by implementing Runnable interface

class MyThread_Runnable implements Runnable
{
    Thread t;
    
    MyThread_Runnable()
    {
        t = new Thread(this, "Demo Child Thread");
        t.setPriority(Thread.NORM_PRIORITY - 2);
        System.out.println("Child Thread: " + t);
        t.start();
    }
    
    public void run()
    {
        try{
        for(int p=15;p>3;p-=3)
        {
            System.out.println("Child Thread running: " + p);
            Thread.sleep(75);
        }
        }
        catch(InterruptedException e)
        {
        }
        System.out.println("Child Thread exiting");
    }
}

class Runnable_Implementation
{
    public static void main(String[] args)
    {
        Thread current_Thread = Thread.currentThread();
        current_Thread.setName("Parent Thread");
        current_Thread.setPriority(Thread.MAX_PRIORITY - 2);
        
        MyThread_Runnable ob = new MyThread_Runnable(); 
    
        System.out.println("Current thread: " + Thread.currentThread());
            
        try{
            for(int n=10;n>0;n--)
            {
                System.out.println("Currently running iteration is: " + n);
                ob.t.join();
            }
        }
        catch(InterruptedException e)
        {
            System.out.println("Exception caught due to sleeping thread getting interrupted by another alive thread");
        }
    }
}