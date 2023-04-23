/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.aula_5;
import java.util.Scanner;

/**
 *
 * @author giova
 */
public class ex_2 {
   
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);
        
        System.out.println("Digite o valor A: ");
        double A = sc.nextDouble();
        System.out.println("Digite o valor B: ");
        double B = sc.nextDouble();
        System.out.println("Digite o valor C: ");
        double C = sc.nextDouble();
        
        ex2_equacao eq = new ex2_equacao(A, B, C);
        
        if(eq.calcDelta() > 0 ){
            System.out.println("R1 igual a: " + eq.calcRaiz("r1"));
            System.out.println("R2 igual a: " + eq.calcRaiz("r2"));
        }
        else if(eq.calcDelta() < 0){
            System.out.println("Não existem raízes para uma equação com estes valores!");
        }
        else{
            System.out.println("O valor de R1 e R2 é: " + eq.calcRaiz("r1"));
        }
        
        
        sc.close();
    }
    
}
