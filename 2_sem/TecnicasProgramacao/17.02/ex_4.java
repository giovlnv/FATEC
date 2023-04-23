/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

/* 4º) Ler a idade de uma pessoa e informar a sua classe eleitoral:
*     Não-eleitor (abaixo de 16 anos)
*     Eleitor obrigatório (entre 18 e 65 anos)
*     Eleitor facultativo (entre 16 e 18 anos e maior de 65 anos)
*/

package com.mycompany.aula_2;
import javax.swing.JOptionPane;
import static javax.swing.JOptionPane.INFORMATION_MESSAGE;
import static javax.swing.JOptionPane.QUESTION_MESSAGE;

/**
 *
 * @author giova
 */
public class ex_4 {
    
    /**
     *
     * @param args
     */
    public static void main(String[] args){    
    
    String status;
    
        String A = JOptionPane.showInputDialog (null, "Insira a idade", "IDADE", QUESTION_MESSAGE);
        
        int id = Integer.parseInt(A);
        
        
        if (id<=15) 
        {status = "Não eleitor";
        }
        else if (id>=18 && id<=65)
        {status = "Eleitor obrigatório";
        }
        else {
        status = "Eleitor facultativo";
        }
                  
        JOptionPane.showMessageDialog(null, "A pessoa informada é "+status,null, INFORMATION_MESSAGE);

                }
}