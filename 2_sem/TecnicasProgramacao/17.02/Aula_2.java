/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

/* 1º) Ler um valor e informar se ele é ou não múltiplo de 3. */


package com.mycompany.aula_2;
import javax.swing.JOptionPane;
import static javax.swing.JOptionPane.INFORMATION_MESSAGE;
import static javax.swing.JOptionPane.QUESTION_MESSAGE;
import static javax.swing.JOptionPane.WARNING_MESSAGE;

/**
 *
 * @author giova
 */
public class Aula_2 {

    /**
     *
     */
    public static final int div = 3;
    public static void main(String[] args){
        
        float resto;
        
        String valor = JOptionPane.showInputDialog (null, "Insira um número", "CALCULO", QUESTION_MESSAGE);
        
        resto=Integer.parseInt(valor)%div;
        
        if (resto == 0)
        {JOptionPane.showMessageDialog(null, "O valor informado é um múltiplo de 3",null, INFORMATION_MESSAGE);
        }
        else
        {JOptionPane.showMessageDialog(null, "O valor informado não é um múltiplo de 3",null, WARNING_MESSAGE);

        }
    }
}