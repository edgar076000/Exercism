class Lasagna
{
    //  define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven(){
        return 40;
    }
    //  define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int actMinutes){
        return ExpectedMinutesInOven() - actMinutes;
    }
    //  define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int numberOfLayers){
        return numberOfLayers * 2;
    }
    // define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int numberOfLayers, int minutesInOven){
        return PreparationTimeInMinutes(numberOfLayers) + minutesInOven;
    }
}
