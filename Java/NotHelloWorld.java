import java.awt.*;
import javax.swing.*;
import javax.swing.border.Border;

public class NotHelloWorld {
  public static void main(String[] args) {
    EventQueue.invokeLater(() -> {
      var frame = new NotHelloWorldFrame();
      frame.setTitle("Not Hello World");
      frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
      frame.setVisible(true);
    });
  }
}

class NotHelloWorldFrame extends JFrame {
  public NotHelloWorldFrame() {
    add(new NotHWComponent());
    pack();
  }
}

class NotHWComponent extends JComponent {
  final int MESSAGE_X = 75;
  final int MESSAGE_Y = 100;
  final int DEFAULT_WIDTH = 400;
  final int DEFAULT_HEIGHT = 400;

  public void paintComponent(Graphics g) {
    g.drawString("Hello World!", MESSAGE_X, MESSAGE_Y);
  }

  public Dimension getPreferredSize() {
    return new Dimension(DEFAULT_WIDTH, DEFAULT_HEIGHT);
  }
}
