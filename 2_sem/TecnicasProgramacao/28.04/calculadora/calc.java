/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.calculadora;
/**
 *
 * @author labs
 */
public class calc {
    double num1, num2;
    char operacao;
    
    
    public void Calculadora(double num1, double num2, int op){
        setNum1(num1);
        setNum2(num2);
        switch(op){
            case 0 ->{
            setOperacao('+');
            }
            case 1 ->{
            setOperacao('-');
            }
            case 2 ->{
            setOperacao('*');
            }
            default ->{
               setOperacao('/');
            }
        }
    }
    
    public void setNum1(double num){
        this.num1 = num;
    }
    
    public void setNum2(double num){
        this.num2 = num;
    }
    
    public void setOperacao(char op){
        this.operacao = op;
    }
    
    public double getNum1(){
        return this.num1;
    }
    
    public double getNum2(){
        return this.num2;
    }
    
    public char getOperacao(){
        return this.operacao;
    }
    
    public double calculo(){
        switch(this.getOperacao()){
            case '+' -> {
                return this.num1+this.num2;
            }
            case '-' -> {
                return this.num1-this.num2;
            }
            case '*' -> {
                return this.num1 * this.num2;
            }
            default->{
                 if(this.num2 == 0){
                    return 0;
                }else{
                    return this.num1 / this.num2;
                }
            }
        }
    }
    
    public String imprimirResultado(){
        if(this.operacao == '/' && this.num2 == 0){
            return "Erro";
        }else{
            return ""+calculo();
        }
    }
}
