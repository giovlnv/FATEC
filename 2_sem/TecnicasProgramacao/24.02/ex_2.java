/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.aula_3;
import javax.swing.JOptionPane;
import static javax.swing.JOptionPane.INFORMATION_MESSAGE;
import static javax.swing.JOptionPane.QUESTION_MESSAGE;

/**
 *
 * @author giova
 */
public class ex_2 {

    public static void main(String[] args){
        
        int a=0, atual=1, ant=0, temp,i;
        String termos="1", A;
                
        try {
                
        A = JOptionPane.showInputDialog (null, "Insira o limite de termos", "FIBONACCI", QUESTION_MESSAGE);
        
        a=Integer.parseInt(A);
        
        for
                (i=0; i<a-1;i++)
        {termos=termos+", "+(ant+atual);
        temp=ant;
        ant=atual;
        atual=atual+temp;
        }
         }

        catch (NumberFormatException e)
        {JOptionPane.showMessageDialog (null, "O conteúdo informado não é um número", "ERRO", INFORMATION_MESSAGE);
        }
        

        System.out.printf("A sequencia fibonacci até o "+a+" termo é "+termos );

    }}