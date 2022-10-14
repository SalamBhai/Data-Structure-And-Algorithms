﻿// See https://aka.ms/new-console-template for more information
int[] initasts = new int[] { 8, -8 };
List<int> asteroids = MazstarSolution(initasts);

foreach (var item in asteroids)
{
    Console.WriteLine(item);
}

static int[] SolveForAsteroids(int[] asteroids)
{
    Array.Sort(asteroids);
    var asteroidsList = asteroids.ToList();
    var explodedAsteroids = new List<int>();
    for (int firstAsteroid = 0; firstAsteroid <= asteroidsList.Count - 1; firstAsteroid++)
    {
        if (firstAsteroid == 0 && asteroids[firstAsteroid] > 0) return asteroids.ToArray();
        for (int nextAsteroid = firstAsteroid + 1; nextAsteroid < asteroidsList.Count; nextAsteroid++)
        {
            if (asteroids[nextAsteroid] < 0) continue;
            else
            {

                if (Math.Abs(asteroids[firstAsteroid]) > asteroids[nextAsteroid])
                {
                    explodedAsteroids.Add( asteroids[nextAsteroid]);
                }
                else if (asteroids[nextAsteroid] > Math.Abs(asteroids[firstAsteroid]))
                {
                    explodedAsteroids.Add(asteroids[firstAsteroid]);
                }
                else if(Math.Abs(asteroids[firstAsteroid]) == asteroids[nextAsteroid])
                {
                    explodedAsteroids.Add(asteroids[firstAsteroid]);
                    explodedAsteroids.Add(asteroids[nextAsteroid]);
                }
            }
        }
    }
    foreach (var item in asteroidsList)
    {
        if (item == explodedAsteroids.Select(p => p).Single())
        {
            asteroidsList.Remove(item);
        }
        return asteroidsList.ToArray();
    }
    return asteroidsList.ToArray();
}
// var survivor = Asteroids(new int[] {-5,-2,10,70,-99,80,78,-56,1000,-670});
// string output = string.Join(",", survivor);
// Console.WriteLine($"Output = [{output}]");


static List<int> MazstarSolution(int[] asteroids)
{
    string representation = string.Join(",", asteroids);
    string[] Survivors = representation.Split(',');
    for (int i = 0; i < Survivors.Length; i++)
    {
        if (Survivors[i] != "removed" && int.Parse(Survivors[i]) < 0)
        {
            for (int j = i - 1; j >= 0 && j < Survivors.Length; j--)
            {
                if (Survivors[j] != "removed" && int.Parse(Survivors[j]) >= 0)
                {
                    if (Math.Abs(int.Parse(Survivors[i])) > Math.Abs(int.Parse(Survivors[j])))
                    {
                        Survivors[j] = "removed";
                    }
                    else if (Math.Abs(int.Parse(Survivors[i])) == Math.Abs(int.Parse(Survivors[j])))
                    {
                        Survivors[i] = "removed";
                        Survivors[j] = "removed";
                        break;
                    }
                    else
                    {
                        Survivors[i] = "removed";
                        break;
                    }
                }
            }
        }
    }

    var Remaining = new List<int> { };
    foreach (var item in Survivors)
    {
        if (item != "removed") Remaining.Add(int.Parse(item));
    }
    return Remaining;
}
