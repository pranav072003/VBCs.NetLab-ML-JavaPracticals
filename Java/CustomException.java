class MyException extends Exception {
    public MyException(String message) {
        super(message);
    }
}

class AgeValidator {
    public static void validateAge(int age) throws MyException {
        if (age < 18) {
            throw new MyException("Age should be 18 or above.");
        } else {
            System.out.println("Age is valid.");
        }
    }
}

public class CustomException {
    public static void main(String[] args) {
        int age = 15;

        try {
            AgeValidator.validateAge(age);
        } catch (MyException e) {
            System.out.println("Exception caught: " + e.getMessage());
        }
    }
}