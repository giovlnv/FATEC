/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.calculadora;

import javax.swing.JOptionPane;

/**
 *
 * @author labs
 */
public class Calculadora {

    public static void main(String[] args) {
        try{
            double num1, num2;
            Character[] options = {'+', '-', '*', '/'};
            int op=-1;

            num1 = Double.parseDouble(JOptionPane.showInputDialog("Digite o primeiro número:"));
            op = JOptionPane.showOptionDialog(null, "Escolha uma operação", "Operação", JOptionPane.DEFAULT_OPTION, JOptionPane.INFORMATION_MESSAGE, null, options, options[0]);
            if(op==-1){
                throw new Exception("OpInvalida");
            }
            num2 = Double.parseDouble(JOptionPane.showInputDialog("Digite o segundo número:"));


            calc calculadora = new calc();

            calculadora.Calculadora(num1, num2, op);

            JOptionPane.showMessageDialog(null, calculadora.getNum1() +" "+ calculadora.getOperacao()+" "+  calculadora.getNum2() + " = "+ calculadora.imprimirResultado());
        }catch(NumberFormatException e){
            JOptionPane.showMessageDialog(null, "Apenas números são permitidos nesse campo");
        }catch(Exception OpInvalida){
            JOptionPane.showMessageDialog(null, "Operação inválida");
        }
        
        
    }
}
