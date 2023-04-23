/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.aula_4;
import javax.swing.JOptionPane;

/**
 *
 * @author giova
 */
public class ex_2 {

    public static double ope(double x, double y, double z){
                
        double salfin = x-y+z;
        
        JOptionPane.showMessageDialog(null, "O saldo atual dessa conta é de R$" + salfin);
        
        return salfin;
        
        }
    
    public static void main(String[] args){
        double salfin;
                
        try {
        int conta = Integer.parseInt (JOptionPane.showInputDialog (null, "Insira o número da conta", 
                "Conta", JOptionPane.QUESTION_MESSAGE));
        double saldo = Double.parseDouble(JOptionPane.showInputDialog(null, "Insira o saldo",
		"Conta", JOptionPane.QUESTION_MESSAGE));        
        double deb = Double.parseDouble(JOptionPane.showInputDialog (null, "Insira o débito efetuado",
                "Conta", JOptionPane.QUESTION_MESSAGE));
        double cred = Double.parseDouble(JOptionPane.showInputDialog (null, "Insira o crédito efetuado",
                "Conta", JOptionPane.QUESTION_MESSAGE));
        
       salfin=ope(saldo,deb,cred);
        
            
        
        if (salfin>=0){
        JOptionPane.showMessageDialog(null, "Saldo positivo na conta " + conta, "Conta", JOptionPane.INFORMATION_MESSAGE);
        }
        else {
        JOptionPane.showMessageDialog(null, "Saldo negativo na conta " + conta, "Conta", JOptionPane.ERROR_MESSAGE);
        }

        }    catch (NumberFormatException e) {
            JOptionPane.showMessageDialog (null, "O conteúdo informado não é um número", "ERRO", JOptionPane.INFORMATION_MESSAGE);
                }
    
    }
}