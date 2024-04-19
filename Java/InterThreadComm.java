class Q 
{
    int n;
    boolean valueset = false;
    
    synchronized int get()
    {
        if(!valueset)
        {
            try 
            {
                wait();
            } 
            catch(Exception e)
            {
                System.out.println("Exception");
            }
        }
        
        System.out.println("Got: " + n);
        valueset = false;
        notify();
        return n;
    }
    
    synchronized void put(int n)
    {
        if(valueset)
        {
            try
            {
                wait();
            }
            catch(InterruptedException e)
            {
                System.out.println("Exception");
            }
        }
        
        this.n = n;
        System.out.println("Put: " + n);
        valueset = true;
        notify();
    }
}

class Producer implements Runnable
{
    Q q;
    int limit;
    
    Producer(Q q, int l)
    {
        limit = l;
        this.q = q;
        new Thread(this, "Producer").start();
    }
    
    public void run()
    {
        int called = 1;
        int i=0;
        while(called<=limit)
        {
            q.put(i++);
            called++;
        }
    }
}

class Consumer implements Runnable
{
    Q q;
    int limit;
    
    Consumer(Q q, int l)
    {
        limit = l;
        this.q = q;
        new Thread(this, "Consumer").start();
    }
    
    public void run()
    {
        int called = 1;
        while(called<=limit)
        {
            q.get();
            called++;
        }
    }
}

class InterThreadComm
{
    public static void main(String[] args)
    {
        Q q = new Q();
        new Producer(q,5);
        new Consumer(q,5);   
        
        System.out.println("Program exited....");
    }
}
