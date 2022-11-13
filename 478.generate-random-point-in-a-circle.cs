/*
 * @lc app=leetcode id=478 lang=csharp
 *
 * [478] Generate Random Point in a Circle
 */

// @lc code=start
public class Solution {
    private double radius;
    private double x_center;
    private double y_center;
    public Solution(double radius, double x_center, double y_center) {
        this.radius = radius;
        this.x_center = x_center;
        this.y_center = y_center;
    }
    
    public double[] RandPoint() {
        System.Random random = new System.Random();
        double randomRadius = random.NextDouble() * this.radius;
        double randomX = random.NextDouble() * randomRadius * (random.Next(0,2) * 2 -1) ;
        double randomY = System.Math.Sqrt(randomRadius * randomRadius - randomX * randomX) * (random.Next(0,2) * 2 -1);
        double resultX = this.x_center + randomX;
        double resultY = this.y_center + randomY;
        double [] result = new double[] {resultX, resultY};
        return result;
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(radius, x_center, y_center);
 * double[] param_1 = obj.RandPoint();
 */
// @lc code=end

