using System;

class ShipDamage
{
    static void Main()
    {
        //receiving coordinates
        int sx1 = Int32.Parse(Console.ReadLine());
        int sy1 = Int32.Parse(Console.ReadLine());
        int sx2 = Int32.Parse(Console.ReadLine());
        int sy2 = Int32.Parse(Console.ReadLine());
        int h = Int32.Parse(Console.ReadLine());
        int cx1 = Int32.Parse(Console.ReadLine());
        int cy1 = Int32.Parse(Console.ReadLine());
        int cx2 = Int32.Parse(Console.ReadLine());
        int cy2 = Int32.Parse(Console.ReadLine());
        int cx3 = Int32.Parse(Console.ReadLine());
        int cy3 = Int32.Parse(Console.ReadLine());

        // ship borders
        int minX = Math.Min(sx1, sx2);
        int maxX = Math.Max(sx1, sx2);
        int minY = Math.Min(sy1, sy2);
        int maxY = Math.Max(sy1, sy2);

        //finding the coordinates of the projectiles
        int px1 = cx1;
        int py1 = 2 * h - cy1;
        int px2 = cx2;
        int py2 = 2 * h - cy2;
        int px3 = cx3;
        int py3 = 2 * h - cy3;

        int damageP1 = 0;
        int damageP2 = 0;
        int damageP3 = 0;

        // scoring 100% damage
        if (px1 < maxX && px1 > minX && py1 < maxY && py1 > minY)
        {
            damageP1 = 100;
        }
        if (px2 < maxX && px2 > minX && py2 < maxY && py2 > minY)
        {
            damageP2 = 100;
        }
        if (px3 < maxX && px3 > minX && py3 < maxY && py3 > minY)
        {
            damageP3 = 100;
        }

        // scoring 50% damage
        // projectile 1
        if ((px1 == maxX || px1 == minX) && (py1 > minY && py1 < maxY))
        {
            damageP1 = 50;
        }
        if ((py1 == maxY || py1 == minY) && (px1 > minX && px1 < maxX))
        {
            damageP1 = 50;
        }

        // projectile 2
        if ((px2 == maxX || px2 == minX) && (py2 > minY && py2 < maxY))
        {
            damageP2 = 50;
        }
        if ((py2 == maxY || py2 == minY) && (px2 > minX && px2 < maxX))
        {
            damageP2 = 50;
        }

        // projectile 3
        if ((px3 == maxX || px3 == minX) && (py3 > minY && py3 < maxY))
        {
            damageP3 = 50;
        }
        if ((py3 == maxY || py3 == minY) && (px3 > minX && px3 < maxX))
        {
            damageP3 = 50;
        }

        // scoring 25% damage
        if ((px1 == minX || px1 == maxX) && (py1 == minY || py1 == maxY))
        {
            damageP1 = 25;
        }

        if ((px2 == minX || px2 == maxX) && (py2 == minY || py2 == maxY))
        {
            damageP2 = 25;
        }

        if ((px3 == minX || px3 == maxX) && (py3 == minY || py3 == maxY))
        {
            damageP3 = 25;
        }

        int totalDamage = damageP1 + damageP2 + damageP3;
        Console.WriteLine(totalDamage + "%");
    }
}
