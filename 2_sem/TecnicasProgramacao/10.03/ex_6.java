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
public class ex_6 {
    
    public static void main(String[] args) {
        try{
        int num = Integer.parseInt(JOptionPane.showInputDialog(null, "Digite o número: ", "Tabuada", JOptionPane.QUESTION_MESSAGE));

		JOptionPane.showMessageDialog(null, "Soma da tabuada = " + calcTabuada(num) + "", "Tabuada", JOptionPane.INFORMATION_MESSAGE);
    }  catch (NumberFormatException e) {
            JOptionPane.showMessageDialog (null, "O conteúdo informado não é um número", "ERRO", JOptionPane.ERROR_MESSAGE);
                }}

	public static int calcTabuada(int num){
		int novonum = 0;
		for (int i = 1; i < 11; i++) {
			novonum += i * num;
		}

		return novonum;
	}
}