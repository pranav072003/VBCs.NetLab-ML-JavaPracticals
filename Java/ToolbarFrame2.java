import java.awt.*;
import java.awt.event.*;
import javax.swing.*;

class ToolbarFrame2 extends Frame implements ActionListener {
  // This time, let's use JButtons!
  JButton cutButton, copyButton, pasteButton;
  JButton winButton, javaButton, motifButton;

  public ToolbarFrame2() {
    super("Toolbar Example (Swing)");
    setSize(450, 250);
    addWindowListener(new BasicWindowMonitor());

    // JPanel works similarly to Panel, so we'll use it
    JPanel toolbar = new JPanel();
    toolbar.setLayout(new FlowLayout(FlowLayout.LEFT));
    cutButton = new JButton("Cut");
    cutButton.addActionListener(this);
    toolbar.add(cutButton);
    copyButton = new JButton("Copy");
    copyButton.addActionListener(this);
    toolbar.add(copyButton);
    pasteButton = new JButton("Paste");
    pasteButton.addActionListener(this);
    toolbar.add(pasteButton);
    add(toolbar, BorderLayout.NORTH); // the new BorderLayout add
    // Add the look-and-feel controls
    JPanel lnfPanel = new JPanel();
    LnFListener lnfListener = new LnFListener(this);
    javaButton = new JButton("Metal");
    javaButton.addActionListener(lnfListener);
    lnfPanel.add(javaButton);
    motifButton = new JButton("Motif");
    motifButton.addActionListener(lnfListener);
    lnfPanel.add(motifButton);
    winButton = new JButton("Windows");
    winButton.addActionListener(lnfListener);
    lnfPanel.add(winButton);
    add(lnfPanel, BorderLayout.SOUTH);
  }

  public void actionPerformed(ActionEvent ae) {
    System.out.println(ae.getActionCommand());
  }

  public static void main(String args[]) {
    ToolbarFrame2 tf2 = new ToolbarFrame2();
    tf2.setVisible(true);
  }
}

class LnFListener implements ActionListener {
  Frame frame;

  public LnFListener(Frame f) {
    frame = f;
  }

  public void actionPerformed(ActionEvent e) {
    String lnfName = null;
    if (e.getActionCommand().equals("Metal")) {
      lnfName = "javax.swing.plaf.metal.MetalLookAndFeel";
    } else if (e.getActionCommand().equals("Motif")) {
      lnfName = "com.sun.java.swing.plaf.motif.MotifLookAndFeel";
    } else {
      lnfName = "com.sun.java.swing.plaf.windows.WindowsLookAndFeel";
    }
    try {
      UIManager.setLookAndFeel(lnfName);
      SwingUtilities.updateComponentTreeUI(frame);
    } catch (UnsupportedLookAndFeelException ex1) {
      System.err.println("Unsupported LookAndFeel: " + lnfName);
    } catch (ClassNotFoundException ex2) {
      System.err.println("LookAndFeel class not found: " + lnfName);
    } catch (InstantiationException ex3) {
      System.err.println("Could not load LookAndFeel: " + lnfName);
    } catch (IllegalAccessException ex4) {
      System.err.println("Cannot use LookAndFeel: " + lnfName);
    }
  }
}

class BasicWindowMonitor extends WindowAdapter {
  public void windowClosing(WindowEvent e) {
    Window w = e.getWindow();
    w.setVisible(false);
    w.dispose();
    System.exit(0);
  }
}