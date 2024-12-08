/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package javafrom_4;

import java.awt.*;
import java.awt.event.*;
import javax.swing.*;

/**
 *
 * @author bảo
 */
public class Screen extends JFrame implements ActionListener, MouseListener, MouseMotionListener {

    JButton btn = new JButton("CLICK ME");
    JTabbedPane tabs = new JTabbedPane();
    JPanel drawX = new JPanel(), drawWords = new JPanel();
    int Count = 0;
    Point firstPoint, secondPoint;
    public Screen(){
        btn.setBounds(100, 100, 300, 250);
     
        drawX.setLayout(null);
        drawWords.setLayout(null);
        drawX.add(btn);
        
        this.addMouseListener(this);
        this.setLayout(null);
     
    }
    @Override
    public void actionPerformed(ActionEvent e) {
       
     }

    @Override
    public void mouseClicked(MouseEvent e) {
            }

    @Override
    public void mousePressed(MouseEvent e) {
        Count++;
        if(Count % 2 != 0) firstPoint = new Point(e.getX(), e.getY());
        else{
            secondPoint = new Point(e.getX(), e.getY());
            Graphics g = getGraphics();
            secondPoint.Display();
            g.drawLine((int)firstPoint.getX(), (int)firstPoint.getY(), (int)secondPoint.getX(), (int)secondPoint.getY());
        }
    }

    @Override
    public void mouseReleased(MouseEvent e) {
           }

    @Override
    public void mouseEntered(MouseEvent e) {
           }

    @Override
    public void mouseExited(MouseEvent e) {
          }

    @Override
    public void mouseDragged(MouseEvent e) {
            }

    @Override
    public void mouseMoved(MouseEvent e) {
     }

}
