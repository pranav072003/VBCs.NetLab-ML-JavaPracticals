import bank.Account;

public class BankManager {
    public static void main(String[] args) {
        Account account = new Account("1234567890", 1000.0);
        account.displayBalance();

        account.deposit(500.0);
        account.withdraw(200.0);
        account.displayBalance();
    }
}