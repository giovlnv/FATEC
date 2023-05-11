/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.empregadoteste;

/**
 *
 * @author Principal
 */
public class Empregado extends Pessoa{
    
    private double _salario;
    
    public Empregado(String _nome, int _idade,double _altura, int _sexo,double _salario) {
	super(_nome, _idade, _altura,_sexo);
        setSalario(_salario);
    }
	
       public void setSalario(double _salario){
           this._salario=_salario;
       }
       
       public double getSalario(){
           return this._salario;
       }
       
       public double obterLucro(){
           return this.getSalario();
       }
        
}
