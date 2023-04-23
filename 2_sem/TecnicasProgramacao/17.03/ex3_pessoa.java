/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.aula_5;

import java.time.LocalDate;
import java.time.Period;

/**
 *
 * @author giova
 */
class ex3_pessoa {

    private String nome;
    private int idade;
    private int dia;
    private int mes;
    private int ano;
    
    public ex3_pessoa(String nome) {
        this.nome = nome;
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public int getIdade() {
        return idade;
    }

    public void setIdade(int idade) {
        this.idade = idade;
    }

    public int getDia() {
        return dia;
    }

    public void setDia(int dia) {
        this.dia = dia;
    }

    public int getMes() {
        return mes;
    }

    public void setMes(int mes) {
        this.mes = mes;
    }

    public int getAno() {
        return ano;
    }

    public void setAno(int ano) {
        this.ano = ano;
    }

    public void calculaIdade(int dia, int mes, int ano){
        this.idade = Period.between(LocalDate.of(this.ano, this.mes, this.dia), LocalDate.of(ano, mes, dia)).getYears();
    }

    public void ajustaDataNascimento(int dia, int mes, int ano){
        this.dia = dia;
        this.mes = mes;
        this.ano = ano;
    }
    
    public int informaIdade(){
        return this.idade;
    }

    public String informaNome(){
        return this.nome;
    }
}