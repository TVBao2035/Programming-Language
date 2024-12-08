/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package javafrom_3;


import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.ItemEvent;
import java.awt.event.ItemListener;
import javax.swing.*;
import javax.swing.event.ListSelectionEvent;
import javax.swing.event.ListSelectionListener;

/**
 *
 * @author bảo
 */
public class Screen extends JFrame implements ActionListener, ListSelectionListener{
    JList list;
    JLabel nameLabel = new JLabel("User name");
    JTextField nameTxt = new JTextField();
    JButton btnAdd = new JButton("Add"),
            btnUp = new JButton("Update"),
            btnDel = new JButton("Delete");
    String[] listName = {"Bao", "Hai"};
    JTabbedPane tabs = new JTabbedPane();
    JPanel p1 = new JPanel(), p2 = new JPanel();
    public Screen(){
        this.setLayout(null);
        nameLabel.setBounds(20, 20, 70, 20);
        nameTxt.setBounds(100, 20, 150, 20);
        p1.setLayout(null);
        tabs.setBounds(0,0, 500, 500);
        tabs.add("main", p1);
        tabs.add("Second", p2);
        list = new JList(listName);
        list.setBounds(0, 300, 500, 200 );
        list.addListSelectionListener(this);
        this.add(tabs);
        p1.add(list);
        p1.add(nameTxt);
        p1.add(nameLabel);
    }



    @Override
    public void actionPerformed(ActionEvent e) {
       
    }

    @Override
    public void valueChanged(ListSelectionEvent e) {
        String data= "" + list.getSelectedValue();
        nameTxt.setText(data);
    }


}
