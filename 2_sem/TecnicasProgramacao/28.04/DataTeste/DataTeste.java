/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.datateste;

import javax.swing.JOptionPane;

/**
 *
 * @author labs
 */
public class DataTeste {

    public static void main(String[] args) {
        int d, m, a;
        
        d=Integer.parseInt(JOptionPane.showInputDialog(null, "Informe o Dia: ", "Dia", JOptionPane.PLAIN_MESSAGE));
        
        m=Integer.parseInt(JOptionPane.showInputDialog(null, "Informe o Mês: ", "Mês", JOptionPane.PLAIN_MESSAGE));
        
        a=Integer.parseInt(JOptionPane.showInputDialog(null, "Informe o Ano: ", "Ano", JOptionPane.PLAIN_MESSAGE));
        
        data dat = new data();
        
        dat.Data(d, m, a);
        
        JOptionPane.showMessageDialog(null,dat.displayData(),"Data",JOptionPane.PLAIN_MESSAGE);
    }
}
