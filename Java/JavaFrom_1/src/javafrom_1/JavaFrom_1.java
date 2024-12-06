package javafrom_1;
import java.awt.event.ActionListener;
import javafx.embed.swing.JFXPanel;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JTextField;

public class JavaFrom_1 extends JFrame {
    
    private static final int JFXPANEL_WIDTH_INT = 300;
    private static final int JFXPANEL_HEIGHT_INT = 250;
   
    public static void main(String[] args) {
      Screen j = new Screen();
      j.setSize(JFXPANEL_WIDTH_INT, JFXPANEL_HEIGHT_INT);
      j.setVisible(true);
      j.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    }
}

class Screen extends JFrame implements ActionListener{
    JLabel num_first_label = new JLabel("Number A:");
    JLabel num_second_label = new JLabel("Number B:");
    JTextField num_first_txt = new JTextField();
    JTextField num_second_txt = new JTextField();
    JButton btnSub = new JButton("Substraction");
    JButton btnAdd  = new JButton("Addition");
    JButton btnMul = new JButton("Multiplication");
    JButton btnDiv = new JButton("Division");
    JTextField result = new JTextField();
    
    public Screen(){
        this.setLayout(null);
        result.setBounds(50, 180, 100, 20);
        num_first_label.setBounds(5, 5, 80, 20);
        num_second_label.setBounds(5, 30, 80, 20);
        num_first_txt.setBounds(90, 5, 100, 20);
        num_second_txt.setBounds(90, 30, 100, 20);
        btnAdd.setBounds(50, 60, 120, 20);
        btnSub.setBounds(50, 90, 120, 20);
        btnMul.setBounds(50, 120, 120, 20);
        btnDiv.setBounds(50, 150, 120, 20);
        
        btnSub.addActionListener(this);
        btnAdd.addActionListener(this);
        btnMul.addActionListener(this);
        btnDiv.addActionListener(this);
        
        this.add(num_first_label);
        this.add(num_first_txt);
        this.add(num_second_label);
        this.add(num_second_txt);
        this.add(result);
        this.add(btnAdd);
        this.add(btnSub);
        this.add(btnMul);
        this.add(btnDiv);
    }

    @Override
    public void actionPerformed(java.awt.event.ActionEvent e) {
        double numFirst = Double.parseDouble(num_first_txt.getText());
        double numSecond = Double.parseDouble(num_second_txt.getText());
        if(e.getSource() == btnAdd){  
            result.setText(" " +(numFirst + numSecond));
            return;
        }
        
        if(e.getSource() == btnSub){
            result.setText(" " + (numFirst - numSecond));
            return;
        }
        
        if(e.getSource() == btnDiv){
            if(numSecond == 0){
                result.setText("Null");
                return;
            }
            result.setText("" + (numFirst / numSecond));
            return;
        }
        
        if(e.getSource() == btnMul){
            result.setText("" + (numFirst * numSecond));
            return;
        }
        
        
    }
}
