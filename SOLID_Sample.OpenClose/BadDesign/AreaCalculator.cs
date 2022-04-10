namespace SOLID_Sample.OpenClosed.BadDesign;
public class AreaCalculator
{
    public double TotalAreaV1(Rectangle[] arrRectangles)
    {
        double area = 0;
        foreach (var objRectangle in arrRectangles)
        {
            area += objRectangle.Height * objRectangle.Width;
        }
        return area;
    }

    public double TotalAreaV2(object[] arrObjects)
    {
        double area = 0;
        Rectangle objRectangle;
        Circle objCircle;
        foreach (var obj in arrObjects)
        {
            if (obj is Rectangle)
            {
                objRectangle = (Rectangle)obj;
                area += objRectangle.Width * objRectangle.Height;
            }
            else
            {
                objCircle = (Circle)obj;
                area += objCircle.Radius * objCircle.Radius * Math.PI;
            }
        }
        return area;
    }
}