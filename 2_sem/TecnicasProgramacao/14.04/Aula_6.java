/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.aula_6;
import java.util.Scanner;

/**
 *
 * @author giova
 */
public class Aula_6 {

    public static void main(String[] args) throws Exception {
        try (Scanner sc = new Scanner(System.in)) {
            double value = 0;
            try {
                System.out.println("Informe o valor inicial da conta:");
                value = Double.parseDouble(sc.nextLine());
                } catch (NumberFormatException e) {
                    System.out.println("ERRO - Digite um valor numérico");
                }
                Conta conta = new Conta(value);
                int resp = 9;
                while (resp != 0) {
                    System.out.println("---------------------");
                    System.out.println("BANCO DIGITAL");
                    System.out.println("CONTA 1 - Saldo atual: " + conta.getSaldo());
                    System.out.println("----------------------");
                    System.out.println("1 - Depósito");
                    System.out.println("2 - Saque");
                    System.out.println("3 - Atualização por taxa");
                    System.out.println("0 - Sair do programa");
                    resp = Integer.parseInt(sc.nextLine());
                
                    switch (resp) {
                        case 0 -> {
                            break;
                        }
                        case 1 -> {
                            System.out.println("Digite o valor para depósito:");
                            value = Double.parseDouble(sc.nextLine());
                            conta.deposita(value);
                        }
                        case 2 -> {
                            System.out.println("Digite o valor para saque:");
                            value = Double.parseDouble(sc.nextLine());
                            conta.saca(value);
                        }
                        case 3 -> {
                            System.out.println("Digite o valor da porcentagem para ajuste:");
                            value = Double.parseDouble(sc.nextLine());
                            conta.attByTaxa(value);
                        }
                        default -> System.out.println("OPÇÃO INVÁLIDA");
                    }
                }
                System.out.println("PROGRAMA FINALIZADO");
        }
    }
}