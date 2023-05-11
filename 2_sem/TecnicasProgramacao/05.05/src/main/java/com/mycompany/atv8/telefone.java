package com.mycompany.atv8;

import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class telefone {
    private JFrame janela;
    private JPanel painelPrincipal, teclado, limparContainer;
    private TextField display;
    private void montaTela(){
        preparaJanela();
        mostraTela();
        preparaPainelPrincipal();
        preparaTeclado();
        adicionarBotoes();
        preparaLimparContainer();
        preparaBotaoLimpar();
        preparaDisplay();
        painelPrincipal.updateUI();
    }

    public static void main(String[] args) {
        telefone Telefone = new telefone();
        Telefone.montaTela();
    }

    private void preparaJanela(){
        janela = new JFrame("Telefone");
        janela.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        janela.setLayout(new BorderLayout());
    }
    private void mostraTela(){
        janela.pack();
        janela.setSize(250,300);
        janela.setVisible(true);
    }

    private void preparaPainelPrincipal(){
        painelPrincipal = new JPanel();
        painelPrincipal.setLayout(new FlowLayout(1, 20, 10));
        janela.add(painelPrincipal);
    }

    private void preparaTeclado(){
        teclado = new JPanel();
        teclado.setLayout(new GridLayout(4,3, 10, 15));
        painelPrincipal.add(teclado);
    }

    private void preparaDisplay(){
        display = new TextField(" ", 20);
        painelPrincipal.add(display);
    }

    private void adicionarBotoes(){
        JButton numero1 = new JButton("1");
        numero1.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                String output = display.getText() + numero1.getText();
                display.setText(output);
            }
        });
        JButton numero2 = new JButton("2");
        numero2.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                String output = display.getText() + numero2.getText();
                display.setText(output);
            }
        });
        JButton numero3 = new JButton("3");
        numero3.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                String output = display.getText() + numero3.getText();
                display.setText(output);
            }
        });
        JButton numero4 = new JButton("4");
        numero4.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                String output = display.getText() + numero4.getText();
                display.setText(output);
            }
        });
        JButton numero5 = new JButton("5");
        numero5.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                String output = display.getText() + numero5.getText();
                display.setText(output);
            }
        });
        JButton numero6 = new JButton("6");
        numero6.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                String output = display.getText() + numero6.getText();
                display.setText(output);
            }
        });
        JButton numero7 = new JButton("7");
        numero7.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                String output = display.getText() + numero7.getText();
                display.setText(output);
            }
        });
        JButton numero8 = new JButton("8");
        numero8.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                String output = display.getText() + numero8.getText();
                display.setText(output);
            }
        });
        JButton numero9 = new JButton("9");
        numero9.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                String output = display.getText() + numero9.getText();
                display.setText(output);
            }
        });

        JButton numero0 = new JButton("0");
        numero0.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                String output = display.getText() + numero0.getText();
                display.setText(output);
            }
        });
        JButton asterisco = new JButton("*");
        asterisco.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                String output = display.getText() + asterisco.getText();
                display.setText(output);
            }
        });
        JButton hashTag = new JButton("#");
        hashTag.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                String output = display.getText() + hashTag.getText();
                display.setText(output);
            }
        });
        teclado.add(numero1);
        teclado.add(numero2);
        teclado.add(numero3);
        teclado.add(numero4);
        teclado.add(numero5);
        teclado.add(numero6);
        teclado.add(numero7);
        teclado.add(numero8);
        teclado.add(numero9);
        teclado.add(asterisco);
        teclado.add(numero0);
        teclado.add(hashTag);
    }

    private void preparaLimparContainer(){
        limparContainer = new JPanel();
        limparContainer.setLayout(new FlowLayout(1));
        painelPrincipal.add(limparContainer);
    }

    private void preparaBotaoLimpar(){
        JButton limpar =  new JButton("Limpar");
        limpar.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                display.setText(" ");
            }
        });

        limparContainer.add(limpar);
    }
}
