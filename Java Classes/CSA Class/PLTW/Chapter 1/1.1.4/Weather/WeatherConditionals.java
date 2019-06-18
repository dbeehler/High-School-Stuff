public class WeatherConditionals
{

    public static String getWeatherAdvice(int temp, String desc){
        boolean windy;
        if(desc.contains("windy"))
            windy = true;
        else
            windy = false;
            
        if (temp >= 100 && desc.contains("snow"))
            return "ItS nOt PoSsIBlE...";
            
        if (temp <= 0 && temp > -54)
            return "You might be in Iowa";
            
        if(!windy && temp > 30)
            return "It's safe to go outside: " + temp + " degress and " + desc;
        else
            return "Too windy or cold...";
    }
}