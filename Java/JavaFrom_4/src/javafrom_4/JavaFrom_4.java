/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/javafx/FXSwingMain.java to edit this template
 */
package javafrom_4;

import java.awt.BorderLayout;
import java.awt.Dimension;
import javafx.application.Platform;
import javafx.embed.swing.JFXPanel;
import javafx.event.ActionEvent;
import javafx.event.EventHandler;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.layout.StackPane;
import javax.swing.JApplet;
import javax.swing.JFrame;
import javax.swing.SwingUtilities;
import javax.swing.UIManager;

/**
 *
 * @author bảo
 */
public class JavaFrom_4 extends JFrame {
    
    private static final int WIDTH = 300;
    private static final int HEIGHT = 250;

    public static void main(String[] args) {
        Screen s = new Screen();
        s.setVisible(true);
        s.setSize(500, 300);
        s.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    }
    
    
    
}
