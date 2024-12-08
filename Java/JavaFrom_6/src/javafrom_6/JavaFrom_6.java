/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/javafx/FXSwingMain.java to edit this template
 */
package javafrom_6;

import java.awt.BorderLayout;
import java.awt.Dimension;
import java.awt.event.ActionListener;
import javafx.application.Platform;
import javafx.embed.swing.JFXPanel;
import javafx.event.ActionEvent;
import javafx.event.EventHandler;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.layout.StackPane;
import javax.swing.JApplet;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JTextField;
import javax.swing.SwingUtilities;
import javax.swing.UIManager;

/**
 *
 * @author bảo
 */
public class JavaFrom_6 extends JFrame {
    
    private static final int JFXPANEL_WIDTH_INT = 300;
    private static final int JFXPANEL_HEIGHT_INT = 250;
    private static JFXPanel fxContainer;

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
       Screen s = new Screen();
       s.setSize(500, 500);
       s.setVisible(true);
       s.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    }
    
    
    
}

class Screen extends JFrame implements ActionListener {
    JLabel num1Lab = new JLabel("Num 1");
    JLabel num2Lab = new JLabel("Num 2");
    JTextField num1Txt = new JTextField();
    JTextField num2Txt = new JTextField();
    JTextField result = new JTextField();
    JButton btn = new JButton("CLICK");
    public Screen(){
        this.setLayout(null);
        num1Txt.setBounds(100, 30, 150, 20);
        num2Txt.setBounds(100, 60, 150, 20);
        num1Lab.setBounds(10, 30, 100, 20);
        num2Lab.setBounds(10, 60, 100, 20);
        btn.setBounds(250, 100, 100, 20);
        btn.addActionListener(this);
        result.setBounds(250, 130, 100, 20);
        this.add(btn);
        this.add(result);
        this.add(num1Lab);
        this.add(num2Lab);
        this.add(num1Txt);
        this.add(num2Txt);
    }
    @Override
    public void actionPerformed(java.awt.event.ActionEvent e) {
        double num1 = Double.parseDouble(num1Txt.getText());
        double num2  = Double.parseDouble(num2Txt.getText());
        
        if(e.getSource() == btn){
            result.setText(String.valueOf(num1 + num2));
        }
    }
    
}
