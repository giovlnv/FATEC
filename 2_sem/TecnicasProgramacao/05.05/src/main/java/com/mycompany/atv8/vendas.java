package com.mycompany.atv8;

import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class vendas {
        private JFrame janela;
        private JPanel painelPrincipal, teclado, limparContainer;
        private Label lbl1, lbl2, lbl3, lbl4, resultadoICMS, resultadoIPI, resultadoTotal;
        private TextField inputVenda;
        private void montaTela(){
            preparaJanela();
            mostraTela();
            preparaPainelPrincipal();
            preparaLayout();
            preparaBotoes();
            painelPrincipal.updateUI();
        }
        public static void main(String[] args){
            vendas icms = new vendas();
            icms.montaTela();
        }
        private void preparaJanela(){
            janela = new JFrame("ICMS");
            janela.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
            janela.setLayout(new FlowLayout(1, 15, 20));
        }
        private void mostraTela(){
            janela.pack();
            janela.setSize(450,250);
            janela.setVisible(true);
        }
        private void preparaPainelPrincipal(){
            painelPrincipal = new JPanel();
            painelPrincipal.setLayout(new GridLayout(5, 2, 10, 10));
            janela.add(painelPrincipal);
        }

        private void preparaLayout(){
            lbl1 = new Label("Valor da Venda:");
            inputVenda = new TextField("", 20);
            lbl2 = new Label("ICMS (18%):");
            resultadoICMS = new Label();
            lbl3 = new Label("IPI(5%):");
            resultadoIPI = new Label();
            lbl4 = new Label("Valor Total:");
            resultadoTotal = new Label();
            painelPrincipal.add(lbl1);
            painelPrincipal.add(inputVenda);
            painelPrincipal.add(lbl2);
            painelPrincipal.add(resultadoICMS);
            painelPrincipal.add(lbl3);
            painelPrincipal.add(resultadoIPI);
            painelPrincipal.add(lbl4);
            painelPrincipal.add(resultadoTotal);
        }
        private void preparaBotoes(){
            JButton calcular = new JButton("Calcular");
            calcular.addActionListener(new ActionListener() {
                @Override
                public void actionPerformed(ActionEvent e) {
                    float res;
                    String texto;
                    res = (float) (Float.parseFloat(inputVenda.getText()) * 0.18);
                    texto = Float.toString(res);
                    resultadoICMS.setText(texto);
                    res = (float) (Float.parseFloat(inputVenda.getText()) * 0.05);
                    texto = Float.toString(res);
                    resultadoIPI.setText(texto);
                    res = (float) (Float.parseFloat(inputVenda.getText()) + Float.parseFloat(resultadoICMS.getText()) + Float.parseFloat(resultadoIPI.getText()));
                    texto = Float.toString(res);
                    resultadoTotal.setText(texto);
                }
            });
            JButton limpar = new JButton("Limpar");
            limpar.addActionListener(new ActionListener() {
                @Override
                public void actionPerformed(ActionEvent e) {
                    inputVenda.setText("");
                    resultadoICMS.setText("");
                    resultadoIPI.setText("");
                    resultadoTotal.setText("");
                }
            });
            painelPrincipal.add(calcular);
            painelPrincipal.add(limpar);
        }
}
