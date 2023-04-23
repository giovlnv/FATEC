/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

/* 5º) Depois da liberação do governo para as mensalidades dos planos de saúde, as 
*    pessoas começaram a fazer pesquisas para descobrir um bom plano, não muito caro. 
*    Um vendedor de um plano de saúde apresentou a tabela a seguir. Criar um programa 
*    que entre com o nome e a idade de uma pessoa e mostre o valor que ela deverá pagar.
*        Até 10 anos – R$ 30,00
*        Acima de 10 até 29 anos – R$ 60,00
*        Acima de 29 até 45 anos – R$ 120,00
*        Acima de 45 até 59 anos – R$ 150,00
*        Acima de 59 até 65 anos – R$ 250,00
*        Maior que 65 anos – R$ 400,0 */

package com.mycompany.aula_2;
import javax.swing.JOptionPane;
import static javax.swing.JOptionPane.INFORMATION_MESSAGE;
import static javax.swing.JOptionPane.QUESTION_MESSAGE;

/**
 *
 * @author giova
 */
public class ex_5 {
    
    /**
     *
     * @param args
     */
    public static void main(String[] args){    
    
        int valor;

        String A = JOptionPane.showInputDialog (null, "Insira o nome da pessoa", "SAÚDE", QUESTION_MESSAGE);
        String B = JOptionPane.showInputDialog (null, "Insira a idade da pessoa", "SAÚDE", QUESTION_MESSAGE);
        
        int id = Integer.parseInt(B);
        
        
        if (id<=10) {
            valor = 30;
        }
        else if (11<=id && id<=29) {
            valor = 60;
        } 
        else if (30<=id && id<=45) {
            valor = 120;
        }
        else if (46<=id && id<=59) {
            valor = 150;
        }    
        else if (60<=id && id<=65){
            valor = 250;
        }
        else {
            valor = 400;
        }
                  
        JOptionPane.showMessageDialog(null, A+" deverá pagar R$"+valor+" pelo plano.",null, INFORMATION_MESSAGE);

                }
}