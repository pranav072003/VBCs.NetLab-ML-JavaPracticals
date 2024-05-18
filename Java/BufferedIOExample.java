import java.io.*;

public class BufferedIOExample {
    public static void main(String[] args) {
        try {
            /*
            input.txt file content
            This is input file!
            */
            
            // Create a FileReader and wrap it with a BufferedReader
            FileReader fileReader = new FileReader("input.txt");
            BufferedReader bufferedReader = new BufferedReader(fileReader);

            // Create a FileWriter and wrap it with a BufferedWriter
            FileWriter fileWriter = new FileWriter("output.txt");
            BufferedWriter bufferedWriter = new BufferedWriter(fileWriter);

            String line;
            while ((line = bufferedReader.readLine()) != null) {
                // Write the line to the output file
                bufferedWriter.write(line);
                bufferedWriter.newLine();
            }

            // Close the streams
            bufferedReader.close();
            bufferedWriter.close();

            System.out.println("File copied successfully.");
        } catch (IOException e) {
            System.out.println(e.getMessage());
        }
    }
}