import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
import java.util.Random;

public class SquareResizer extends JFrame {
    private int squareSize = 100;
    private Color squareColor = Color.RED;

    public SquareResizer() {
        setTitle("Square Resizer");
        setSize(400, 400);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setLocationRelativeTo(null);
        setResizable(false);

        addKeyListener(new KeyAdapter() {
            @Override
            public void keyPressed(KeyEvent e) {
                if (e.getKeyCode() == KeyEvent.VK_UP) {
                    squareSize += 10;
                } else if (e.getKeyCode() == KeyEvent.VK_DOWN) {
                    squareSize -= 10;
                    if (squareSize < 0) {
                        squareSize = 0;
                    }
                } else if (e.getKeyCode() == KeyEvent.VK_SPACE) {
                    Random random = new Random();
                    squareColor = new Color(random.nextInt(256), random.nextInt(256), random.nextInt(256));
                }
                repaint();
            }
        });
    }

    @Override
    public void paint(Graphics g) {
        super.paint(g);
        g.setColor(squareColor);
        int x = (getWidth() - squareSize) / 2;
        int y = (getHeight() - squareSize) / 2;
        g.fillRect(x, y, squareSize, squareSize);
    }

    public static void main(String[] args) {
        SwingUtilities.invokeLater(() -> {
            SquareResizer squareResizer = new SquareResizer();
            squareResizer.setVisible(true);
            squareResizer.requestFocus();
        });
    }
}