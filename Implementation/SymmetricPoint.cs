using TestTypes;

namespace Implementation;

public class SymmetricPoint
{
    /// <summary>
    /// Point symmetry is when every part has a matching part the same distance from a central point but in opposite direction
    /// Function gets a point p and central point q and calculates symmetric point using given points.
    /// </summary>
    /// <param name="p"></param>
    /// <param name="q"></param>
    /// <returns></returns>
    public static Point Calculate(Point p, Point q)
    {
        Point sp = new Point(2 * q.X - p.X, 2*q.Y - p.Y); // using point symmtery formula : x2 = 2*x1 - x0, y2 = 2*y1 - y0
        return sp;
    }
}