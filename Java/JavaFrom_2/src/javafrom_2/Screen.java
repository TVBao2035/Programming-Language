/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package javafrom_2;

import com.sun.jdi.connect.ListeningConnector;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.ButtonGroup;
import javax.swing.JButton;
import javax.swing.JComboBox;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JRadioButton;
import javax.swing.JTextField;

/**
 *
 * @author bảo
 */
public class Screen extends JFrame implements ActionListener {
    JLabel firstLabel = new JLabel("Enter Number First");
    JLabel secondLabel = new JLabel("Eneter Number Second");
    JTextField firstTxt = new JTextField(), secondTxt = new JTextField();
    JButton calBtn = new JButton("Calculator");
    JLabel resultLabel = new JLabel("Result");
    JTextField resultTxt = new JTextField();
    JComboBox operCB = new JComboBox();
    ButtonGroup btnGroup = new ButtonGroup();
    JRadioButton rAdd = new JRadioButton("Addition"), rSub = new JRadioButton("Substraction"), rMul = new JRadioButton("Multplication"), rDiv = new JRadioButton("Division");
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
        double firstNum = Double.parseDouble(firstTxt.getText());
        double secondNum = Double.parseDouble(secondTxt.getText());
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
       
    }
        
}
