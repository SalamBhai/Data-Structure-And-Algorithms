// See https://aka.ms/new-console-template for more information
int[] vehicles = {1,1,0,0,1,0,1};
Console.WriteLine(MinimalNumberOfTimesForIllegalVehicleRemoval(vehicles));

static int MinimalNumberOfTimesForIllegalVehicleRemoval(int[] vehicles)
{
    int numberOfSteps = 0;
    var vehiclesList = vehicles.ToList();
    int indexingLast = vehicles.Length;
    if (!vehicles.Contains(1)) return numberOfSteps;

    for (int i = 0; i < vehicles.Length; i++)
    {
        indexingLast--;
        if (vehicles.Contains(1))
        {
            if (vehicles[i] == 1)
            {
                vehiclesList.RemoveAt(vehiclesList.IndexOf(vehicles[i]));
                numberOfSteps++;
            }
            else if(vehicles[indexingLast] == 1)
            {
                vehiclesList.RemoveAt(vehiclesList.IndexOf(vehicles[indexingLast]));
                 numberOfSteps++;
            }
        }

    }
    return numberOfSteps;
}