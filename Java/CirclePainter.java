import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

public class CirclePainter extends JFrame {
    private int mouseX, mouseY;

    public CirclePainter() {
        setTitle("Circle Painter");
        setSize(400, 400);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setLocationRelativeTo(null);
        setResizable(false);

        addMouseMotionListener(new MouseAdapter() {
            @Override
            public void mouseMoved(MouseEvent e) {
                mouseX = e.getX();
                mouseY = e.getY();
                repaint();
            }
        });
    }

    @Override
    public void paint(Graphics g) {
        super.paint(g);
        g.setColor(Color.RED);
        g.fillOval(mouseX - 10, mouseY - 10, 20, 20);
    }

    public static void main(String[] args) {
        SwingUtilities.invokeLater(() -> {
            CirclePainter circlePainter = new CirclePainter();
            circlePainter.setVisible(true);
        });
    }
}