/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.empresa;

/**
 *
 * @author labs
 */
public class empregado {
    String nome, sobrenome;
    double salarioM;
    
    public void Empregado(String nome, String sobrenome, double salario){
        setNome(nome);
        setSobrenome(sobrenome);
        if(salario < 0){
            setSalario(0);
        }else{
            setSalario(salario);
        }
    }
    
    public void setNome(String nome){
        this.nome = nome;
    }
    
    public void setSobrenome(String sobrenome){
        this.sobrenome = sobrenome;
    }
    
    public void setSalario(double salario){
        this.salarioM = salario;
    }
    
    public String getNome(){
        return this.nome;
    }
    
    public String getSobrenome(){
        return this.sobrenome;
    }
    
    public double getSalario(){
        return this.salarioM;
    }
    
    public double getSalarioAnual(){
        return this.salarioM * 12;
    }
    
    public double aumento(){
        return this.salarioM += this.salarioM * 0.1;
    }
    
}
