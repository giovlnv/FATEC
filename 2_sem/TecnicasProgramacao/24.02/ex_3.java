/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.aula_3;

import java.util.ArrayList;
import java.util.List;
import javax.swing.JOptionPane;

/**
 *
 * @author giova
 */
public class ex_3 {
    public static void main(String[] args) throws Exception {
		List<Integer> list = new ArrayList<>();
		try {
			int beg = Integer.parseInt(JOptionPane.showInputDialog(null, "Digite o início do intervalo: ", "Numeros primos", JOptionPane.QUESTION_MESSAGE));
			int end = Integer.parseInt(JOptionPane.showInputDialog(null, "Digite o final do intervalo: ", "Numeros primos", JOptionPane.QUESTION_MESSAGE));

			for (; beg <= end; beg++) {
				if(isPrimo(beg)){
					list.add(beg);
				}
			}

			JOptionPane.showMessageDialog(null, list, "Numeros primos", JOptionPane.INFORMATION_MESSAGE);
		} catch (NumberFormatException e) {
			JOptionPane.showMessageDialog(null, "Aviso: dado informado não é um número.", "Numeros primos", JOptionPane.ERROR_MESSAGE);
		}
    }

	public static boolean isPrimo(int num){
		if (num == 1)
			return false;

		for (int i = 2; i < num; i++) {
            if (num % i == 0) {
                return false;
            }
        }

        return true;
	}
}