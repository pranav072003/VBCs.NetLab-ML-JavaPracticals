class TableCalc{
    void printval(int table, int maxCount)
    {
        for (int i = 1; i <= maxCount; i++)
        {
            System.out.println(table + " x " + i + " = " + (table * i));
        }
    }
}


public class TablePrinter implements Runnable {
    private int table;
    private int maxCount;   
    private TableCalc call;

    public TablePrinter(int table, int maxCount, TableCalc c) {
        this.table = table;
        this.maxCount = maxCount;
        this.call = c;
    }

    public void run()
    {
        synchronized(call)
        {
            call.printval(table, maxCount);
        }
    }

    public static void main(String[] args) {
        Thread thread5 = new Thread(new TablePrinter(5, 10, new TableCalc()),"Thread of 5s table");
        Thread thread7 = new Thread(new TablePrinter(7, 10, new TableCalc()),"Thread of 7s table");

        thread5.start();
        thread7.start();
    }
}