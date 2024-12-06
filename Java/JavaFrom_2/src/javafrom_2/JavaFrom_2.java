/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/javafx/FXSwingMain.java to edit this template
 */
package javafrom_2;

import javax.swing.JFrame;


/**
 *
 * @author bảo
 */
public class JavaFrom_2 extends JFrame {
    
    private static final int JFXPANEL_WIDTH_INT = 400;
    private static final int JFXPANEL_HEIGHT_INT = 500;

    public static void main(String[] args) {
        Screen s = new Screen();
        s.setVisible(true);
        s.setSize(JFXPANEL_WIDTH_INT, JFXPANEL_HEIGHT_INT);
        s.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    }
}
