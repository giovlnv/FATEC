package com.mycompany.atv8;

import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

public class calculadora {
        private JFrame janela; //cria componente JFrame
        private JPanel painelPrincipal;
        private Label label1,lblr,lbl3;
        private TextField t1,t2;
        public static void main(String[] args) {
            new calculadora().montaTela();
        }
        private void montaTela() {
            preparaJanela();
            preparaPainelPrincipal();
            preparaLabel();
            preparaText();
            preparaBotaoCarregar();
            preparaBotaoSubtrair();
            preparaBotaoMultiplicar();
            preparaBotaoDividir();
            preparaBotaoSair();
            mostraJanela();
        }

        private void preparaJanela() {
            janela = new JFrame("Exemplo");

            janela.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        }
        private void mostraJanela() {
            janela.pack();

            janela.setSize(800, 150);
            janela.setVisible(true);
        }
        private void preparaPainelPrincipal() {
            painelPrincipal = new JPanel();
            painelPrincipal.setLayout(new GridLayout(2,5, 15, 10));
            janela.add(painelPrincipal);
        }
        private void preparaLabel(){
            label1 = new Label("Calculando 2 números");
            painelPrincipal.add(label1);
        };
        private void preparaText(){
            t1 = new TextField("");
            t2= new TextField("");
            lblr = new Label("Resultado=");
            lbl3 = new Label(" ");
            painelPrincipal.add(t1);
            painelPrincipal.add(t2);
            painelPrincipal.add(lblr);
            painelPrincipal.add(lbl3);
        };
        private void preparaBotaoCarregar() {
            JButton botaoCarregar = new JButton("Soma");
            botaoCarregar.addActionListener(new ActionListener() {
                @Override
                public void actionPerformed(ActionEvent e) {

                    int soma=Integer.parseInt(t1.getText())+ Integer.parseInt(t2.getText());
                    String r = Integer.toString(soma);
                    lbl3.setText(r);
                }
            });

            painelPrincipal.setLocation(50,100);
            painelPrincipal.add(botaoCarregar);
        }
        private void preparaBotaoSubtrair() {
            JButton botaoCarregar = new JButton("Subtrair");
            botaoCarregar.addActionListener(new ActionListener() {
                @Override
                public void actionPerformed(ActionEvent e) {

                    int sub=Integer.parseInt(t1.getText()) - Integer.parseInt(t2.getText());
                    String r = Integer.toString(sub);
                    lbl3.setText(r);
                }
            });

            painelPrincipal.setLocation(50,100);
            painelPrincipal.add(botaoCarregar);
        }
        private void preparaBotaoMultiplicar() {
            JButton botaoCarregar = new JButton("Multiplicar");
            botaoCarregar.addActionListener(new ActionListener() {
                @Override
                public void actionPerformed(ActionEvent e) {

                    int mult=Integer.parseInt(t1.getText()) * Integer.parseInt(t2.getText());
                    String r = Integer.toString(mult);
                    lbl3.setText(r);
                }
            });

            painelPrincipal.setLocation(50,100);
            painelPrincipal.add(botaoCarregar);
        }
        private void preparaBotaoDividir() {
            JButton botaoCarregar = new JButton("Dividir");
            botaoCarregar.addActionListener(new ActionListener() {
                @Override
                public void actionPerformed(ActionEvent e) {

                    float div=Float.parseFloat(t1.getText()) / Float.parseFloat(t2.getText());
                    String r = Float.toString(div);
                    lbl3.setText(r);
                }
            });

            painelPrincipal.setLocation(50,100);
            painelPrincipal.add(botaoCarregar);
        }
        private void preparaBotaoSair() {
            JButton botaoSair = new JButton("Sair");
            botaoSair.addActionListener(new ActionListener() {
                @Override
                public void actionPerformed(ActionEvent e) {
                    System.exit(0);
                }
            });
            painelPrincipal.add(botaoSair);
        }
}
