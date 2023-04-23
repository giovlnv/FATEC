/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.aula_5;

/**
 *
 * @author giova
 */
public class ex1_triangulo {
    private double height; 
    private double base;

    public ex1_triangulo(double height, double base) {
        this.height = height;
        this.base = base;
    }
    

    public double getHeight() {
        return height;
    }

    public void setHeight(double height) {
        this.height = height;
    }

    public double getBase() {
        return base;
    }

    public void setBase(double base) {
        this.base = base;
    }
    
    public double calculateArea(){
        return (this.height * this.base)/2;
    }
    
}