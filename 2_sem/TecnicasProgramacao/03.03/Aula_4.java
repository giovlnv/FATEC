/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.aula_4;
import javax.swing.JOptionPane;


/**
 *
 * @author giova
 */
public class Aula_4 {

    public static double desc(double x, int y){
        double des, pag = x*y;
        
        if (y>50) {
            des=0.75;}
        else if (y>=21) {
            des=0.80;}
        else if (y>=11) {
            des=0.90;}
        else {
            des=1;}
        
        double fin = pag*des;
        
        return fin;
        }
    
    public static void main(String[] args){
        double pagar;
                
        try {
        String A = JOptionPane.showInputDialog (null, "Insira o nome do produto", "Desconto", JOptionPane.QUESTION_MESSAGE);
        double preco = Double.parseDouble(JOptionPane.showInputDialog(null, "Insira o valor unitario",
		"Desconto", JOptionPane.QUESTION_MESSAGE));        
        int qtd = Integer.parseInt(JOptionPane.showInputDialog (null, "Insira a quantidade comprada",
                "Desconto", JOptionPane.QUESTION_MESSAGE));
        
       pagar=desc(preco, qtd);
        
            JOptionPane.showMessageDialog(null, "O valor a ser pago por " + qtd + " unidades do produto " + A + " é de R$" + pagar);
        } catch (NumberFormatException e) {
            JOptionPane.showMessageDialog (null, "O conteúdo informado não é um número", "ERRO", JOptionPane.INFORMATION_MESSAGE);
                }
    
    }
}