/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.datateste;

/**
 *
 * @author labs
 */
public class data {
    int dia, mes, ano;
    
    public void Data(int dia, int mes, int ano){
        setDia(dia);
        setMes(mes);
        setAno(ano);
    }
    
    public void setDia(int dia){
        this.dia = dia;
    }
    
    public void setMes(int mes){
        this.mes = mes;
    }
    
    public void setAno(int ano){
        this.ano = ano;
    }
    
    public int getDia(){
        return this.dia;
    }
    
    public int getMes(){
        return this.mes;
    }
    
    public int getAno(){
        return this.ano;
    }
    
    public String displayData(){
        if(this.dia<10 && this.mes<10){
            return "0"+this.dia + "/0" + this.mes + "/" + this.ano;
        }else if(this.mes<10){
            return this.dia + "/0" + this.mes + "/" + this.ano;
        }else if(this.dia<10){
            return "0"+this.dia + "/" + this.mes + "/" + this.ano;
        }else{
            return this.dia + "/" + this.mes + "/" + this.ano;
        }
    }
}
