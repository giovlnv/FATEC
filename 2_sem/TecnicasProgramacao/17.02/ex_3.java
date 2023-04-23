/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

/* 3º) Um comerciante comprou um produto e quer vendê-lo com um lucro de 45% se o 
*    valor da compra for menor que R$20,00; caso contrário, o lucro será de 30%. Entrar 
*    com o valor do produto e imprimir o valor da venda.
 */

package com.mycompany.aula_2;

import javax.swing.JOptionPane;
import static javax.swing.JOptionPane.INFORMATION_MESSAGE;
import static javax.swing.JOptionPane.QUESTION_MESSAGE;

/**
 *
 * @author giova
 */
public class ex_3 {
    
    /**
     *
     * @param args
     */
    public static void main(String[] args){    
    
    double luc;
    
        String A = JOptionPane.showInputDialog (null, "Insira o valor do produto", "LUCRO", QUESTION_MESSAGE);
        
        float a = Float.parseFloat(A);
        
        
        if (a<=20) 
        {luc = 1.45;
        }
        else
        {luc = 1.30;
        }
        
        a=(float) (a*luc);

            
        JOptionPane.showMessageDialog(null, "O produto deve ser vendido por R$"+a, null, INFORMATION_MESSAGE);

                }
}