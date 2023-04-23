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
public class ex_5 {
    
    public static void main(String[] args) {
        try{
        int ano = Integer.parseInt(JOptionPane.showInputDialog(null, "Digite o ano do seu carro: ", "DETRAN", JOptionPane.QUESTION_MESSAGE));

        double preco = Double.parseDouble(JOptionPane.showInputDialog(null, "Digite o valor do seu carro: ", "DETRAN", JOptionPane.QUESTION_MESSAGE));

		JOptionPane.showMessageDialog(null, "Você irá pagar R$" + String.format("%.2f", calcImpo(ano, preco)) + " para transferir!", "DETRAN", JOptionPane.INFORMATION_MESSAGE);
    }catch (NumberFormatException e) {
            JOptionPane.showMessageDialog (null, "O conteúdo informado não é um número", "ERRO", JOptionPane.ERROR_MESSAGE);
                }}

	public static double calcImpo(int ano, double preco){
		if (ano < 1990) {
			return preco * 0.01;
		} else {
			return preco * 0.015;
		}
	}
}