/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.aula_5;
import java.time.LocalDate;


/**
 *
 * @author giova
 */

public class ex_3 {
      public static void main(String[] args) {
        int diaAtual = LocalDate.now().getDayOfMonth();
        int mesAtual = LocalDate.now().getMonthValue();
        int anoAtual = LocalDate.now().getYear();

        ex3_pessoa albertEinstein = new ex3_pessoa("Albert Einstein");
        albertEinstein.ajustaDataNascimento(14, 03, 1879);
        albertEinstein.calculaIdade(diaAtual, mesAtual, anoAtual);

        ex3_pessoa isacNewton = new ex3_pessoa("Isac Newton");
        isacNewton.ajustaDataNascimento(04, 01, 1643);
        isacNewton.calculaIdade(diaAtual, mesAtual, anoAtual);

        System.out.println(albertEinstein.informaNome() + " teria " + albertEinstein.informaIdade() + " anos");
        System.out.println(isacNewton.informaNome() + " teria " + isacNewton.informaIdade() + " anos");
    }
}