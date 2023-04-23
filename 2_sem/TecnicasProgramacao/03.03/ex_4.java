/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.aula_4;
import javax.swing.JOptionPane;

/**
 *
 * @author giova
 */
public class ex_4 {
     public static void main(String[] args) {
        try{
        double alt = Double.parseDouble(JOptionPane.showInputDialog(null, "Digite a sua altura: ", "Pesagem", JOptionPane.QUESTION_MESSAGE));

	int sexo = Integer.parseInt(JOptionPane.showInputDialog(null, "Digite o seu sexo (1 - Homem | 2 - Mulher): ", "Pesagem", JOptionPane.QUESTION_MESSAGE));

	calcPeso(alt, sexo);
    } catch (NumberFormatException e) {
            JOptionPane.showMessageDialog (null, "O conteúdo informado não é um número", "ERRO", JOptionPane.ERROR_MESSAGE);
            }
     }

	public static void calcPeso(double alt, int sexo) {
         switch (sexo) {
             case 1 -> JOptionPane.showMessageDialog(null, "Homem: Peso ideal = " + String.format("%.2f", ((72.2 * alt) - 58)), "Pesagem", JOptionPane.INFORMATION_MESSAGE);
             case 2 -> JOptionPane.showMessageDialog(null, "Mulher: Peso ideal = " + String.format("%.2f", ((62.1 * alt) - 44.7)), "Pesagem", JOptionPane.INFORMATION_MESSAGE);
             default -> JOptionPane.showMessageDialog(null, "Valor de sexo inválido!", "Peso", JOptionPane.ERROR_MESSAGE);
         }
	}
}