/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.aula_5;
import java.util.Scanner;

/**
 *
 * @author giova
 */
public class Aula_5 {

    public static void main(String[] args) {
        
        Scanner sc = new Scanner(System.in);
        System.out.println("Digite o valor da base: ");
        double base = sc.nextDouble();
        System.out.println("Digite o valor da altura: ");
        double altura = sc.nextDouble();
        
        ex1_triangulo triangle = new ex1_triangulo(altura,base);
        
        System.out.println("O valor da área do triangulo é: " +triangle.calculateArea());
        
        sc.close();
    }
}