/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package javafrom_4;

/**
 *
 * @author bảo
 */
public class Point {
    private double x, y;
    public double getX(){
        return x;
    }
    public double getY(){
        return y;
    }
    
    public Point(double x, double y){
        this.x = x;
        this.y = y;
    }

    public Point centerPoint(Point ortherPoint){
         double newX = (this.x + ortherPoint.x) / 2;
         double newY = (this.y + ortherPoint.y) / 2;
         return new Point(newX, newY);
    }
    public void Display(){
        System.out.println(this.x + "  " + this.y);
    }
}
