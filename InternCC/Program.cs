// See https://aka.ms/new-console-template for more information
int[] initasts = new int[] { 8, -8 };
int[] asteroids = SolveForAsteroids(initasts);

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

