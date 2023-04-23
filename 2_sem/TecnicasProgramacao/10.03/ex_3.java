/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.aula_4;
import javax.swing.JOptionPane;

/**
 *
 * @author giova
 */
public class ex_3 {

      public static void main(String[] args) {
          try{
		double x = Double.parseDouble(JOptionPane.showInputDialog(null, "Digite o lado X do Triângulo: ", "Triângulo", JOptionPane.QUESTION_MESSAGE));

		double y = Double.parseDouble(JOptionPane.showInputDialog(null, "Digite o lado Y do Triângulo: ", "Triângulo", JOptionPane.QUESTION_MESSAGE));

		double z = Double.parseDouble(JOptionPane.showInputDialog(null, "Digite o lado Z do Triângulo: ", "Triângulo", JOptionPane.QUESTION_MESSAGE));

		if (!validateTriangle(x, y, z)) {
			JOptionPane.showMessageDialog(null, "Os valores informados não formam um triângulo!", "ERRO", JOptionPane.ERROR_MESSAGE);
		} else {
			JOptionPane.showMessageDialog(null, "Esses valores formam um triângulo " + typeOfTriangle(x, y, z), "Triângulo", JOptionPane.INFORMATION_MESSAGE);
		}
    } catch (NumberFormatException e) {
            JOptionPane.showMessageDialog (null, "O conteúdo informado não é um número", "ERRO", JOptionPane.INFORMATION_MESSAGE);
                }}

	public static boolean validateTriangle(double x, double y, double z){
		return !((x > y + z) ||(y > x + z) || (z > x + y));
	}

	public static String typeOfTriangle(double x, double y, double z) {
		if ((x == y) && (y == z)){
			return "Equilátero";
		} else if (((x == y) && (x != z)) || (y == z) && (y != x) || (x == z) && (x != y)){
			return "Isóceles";
		} else {
			return "Escaleno";
		}
	}
}