/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.aula_3;
import javax.swing.JOptionPane;
import static javax.swing.JOptionPane.ERROR_MESSAGE;


/**
 *
 * @author giova
 */
public class ex_4 {
    
	public static void main(String[] args) throws Exception {
		try {
			double p1 = Double.parseDouble(JOptionPane.showInputDialog(null, "Digite a nota da P1: ",
					"Notas - FATEC", JOptionPane.QUESTION_MESSAGE));
                        if (p1<0 || p1>10){
                            throw new Exception ("Intervalo");
                        }
                        
			double p2 = Double.parseDouble(JOptionPane.showInputDialog(null, "Digite a nota da P2: ",
					"Notas - FATEC", JOptionPane.QUESTION_MESSAGE));
                        if (p2<0 || p2>10){
                            throw new Exception ("Intervalo");
                        }
                       
			double tra = Double.parseDouble(JOptionPane.showInputDialog(null, "Digite a nota de trabalhos: ",
					"Notas - FATEC", JOptionPane.QUESTION_MESSAGE));
                        if (tra<0 || tra>10){
                            throw new Exception ("Intervalo");
                        }
                        
                        
			double media = ((p1 * 0.35) + (p2 * 0.35) + (tra * 0.30));
			JOptionPane.showMessageDialog(null, "Sua média é: " + media);
                        
                        
		} catch (NumberFormatException e) {
			JOptionPane.showMessageDialog(null, "Aviso: dado informado não é um número.", "Notas - FATEC", JOptionPane.ERROR_MESSAGE);
		}
                
               catch (Exception Intervalo){
                        JOptionPane.showMessageDialog (null, "O valor informado não é uma nota possível", "ORDEM", ERROR_MESSAGE);
                        System.exit(0);
                } 
	}
}