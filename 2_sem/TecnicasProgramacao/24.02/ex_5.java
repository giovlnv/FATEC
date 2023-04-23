/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.aula_3;
import java.util.ArrayList;
import java.util.List;
import javax.swing.JOptionPane;
import static javax.swing.JOptionPane.ERROR_MESSAGE;

/**
 *
 * @author giova
 */

public class ex_5 {

    public static void main(String[] args) throws Exception {
		List<Integer> list = new ArrayList<>();
		try {
			int sup = Integer.parseInt(JOptionPane.showInputDialog(null, "Digite o limite superior: ", "Incrementando", JOptionPane.QUESTION_MESSAGE));
			int incr = Integer.parseInt(JOptionPane.showInputDialog(null, "Digite o incremento: ", "Incrementando", JOptionPane.QUESTION_MESSAGE));

			for (int i = 0; i <= sup; i = i + incr) {
				list.add(i);
			}

			JOptionPane.showMessageDialog(null, list, "Incrementando", JOptionPane.INFORMATION_MESSAGE);
		} catch (NumberFormatException e) {
                    JOptionPane.showMessageDialog (null, "O conteúdo informado não é um número", "ERRO", ERROR_MESSAGE);
                }
    }
}