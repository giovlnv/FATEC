/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.empresa;
import javax.swing.JOptionPane;

/**
 *
 * @author labs
 */
public class Empresa {

    public static void main(String[] args) {
        try{
             String nome, sobrenome;
            double salario;
            
            empregado emp1 = new empregado();
        
            nome = JOptionPane.showInputDialog("Insira o nome do funcionário:");
            sobrenome = JOptionPane.showInputDialog("Insira o sobrenome do funcionário:");
            salario = Double.parseDouble(JOptionPane.showInputDialog("Insira o salário do funcionário: "));

            emp1.Empregado(nome, sobrenome, salario);

            empregado emp2 = new empregado();

            nome = JOptionPane.showInputDialog("Insira o nome do funcionário:");
            sobrenome = JOptionPane.showInputDialog("Insira o sobrenome do funcionário:");
            salario = Double.parseDouble(JOptionPane.showInputDialog("Insira o salário do funcionário: "));

            emp2.Empregado(nome, sobrenome, salario);

            JOptionPane.showMessageDialog(null, "Nome: " + emp1.getNome() + " " + emp1.getSobrenome() + "\nSalário Mensal: " + emp1.getSalario() + "\nSalário Anual: " + emp1.getSalarioAnual(), emp1.getNome() + " " + emp1.getSobrenome(), JOptionPane.PLAIN_MESSAGE);
            JOptionPane.showMessageDialog(null, "Nome: " + emp2.getNome() + " " + emp2.getSobrenome() + "\nSalário Mensal: " + emp2.getSalario() + "\nSalário Anual: " + emp2.getSalarioAnual(), emp2.getNome() + " " + emp2.getSobrenome(), JOptionPane.PLAIN_MESSAGE);

            JOptionPane.showMessageDialog(null, "Nome: " + emp1.getNome() + " " + emp1.getSobrenome() + "\nSalário Mensal: " + emp1.aumento() + "\nSalário Anual: " + emp1.getSalarioAnual(), emp1.getNome() + " " + emp1.getSobrenome(), JOptionPane.PLAIN_MESSAGE);
            JOptionPane.showMessageDialog(null, "Nome: " + emp2.getNome() + " " + emp2.getSobrenome() + "\nSalário Mensal: " + emp2.aumento() + "\nSalário Anual: " + emp2.getSalarioAnual(), emp2.getNome() + " " + emp2.getSobrenome(), JOptionPane.PLAIN_MESSAGE);
        
        }catch(NumberFormatException e){
            JOptionPane.showMessageDialog(null, "Apenas números nesse campo", "Erro", JOptionPane.ERROR_MESSAGE);
        }
        
        
        
    }
}
