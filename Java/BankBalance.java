// BankAccount class
class BankAccount {
    public String accountNumber;
    public String accountHolder;
    public double balance;

    public BankAccount(String accountNumber, String accountHolder, double balance) {
        this.accountNumber = accountNumber;
        this.accountHolder = accountHolder;
        this.balance = balance;
    }

    public void deposit(double amount) {
        balance += amount;
        System.out.println("Deposit successful. New balance: " + balance);
    }

    public void withdraw(double amount) {
        if (balance >= amount) {
            balance -= amount;
            System.out.println("Withdrawal successful. New balance: " + balance);
        } else {
            System.out.println("Insufficient funds!");
        }
    }

    public void displayAccountInfo() {
        System.out.println("Account Number: " + accountNumber);
        System.out.println("Account Holder: " + accountHolder);
        System.out.println("Balance: " + balance);
    }
}

// CurrentAccount class
class CurrentAccount extends BankAccount {
    private double overdraftLimit;

    public CurrentAccount(String accountNumber, String accountHolder, double balance, double overdraftLimit) {
        super(accountNumber, accountHolder, balance);
        this.overdraftLimit = overdraftLimit;
    }

    @Override
    public void withdraw(double amount) {
        if (balance + overdraftLimit >= amount) {
            balance -= amount;
            System.out.println("Withdrawal successful. New balance: " + balance);
        } else {
            System.out.println("Insufficient funds!");
        }
    }
}

// SavingsAccount class
class SavingsAccount extends BankAccount {
    private double interestRate;

    public SavingsAccount(String accountNumber, String accountHolder, double balance, double interestRate) {
        super(accountNumber, accountHolder, balance);
        this.interestRate = interestRate;
    }

    public void applyInterest() {
        double interest = balance * interestRate / 100;
        balance += interest;
        System.out.println("Interest applied. New balance: " + balance);
    }
}

// Main class
public class BankBalance {
    public static void main(String[] args) {
        BankAccount account1 = new BankAccount("123456789", "John Doe", 1000);
        account1.deposit(500);
        account1.withdraw(200);
        account1.displayAccountInfo();

        CurrentAccount account2 = new CurrentAccount("987654321", "Jane Smith", 2000, 1000);
        account2.withdraw(3000);
        account2.withdraw(2500);
        account2.displayAccountInfo();

        SavingsAccount account3 = new SavingsAccount("567890123", "Alice Johnson", 5000, 2.5);
        account3.applyInterest();
        account3.displayAccountInfo();
    }
}