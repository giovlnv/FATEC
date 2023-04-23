/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.aula_3;
import javax.swing.JOptionPane;
import static javax.swing.JOptionPane.INFORMATION_MESSAGE;
import static javax.swing.JOptionPane.QUESTION_MESSAGE;

/**
 *
 * @author giova
 */
public class Aula_3 {

    public static void main(String[] args){
        
        int aux, a, b, i, par;
        String pares=" ", A, B;
        aux=a=b=i=par=0;
        
        try {
                
        A = JOptionPane.showInputDialog (null, "Insira o primeiro número", "INICIO", QUESTION_MESSAGE);
        B = JOptionPane.showInputDialog (null, "Insira o segundo número", "FINAL", QUESTION_MESSAGE);
        
        a=Integer.parseInt(A);
        b=Integer.parseInt(B);
                
        if (a>b)
        {aux = a;
        a = b;
        b = aux;
        throw new Exception("Ordem");
      }
        }

        catch (NumberFormatException e)
        {JOptionPane.showMessageDialog (null, "O conteúdo informado não é um número", "ERRO", INFORMATION_MESSAGE);
        }
        catch (Exception Ordem)
        {JOptionPane.showMessageDialog (null, "Lembre-se: Insira o menor e depois o maior", "ORDEM", INFORMATION_MESSAGE);
        }       
        
        finally {
      
        for
                (i=a; i<b; i++)
        {par = i%2;
            if
            (par==0){
            pares = pares+i+ ", ";}
            
        }

        System.out.printf("Os números pares entre "+a+" e " +b+ " sâo: " +pares);

    }}
}