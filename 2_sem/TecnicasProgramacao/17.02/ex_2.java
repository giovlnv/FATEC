/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

/* 2º) Ler três números e mostrá-los em ordem crescente. */


package com.mycompany.aula_2;
import javax.swing.JOptionPane;
import static javax.swing.JOptionPane.INFORMATION_MESSAGE;
import static javax.swing.JOptionPane.QUESTION_MESSAGE;

/**
 *
 * @author giova
 */
public class ex_2 {

    /**
     *
     * @param args
     */
    public static void main(String[] args){
        
        int aux, a, b, c;
        
        String A = JOptionPane.showInputDialog (null, "Insira o primeiro número", "ORGANIZAÇÃO", QUESTION_MESSAGE);
        String B = JOptionPane.showInputDialog (null, "Insira o segundo número", "ORGANIZAÇÃO", QUESTION_MESSAGE);
        String C = JOptionPane.showInputDialog (null, "Insira o terceiro número", "ORGANIZAÇÃO", QUESTION_MESSAGE);
        
        a=Integer.parseInt(A);
        b=Integer.parseInt(B);
        c=Integer.parseInt(C);
        
        
        if (a>b) 
        {
        aux = a;
        a = b;
        b = aux;}
        if (b>c)
        {
        aux = b;
        b = c;
        c = aux; 
        if (a>b) 
        {
        aux = a;
        a = b;
        b = aux;   
        }
        }
        
            
        JOptionPane.showMessageDialog(null, "Os números informados, em ordem crescente, são: "+a+" "+b+" " +c,null, INFORMATION_MESSAGE);

                }
}