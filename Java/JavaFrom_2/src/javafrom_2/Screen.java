/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package javafrom_2;

import com.sun.jdi.connect.ListeningConnector;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.ItemEvent;
import java.awt.event.ItemListener;
import javax.swing.ButtonGroup;
import javax.swing.JButton;
import javax.swing.JComboBox;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JMenu;
import javax.swing.JMenuBar;
import javax.swing.JMenuItem;
import javax.swing.JRadioButton;
import javax.swing.JTextField;

/**
 *
 * @author bảo
 */
public class Screen extends JFrame implements ActionListener, ItemListener {
    JLabel firstLabel = new JLabel("Enter Number First");
    JLabel secondLabel = new JLabel("Eneter Number Second");
    JTextField firstTxt = new JTextField(), secondTxt = new JTextField();
    JButton calBtn = new JButton("Calculator");
    JLabel resultLabel = new JLabel("Result");
    JTextField resultTxt = new JTextField();
    JComboBox operCB = new JComboBox();
    ButtonGroup btnGroup = new ButtonGroup();
    JRadioButton rAdd = new JRadioButton("Addition"), rSub = new JRadioButton("Substraction"), rMul = new JRadioButton("Multplication"), rDiv = new JRadioButton("Division");
    JMenuBar menuBar = new JMenuBar();
    JMenu firstMenu = new JMenu("Addition Group"), secondMenu = new JMenu("Multplication");
    JMenuItem addMenuI = new JMenuItem("Add"), subMenuI = new JMenuItem("Sub");

    public Screen(){
        this.setLayout(null);
        
        rAdd.setBounds(190, 140, 100, 20);
        rSub.setBounds(190,170, 100, 20 );
        rMul.setBounds(190, 200, 100, 20);
        rDiv.setBounds(190, 230, 100, 20);
        btnGroup.add(rSub);
        btnGroup.add(rMul);
        btnGroup.add(rDiv);
        btnGroup.add(rAdd);
        menuBar.add(firstMenu);
        menuBar.add(secondMenu);
        firstMenu.add(addMenuI);
        firstMenu.add(subMenuI);
        addMenuI.addActionListener(this);
        subMenuI.addActionListener(this);
        
        this.setJMenuBar(menuBar);
        String[] operators = {"Addition", "Substraction", "Multplication", "Division"};
        for(int i=0; i<operators.length; i++)
        operCB.addItem(operators[i]);
 
        operCB.setBounds(10, 140, 100, 20);
        firstLabel.setBounds(10, 20, 140, 20);
        firstTxt.setBounds(170, 20, 140, 20);
        secondLabel.setBounds(10, 50, 140, 20);
        secondTxt.setBounds(170, 50, 140, 20);
        calBtn.setBounds(10, 80, 100 ,20);
        resultLabel.setBounds(10, 110, 140, 20);
        resultTxt.setBounds(50, 110, 140, 20);
        
        calBtn.addActionListener(this);
        rAdd.addActionListener(this);
        rSub.addActionListener(this);
        rMul.addActionListener(this);
        rDiv.addActionListener(this);
        operCB.addActionListener(this);
        this.add(rSub);
        this.add(rMul);
        this.add(rDiv);
        this.add(rAdd);
        this.add(operCB);
        this.add(resultTxt);
        this.add(resultLabel);
        this.add(calBtn);
        this.add(firstLabel);
        this.add(secondLabel);
        this.add(firstTxt);
        this.add(secondTxt);
    }

    @Override
    public void actionPerformed(ActionEvent e) {
        double firstNum = 0, secondNum=0;
        
         try {
            firstNum = Double.parseDouble(firstTxt.getText());
        } catch(Exception ex) {
            firstTxt.setText("");
            firstTxt.setFocusable(true);
            firstTxt.requestFocus();
        }
          try {
            secondNum = Double.parseDouble(secondTxt.getText());
        } catch(Exception ex) {
            secondTxt.setText("");
            secondTxt.setFocusable(true);
            secondTxt.requestFocus();
        }
        if(e.getSource() == operCB){
            int choose = operCB.getSelectedIndex();
            if(choose == 0) resultTxt.setText("" + (firstNum + secondNum));
            if(choose == 1) resultTxt.setText("" + (firstNum - secondNum));
            if(choose == 2) resultTxt.setText("" + (firstNum * secondNum));
            
            if(choose == 3 && secondNum != 0) resultTxt.setText("" + (firstNum / secondNum));
        }
        
        if(e.getSource() == calBtn){
            if(rAdd.isSelected()){
               resultTxt.setText("" + (firstNum + secondNum));
            }

             if(rSub.isSelected()){
                resultTxt.setText("" + (firstNum - secondNum));
            }

             if(rMul.isSelected()){
                resultTxt.setText("" + (firstNum * secondNum));
            }
             if(rDiv.isSelected() && secondNum != 0){
                resultTxt.setText("" + (firstNum / secondNum));
            }
        }
        
        if(e.getSource() == addMenuI) resultTxt.setText(String.valueOf((firstNum + secondNum)));
        
        if(e.getSource() == subMenuI) resultTxt.setText(String.valueOf((firstNum - secondNum)));
       
    }

    @Override
    public void itemStateChanged(ItemEvent e) {
     
        
     
    }
        
}
