/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.empregadoteste;

/**
 *
 * @author Principal
 */
public class Pessoa {
    
    private String _nome, _sexo;
    private int _idade;
    private double _altura;
    
    public Pessoa(String nome,int idade,double altura,int sexo){
        this.setNome(nome);
        this.setIdade(idade);
        this.setAltura(altura);
        this.setSexo(sexo);
    }
    
    public void setNome(String nome){
        this._nome=nome;
    }
    
    public void setIdade(int idade){
        this._idade=idade;
    }
    
    public void setAltura(Double altura){
        this._altura=altura;
    }
    
    public void setSexo(int sexo){
        switch(sexo){
            case 1 ->{ this._sexo= "Masculino"; }
            default ->{ this._sexo= "Feminino"; }
        }
    }
    
    public String getNome(){
        return this._nome;
    }
    
    public int getIdade(){
        return this._idade;
    }
    
    public double getAltura(){
        return this._altura;
    }
    
    public String getSexo(){
        return this._sexo;
    }
    
}
