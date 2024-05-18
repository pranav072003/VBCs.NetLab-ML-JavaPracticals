import java.io.*;

public class FileIOHandle {
  public static void main(String[] args) {
    try {

       // reading from a file
       File file_r = new File("demo-file.txt");
       FileInputStream sr = new FileInputStream(file_r);
       System.out.println("File contents after being read are:-");
       int i;
       do {
       i = sr.read();
       System.out.print((char) i);
       } while (i != -1);
       System.out.println();
       sr.close();

      // writing to a file
      File file_w = new File("demo-file.txt");
      FileOutputStream sw = new FileOutputStream(file_w, true);
      System.out.println("Writing text to the file...");
      String s = "\nThis is the text written over the file";
      byte buf[] = s.getBytes();
      sw.write(buf);
      System.out.println("Text written successfully on the file");
      sw.close();
    } catch (FileNotFoundException e) {
      System.out.println("File not found");
    } catch (IOException e) {
      System.out.println("IO error! " + e.getMessage());
    } catch (Exception e) {
      System.out.println("Error! " + e.getMessage());
    }
    
    /*
    demo-file.txt initial contents
    Hi there! This is a demo file.
    */
  }
}