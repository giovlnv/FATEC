/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Project/Maven2/JavaApp/src/main/java/${packagePath}/${mainClassName}.java to edit this template
 */

package com.mycompany.empregadoteste;

import java.text.DecimalFormat;
import javax.swing.JOptionPane;

/**
 *
 * @author Principal
 */
public class EmpregadoTeste {

    public static void main(String[] args) {
        try{
        
        String _nome;
        int _idade;
        double _altura,_salario;
        String[] options = {"Feminino", "Masculino"};
        int _sexo=-1;
        
        DecimalFormat df = new DecimalFormat();
        df.setMaximumFractionDigits(2); df.setMinimumFractionDigits(2);
        
        
        _nome=JOptionPane.showInputDialog(null, "Informe o nome do Empregado: ", "Nome", JOptionPane.PLAIN_MESSAGE);
        if("".equals(_nome)|| _nome==null){ throw new Exception("deuErro"); }
        
        _idade=Integer.parseInt(JOptionPane.showInputDialog(null, "Informe a idade do Empregado: ", "Idade", JOptionPane.PLAIN_MESSAGE));
        
        _altura=Double.parseDouble(JOptionPane.showInputDialog(null, "Informe a altura do Empregado: ", "Altura", JOptionPane.PLAIN_MESSAGE));
        
        _sexo = JOptionPane.showOptionDialog(null, "Qual o sexo do Empregado?", "Sexo", JOptionPane.DEFAULT_OPTION, JOptionPane.QUESTION_MESSAGE, null, options, options[0]);
        if(_sexo==-1){ throw new Exception("deuErro"); }
        
        _salario=Double.parseDouble(JOptionPane.showInputDialog(null, "Informe o salário do Empregado: ", "Salrário", JOptionPane.PLAIN_MESSAGE));
        
        
        Empregado empregado1 = new Empregado(_nome,_idade,_altura,_sexo,_salario);
        
        JOptionPane.showMessageDialog(null,"Nome: "+empregado1.getNome()+"\nIdade: "+empregado1.getIdade()+"\nAltura: "+df.format(empregado1.getAltura())+"m\nSexo: "+empregado1.getSexo()+"\nSalário: R$ "+df.format(empregado1.obterLucro()),"Empregado",JOptionPane.PLAIN_MESSAGE);
        
        }catch(NumberFormatException e){
            JOptionPane.showMessageDialog(null,"Insira penas Múmeros","ERRO",JOptionPane.PLAIN_MESSAGE);
        }catch(Exception deuErro){
            JOptionPane.showMessageDialog(null,"Input Inválido","ERRO",JOptionPane.PLAIN_MESSAGE);
        }
    }
    
    
    
}
